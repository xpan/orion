using Hydrogen.Arrays;
using Hydrogen.Exprs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hydrogen
{
    public class Visitor<T> : ExprVisitor
    {
        private Func<string, Joinable<T>> constant;
        private Func<Joinable<T>, string, Variant, Snapshot<T>> eqSnapshot;
        private Func<Joinable<T>, string, Variant, Test<T>> eqTest;
        private Func<Joinable<T>, Joinable<T>, FieldSpec, FieldSpec, Joinable<T>> join;
        private IComparer<T> comparison;

        public Visitor(
            IComparer<T> comparison,
            Func<string, Joinable<T>> constant, 
            Func<Joinable<T>, string, Variant, Snapshot<T>> eqSnapshot, 
            Func<Joinable<T>, string, Variant, Test<T>> eqTest, 
            Func<Joinable<T>, Joinable<T>, FieldSpec, FieldSpec, Joinable<T>> join
            )
        {
            Ops = new Stack<Joinable<T>>();
            this.comparison = comparison;
            this.constant = constant;
            this.eqSnapshot = eqSnapshot;
            this.eqTest = eqTest;
            this.join = join;
        }
        public override void VisitJoin(JoinExpr node)
        {
            node.Left.Accept(this);
            var lTable = Ops.Pop();
            node.Right.Accept(this);
            var rTable = Ops.Pop();

            var lField = Array.Find(lTable.Table.Fields, fs => fs.Name == node.LField);
            var rField = Array.Find(rTable.Table.Fields, fs => fs.Name == node.RField);

            Ops.Push(join(lTable, rTable, lField, rField));     
        }

        public override void VisitWhere(WhereExpr node)
        {
            node.Source.Accept(this);
            var joinable = Ops.Pop();

            var testVisitor = new BinaryVisitor<Test<T>>((n, v) => eqTest(joinable, n, v), (l, r) => (s, n) => Extensions.Intersect(l(s, n), r(s, n), comparison), (l, r) => (s, n) => Extensions.Union(l(s, n), r(s, n), comparison));
            node.Condition.Accept(testVisitor);
            var test = testVisitor.Ops.Pop();

            var snapshotVisitor = new BinaryVisitor<Snapshot<T>>((n, v) => eqSnapshot(joinable, n, v), (l, r) => () => Extensions.Intersect(l(), r(), comparison), (l, r) => () => Extensions.Union(l(), r(), comparison));
            node.Condition.Accept(snapshotVisitor);
            var snapshot = snapshotVisitor.Ops.Pop();

            Ops.Push(new Joinable<T>(joinable.Table, test, snapshot));
        }

        public override void VisitConst(ConstExpr node)
        {
            Ops.Push(constant(node.Value));
        }

        public override void VisitSelect(SelectExpr node)
        {
            node.Source.Accept(this);
        }
        public Stack<Joinable<T>> Ops { get; }
    }
}

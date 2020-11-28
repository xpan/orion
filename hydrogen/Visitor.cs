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
        private IComparer<T> comparer;

        public Visitor(
            IComparer<T> comparison,
            Func<string, Joinable<T>> constant, 
            Func<Joinable<T>, string, Variant, Snapshot<T>> eqSnapshot, 
            Func<Joinable<T>, string, Variant, Test<T>> eqTest, 
            Func<Joinable<T>, Joinable<T>, FieldSpec, FieldSpec, Joinable<T>> join
            )
        {
            Ops = new Stack<Joinable<T>>();
            this.comparer = comparison;
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

            var binary = new BinaryVisitor<T>(Utils.Union(comparer), eqTest, eqSnapshot);
            binary.Ops.Push(joinable);
            node.Condition.Accept(binary);

            var r = binary.Ops.Pop();
            Ops.Push(r);           
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

using Hydrogen.Exprs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hydrogen
{
    public class BinaryVisitor<T> : ExprVisitor
    {
        private Func<Joinable<T>, string, Variant, Test<T>> eqTest;
        private Func<Joinable<T>, string, Variant, Snapshot<T>> eqSnapshot;
        private Func<IEnumerable<T>, IEnumerable<T>, IEnumerable<T>> union;
        public BinaryVisitor(Func<IEnumerable<T>, IEnumerable<T>, IEnumerable<T>> union, Func<Joinable<T>, string, Variant, Test<T>> eqTest, Func<Joinable<T>, string, Variant, Snapshot<T>> eqSnapshot)
        {
            Ops = new Stack<Joinable<T>>();
            this.eqTest = eqTest;
            this.eqSnapshot = eqSnapshot;
            this.union = union;
        }
        public override void VisitAnd(AndExpr node)
        {
            node.Left.Accept(this);
            node.Right.Accept(this);
        }
        public override void VisitOr(OrExpr node)
        {
            var joinable = Ops.Pop();

            Ops.Push(joinable);
            node.Left.Accept(this);
            var (_, lt, ls) = Ops.Pop();

            Ops.Push(joinable);
            node.Right.Accept(this);
            var (_, rt, rs) = Ops.Pop();

            var r = new Joinable<T>(joinable.Table, (s, i) => union(lt(s, i), rt(s, i)), () => union(ls(), rs()));
            Ops.Push(r);
        }
        public override void VisitEq(EqExpr node)
        {
            var joinable = Ops.Pop();
            var test = eqTest(joinable, node.FieldName, node.Value);
            var snapshot = eqSnapshot(joinable, node.FieldName, node.Value);
            Ops.Push(new Joinable<T>(joinable.Table, test, snapshot));
        }
        public Stack<Joinable<T>> Ops { get; }

    }
}

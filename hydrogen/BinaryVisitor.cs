using Hydrogen.Arrays;
using Hydrogen.Exprs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen
{
    public class BinaryVisitor<R> : ExprVisitor
    {
        private Func<string, Variant, R> eq;
        private Func<R, R, R> and;
        private Func<R, R, R> or;
        public BinaryVisitor(Func<string, Variant, R> eq, Func<R, R, R> and, Func<R, R, R> or)
        {
            Ops = new Stack<R>();
            this.eq = eq;
            this.and = and;
            this.or = or;
        }
        public override void VisitAnd(AndExpr node)
        {
            node.Left.Accept(this);
            var l = Ops.Pop();
            node.Right.Accept(this);
            var r = Ops.Pop();
            Ops.Push(and(l, r));
        }
        public override void VisitOr(OrExpr node)
        {
            node.Left.Accept(this);
            var l = Ops.Pop();
            node.Right.Accept(this);
            var r = Ops.Pop();
            Ops.Push(or(l, r));
        }
        public override void VisitEq(EqExpr node)
        {
            Ops.Push(eq(node.FieldName, node.Value));
        }
        public Stack<R> Ops { get; }

    }
}

using Hydrogen.Exprs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hydrogen
{
    public class BinaryVisitor : ExprVisitor
    {
        private Func<IJoinable, string, Variant, IJoinable> eq;
        public BinaryVisitor(Func<IJoinable, string, Variant, IJoinable> eq)
        {
            this.eq = eq;
            Ops = new Stack<IJoinable>();
        }
        public override void VisitAnd(AndExpr node)
        {
            node.Left.Accept(this);
            node.Right.Accept(this);
        }

        public override void VisitEq(EqExpr node)
        {
            var joinable = Ops.Pop();
            var j = eq(joinable, node.FieldName, node.Value);
            Ops.Push(j);
        }

        public Stack<IJoinable> Ops { get; }
    }
}

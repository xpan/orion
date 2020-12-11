using Hydrogen.Exprs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hydrogen
{
    public class Visitor : ExprVisitor
    {
        private Func<string, IJoinable> resolve;
        private Func<int, Func<IJoinable, string, Variant, IJoinable>> eq;
        private Func<int, int, Func<IJoinable, IJoinable, string, string, IJoinable>> join;

        public Visitor(Func<string, IJoinable> resolve, 
            Func<int, Func<IJoinable, string, Variant, IJoinable>> eq,
            Func<int, int, Func<IJoinable, IJoinable, string, string, IJoinable>> join)
        {
            this.join = join;
            this.resolve = resolve;
            this.eq = eq;
            Ops = new Stack<IJoinable>();
        }

        public override void VisitWhere(WhereExpr node)
        {
            node.Source.Accept(this);
            var s = Ops.Pop();
            var binary = new BinaryVisitor(eq);
            binary.Ops.Push(s);
            node.Condition.Accept(binary);
            var j = binary.Ops.Pop();
            Ops.Push(j);
        }

        public override void VisitConst(ConstExpr node)
        {
            Ops.Push(resolve(node.Value));
        }

        public override void VisitJoin(JoinExpr node)
        {
            node.Left.Accept(this);
            var l = Ops.Pop();
            node.Right.Accept(this);
            var r = Ops.Pop();
            var ctor = join(l.Table.Dim, r.Table.Dim);
            var j = ctor(l, r, node.LField, node.RField);
            Ops.Push(j);
        }

        public Stack<IJoinable> Ops { get; }
    }
}

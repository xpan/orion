using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.Exprs
{
    public class WhereExpr : Expr
    {
        public WhereExpr(Expr source, Expr condition)
        {
            Source = source;
            Condition = condition;
        }
        public Expr Condition { get; }
        public Expr Source { get; }
        public override void Accept(ExprVisitor visitor)
        {
            visitor.VisitWhere(this);
        }

        public void Deconstruct(out Expr source, out Expr condition)
        {
            source = Source;
            condition = Condition;
        }
    }
}

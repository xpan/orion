using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.Exprs
{
    public class AndExpr : Expr
    {
        public AndExpr(Expr l, Expr r)
        {
            Left = l;
            Right = r;
        }
        public Expr Left { get; }
        public Expr Right { get; }

        public void Deconstruct(out Expr l, out Expr r)
        {
            l = Left;
            r = Right;
        }
        public override void Accept(ExprVisitor visitor)
        {
            visitor.VisitAnd(this);
        }

        public override string ToString()
        {
            return $"&({Left})({Right})";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.Exprs
{
    public class OrExpr : Expr
    {
        public OrExpr(Expr l, Expr r)
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
            visitor.VisitOr(this);
        }

        public override string ToString()
        {
            return $"|({Left})({Right})";
        }
    }
}

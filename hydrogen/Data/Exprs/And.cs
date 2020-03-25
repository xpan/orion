using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.Data.Exprs
{
    public class And : Expr
    {
        public And(Expr l, Expr r)
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

    }
}

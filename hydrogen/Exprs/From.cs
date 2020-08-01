using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.Exprs
{
    public class From : Expr
    {
        public From(Expr source)
        {
            Source = source;
        }
        public Expr Source;
        public override void Accept(ExprVisitor visitor)
        {
            base.Accept(visitor);
        }
    }
}

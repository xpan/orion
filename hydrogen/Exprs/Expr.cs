using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.Exprs
{
    public class Expr
    {
        public virtual void Accept(ExprVisitor visitor)
        {

        }
    }
}

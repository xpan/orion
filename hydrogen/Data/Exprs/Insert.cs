using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.Data.Exprs
{
    public class Insert : Expr
    {
        public override void Accept(ExprVisitor visitor)
        {
            visitor.VisitInsert(this);
        }

        public static Insert Create(string tn, string[] vals)
        {
            return null;
        }
    }
}

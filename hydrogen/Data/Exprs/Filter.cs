using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.Data.Exprs
{
    public class Filter: Expr
    {
        public Filter(Expr table, Expr condition)
        {
            Table = table;
            Condition = condition;
        }
        public Expr Table { get; }
        public Expr Condition { get; }
        public override void Accept(ExprVisitor visitor)
        {
            visitor.VisitFilter(this);
        }
    }
}

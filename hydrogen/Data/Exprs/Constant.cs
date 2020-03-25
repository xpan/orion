using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.Data.Exprs
{
    public class Constant : Expr
    {
        public Constant(Table table)
        {
            Table = table;
        }
        public Table Table { get; }
        public override void Accept(ExprVisitor visitor)
        {
            visitor.VisitConstant(this);
        }
    }
}

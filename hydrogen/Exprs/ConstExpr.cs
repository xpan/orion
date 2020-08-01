using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.Exprs
{
    public class ConstExpr : Expr
    {
        public ConstExpr(string value)
        {
            Value = value;
        }
        public string Value { get; }
        public override void Accept(ExprVisitor visitor)
        {
            visitor.VisitConst(this);
        }
        public void Deconstruct(out string value)
        {
            value = Value;
        }
    }
}

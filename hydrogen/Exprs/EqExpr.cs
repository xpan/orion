using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.Exprs
{
    public class EqExpr : Expr
    {
        public EqExpr(string column, Variant value)
        {
            FieldName = column;
            Value = value; 
        }
        public string FieldName { get; }
        public Variant Value { get; }
        public override void Accept(ExprVisitor visitor)
        {
            visitor.VisitEq(this);
        }
        public void Deconstruct(out string fieldName, out Variant value)
        {
            fieldName = FieldName;
            value = Value;
        }

        public override string ToString()
        {
            return $"{FieldName} = {Value}";
        }
    }
}

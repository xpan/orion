using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.Data.Exprs
{
    public class Lt<T> : Expr where T: IComparable<T>
    {
        public Lt(in FieldSpec<T> fieldSpec, T value)
        {
            FieldSpec = fieldSpec;
            Value = value;
        }
        public FieldSpec<T> FieldSpec { get; }
        public T Value { get; }
        public override void Accept(ExprVisitor visitor)
        {
            visitor.VistLt(this);
        }
    }
}

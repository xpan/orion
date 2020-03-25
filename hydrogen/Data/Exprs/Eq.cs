using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.Data.Exprs
{
    public class Eq<T> : Expr where T : IComparable<T>
    {
        public Eq(in FieldSpec<T> fieldSpec, T value)
        {
            FieldSpec = fieldSpec;
            Value = value;
        }
        public FieldSpec<T> FieldSpec { get; }
        public T Value { get; }
        public override void Accept(ExprVisitor visitor)
        {
            visitor.VisitEq(this);
        }
    }
}

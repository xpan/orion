using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.Data.Exprs
{
    public class Join<T>: Expr
    {
        public Join(Expr outer, Expr inner, FieldSpec<T> outerFieldSpec, FieldSpec<T> innerFieldSpec)
        {
            Outer = outer;
            Inner = inner;
            OuterFieldSpec = outerFieldSpec;
            InnerFieldSpec = innerFieldSpec;
        }
        public Expr Outer { get; }
        public Expr Inner { get; }
        public FieldSpec<T> OuterFieldSpec { get; }
        public FieldSpec<T> InnerFieldSpec { get; }
        public override void Accept(ExprVisitor visitor)
        {
            visitor.VisitJoin(this);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.Exprs
{
    public class SelectExpr : Expr
    {
        public SelectExpr(string[] selected, Expr source)
        {
            Selected = selected;
            Source = source;
        }
        public string[] Selected { get; }
        public Expr Source { get; }
        public override void Accept(ExprVisitor visitor)
        {
            visitor.VisitSelect(this);
        }

        public void Deconstruct(out string[] selected, out Expr source)
        {
            selected = Selected;
            source = Source;
        }
    }
}

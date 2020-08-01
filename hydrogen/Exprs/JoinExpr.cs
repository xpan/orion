using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.Exprs
{
    public class JoinExpr : Expr
    {
        public JoinExpr(Expr left, Expr right, string fieldLeft, string fieldRight)
        {
            Left = left;
            Right = right;
            LField = fieldLeft;
            RField = fieldRight;
        }

        public Expr Left { get; }
        public Expr Right { get; }
        public string LField { get; }
        public string RField { get; }
        public override void Accept(ExprVisitor visitor)
        {
            visitor.VisitJoin(this);
        }

        public void Deconstruct(out Expr left, out Expr right, out string fieldLeft, out string fieldRight)
        {
            left = Left;
            right = Right;
            fieldLeft = LField;
            fieldRight = RField;
        }
    }
}

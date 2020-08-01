using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.Exprs
{
    public class ExprVisitor
    {
        public virtual void VisitAnd(AndExpr node)
        {
            node.Left.Accept(this);
            node.Right.Accept(this);
        }
        public virtual void VisitOr(OrExpr node)
        {
            node.Left.Accept(this);
            node.Right.Accept(this);
        }
        public virtual void VisitSelect(SelectExpr node)
        {
            
        }
        public virtual void VisitWhere(WhereExpr node)
        {

        }
        public virtual void VisitEq(EqExpr node)
        {

        }
        public virtual void VisitFrom(From node)
        {

        }
        public virtual void VisitConst(ConstExpr node)
        {

        }

        public virtual void VisitJoin(JoinExpr node)
        {

        }
    }
}

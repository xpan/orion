using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.Data.Exprs.Serialization
{
    public enum TokenType
    {
        Lt,
        Eq,
        Gt,
        And,
        Or,
        Dt,
        Lb,
        Rb,
        Comma,
        Integer,
        Symbol,
        Boolean
    }
}

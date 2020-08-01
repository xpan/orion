using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.Exprs.Serialization
{
    public enum TokenType
    {
        Select,
        From,
        Where,
        Wildcard,
        Number,
        Literal,
        Symbol,
        Comma,
        Eq,
        Gt,
        Lt,
        And,
        Or,
        Join,
        On,
        Boolean,
        Lb,
        Rb
    }
}

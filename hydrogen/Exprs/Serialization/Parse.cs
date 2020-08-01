using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.Exprs.Serialization
{
    public delegate ParseResult<T> Parse<T>(ArraySegment<Token> input);
}

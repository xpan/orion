using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.Data.Exprs.Serialization
{
    public delegate (T result, bool succeeded, ArraySegment<Token> remaining) Parse<T>(ArraySegment<Token> input);
}

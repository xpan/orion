using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen
{
    public delegate void Subscribe<T>(Joinable<T> joinable, Op op, T rowId, IEnumerable<(int fieldId, Variant v)> fields);
}

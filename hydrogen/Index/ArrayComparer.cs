using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Hydrogen.Index
{
    public class ArrayComparer<T> : IComparer<T> where T : IValueTypedArray<int>
    {
        public int Compare([AllowNull] T x, [AllowNull] T y)
        {
            static int ComparerArray(in T x, in T y, int index)
            {
                var r = x[index] - y[index];
                if (r != 0)
                    return r;
                else
                    return index < (x.Length - 1)? ComparerArray(x, y, index + 1) : 0;
            }
            return ComparerArray(x, y, 0);
        }

        public static implicit operator Comparison<T>(ArrayComparer<T> comparer)
        {
            return (x, y) => comparer.Compare(x, y);
        }
    }
}

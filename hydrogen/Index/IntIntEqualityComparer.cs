using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hydrogen.Index
{
    public class IntIntEqualityComparer : IEqualityComparer<(int id, int value)>
    {
        public bool Equals((int id, int value) x, (int id, int value) y)
        {
            return x.id == y.id && x.value == y.value;
        }

        public int GetHashCode([DisallowNull] (int id, int value) obj)
        {
            return obj.id * 31 + obj.value;
        }
    }
}

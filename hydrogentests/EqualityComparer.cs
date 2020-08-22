using Hydrogen;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace HydrogenTests
{
    class EqualityComparer : IEqualityComparer<ByteSlice>
    {
        public bool Equals([AllowNull] ByteSlice x, [AllowNull] ByteSlice y)
        {
            if (x.Count != y.Count)
            {                
                return false;
            }

            for (var i = 0; i < x.Count; i++)
            {
                if (x[i] != y[i])
                    return false;
            }
            return true;
        }

        public int GetHashCode([DisallowNull] ByteSlice obj)
        {
            return 0;
        }
    }
}

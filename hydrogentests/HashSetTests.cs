using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using Xunit;

namespace HydrogenTests
{
    public class HashSetTests
    {
        class IntEq : IEqualityComparer<int>
        {
            public bool Equals([AllowNull] int x, [AllowNull] int y)
            {
                return x == y;
            }

            public int GetHashCode([DisallowNull] int obj)
            {
                return obj;
            }
        }

        [Fact]
        public void Insert_None()
        {
            var hs = new Hydrogen.Index.HashSet<int>(new IntEq());
            var entry = hs.GetEntry(3);
            Assert.Equal(-1, entry);
        }

        [Fact]
        public void Insert_1()
        {
            var hs = new Hydrogen.Index.HashSet<int>(new IntEq());
            hs.Insert(3);
            var entry = hs.GetEntry(3);
            Assert.Equal(3, entry);
        }
    }
}

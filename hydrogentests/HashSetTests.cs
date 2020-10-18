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
                return 0;
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
            Assert.Equal(0, entry);
            Assert.Equal(3, hs.GetEntryValue(entry));
        }

        [Fact]
        public void Insert_1_2()
        {
            var hs = new Hydrogen.Index.HashSet<int>(new IntEq());
            hs.Insert(3);
            hs.Insert(4);
            var entry0 = hs.GetEntry(3);
            Assert.Equal(0, entry0);
            Assert.Equal(3, hs.GetEntryValue(entry0));
            var entry1 = hs.GetEntry(4);
            Assert.Equal(1, entry1);
            Assert.Equal(4, hs.GetEntryValue(entry1));
        }
    }
}

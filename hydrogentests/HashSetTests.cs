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
        public void Insert_3()
        {
            var hs = new Hydrogen.Index.HashSet<int>(new IntEq());
            hs.Insert(3);
            var entry = hs.GetEntry(3);
            Assert.Equal(0, entry);
            Assert.Equal(3, hs.GetEntryValue(entry));
            Assert.Equal(1, hs.Count);
            Assert.Equal(new int[] { 3 }, hs.It());
        }

        [Fact]
        public void Insert_3_4()
        {
            var hs = new Hydrogen.Index.HashSet<int>(new IntEq());
            hs.Insert(3);
            hs.Insert(4);
            var a = hs.GetEntry(3);
            Assert.Equal(0, a);
            Assert.Equal(3, hs.GetEntryValue(a));
            var b = hs.GetEntry(4);
            Assert.Equal(1, b);
            Assert.Equal(4, hs.GetEntryValue(b));
            Assert.Equal(2, hs.Count);
            Assert.Equal(new int[] { 3, 4 }, hs.It());
        }

        [Fact]
        public void Insert_3_then_remove_3()
        {
            var hs = new Hydrogen.Index.HashSet<int>(new IntEq());
            hs.Insert(3);
            var entry = hs.GetEntry(3);
            Assert.Equal(0, entry);
            Assert.Equal(3, hs.GetEntryValue(entry));
            Assert.Equal(1, hs.Count);
            Assert.Equal(new int[] { 3 }, hs.It());

            hs.Remove(entry);
            Assert.Equal(0, hs.Count);
            Assert.Empty(hs.It());
        }

        [Fact]
        public void Insert_3_4_then_remove_3()
        {
            var hs = new Hydrogen.Index.HashSet<int>(new IntEq());
            hs.Insert(3);
            hs.Insert(4);
            var a = hs.GetEntry(3);
            Assert.Equal(0, a);
            Assert.Equal(3, hs.GetEntryValue(a));
            var b = hs.GetEntry(4);
            Assert.Equal(1, b);
            Assert.Equal(4, hs.GetEntryValue(b));
            Assert.Equal(2, hs.Count);
            Assert.Equal(new int[] { 3, 4 }, hs.It());

            hs.Remove(a);
            Assert.Equal(1, hs.Count);
            Assert.Equal(new int[] { 4 }, hs.It());
        }

        [Fact]
        public void Insert_3_4_then_remove_4()
        {
            var hs = new Hydrogen.Index.HashSet<int>(new IntEq());
            hs.Insert(3);
            hs.Insert(4);
            var a = hs.GetEntry(3);
            Assert.Equal(0, a);
            Assert.Equal(3, hs.GetEntryValue(a));
            var b = hs.GetEntry(4);
            Assert.Equal(1, b);
            Assert.Equal(4, hs.GetEntryValue(b));
            Assert.Equal(2, hs.Count);
            Assert.Equal(new int[] { 3, 4 }, hs.It());

            hs.Remove(b);
            Assert.Equal(1, hs.Count);
            Assert.Equal(new int[] { 3 }, hs.It());
        }

        [Fact]
        public void Insert_3_4_then_remove_4_then_add_5()
        {
            var hs = new Hydrogen.Index.HashSet<int>(new IntEq());
            hs.Insert(3);
            hs.Insert(4);
            var a = hs.GetEntry(3);
            Assert.Equal(0, a);
            Assert.Equal(3, hs.GetEntryValue(a));
            var b = hs.GetEntry(4);
            Assert.Equal(1, b);
            Assert.Equal(4, hs.GetEntryValue(b));
            Assert.Equal(2, hs.Count);
            Assert.Equal(new int[] { 3, 4 }, hs.It());

            hs.Remove(b);
            Assert.Equal(1, hs.Count);
            Assert.Equal(new int[] { 3 }, hs.It());

            hs.Insert(5);
            var c = hs.GetEntry(5);
            Assert.Equal(1, c);
            Assert.Equal(5, hs.GetEntryValue(c));
            Assert.Equal(2, hs.Count);
            Assert.Equal(new int[] { 3, 5 }, hs.It());
        }
    }
}

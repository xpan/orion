using Hydrogen;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using Xunit;

namespace HydrogenTests
{
    public class FieldHashedSliceTests
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

        [Fact]
        public void Test_put_a()
        {
            var hashSet = new Hydrogen.Index.HashSet<ByteSlice>(new ByteSliceEqualityComparer());
            var bytes = new byte[] { (byte)'a' };
            var bs = new ByteSlice(bytes, 0, 1);
            hashSet.Insert(bs);
            var entry = hashSet.GetEntry(bs);
            var slice = hashSet.GetEntryValue(entry);
            Assert.Equal(0, slice.Offset);
            Assert.Equal(1, slice.Count);
            Assert.Equal((byte)'a', slice[0]);
        }

        [Fact]
        public void Test_put_a_with_hasher()
        {
            var hashSet = new Hydrogen.Index.HashSet<ByteSlice>(new EqualityComparer());
            var bytes = new byte[] { (byte)'a' };
            var bs = new ByteSlice(bytes, 0, 1);
            hashSet.Insert(bs);
            var entry = hashSet.GetEntry(bs);
            var slice = hashSet.GetEntryValue(entry);
            Assert.Equal(0, slice.Offset);
            Assert.Equal(1, slice.Count);
            Assert.Equal((byte)'a', slice[0]);
        }

        [Fact]
        public void Test_put_a_b_with_hasher()
        {
            var hashSet = new Hydrogen.Index.HashSet<ByteSlice>(new EqualityComparer());
            var bytes = new byte[] { (byte)'a', (byte)'b' };
            var bs0 = new ByteSlice(bytes, 0, 1);
            hashSet.Insert(bs0);
            var entry0 = hashSet.GetEntry(bs0);
            var slice0 = hashSet.GetEntryValue(entry0);
            Assert.Equal(0, slice0.Offset);
            Assert.Equal(1, slice0.Count);
            Assert.Equal((byte)'a', slice0[0]);

            var bs1 = new ByteSlice(bytes, 1, 1);
            hashSet.Insert(bs1);
            var entry1 = hashSet.GetEntry(bs1);
            var slice1 = hashSet.GetEntryValue(entry1);
            Assert.Equal(1, slice1.Offset);
            Assert.Equal(1, slice1.Count);
            Assert.Equal((byte)'b', slice1[0]);
        }

        [Fact]
        public void Test_put_a_b_c_with_hasher()
        {
            var hashSet = new Hydrogen.Index.HashSet<ByteSlice>(new EqualityComparer());
            var bytes = new byte[] { (byte)'a', (byte)'b', (byte)'c' };
            var bs0 = new ByteSlice(bytes, 0, 1);
            hashSet.Insert(bs0);
            var entry0 = hashSet.GetEntry(bs0);
            var slice0 = hashSet.GetEntryValue(entry0);
            Assert.Equal(0, slice0.Offset);
            Assert.Equal(1, slice0.Count);
            Assert.Equal((byte)'a', slice0[0]);

            var bs1 = new ByteSlice(bytes, 1, 1);
            hashSet.Insert(bs1);
            var entry1 = hashSet.GetEntry(bs1);
            var slice1 = hashSet.GetEntryValue(entry1);
            Assert.Equal(1, slice1.Offset);
            Assert.Equal(1, slice1.Count);
            Assert.Equal((byte)'b', slice1[0]);

            var bs2 = new ByteSlice(bytes, 2, 1);
            hashSet.Insert(bs2);
            var entry2 = hashSet.GetEntry(bs2);
            var slice2 = hashSet.GetEntryValue(entry2);
            Assert.Equal(2, slice2.Offset);
            Assert.Equal(1, slice2.Count);
            Assert.Equal((byte)'c', slice2[0]);
        }

        [Fact]
        public void Test_put_a_a_with_hasher()
        {
            var hashSet = new Hydrogen.Index.HashSet<ByteSlice>(new EqualityComparer());
            var bytes = new byte[] { (byte)'a', (byte)'a', (byte)'c' };
            var bs0 = new ByteSlice(bytes, 0, 1);
            hashSet.Insert(bs0);
            var entry0 = hashSet.GetEntry(bs0);
            var slice0 = hashSet.GetEntryValue(entry0);
            Assert.Equal(0, slice0.Offset);
            Assert.Equal(1, slice0.Count);
            Assert.Equal((byte)'a', slice0[0]);

            var bs1 = new ByteSlice(bytes, 1, 1);
            hashSet.Insert(bs1);
            var entry1 = hashSet.GetEntry(bs1);
            var slice1 = hashSet.GetEntryValue(entry1);
            Assert.Equal(0, slice1.Offset);
            Assert.Equal(1, slice1.Count);
            Assert.Equal((byte)'a', slice1[0]);
        }
    }
}

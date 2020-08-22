using Hydrogen;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace HydrogenTests
{
    public class ByteSliceHasherTests
    {
        [Fact]
        public void Test_put_a()
        {
            var hasher = new ByteSliceHasher();
            var bytes = new byte[] { (byte)'a' };
            var entry = hasher.GetEntry(new ByteSlice(bytes, 0, 1));
            var slice = hasher.GetEntryValue(entry);
            Assert.Equal(0, slice.Offset);
            Assert.Equal(1, slice.Count);
            Assert.Equal((byte)'a', slice[0]);
        }

        [Fact]
        public void Test_put_a_with_hasher()
        {
            var hasher = new ByteSliceHasher(new EqualityComparer());
            var bytes = new byte[] { (byte)'a' };
            var entry = hasher.GetEntry(new ByteSlice(bytes, 0, 1));
            var slice = hasher.GetEntryValue(entry);
            Assert.Equal(0, slice.Offset);
            Assert.Equal(1, slice.Count);
            Assert.Equal((byte)'a', slice[0]);
        }

        [Fact]
        public void Test_put_a_b_with_hasher()
        {
            var hasher = new ByteSliceHasher(new EqualityComparer());
            var bytes = new byte[] { (byte)'a', (byte)'b' };
            var entry = hasher.GetEntry(new ByteSlice(bytes, 0, 1));
            var slice = hasher.GetEntryValue(entry);
            Assert.Equal(0, slice.Offset);
            Assert.Equal(1, slice.Count);
            Assert.Equal((byte)'a', slice[0]);

            var entry1 = hasher.GetEntry(new ByteSlice(bytes, 1, 1));
            var slice1 = hasher.GetEntryValue(entry1);
            Assert.Equal(1, slice1.Offset);
            Assert.Equal(1, slice1.Count);
            Assert.Equal((byte)'b', slice1[0]);
        }

        [Fact]
        public void Test_put_a_b_c_with_hasher()
        {
            var hasher = new ByteSliceHasher(new EqualityComparer());
            var bytes = new byte[] { (byte)'a', (byte)'b', (byte)'c' };
            var entry = hasher.GetEntry(new ByteSlice(bytes, 0, 1));
            var slice = hasher.GetEntryValue(entry);
            Assert.Equal(0, slice.Offset);
            Assert.Equal(1, slice.Count);
            Assert.Equal((byte)'a', slice[0]);

            var entry1 = hasher.GetEntry(new ByteSlice(bytes, 1, 1));
            var slice1 = hasher.GetEntryValue(entry1);
            Assert.Equal(1, slice1.Offset);
            Assert.Equal(1, slice1.Count);
            Assert.Equal((byte)'b', slice1[0]);

            var entry2 = hasher.GetEntry(new ByteSlice(bytes, 2, 1));
            var slice2 = hasher.GetEntryValue(entry2);
            Assert.Equal(2, slice2.Offset);
            Assert.Equal(1, slice2.Count);
            Assert.Equal((byte)'c', slice2[0]);
        }

        [Fact]
        public void Test_put_a_a_with_hasher()
        {
            var hasher = new ByteSliceHasher(new EqualityComparer());
            var bytes = new byte[] { (byte)'a', (byte)'a', (byte)'c' };
            var entry = hasher.GetEntry(new ByteSlice(bytes, 0, 1));
            var slice = hasher.GetEntryValue(entry);
            Assert.Equal(0, slice.Offset);
            Assert.Equal(1, slice.Count);
            Assert.Equal((byte)'a', slice[0]);

            var entry1 = hasher.GetEntry(new ByteSlice(bytes, 1, 1));
            var slice1 = hasher.GetEntryValue(entry1);
            Assert.Equal(0, slice1.Offset);
            Assert.Equal(1, slice1.Count);
            Assert.Equal((byte)'a', slice1[0]);
        }
    }
}

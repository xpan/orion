using Hydrogen;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace HydrogenTests
{
    public class ByteSliceEqualityComparerTests
    {
        [Fact]
        public void Test_a()
        {
            var bytes = new byte[] { (byte)'a', (byte)'b', (byte)'c', (byte)'d', (byte)'e', (byte)'f', (byte)'g', (byte)'h', (byte)'i', (byte)'j', (byte)'k', (byte)'l', (byte)'m', (byte)'n', (byte)'o', (byte)'p', (byte)'q', (byte)'r', (byte)'s', (byte)'t', (byte)'u', (byte)'v', (byte)'w', (byte)'x', (byte)'y', (byte)'z' };
            var x = new ByteSlice(bytes, 0, 1);
            var y = new ByteSlice(bytes, 0, 1);
            var comparer = new ByteSliceEqualityComparer();
            Assert.True(comparer.Equals(x, y));
        }

        [Fact]
        public void Test_ab()
        {
            var bytes = new byte[] { (byte)'a', (byte)'b', (byte)'c', (byte)'d', (byte)'e', (byte)'f', (byte)'g', (byte)'h', (byte)'i', (byte)'j', (byte)'k', (byte)'l', (byte)'m', (byte)'n', (byte)'o', (byte)'p', (byte)'q', (byte)'r', (byte)'s', (byte)'t', (byte)'u', (byte)'v', (byte)'w', (byte)'x', (byte)'y', (byte)'z' };
            var x = new ByteSlice(bytes, 0, 2);
            var y = new ByteSlice(bytes, 0, 2);
            var comparer = new ByteSliceEqualityComparer();
            Assert.True(comparer.Equals(x, y));
        }

        [Fact]
        public void Test_abc()
        {
            var bytes = new byte[] { (byte)'a', (byte)'b', (byte)'c', (byte)'d', (byte)'e', (byte)'f', (byte)'g', (byte)'h', (byte)'i', (byte)'j', (byte)'k', (byte)'l', (byte)'m', (byte)'n', (byte)'o', (byte)'p', (byte)'q', (byte)'r', (byte)'s', (byte)'t', (byte)'u', (byte)'v', (byte)'w', (byte)'x', (byte)'y', (byte)'z' };
            var x = new ByteSlice(bytes, 0, 3);
            var y = new ByteSlice(bytes, 0, 3);
            var comparer = new ByteSliceEqualityComparer();
            Assert.True(comparer.Equals(x, y));
        }

        [Fact]
        public void Test_abcd()
        {
            var bytes = new byte[] { (byte)'a', (byte)'b', (byte)'c', (byte)'d', (byte)'e', (byte)'f', (byte)'g', (byte)'h', (byte)'i', (byte)'j', (byte)'k', (byte)'l', (byte)'m', (byte)'n', (byte)'o', (byte)'p', (byte)'q', (byte)'r', (byte)'s', (byte)'t', (byte)'u', (byte)'v', (byte)'w', (byte)'x', (byte)'y', (byte)'z' };
            var x = new ByteSlice(bytes, 0, 4);
            var y = new ByteSlice(bytes, 0, 4);
            var comparer = new ByteSliceEqualityComparer();
            Assert.True(comparer.Equals(x, y));
        }

        [Fact]
        public void Test_abcde()
        {
            var bytes = new byte[] { (byte)'a', (byte)'b', (byte)'c', (byte)'d', (byte)'e', (byte)'f', (byte)'g', (byte)'h', (byte)'i', (byte)'j', (byte)'k', (byte)'l', (byte)'m', (byte)'n', (byte)'o', (byte)'p', (byte)'q', (byte)'r', (byte)'s', (byte)'t', (byte)'u', (byte)'v', (byte)'w', (byte)'x', (byte)'y', (byte)'z' };
            var x = new ByteSlice(bytes, 0, 5);
            var y = new ByteSlice(bytes, 0, 5);
            var comparer = new ByteSliceEqualityComparer();
            Assert.True(comparer.Equals(x, y));
        }

        [Fact]
        public void Test_abcdef()
        {
            var bytes = new byte[] { (byte)'a', (byte)'b', (byte)'c', (byte)'d', (byte)'e', (byte)'f', (byte)'g', (byte)'h', (byte)'i', (byte)'j', (byte)'k', (byte)'l', (byte)'m', (byte)'n', (byte)'o', (byte)'p', (byte)'q', (byte)'r', (byte)'s', (byte)'t', (byte)'u', (byte)'v', (byte)'w', (byte)'x', (byte)'y', (byte)'z' };
            var x = new ByteSlice(bytes, 0, 6);
            var y = new ByteSlice(bytes, 0, 6);
            var comparer = new ByteSliceEqualityComparer();
            Assert.True(comparer.Equals(x, y));
        }

        [Fact]
        public void Test_abcdefg()
        {
            var bytes = new byte[] { (byte)'a', (byte)'b', (byte)'c', (byte)'d', (byte)'e', (byte)'f', (byte)'g', (byte)'h', (byte)'i', (byte)'j', (byte)'k', (byte)'l', (byte)'m', (byte)'n', (byte)'o', (byte)'p', (byte)'q', (byte)'r', (byte)'s', (byte)'t', (byte)'u', (byte)'v', (byte)'w', (byte)'x', (byte)'y', (byte)'z' };
            var x = new ByteSlice(bytes, 0, 7);
            var y = new ByteSlice(bytes, 0, 7);
            var comparer = new ByteSliceEqualityComparer();
            Assert.True(comparer.Equals(x, y));
        }

        [Fact]
        public void Test_abcdefgh()
        {
            var bytes = new byte[] { (byte)'a', (byte)'b', (byte)'c', (byte)'d', (byte)'e', (byte)'f', (byte)'g', (byte)'h', (byte)'i', (byte)'j', (byte)'k', (byte)'l', (byte)'m', (byte)'n', (byte)'o', (byte)'p', (byte)'q', (byte)'r', (byte)'s', (byte)'t', (byte)'u', (byte)'v', (byte)'w', (byte)'x', (byte)'y', (byte)'z' };
            var x = new ByteSlice(bytes, 0, 8);
            var y = new ByteSlice(bytes, 0, 8);
            var comparer = new ByteSliceEqualityComparer();
            Assert.True(comparer.Equals(x, y));
        }

        [Fact]
        public void Test_abcdefghi()
        {
            var bytes = new byte[] { (byte)'a', (byte)'b', (byte)'c', (byte)'d', (byte)'e', (byte)'f', (byte)'g', (byte)'h', (byte)'i', (byte)'j', (byte)'k', (byte)'l', (byte)'m', (byte)'n', (byte)'o', (byte)'p', (byte)'q', (byte)'r', (byte)'s', (byte)'t', (byte)'u', (byte)'v', (byte)'w', (byte)'x', (byte)'y', (byte)'z' };
            var x = new ByteSlice(bytes, 0, 9);
            var y = new ByteSlice(bytes, 0, 9);
            var comparer = new ByteSliceEqualityComparer();
            Assert.True(comparer.Equals(x, y));
        }

        [Fact]
        public void Test_abcdefghijklmnopqrstuvwxyz()
        {
            var bytes = new byte[] { (byte)'a', (byte)'b', (byte)'c', (byte)'d', (byte)'e', (byte)'f', (byte)'g', (byte)'h', (byte)'i', (byte)'j', (byte)'k', (byte)'l', (byte)'m', (byte)'n', (byte)'o', (byte)'p', (byte)'q', (byte)'r', (byte)'s', (byte)'t', (byte)'u', (byte)'v', (byte)'w', (byte)'x', (byte)'y', (byte)'z' };
            var x = new ByteSlice(bytes, 0, 26);
            var y = new ByteSlice(bytes, 0, 26);
            var comparer = new ByteSliceEqualityComparer();
            Assert.True(comparer.Equals(x, y));
        }
    }
}

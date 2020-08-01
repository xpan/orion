using Hydrogen;
using Hydrogen.Arrays;
using Hydrogen.Index;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace HydrogenTests
{
    public class InvertedIndexTests
    {
        [Fact]
        public void Test_put_00_10_21_32_41()
        {
            var comparer = new ArrayComparer<Array4<int>>();
            var invertedIndex = ArrayInvertedIndex<Array4<int>>.Create(n => new Array4<int>(n), comparer, 2);
            invertedIndex.Put(new Array4<int>(2) { [0] = 0, [1] = 0 });
            invertedIndex.Put(new Array4<int>(2) { [0] = 1, [1] = 0 });
            invertedIndex.Put(new Array4<int>(2) { [0] = 2, [1] = 1 });
            invertedIndex.Put(new Array4<int>(2) { [0] = 3, [1] = 2 });
            invertedIndex.Put(new Array4<int>(2) { [0] = 4, [1] = 1 });

            Assert.Equal(new Array4<int>[] { new Array4<int>(2) { [0] = 0, [1] = 0 }, new Array4<int>(2) { [0] = 1, [1] = 0 } }, invertedIndex.GetPostings(1, 0).ToArray());
            Assert.Equal(new Array4<int>[] { new Array4<int>(2) { [0] = 2, [1] = 1 }, new Array4<int>(2) { [0] = 4, [1] = 1 } }, invertedIndex.GetPostings(1, 1).ToArray());
            Assert.Equal(new Array4<int>[] { new Array4<int>(2) { [0] = 3, [1] = 2 } }, invertedIndex.GetPostings(1, 2).ToArray());
            Assert.Equal(new Array4<int>[] { new Array4<int>(2) { [0] = 0, [1] = 0 } }, invertedIndex.GetPostings(0, 0).ToArray());
            Assert.Equal(new Array4<int>[] { new Array4<int>(2) { [0] = 1, [1] = 0 } }, invertedIndex.GetPostings(0, 1).ToArray());
            Assert.Equal(new Array4<int>[] { new Array4<int>(2) { [0] = 2, [1] = 1 } }, invertedIndex.GetPostings(0, 2).ToArray());
            Assert.Equal(new Array4<int>[] { new Array4<int>(2) { [0] = 3, [1] = 2 } }, invertedIndex.GetPostings(0, 3).ToArray());
            Assert.Equal(new Array4<int>[] { new Array4<int>(2) { [0] = 4, [1] = 1 } }, invertedIndex.GetPostings(0, 4).ToArray());
        }

        [Fact]
        public void Test_put_00_10_21_32_41_then_delete_21()
        {
            var comparer = new ArrayComparer<Array4<int>>();
            var invertedIndex = ArrayInvertedIndex<Array4<int>>.Create(n => new Array4<int>(n), comparer, 2);
            invertedIndex.Put(new Array4<int>(2) { [0] = 0, [1] = 0 });
            invertedIndex.Put(new Array4<int>(2) { [0] = 1, [1] = 0 });
            invertedIndex.Put(new Array4<int>(2) { [0] = 2, [1] = 1 });
            invertedIndex.Put(new Array4<int>(2) { [0] = 3, [1] = 2 });
            invertedIndex.Put(new Array4<int>(2) { [0] = 4, [1] = 1 });
            invertedIndex.Remove(new Array4<int>(2) { [0] = 2, [1] = 1 });

            Assert.Equal(new Array4<int>[] { new Array4<int>(2) { [0] = 0, [1] = 0 }, new Array4<int>(2) { [0] = 1, [1] = 0 } }, invertedIndex.GetPostings(1, 0).ToArray());
            Assert.Equal(new Array4<int>[] { new Array4<int>(2) { [0] = 4, [1] = 1 } }, invertedIndex.GetPostings(1, 1).ToArray());
            Assert.Equal(new Array4<int>[] { new Array4<int>(2) { [0] = 3, [1] = 2 } }, invertedIndex.GetPostings(1, 2).ToArray());
            Assert.Equal(new Array4<int>[] { new Array4<int>(2) { [0] = 0, [1] = 0 } }, invertedIndex.GetPostings(0, 0).ToArray());
            Assert.Equal(new Array4<int>[] { new Array4<int>(2) { [0] = 1, [1] = 0 } }, invertedIndex.GetPostings(0, 1).ToArray());
            Assert.Empty(invertedIndex.GetPostings(0, 2).ToArray());
            Assert.Equal(new Array4<int>[] { new Array4<int>(2) { [0] = 3, [1] = 2 } }, invertedIndex.GetPostings(0, 3).ToArray());
            Assert.Equal(new Array4<int>[] { new Array4<int>(2) { [0] = 4, [1] = 1 } }, invertedIndex.GetPostings(0, 4).ToArray());
        }
    }
}

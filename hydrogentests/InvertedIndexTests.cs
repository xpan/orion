using Hydrogen.Data.Indices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace Hydrogen
{
    public class InvertedIndexTests
    {
        [Fact]
        public void Add_true_0()
        {
            var invertedIndex = new InvertedIndex<bool>(Comparer<bool>.Default);
            invertedIndex.Add(true, 0);
            var keys = invertedIndex.Keys.ToArray();
            Assert.Single(keys);
            Assert.True(keys[0]);
            var postings = invertedIndex.GetPostings(true).ToArray();
            Assert.Single(postings);
            Assert.Equal(0, postings[0]);
        }
        [Fact]
        public void Add_true_0_and_true_1()
        {
            var invertedIndex = new InvertedIndex<bool>(Comparer<bool>.Default);
            invertedIndex.Add(true, 0);
            invertedIndex.Add(true, 1);
            var keys = invertedIndex.Keys.ToArray();
            Assert.Single(keys);
            Assert.True(keys[0]);
            var postings = invertedIndex.GetPostings(true).ToArray();
            Assert.Equal(2, postings.Length);
            Assert.Equal(0, postings[0]);
            Assert.Equal(1, postings[1]);
        }
        [Fact]
        public void Add_true_1_and_true_0()
        {
            var invertedIndex = new InvertedIndex<bool>(Comparer<bool>.Default);
            invertedIndex.Add(true, 1);
            invertedIndex.Add(true, 0);
            var keys = invertedIndex.Keys.ToArray();
            Assert.Single(keys);
            Assert.True(keys[0]);
            var postings = invertedIndex.GetPostings(true).ToArray();
            Assert.Equal(2, postings.Length);
            Assert.Equal(0, postings[0]);
            Assert.Equal(1, postings[1]);
        }

        [Fact]
        public void Add_true_0_ThenDelete_true_0()
        {
            var invertedIndex = new InvertedIndex<bool>(Comparer<bool>.Default);
            invertedIndex.Add(true, 0);
            invertedIndex.Delete(true, 0);
            var keys = invertedIndex.Keys.ToArray();
            Assert.Empty(keys);
            var postings = invertedIndex.GetPostings(true).ToArray();
            Assert.Empty(postings);
        }
        [Fact]
        public void Add_true_0_and_true_1_ThenDelete_true_0()
        {
            var invertedIndex = new InvertedIndex<bool>(Comparer<bool>.Default);
            invertedIndex.Add(true, 0);
            invertedIndex.Add(true, 1);
            invertedIndex.Delete(true, 0);
            var keys = invertedIndex.Keys.ToArray();
            Assert.Single(keys);
            Assert.True(keys[0]);
            var postings = invertedIndex.GetPostings(true).ToArray();
            Assert.Single(postings);
            Assert.Equal(1, postings[0]);
        }

        [Fact]
        public void Add_true_0_and_true_1_ThenDelete_true_1()
        {
            var invertedIndex = new InvertedIndex<bool>(Comparer<bool>.Default);
            invertedIndex.Add(true, 0);
            invertedIndex.Add(true, 1);
            invertedIndex.Delete(true, 1);
            var keys = invertedIndex.Keys.ToArray();
            Assert.Single(keys);
            Assert.True(keys[0]);
            var postings = invertedIndex.GetPostings(true).ToArray();
            Assert.Single(postings);
            Assert.Equal(0, postings[0]);
        }
        [Fact]
        public void Add_true_0_And_true_1_ThenDelete_true_0_And_true_1()
        {
            var invertedIndex = new InvertedIndex<bool>(Comparer<bool>.Default);
            invertedIndex.Add(true, 0);
            invertedIndex.Add(true, 1);
            invertedIndex.Delete(true, 0);
            invertedIndex.Delete(true, 1);
            var keys = invertedIndex.Keys.ToArray();
            Assert.Empty(keys);
            var postings = invertedIndex.GetPostings(true).ToArray();
            Assert.Empty(postings);
        }

        [Fact]
        public void Add_true_0_And_true_1_ThenDelete_true_1_And_true_0()
        {
            var invertedIndex = new InvertedIndex<bool>(Comparer<bool>.Default);
            invertedIndex.Add(true, 0);
            invertedIndex.Add(true, 1);
            invertedIndex.Delete(true, 1);
            invertedIndex.Delete(true, 0);
            var keys = invertedIndex.Keys.ToArray();
            Assert.Empty(keys);
            var postings = invertedIndex.GetPostings(true).ToArray();
            Assert.Empty(postings);
        }

        [Fact]
        public void Add_true_0_And_false_1()
        {
            var invertedIndex = new InvertedIndex<bool>(Comparer<bool>.Default);
            invertedIndex.Add(true, 0);
            invertedIndex.Add(false, 1);
            var keys = invertedIndex.Keys.ToArray();
            Assert.Equal(2, keys.Length);
            Assert.False(keys[0]);
            Assert.True(keys[1]);
            var postings1 = invertedIndex.GetPostings(true).ToArray();
            Assert.Single(postings1);
            Assert.Equal(0, postings1[0]);
            var postings2 = invertedIndex.GetPostings(false).ToArray();
            Assert.Single(postings2);
            Assert.Equal(1, postings2[0]);
        }

        [Fact]
        public void Add_true_0_And_false_1_ThenDelete_true_0()
        {
            var invertedIndex = new InvertedIndex<bool>(Comparer<bool>.Default);
            invertedIndex.Add(true, 0);
            invertedIndex.Add(false, 1);
            invertedIndex.Delete(true, 0);
            var keys = invertedIndex.Keys.ToArray();
            Assert.Single(keys);
            Assert.False(keys[0]);
            var postings = invertedIndex.GetPostings(false).ToArray();
            Assert.Single(postings);
            Assert.Equal(1, postings[0]);
        }

        [Fact]
        public void Add_true_0_And_false_1_ThenDelete_false_1()
        {
            var invertedIndex = new InvertedIndex<bool>(Comparer<bool>.Default);
            invertedIndex.Add(true, 0);
            invertedIndex.Add(false, 1);
            invertedIndex.Delete(false, 1);
            var keys = invertedIndex.Keys.ToArray();
            Assert.Single(keys);
            Assert.True(keys[0]);
            var postings = invertedIndex.GetPostings(true).ToArray();
            Assert.Single(postings);
            Assert.Equal(0, postings[0]);
        }

        [Fact]
        public void Add_true_0_And_true_1_And_false_2()
        {
            var invertedIndex = new InvertedIndex<bool>(Comparer<bool>.Default);
            invertedIndex.Add(true, 0);
            invertedIndex.Add(true, 1);
            invertedIndex.Add(false, 2);
            var keys = invertedIndex.Keys.ToArray();
            Assert.Equal(2, keys.Length);
            Assert.False(keys[0]);
            Assert.True(keys[1]);
            var postings1 = invertedIndex.GetPostings(true).ToArray();
            Assert.Equal(2, postings1.Length);
            Assert.Equal(0, postings1[0]);
            Assert.Equal(1, postings1[1]);
            var postings2 = invertedIndex.GetPostings(false).ToArray();
            Assert.Single(postings2);
            Assert.Equal(2, postings2[0]);
        }
    }
}

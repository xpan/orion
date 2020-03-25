using System;
using Xunit;
using Hydrogen.Data.Indices;
using System.Collections.Generic;

namespace Hydrogen
{
    public class BinaryTreeInsertTests
    {
        [Fact]
        public void Insert_1()
        {
            var tree = new BinaryTree<int>(1024, Comparer<int>.Default);
            tree.Insert(1);
            
            Assert.Equal(-1, tree.nodes[0].h);
            Assert.Equal(-1, tree.nodes[0].l);
            Assert.Equal(1, tree.nodes[0].r);
            Assert.Equal(1, tree.nodes[0].p);
            Assert.Equal(1, tree.nodes[0].n);
            Assert.Equal(0, tree.nodes[0].val.value);
            Assert.True(tree.nodes[0].val.minimum);

            Assert.Equal(1, tree.nodes[1].h);
            Assert.Equal(-1, tree.nodes[1].l);
            Assert.Equal(-1, tree.nodes[1].r);
            Assert.Equal(0, tree.nodes[1].p);
            Assert.Equal(0, tree.nodes[1].n);
            Assert.Equal(1, tree.nodes[1].val.value);
            Assert.False(tree.nodes[1].val.minimum);
        }

        [Fact]
        public void Insert_1_2()
        {
            var tree = new BinaryTree<int>(1024, Comparer<int>.Default);
            tree.Insert(1);
            tree.Insert(2);

            Assert.Equal(-1, tree.nodes[0].h);
            Assert.Equal(-1, tree.nodes[0].l);
            Assert.Equal(1, tree.nodes[0].r);
            Assert.Equal(2, tree.nodes[0].p);
            Assert.Equal(1, tree.nodes[0].n);
            Assert.Equal(0, tree.nodes[0].val.value);
            Assert.True(tree.nodes[0].val.minimum);

            Assert.Equal(2, tree.nodes[1].h);
            Assert.Equal(-1, tree.nodes[1].l);
            Assert.Equal(2, tree.nodes[1].r);
            Assert.Equal(0, tree.nodes[1].p);
            Assert.Equal(2, tree.nodes[1].n);
            Assert.Equal(1, tree.nodes[1].val.value);
            Assert.False(tree.nodes[1].val.minimum);

            Assert.Equal(1, tree.nodes[2].h);
            Assert.Equal(-1, tree.nodes[2].l);
            Assert.Equal(-1, tree.nodes[2].r);
            Assert.Equal(1, tree.nodes[2].p);
            Assert.Equal(0, tree.nodes[2].n);
            Assert.Equal(2, tree.nodes[2].val.value);
            Assert.False(tree.nodes[2].val.minimum);
        }

        [Fact]
        public void Insert_1_3()
        {
            var tree = new BinaryTree<int>(1024, Comparer<int>.Default);
            tree.Insert(1);
            tree.Insert(3);

            Assert.Equal(-1, tree.nodes[0].h);
            Assert.Equal(-1, tree.nodes[0].l);
            Assert.Equal(1, tree.nodes[0].r);
            Assert.Equal(2, tree.nodes[0].p);
            Assert.Equal(1, tree.nodes[0].n);
            Assert.Equal(0, tree.nodes[0].val.value);
            Assert.True(tree.nodes[0].val.minimum);

            Assert.Equal(2, tree.nodes[1].h);
            Assert.Equal(-1, tree.nodes[1].l);
            Assert.Equal(2, tree.nodes[1].r);
            Assert.Equal(0, tree.nodes[1].p);
            Assert.Equal(2, tree.nodes[1].n);
            Assert.Equal(1, tree.nodes[1].val.value);
            Assert.False(tree.nodes[1].val.minimum);

            Assert.Equal(1, tree.nodes[2].h);
            Assert.Equal(-1, tree.nodes[2].l);
            Assert.Equal(-1, tree.nodes[2].r);
            Assert.Equal(1, tree.nodes[2].p);
            Assert.Equal(0, tree.nodes[2].n);
            Assert.Equal(3, tree.nodes[2].val.value);
            Assert.False(tree.nodes[2].val.minimum);
        }

        [Fact]
        public void Insert_1_2_3()
        {
            var tree = new BinaryTree<int>(1024, Comparer<int>.Default);
            tree.Insert(1);
            tree.Insert(2);
            tree.Insert(3);

            Assert.Equal(-1, tree.nodes[0].h);
            Assert.Equal(-1, tree.nodes[0].l);
            Assert.Equal(2, tree.nodes[0].r);
            Assert.Equal(3, tree.nodes[0].p);
            Assert.Equal(1, tree.nodes[0].n);
            Assert.Equal(0, tree.nodes[0].val.value);
            Assert.True(tree.nodes[0].val.minimum);

            Assert.Equal(1, tree.nodes[1].h);
            Assert.Equal(-1, tree.nodes[1].l);
            Assert.Equal(-1, tree.nodes[1].r);
            Assert.Equal(0, tree.nodes[1].p);
            Assert.Equal(2, tree.nodes[1].n);
            Assert.Equal(1, tree.nodes[1].val.value);
            Assert.False(tree.nodes[1].val.minimum);

            Assert.Equal(2, tree.nodes[2].h);
            Assert.Equal(1, tree.nodes[2].l);
            Assert.Equal(3, tree.nodes[2].r);
            Assert.Equal(1, tree.nodes[2].p);
            Assert.Equal(3, tree.nodes[2].n);
            Assert.Equal(2, tree.nodes[2].val.value);
            Assert.False(tree.nodes[2].val.minimum);

            Assert.Equal(1, tree.nodes[3].h);
            Assert.Equal(-1, tree.nodes[3].l);
            Assert.Equal(-1, tree.nodes[3].r);
            Assert.Equal(2, tree.nodes[3].p);
            Assert.Equal(0, tree.nodes[3].n);
            Assert.Equal(3, tree.nodes[3].val.value);
            Assert.False(tree.nodes[3].val.minimum);
        }

        [Fact]
        public void Insert_1_3_2()
        {
            var tree = new BinaryTree<int>(1024, Comparer<int>.Default);
            tree.Insert(1);
            tree.Insert(3);
            tree.Insert(2);

            Assert.Equal(-1, tree.nodes[0].h);
            Assert.Equal(-1, tree.nodes[0].l);
            Assert.Equal(3, tree.nodes[0].r);
            Assert.Equal(2, tree.nodes[0].p);
            Assert.Equal(1, tree.nodes[0].n);
            Assert.Equal(0, tree.nodes[0].val.value);
            Assert.True(tree.nodes[0].val.minimum);

            Assert.Equal(1, tree.nodes[1].h);
            Assert.Equal(-1, tree.nodes[1].l);
            Assert.Equal(-1, tree.nodes[1].r);
            Assert.Equal(0, tree.nodes[1].p);
            Assert.Equal(3, tree.nodes[1].n);
            Assert.Equal(1, tree.nodes[1].val.value);
            Assert.False(tree.nodes[1].val.minimum);

            Assert.Equal(1, tree.nodes[2].h);
            Assert.Equal(-1, tree.nodes[2].l);
            Assert.Equal(-1, tree.nodes[2].r);
            Assert.Equal(3, tree.nodes[2].p);
            Assert.Equal(0, tree.nodes[2].n);
            Assert.Equal(3, tree.nodes[2].val.value);
            Assert.False(tree.nodes[2].val.minimum);

            Assert.Equal(2, tree.nodes[3].h);
            Assert.Equal(1, tree.nodes[3].l);
            Assert.Equal(2, tree.nodes[3].r);
            Assert.Equal(1, tree.nodes[3].p);
            Assert.Equal(2, tree.nodes[3].n);
            Assert.Equal(2, tree.nodes[3].val.value);
            Assert.False(tree.nodes[3].val.minimum);
        }

        [Fact]
        public void Insert_2()
        {
            var tree = new BinaryTree<int>(1024, Comparer<int>.Default);
            tree.Insert(2);

            Assert.Equal(-1, tree.nodes[0].h);
            Assert.Equal(-1, tree.nodes[0].l);
            Assert.Equal(1, tree.nodes[0].r);
            Assert.Equal(1, tree.nodes[0].p);
            Assert.Equal(1, tree.nodes[0].n);
            Assert.Equal(0, tree.nodes[0].val.value);
            Assert.True(tree.nodes[0].val.minimum);

            Assert.Equal(1, tree.nodes[1].h);
            Assert.Equal(-1, tree.nodes[1].l);
            Assert.Equal(-1, tree.nodes[1].r);
            Assert.Equal(0, tree.nodes[1].p);
            Assert.Equal(0, tree.nodes[1].n);
            Assert.Equal(2, tree.nodes[1].val.value);
            Assert.False(tree.nodes[1].val.minimum);
        }

        [Fact]
        public void Insert_2_1()
        {
            var tree = new BinaryTree<int>(1024, Comparer<int>.Default);
            tree.Insert(2);
            tree.Insert(1);

            Assert.Equal(-1, tree.nodes[0].h);
            Assert.Equal(-1, tree.nodes[0].l);
            Assert.Equal(1, tree.nodes[0].r);
            Assert.Equal(1, tree.nodes[0].p);
            Assert.Equal(2, tree.nodes[0].n);
            Assert.Equal(0, tree.nodes[0].val.value);
            Assert.True(tree.nodes[0].val.minimum);

            Assert.Equal(2, tree.nodes[1].h);
            Assert.Equal(2, tree.nodes[1].l);
            Assert.Equal(-1, tree.nodes[1].r);
            Assert.Equal(2, tree.nodes[1].p);
            Assert.Equal(0, tree.nodes[1].n);
            Assert.Equal(2, tree.nodes[1].val.value);
            Assert.False(tree.nodes[1].val.minimum);

            Assert.Equal(1, tree.nodes[2].h);
            Assert.Equal(-1, tree.nodes[2].l);
            Assert.Equal(-1, tree.nodes[2].r);
            Assert.Equal(0, tree.nodes[2].p);
            Assert.Equal(1, tree.nodes[2].n);
            Assert.Equal(1, tree.nodes[2].val.value);
            Assert.False(tree.nodes[2].val.minimum);
        }

        [Fact]
        public void Insert_2_3()
        {
            var tree = new BinaryTree<int>(1024, Comparer<int>.Default);
            tree.Insert(2);
            tree.Insert(3);

            Assert.Equal(-1, tree.nodes[0].h);
            Assert.Equal(-1, tree.nodes[0].l);
            Assert.Equal(1, tree.nodes[0].r);
            Assert.Equal(2, tree.nodes[0].p);
            Assert.Equal(1, tree.nodes[0].n);
            Assert.Equal(0, tree.nodes[0].val.value);
            Assert.True(tree.nodes[0].val.minimum);

            Assert.Equal(2, tree.nodes[1].h);
            Assert.Equal(-1, tree.nodes[1].l);
            Assert.Equal(2, tree.nodes[1].r);
            Assert.Equal(0, tree.nodes[1].p);
            Assert.Equal(2, tree.nodes[1].n);
            Assert.Equal(2, tree.nodes[1].val.value);
            Assert.False(tree.nodes[1].val.minimum);

            Assert.Equal(1, tree.nodes[2].h);
            Assert.Equal(-1, tree.nodes[2].l);
            Assert.Equal(-1, tree.nodes[2].r);
            Assert.Equal(1, tree.nodes[2].p);
            Assert.Equal(0, tree.nodes[2].n);
            Assert.Equal(3, tree.nodes[2].val.value);
            Assert.False(tree.nodes[2].val.minimum);
        }

        [Fact]
        public void Insert_2_1_3()
        {
            var tree = new BinaryTree<int>(1024, Comparer<int>.Default);
            tree.Insert(2);
            tree.Insert(1);
            tree.Insert(3);

            Assert.Equal(-1, tree.nodes[0].h);
            Assert.Equal(-1, tree.nodes[0].l);
            Assert.Equal(1, tree.nodes[0].r);
            Assert.Equal(3, tree.nodes[0].p);
            Assert.Equal(2, tree.nodes[0].n);
            Assert.Equal(0, tree.nodes[0].val.value);
            Assert.True(tree.nodes[0].val.minimum);

            Assert.Equal(2, tree.nodes[1].h);
            Assert.Equal(2, tree.nodes[1].l);
            Assert.Equal(3, tree.nodes[1].r);
            Assert.Equal(2, tree.nodes[1].p);
            Assert.Equal(3, tree.nodes[1].n);
            Assert.Equal(2, tree.nodes[1].val.value);
            Assert.False(tree.nodes[1].val.minimum);

            Assert.Equal(1, tree.nodes[2].h);
            Assert.Equal(-1, tree.nodes[2].l);
            Assert.Equal(-1, tree.nodes[2].r);
            Assert.Equal(0, tree.nodes[2].p);
            Assert.Equal(1, tree.nodes[2].n);
            Assert.Equal(1, tree.nodes[2].val.value);
            Assert.False(tree.nodes[2].val.minimum);

            Assert.Equal(1, tree.nodes[3].h);
            Assert.Equal(-1, tree.nodes[3].l);
            Assert.Equal(-1, tree.nodes[3].r);
            Assert.Equal(1, tree.nodes[3].p);
            Assert.Equal(0, tree.nodes[3].n);
            Assert.Equal(3, tree.nodes[3].val.value);
            Assert.False(tree.nodes[2].val.minimum);
        }

        [Fact]
        public void Insert_2_3_1()
        {
            var tree = new BinaryTree<int>(1024, Comparer<int>.Default);
            tree.Insert(2);
            tree.Insert(3);
            tree.Insert(1);

            Assert.Equal(-1, tree.nodes[0].h);
            Assert.Equal(-1, tree.nodes[0].l);
            Assert.Equal(1, tree.nodes[0].r);
            Assert.Equal(2, tree.nodes[0].p);
            Assert.Equal(3, tree.nodes[0].n);
            Assert.Equal(0, tree.nodes[0].val.value);
            Assert.True(tree.nodes[0].val.minimum);

            Assert.Equal(2, tree.nodes[1].h);
            Assert.Equal(3, tree.nodes[1].l);
            Assert.Equal(2, tree.nodes[1].r);
            Assert.Equal(3, tree.nodes[1].p);
            Assert.Equal(2, tree.nodes[1].n);
            Assert.Equal(2, tree.nodes[1].val.value);
            Assert.False(tree.nodes[1].val.minimum);

            Assert.Equal(1, tree.nodes[2].h);
            Assert.Equal(-1, tree.nodes[2].l);
            Assert.Equal(-1, tree.nodes[2].r);
            Assert.Equal(1, tree.nodes[2].p);
            Assert.Equal(0, tree.nodes[2].n);
            Assert.Equal(3, tree.nodes[2].val.value);
            Assert.False(tree.nodes[2].val.minimum);

            Assert.Equal(1, tree.nodes[3].h);
            Assert.Equal(-1, tree.nodes[3].l);
            Assert.Equal(-1, tree.nodes[3].r);
            Assert.Equal(0, tree.nodes[3].p);
            Assert.Equal(1, tree.nodes[3].n);
            Assert.Equal(1, tree.nodes[3].val.value);
            Assert.False(tree.nodes[2].val.minimum);
        }

        [Fact]
        public void Insert_3()
        {
            var tree = new BinaryTree<int>(1024, Comparer<int>.Default);
            tree.Insert(3);

            Assert.Equal(-1, tree.nodes[0].h);
            Assert.Equal(-1, tree.nodes[0].l);
            Assert.Equal(1, tree.nodes[0].r);
            Assert.Equal(1, tree.nodes[0].p);
            Assert.Equal(1, tree.nodes[0].n);
            Assert.Equal(0, tree.nodes[0].val.value);
            Assert.True(tree.nodes[0].val.minimum);

            Assert.Equal(1, tree.nodes[1].h);
            Assert.Equal(-1, tree.nodes[1].l);
            Assert.Equal(-1, tree.nodes[1].r);
            Assert.Equal(0, tree.nodes[1].p);
            Assert.Equal(0, tree.nodes[1].n);
            Assert.Equal(3, tree.nodes[1].val.value);
            Assert.False(tree.nodes[1].val.minimum);
        }

        [Fact]
        public void Insert_3_1()
        {
            var tree = new BinaryTree<int>(1024, Comparer<int>.Default);
            tree.Insert(3);
            tree.Insert(1);

            Assert.Equal(-1, tree.nodes[0].h);
            Assert.Equal(-1, tree.nodes[0].l);
            Assert.Equal(1, tree.nodes[0].r);
            Assert.Equal(1, tree.nodes[0].p);
            Assert.Equal(2, tree.nodes[0].n);
            Assert.Equal(0, tree.nodes[0].val.value);
            Assert.True(tree.nodes[0].val.minimum);

            Assert.Equal(2, tree.nodes[1].h);
            Assert.Equal(2, tree.nodes[1].l);
            Assert.Equal(-1, tree.nodes[1].r);
            Assert.Equal(2, tree.nodes[1].p);
            Assert.Equal(0, tree.nodes[1].n);
            Assert.Equal(3, tree.nodes[1].val.value);
            Assert.False(tree.nodes[1].val.minimum);

            Assert.Equal(1, tree.nodes[2].h);
            Assert.Equal(-1, tree.nodes[2].l);
            Assert.Equal(-1, tree.nodes[2].r);
            Assert.Equal(0, tree.nodes[2].p);
            Assert.Equal(1, tree.nodes[2].n);
            Assert.Equal(1, tree.nodes[2].val.value);
            Assert.False(tree.nodes[2].val.minimum);
        }

        [Fact]
        public void Insert_3_2()
        {
            var tree = new BinaryTree<int>(1024, Comparer<int>.Default);
            tree.Insert(3);
            tree.Insert(2);

            Assert.Equal(-1, tree.nodes[0].h);
            Assert.Equal(-1, tree.nodes[0].l);
            Assert.Equal(1, tree.nodes[0].r);
            Assert.Equal(1, tree.nodes[0].p);
            Assert.Equal(2, tree.nodes[0].n);
            Assert.Equal(0, tree.nodes[0].val.value);
            Assert.True(tree.nodes[0].val.minimum);

            Assert.Equal(2, tree.nodes[1].h);
            Assert.Equal(2, tree.nodes[1].l);
            Assert.Equal(-1, tree.nodes[1].r);
            Assert.Equal(2, tree.nodes[1].p);
            Assert.Equal(0, tree.nodes[1].n);
            Assert.Equal(3, tree.nodes[1].val.value);
            Assert.False(tree.nodes[1].val.minimum);

            Assert.Equal(1, tree.nodes[2].h);
            Assert.Equal(-1, tree.nodes[2].l);
            Assert.Equal(-1, tree.nodes[2].r);
            Assert.Equal(0, tree.nodes[2].p);
            Assert.Equal(1, tree.nodes[2].n);
            Assert.Equal(2, tree.nodes[2].val.value);
            Assert.False(tree.nodes[2].val.minimum);
        }

        [Fact]
        public void Insert_3_1_2()
        {
            var tree = new BinaryTree<int>(1024, Comparer<int>.Default);
            tree.Insert(3);
            tree.Insert(1);
            tree.Insert(2);

            Assert.Equal(-1, tree.nodes[0].h);
            Assert.Equal(-1, tree.nodes[0].l);
            Assert.Equal(3, tree.nodes[0].r);
            Assert.Equal(1, tree.nodes[0].p);
            Assert.Equal(2, tree.nodes[0].n);
            Assert.Equal(0, tree.nodes[0].val.value);
            Assert.True(tree.nodes[0].val.minimum);

            Assert.Equal(1, tree.nodes[1].h);
            Assert.Equal(-1, tree.nodes[1].l);
            Assert.Equal(-1, tree.nodes[1].r);
            Assert.Equal(3, tree.nodes[1].p);
            Assert.Equal(0, tree.nodes[1].n);
            Assert.Equal(3, tree.nodes[1].val.value);
            Assert.False(tree.nodes[1].val.minimum);

            Assert.Equal(1, tree.nodes[2].h);
            Assert.Equal(-1, tree.nodes[2].l);
            Assert.Equal(-1, tree.nodes[2].r);
            Assert.Equal(0, tree.nodes[2].p);
            Assert.Equal(3, tree.nodes[2].n);
            Assert.Equal(1, tree.nodes[2].val.value);
            Assert.False(tree.nodes[2].val.minimum);

            Assert.Equal(2, tree.nodes[3].h);
            Assert.Equal(2, tree.nodes[3].l);
            Assert.Equal(1, tree.nodes[3].r);
            Assert.Equal(2, tree.nodes[3].p);
            Assert.Equal(1, tree.nodes[3].n);
            Assert.Equal(2, tree.nodes[3].val.value);
            Assert.False(tree.nodes[3].val.minimum);
        }

        [Fact]
        public void Insert_3_2_1()
        {
            var tree = new BinaryTree<int>(1024, Comparer<int>.Default);
            tree.Insert(3);
            tree.Insert(2);
            tree.Insert(1);

            Assert.Equal(-1, tree.nodes[0].h);
            Assert.Equal(-1, tree.nodes[0].l);
            Assert.Equal(2, tree.nodes[0].r);
            Assert.Equal(1, tree.nodes[0].p);
            Assert.Equal(3, tree.nodes[0].n);
            Assert.Equal(0, tree.nodes[0].val.value);
            Assert.True(tree.nodes[0].val.minimum);

            Assert.Equal(1, tree.nodes[1].h);
            Assert.Equal(-1, tree.nodes[1].l);
            Assert.Equal(-1, tree.nodes[1].r);
            Assert.Equal(2, tree.nodes[1].p);
            Assert.Equal(0, tree.nodes[1].n);
            Assert.Equal(3, tree.nodes[1].val.value);
            Assert.False(tree.nodes[1].val.minimum);

            Assert.Equal(2, tree.nodes[2].h);
            Assert.Equal(3, tree.nodes[2].l);
            Assert.Equal(1, tree.nodes[2].r);
            Assert.Equal(3, tree.nodes[2].p);
            Assert.Equal(1, tree.nodes[2].n);
            Assert.Equal(2, tree.nodes[2].val.value);
            Assert.False(tree.nodes[2].val.minimum);

            Assert.Equal(1, tree.nodes[3].h);
            Assert.Equal(-1, tree.nodes[3].l);
            Assert.Equal(-1, tree.nodes[3].r);
            Assert.Equal(0, tree.nodes[3].p);
            Assert.Equal(2, tree.nodes[3].n);
            Assert.Equal(1, tree.nodes[3].val.value);
            Assert.False(tree.nodes[3].val.minimum);
        }

        [Fact]
        public void Insert_1_2_3_4_5()
        {
            var tree = new BinaryTree<int>(1024, Comparer<int>.Default);
            tree.Insert(1);
            tree.Insert(2);
            tree.Insert(3);
            tree.Insert(4);
            tree.Insert(5);

            Assert.Equal(-1, tree.nodes[0].h);
            Assert.Equal(-1, tree.nodes[0].l);
            Assert.Equal(2, tree.nodes[0].r);
            Assert.Equal(5, tree.nodes[0].p);
            Assert.Equal(1, tree.nodes[0].n);
            Assert.Equal(0, tree.nodes[0].val.value);
            Assert.True(tree.nodes[0].val.minimum);

            Assert.Equal(1, tree.nodes[1].h);
            Assert.Equal(-1, tree.nodes[1].l);
            Assert.Equal(-1, tree.nodes[1].r);
            Assert.Equal(0, tree.nodes[1].p);
            Assert.Equal(2, tree.nodes[1].n);
            Assert.Equal(1, tree.nodes[1].val.value);
            Assert.False(tree.nodes[1].val.minimum);

            Assert.Equal(3, tree.nodes[2].h);
            Assert.Equal(1, tree.nodes[2].l);
            Assert.Equal(4, tree.nodes[2].r);
            Assert.Equal(1, tree.nodes[2].p);
            Assert.Equal(3, tree.nodes[2].n);
            Assert.Equal(2, tree.nodes[2].val.value);
            Assert.False(tree.nodes[2].val.minimum);

            Assert.Equal(1, tree.nodes[3].h);
            Assert.Equal(-1, tree.nodes[3].l);
            Assert.Equal(-1, tree.nodes[3].r);
            Assert.Equal(2, tree.nodes[3].p);
            Assert.Equal(4, tree.nodes[3].n);
            Assert.Equal(3, tree.nodes[3].val.value);
            Assert.False(tree.nodes[3].val.minimum);

            Assert.Equal(2, tree.nodes[4].h);
            Assert.Equal(3, tree.nodes[4].l);
            Assert.Equal(5, tree.nodes[4].r);
            Assert.Equal(3, tree.nodes[4].p);
            Assert.Equal(5, tree.nodes[4].n);
            Assert.Equal(4, tree.nodes[4].val.value);
            Assert.False(tree.nodes[4].val.minimum);

            Assert.Equal(1, tree.nodes[5].h);
            Assert.Equal(-1, tree.nodes[5].l);
            Assert.Equal(-1, tree.nodes[5].r);
            Assert.Equal(4, tree.nodes[5].p);
            Assert.Equal(0, tree.nodes[5].n);
            Assert.Equal(5, tree.nodes[5].val.value);
            Assert.False(tree.nodes[5].val.minimum);
        }

        [Fact]
        public void Insert_1_2_3_5_4()
        {
            var tree = new BinaryTree<int>(1024, Comparer<int>.Default);
            tree.Insert(1);
            tree.Insert(2);
            tree.Insert(3);
            tree.Insert(5);
            tree.Insert(4);

            Assert.Equal(-1, tree.nodes[0].h);
            Assert.Equal(-1, tree.nodes[0].l);
            Assert.Equal(2, tree.nodes[0].r);
            Assert.Equal(4, tree.nodes[0].p);
            Assert.Equal(1, tree.nodes[0].n);
            Assert.Equal(0, tree.nodes[0].val.value);
            Assert.True(tree.nodes[0].val.minimum);

            Assert.Equal(1, tree.nodes[1].h);
            Assert.Equal(-1, tree.nodes[1].l);
            Assert.Equal(-1, tree.nodes[1].r);
            Assert.Equal(0, tree.nodes[1].p);
            Assert.Equal(2, tree.nodes[1].n);
            Assert.Equal(1, tree.nodes[1].val.value);
            Assert.False(tree.nodes[1].val.minimum);

            Assert.Equal(3, tree.nodes[2].h);
            Assert.Equal(1, tree.nodes[2].l);
            Assert.Equal(5, tree.nodes[2].r);
            Assert.Equal(1, tree.nodes[2].p);
            Assert.Equal(3, tree.nodes[2].n);
            Assert.Equal(2, tree.nodes[2].val.value);
            Assert.False(tree.nodes[2].val.minimum);

            Assert.Equal(1, tree.nodes[3].h);
            Assert.Equal(-1, tree.nodes[3].l);
            Assert.Equal(-1, tree.nodes[3].r);
            Assert.Equal(2, tree.nodes[3].p);
            Assert.Equal(5, tree.nodes[3].n);
            Assert.Equal(3, tree.nodes[3].val.value);
            Assert.False(tree.nodes[3].val.minimum);

            Assert.Equal(1, tree.nodes[4].h);
            Assert.Equal(-1, tree.nodes[4].l);
            Assert.Equal(-1, tree.nodes[4].r);
            Assert.Equal(5, tree.nodes[4].p);
            Assert.Equal(0, tree.nodes[4].n);
            Assert.Equal(5, tree.nodes[4].val.value);
            Assert.False(tree.nodes[4].val.minimum);

            Assert.Equal(2, tree.nodes[5].h);
            Assert.Equal(3, tree.nodes[5].l);
            Assert.Equal(4, tree.nodes[5].r);
            Assert.Equal(3, tree.nodes[5].p);
            Assert.Equal(4, tree.nodes[5].n);
            Assert.Equal(4, tree.nodes[5].val.value);
            Assert.False(tree.nodes[5].val.minimum);
        }
    }
}

using Hydrogen.Index;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace HydrogenTests
{
    public class BinaryTreeDeleteTests
    {
        [Fact]
        public void Insert_1_2_3_4_5_6_ThenDelete_1()
        {
            var s = new BinaryTree<int>(1024, Comparer<int>.Default);
            s.Insert(1);
            s.Insert(2);
            s.Insert(3);
            s.Insert(4);
            s.Insert(5);
            s.Insert(6);

            s.Remove(1);

            Assert.Equal(-1, s.nodes[0].h);
            Assert.Equal(-1, s.nodes[0].l);
            Assert.Equal(4, s.nodes[0].r);
            Assert.Equal(6, s.nodes[0].p);
            Assert.Equal(2, s.nodes[0].n);
            Assert.Equal(0, s.nodes[0].val.value);
            Assert.True(s.nodes[0].val.minimum);

            Assert.Equal(1, s.nodes[1].h);
            Assert.Equal(-1, s.nodes[1].l);
            Assert.Equal(-1, s.nodes[1].r);
            Assert.Equal(0, s.nodes[1].p);
            Assert.Equal(2, s.nodes[1].n);
            Assert.Equal(1, s.nodes[1].val.value);
            Assert.False(s.nodes[1].val.minimum);

            Assert.Equal(2, s.nodes[2].h);
            Assert.Equal(-1, s.nodes[2].l);
            Assert.Equal(3, s.nodes[2].r);
            Assert.Equal(0, s.nodes[2].p);
            Assert.Equal(3, s.nodes[2].n);
            Assert.Equal(2, s.nodes[2].val.value);
            Assert.False(s.nodes[2].val.minimum);

            Assert.Equal(1, s.nodes[3].h);
            Assert.Equal(-1, s.nodes[3].l);
            Assert.Equal(-1, s.nodes[3].r);
            Assert.Equal(2, s.nodes[3].p);
            Assert.Equal(4, s.nodes[3].n);
            Assert.Equal(3, s.nodes[3].val.value);
            Assert.False(s.nodes[3].val.minimum);

            Assert.Equal(3, s.nodes[4].h);
            Assert.Equal(2, s.nodes[4].l);
            Assert.Equal(5, s.nodes[4].r);
            Assert.Equal(3, s.nodes[4].p);
            Assert.Equal(5, s.nodes[4].n);
            Assert.Equal(4, s.nodes[4].val.value);
            Assert.False(s.nodes[4].val.minimum);

            Assert.Equal(2, s.nodes[5].h);
            Assert.Equal(-1, s.nodes[5].l);
            Assert.Equal(6, s.nodes[5].r);
            Assert.Equal(4, s.nodes[5].p);
            Assert.Equal(6, s.nodes[5].n);
            Assert.Equal(5, s.nodes[5].val.value);
            Assert.False(s.nodes[5].val.minimum);

            Assert.Equal(1, s.nodes[6].h);
            Assert.Equal(-1, s.nodes[6].l);
            Assert.Equal(-1, s.nodes[6].r);
            Assert.Equal(5, s.nodes[6].p);
            Assert.Equal(0, s.nodes[6].n);
            Assert.Equal(6, s.nodes[6].val.value);
            Assert.False(s.nodes[6].val.minimum);
        }

        [Fact]
        public void Insert_1_2_3_4_5_6_ThenDelete_2()
        {
            var s = new BinaryTree<int>(1024, Comparer<int>.Default);
            s.Insert(1);
            s.Insert(2);
            s.Insert(3);
            s.Insert(4);
            s.Insert(5);
            s.Insert(6);

            s.Remove(2);

            Assert.Equal(-1, s.nodes[0].h);
            Assert.Equal(-1, s.nodes[0].l);
            Assert.Equal(4, s.nodes[0].r);
            Assert.Equal(6, s.nodes[0].p);
            Assert.Equal(2, s.nodes[0].n);
            Assert.Equal(0, s.nodes[0].val.value);
            Assert.True(s.nodes[0].val.minimum);

            Assert.Equal(1, s.nodes[1].h);
            Assert.Equal(-1, s.nodes[1].l);
            Assert.Equal(-1, s.nodes[1].r);
            Assert.Equal(0, s.nodes[1].p);
            Assert.Equal(2, s.nodes[1].n);
            Assert.Equal(1, s.nodes[1].val.value);
            Assert.False(s.nodes[1].val.minimum);

            Assert.Equal(2, s.nodes[2].h);
            Assert.Equal(-1, s.nodes[2].l);
            Assert.Equal(3, s.nodes[2].r);
            Assert.Equal(0, s.nodes[2].p);
            Assert.Equal(3, s.nodes[2].n);
            Assert.Equal(1, s.nodes[2].val.value);
            Assert.False(s.nodes[2].val.minimum);

            Assert.Equal(1, s.nodes[3].h);
            Assert.Equal(-1, s.nodes[3].l);
            Assert.Equal(-1, s.nodes[3].r);
            Assert.Equal(2, s.nodes[3].p);
            Assert.Equal(4, s.nodes[3].n);
            Assert.Equal(3, s.nodes[3].val.value);
            Assert.False(s.nodes[3].val.minimum);

            Assert.Equal(3, s.nodes[4].h);
            Assert.Equal(2, s.nodes[4].l);
            Assert.Equal(5, s.nodes[4].r);
            Assert.Equal(3, s.nodes[4].p);
            Assert.Equal(5, s.nodes[4].n);
            Assert.Equal(4, s.nodes[4].val.value);
            Assert.False(s.nodes[4].val.minimum);

            Assert.Equal(2, s.nodes[5].h);
            Assert.Equal(-1, s.nodes[5].l);
            Assert.Equal(6, s.nodes[5].r);
            Assert.Equal(4, s.nodes[5].p);
            Assert.Equal(6, s.nodes[5].n);
            Assert.Equal(5, s.nodes[5].val.value);
            Assert.False(s.nodes[5].val.minimum);

            Assert.Equal(1, s.nodes[6].h);
            Assert.Equal(-1, s.nodes[6].l);
            Assert.Equal(-1, s.nodes[6].r);
            Assert.Equal(5, s.nodes[6].p);
            Assert.Equal(0, s.nodes[6].n);
            Assert.Equal(6, s.nodes[6].val.value);
            Assert.False(s.nodes[6].val.minimum);
        }

        [Fact]
        public void Insert_1_2_3_4_5_6_ThenDelete_3()
        {
            var s = new BinaryTree<int>(1024, Comparer<int>.Default);
            s.Insert(1);
            s.Insert(2);
            s.Insert(3);
            s.Insert(4);
            s.Insert(5);
            s.Insert(6);

            s.Remove(3);

            Assert.Equal(-1, s.nodes[0].h);
            Assert.Equal(-1, s.nodes[0].l);
            Assert.Equal(4, s.nodes[0].r);
            Assert.Equal(6, s.nodes[0].p);
            Assert.Equal(1, s.nodes[0].n);
            Assert.Equal(0, s.nodes[0].val.value);
            Assert.True(s.nodes[0].val.minimum);

            Assert.Equal(1, s.nodes[1].h);
            Assert.Equal(-1, s.nodes[1].l);
            Assert.Equal(-1, s.nodes[1].r);
            Assert.Equal(0, s.nodes[1].p);
            Assert.Equal(2, s.nodes[1].n);
            Assert.Equal(1, s.nodes[1].val.value);
            Assert.False(s.nodes[1].val.minimum);

            Assert.Equal(2, s.nodes[2].h);
            Assert.Equal(1, s.nodes[2].l);
            Assert.Equal(-1, s.nodes[2].r);
            Assert.Equal(1, s.nodes[2].p);
            Assert.Equal(4, s.nodes[2].n);
            Assert.Equal(2, s.nodes[2].val.value);
            Assert.False(s.nodes[2].val.minimum);

            Assert.Equal(1, s.nodes[3].h);
            Assert.Equal(-1, s.nodes[3].l);
            Assert.Equal(-1, s.nodes[3].r);
            Assert.Equal(2, s.nodes[3].p);
            Assert.Equal(4, s.nodes[3].n);
            Assert.Equal(3, s.nodes[3].val.value);
            Assert.False(s.nodes[3].val.minimum);

            Assert.Equal(3, s.nodes[4].h);
            Assert.Equal(2, s.nodes[4].l);
            Assert.Equal(5, s.nodes[4].r);
            Assert.Equal(2, s.nodes[4].p);
            Assert.Equal(5, s.nodes[4].n);
            Assert.Equal(4, s.nodes[4].val.value);
            Assert.False(s.nodes[4].val.minimum);

            Assert.Equal(2, s.nodes[5].h);
            Assert.Equal(-1, s.nodes[5].l);
            Assert.Equal(6, s.nodes[5].r);
            Assert.Equal(4, s.nodes[5].p);
            Assert.Equal(6, s.nodes[5].n);
            Assert.Equal(5, s.nodes[5].val.value);
            Assert.False(s.nodes[5].val.minimum);

            Assert.Equal(1, s.nodes[6].h);
            Assert.Equal(-1, s.nodes[6].l);
            Assert.Equal(-1, s.nodes[6].r);
            Assert.Equal(5, s.nodes[6].p);
            Assert.Equal(0, s.nodes[6].n);
            Assert.Equal(6, s.nodes[6].val.value);
            Assert.False(s.nodes[6].val.minimum);
        }

        [Fact]
        public void Insert_1_2_3_4_5_6_ThenDelete_4()
        {
            var s = new BinaryTree<int>(1024, Comparer<int>.Default);
            s.Insert(1);
            s.Insert(2);
            s.Insert(3);
            s.Insert(4);
            s.Insert(5);
            s.Insert(6);

            s.Remove(4);

            Assert.Equal(-1, s.nodes[0].h);
            Assert.Equal(-1, s.nodes[0].l);
            Assert.Equal(4, s.nodes[0].r);
            Assert.Equal(6, s.nodes[0].p);
            Assert.Equal(1, s.nodes[0].n);
            Assert.Equal(0, s.nodes[0].val.value);
            Assert.True(s.nodes[0].val.minimum);

            Assert.Equal(1, s.nodes[1].h);
            Assert.Equal(-1, s.nodes[1].l);
            Assert.Equal(-1, s.nodes[1].r);
            Assert.Equal(0, s.nodes[1].p);
            Assert.Equal(2, s.nodes[1].n);
            Assert.Equal(1, s.nodes[1].val.value);
            Assert.False(s.nodes[1].val.minimum);

            Assert.Equal(2, s.nodes[2].h);
            Assert.Equal(1, s.nodes[2].l);
            Assert.Equal(-1, s.nodes[2].r);
            Assert.Equal(1, s.nodes[2].p);
            Assert.Equal(4, s.nodes[2].n);
            Assert.Equal(2, s.nodes[2].val.value);
            Assert.False(s.nodes[2].val.minimum);

            Assert.Equal(1, s.nodes[3].h);
            Assert.Equal(-1, s.nodes[3].l);
            Assert.Equal(-1, s.nodes[3].r);
            Assert.Equal(2, s.nodes[3].p);
            Assert.Equal(4, s.nodes[3].n);
            Assert.Equal(3, s.nodes[3].val.value);
            Assert.False(s.nodes[3].val.minimum);

            Assert.Equal(3, s.nodes[4].h);
            Assert.Equal(2, s.nodes[4].l);
            Assert.Equal(5, s.nodes[4].r);
            Assert.Equal(2, s.nodes[4].p);
            Assert.Equal(5, s.nodes[4].n);
            Assert.Equal(3, s.nodes[4].val.value);
            Assert.False(s.nodes[4].val.minimum);

            Assert.Equal(2, s.nodes[5].h);
            Assert.Equal(-1, s.nodes[5].l);
            Assert.Equal(6, s.nodes[5].r);
            Assert.Equal(4, s.nodes[5].p);
            Assert.Equal(6, s.nodes[5].n);
            Assert.Equal(5, s.nodes[5].val.value);
            Assert.False(s.nodes[5].val.minimum);

            Assert.Equal(1, s.nodes[6].h);
            Assert.Equal(-1, s.nodes[6].l);
            Assert.Equal(-1, s.nodes[6].r);
            Assert.Equal(5, s.nodes[6].p);
            Assert.Equal(0, s.nodes[6].n);
            Assert.Equal(6, s.nodes[6].val.value);
            Assert.False(s.nodes[6].val.minimum);
        }

        [Fact]
        public void Insert_1_2_3_4_5_6_ThenDelete_5()
        {
            var s = new BinaryTree<int>(1024, Comparer<int>.Default);
            s.Insert(1);
            s.Insert(2);
            s.Insert(3);
            s.Insert(4);
            s.Insert(5);
            s.Insert(6);

            s.Remove(5);

            Assert.Equal(-1, s.nodes[0].h);
            Assert.Equal(-1, s.nodes[0].l);
            Assert.Equal(4, s.nodes[0].r);
            Assert.Equal(6, s.nodes[0].p);
            Assert.Equal(1, s.nodes[0].n);
            Assert.Equal(0, s.nodes[0].val.value);
            Assert.True(s.nodes[0].val.minimum);

            Assert.Equal(1, s.nodes[1].h);
            Assert.Equal(-1, s.nodes[1].l);
            Assert.Equal(-1, s.nodes[1].r);
            Assert.Equal(0, s.nodes[1].p);
            Assert.Equal(2, s.nodes[1].n);
            Assert.Equal(1, s.nodes[1].val.value);
            Assert.False(s.nodes[1].val.minimum);

            Assert.Equal(2, s.nodes[2].h);
            Assert.Equal(1, s.nodes[2].l);
            Assert.Equal(3, s.nodes[2].r);
            Assert.Equal(1, s.nodes[2].p);
            Assert.Equal(3, s.nodes[2].n);
            Assert.Equal(2, s.nodes[2].val.value);
            Assert.False(s.nodes[2].val.minimum);

            Assert.Equal(1, s.nodes[3].h);
            Assert.Equal(-1, s.nodes[3].l);
            Assert.Equal(-1, s.nodes[3].r);
            Assert.Equal(2, s.nodes[3].p);
            Assert.Equal(4, s.nodes[3].n);
            Assert.Equal(3, s.nodes[3].val.value);
            Assert.False(s.nodes[3].val.minimum);

            Assert.Equal(3, s.nodes[4].h);
            Assert.Equal(2, s.nodes[4].l);
            Assert.Equal(6, s.nodes[4].r);
            Assert.Equal(3, s.nodes[4].p);
            Assert.Equal(6, s.nodes[4].n);
            Assert.Equal(4, s.nodes[4].val.value);
            Assert.False(s.nodes[4].val.minimum);

            Assert.Equal(2, s.nodes[5].h);
            Assert.Equal(-1, s.nodes[5].l);
            Assert.Equal(6, s.nodes[5].r);
            Assert.Equal(4, s.nodes[5].p);
            Assert.Equal(6, s.nodes[5].n);
            Assert.Equal(5, s.nodes[5].val.value);
            Assert.False(s.nodes[5].val.minimum);

            Assert.Equal(1, s.nodes[6].h);
            Assert.Equal(-1, s.nodes[6].l);
            Assert.Equal(-1, s.nodes[6].r);
            Assert.Equal(4, s.nodes[6].p);
            Assert.Equal(0, s.nodes[6].n);
            Assert.Equal(6, s.nodes[6].val.value);
            Assert.False(s.nodes[6].val.minimum);
        }

        [Fact]
        public void Insert_1_2_3_4_5_6_ThenDelete_6()
        {
            var s = new BinaryTree<int>(1024, Comparer<int>.Default);
            s.Insert(1);
            s.Insert(2);
            s.Insert(3);
            s.Insert(4);
            s.Insert(5);
            s.Insert(6);

            s.Remove(6);

            Assert.Equal(-1, s.nodes[0].h);
            Assert.Equal(-1, s.nodes[0].l);
            Assert.Equal(4, s.nodes[0].r);
            Assert.Equal(5, s.nodes[0].p);
            Assert.Equal(1, s.nodes[0].n);
            Assert.Equal(0, s.nodes[0].val.value);
            Assert.True(s.nodes[0].val.minimum);

            Assert.Equal(1, s.nodes[1].h);
            Assert.Equal(-1, s.nodes[1].l);
            Assert.Equal(-1, s.nodes[1].r);
            Assert.Equal(0, s.nodes[1].p);
            Assert.Equal(2, s.nodes[1].n);
            Assert.Equal(1, s.nodes[1].val.value);
            Assert.False(s.nodes[1].val.minimum);

            Assert.Equal(2, s.nodes[2].h);
            Assert.Equal(1, s.nodes[2].l);
            Assert.Equal(3, s.nodes[2].r);
            Assert.Equal(1, s.nodes[2].p);
            Assert.Equal(3, s.nodes[2].n);
            Assert.Equal(2, s.nodes[2].val.value);
            Assert.False(s.nodes[2].val.minimum);

            Assert.Equal(1, s.nodes[3].h);
            Assert.Equal(-1, s.nodes[3].l);
            Assert.Equal(-1, s.nodes[3].r);
            Assert.Equal(2, s.nodes[3].p);
            Assert.Equal(4, s.nodes[3].n);
            Assert.Equal(3, s.nodes[3].val.value);
            Assert.False(s.nodes[3].val.minimum);

            Assert.Equal(3, s.nodes[4].h);
            Assert.Equal(2, s.nodes[4].l);
            Assert.Equal(5, s.nodes[4].r);
            Assert.Equal(3, s.nodes[4].p);
            Assert.Equal(5, s.nodes[4].n);
            Assert.Equal(4, s.nodes[4].val.value);
            Assert.False(s.nodes[4].val.minimum);

            Assert.Equal(1, s.nodes[5].h);
            Assert.Equal(-1, s.nodes[5].l);
            Assert.Equal(-1, s.nodes[5].r);
            Assert.Equal(4, s.nodes[5].p);
            Assert.Equal(0, s.nodes[5].n);
            Assert.Equal(5, s.nodes[5].val.value);
            Assert.False(s.nodes[5].val.minimum);

            Assert.Equal(1, s.nodes[6].h);
            Assert.Equal(-1, s.nodes[6].l);
            Assert.Equal(-1, s.nodes[6].r);
            Assert.Equal(5, s.nodes[6].p);
            Assert.Equal(0, s.nodes[6].n);
            Assert.Equal(6, s.nodes[6].val.value);
            Assert.False(s.nodes[6].val.minimum);
        }
    }
}

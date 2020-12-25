using Hydrogen.Enumerators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace HydrogenTests
{
    public class EnumeratorTests
    {
        [Fact]
        public void TestEmpty()
        {
            var e = new Empty<int>();
            IEnumerable<int> It()
            {
                while (e.MoveNext())
                {
                    yield return e.Current;
                }
            }
            
            Assert.Empty(It());
        }

        [Fact]
        public void TestSeq1()
        {
            var e = new Seq1<int> { d1 = 2 };
            IEnumerable<int> It()
            {
                while (e.MoveNext())
                {
                    yield return e.Current;
                }
            }
            Assert.Equal(new int[] { 2 }, It());
        }

        [Fact]
        public void TestSeq2()
        {
            var e = new Seq2<int> { d1 = 2, d2 = 5 };
            IEnumerable<int> It()
            {
                while (e.MoveNext())
                {
                    yield return e.Current;
                }
            }
            Assert.Equal(new int[] { 2, 5 }, It());
        }

        [Fact]
        public void TestSeq3()
        {
            var e = new Seq3<int> { d1 = 2, d2 = 5, d3 = 3 };
            IEnumerable<int> It()
            {
                while (e.MoveNext())
                {
                    yield return e.Current;
                }
            }
            Assert.Equal(new int[] { 2, 5, 3 }, It());
        }

        [Fact]
        public void TestSeq4()
        {
            var e = new Seq4<int> { d1 = 2, d2 = 5, d3 = 3, d4 = 7 };
            IEnumerable<int> It()
            {
                while (e.MoveNext())
                {
                    yield return e.Current;
                }
            }
            Assert.Equal(new int[] { 2, 5, 3, 7 }, It());
        }

        [Fact]
        public void TestSelectMany()
        {
            var e = new Seq3<int> { d1 = 2, d2 = 5, d3 = 3 };
            var selectMany = new SelectMany<Seq3<int>, int, Seq2<bool>, bool, (int, bool)> { state = 0, s = e, flatMap = i => new Seq2<bool> { d1 = true, d2 = false }, select = (i, j) => (i, j) };
            IEnumerable<(int,bool)> It()
            {
                while (selectMany.MoveNext())
                {
                    yield return selectMany.Current;
                }
            }
            Assert.Equal(new (int, bool)[] { (2, true), (2, false), (5, true), (5, false), (3, true), (3, false) }, It());
        }

        [Fact]
        public void TestWhere()
        {
            var e = new Seq4<int> { d1 = 2, d2 = 5, d3 = 3, d4 = 7 };
            var _if = new Where<Seq4<int>, int> { s = e, predicate = i => i != 5 };
            IEnumerable<int> It()
            {
                while (_if.MoveNext())
                {
                    yield return _if.Current;
                }
            }
            Assert.Equal(new int[] { 2, 3, 7 }, It());
        }
    }
}

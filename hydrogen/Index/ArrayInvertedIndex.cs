using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hydrogen.Index
{
    public class ArrayInvertedIndex<T> where T : IValueTypedArray<int>
    {
        private readonly BinarySearchTree<IndexEntry<T>> bt;
        private readonly Func<T, int>[] factCreators;
        private readonly T minimum;
        protected ArrayInvertedIndex(T minimum, int capacity, Comparison<T> comparison, Func<T, int>[] factCreators)
        {
            int Compare(IndexEntry<T> x, IndexEntry<T> y)
            {
                if (x.factId < y.factId)
                    return -1;
                else if (x.factId > y.factId)
                    return 1;
                else if (x.fact < y.fact)
                    return -1;
                else if (x.fact > y.fact)
                    return 1;
                else
                    return comparison(x.value, y.value);
            }

            this.minimum = minimum;
            this.factCreators = factCreators;
            bt = new BinarySearchTree<IndexEntry<T>>(Compare, capacity);
        }

        public static ArrayInvertedIndex<T> Create(Func<int, T> ctor, IComparer<T> comparer, int dimension)
        {
            var min = ctor(dimension);
            min[0] = -1;
            Func<T, int> Create(int i) => v => v[i];
            var creators = Enumerable.Range(0, dimension).Select(Create).ToArray();

            return new ArrayInvertedIndex<T>(min, 1024, (x, y) => comparer.Compare(x, y), creators);
        }
        public void Put(T value)
        {
            for (var i = 0; i < factCreators.Length; i++)
                bt.Insert(new IndexEntry<T> { factId = i, fact = factCreators[i](value), value = value });
        }

        public void Remove(T value)
        {
            for (var i = 0; i < factCreators.Length; i++)
                bt.Remove(new IndexEntry<T> { factId = i, fact = factCreators[i](value), value = value });
        }

        public IEnumerable<T> GetPostings(int factId, int fact)
        {
            var target = new IndexEntry<T> { factId = factId, fact = fact, value = minimum };
            foreach (var (fid, f, val) in bt.Gt(target))
            {
                if (fid == factId && f == fact)
                    yield return val;
                else
                    yield break;
            }                
        }
    }
}

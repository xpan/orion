using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hydrogen.Index
{
    public class ArrayInvertedIndex<T> where T : IValueTypedArray<int>
    {
        private readonly BinaryTree<IndexEntry<T>> bt;
        private readonly Func<T, int>[] factCreators;
        private readonly T minimum;
        protected ArrayInvertedIndex(T minimum, int capacity, Comparison<T> comparer, Func<T, int>[] factCreators)
        {
            this.minimum = minimum;
            this.factCreators = factCreators;
            bt = new BinaryTree<IndexEntry<T>>(capacity, new IndexEntryComparer<T>(comparer));
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
            foreach (var (_, _, value) in bt.GreaterThan(target, e => e.factId == factId && e.fact == fact))
                yield return value;
        }
    }
}

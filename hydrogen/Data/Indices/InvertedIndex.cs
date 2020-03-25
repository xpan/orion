using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hydrogen.Data.Indices
{
    public class InvertedIndex<T>
    {
        private BinaryTree<InvertedIndexEntry<T>> s;
        private BinaryTree<T> keys;
        private InvertedIndexEntryComparer<T> entryComparer;
        private IComparer<T> valueComparer;
        public InvertedIndex(IComparer<T> comparer)
        {
            valueComparer = comparer;
            entryComparer = new InvertedIndexEntryComparer<T>(comparer);
            s = new BinaryTree<InvertedIndexEntry<T>>(4096, entryComparer);
            keys = new BinaryTree<T>(1024, comparer);
        }
        public IEnumerable<int> GreaterThanIter(T key)
        {
            InvertedIndexEntry<T> entry;
            entry.key = key;
            // For now I am using int.MaxValue to implement (>).  The limitation
            // is posting cannot use in.MaxValue as a valid value
            entry.posting = int.MaxValue;
            var iter = s.GreaterThan(entry);
            foreach (var (_, posting) in iter)
            {
                yield return posting;
            }
        }

        public IEnumerable<T> Keys => keys.Iter();

        public IEnumerable<int> GetPostings(T key)
        {
            InvertedIndexEntry<T> entry;
            entry.key = key;
            // An index is always a postive value or zero.  -1 will make sure
            // all associated indices are returned
            entry.posting = -1;
            var iter = s.GreaterThan(entry, e => valueComparer.Compare(e.key, key) == 0);
            foreach (var (_, posting) in iter)
            {
                yield return posting;
            }
        }

        public void Add(T key, int value)
        {
            InvertedIndexEntry<T> entry;
            entry.key = key;
            entry.posting = value;
            s.Insert(entry);
            keys.Insert(key);
        }
        public void Delete(T key, int value)
        {
            InvertedIndexEntry<T> entry;
            entry.key = key;
            entry.posting = value;
            s.Remove(entry);
            if (!GetPostings(key).Any())
            {
                keys.Remove(key);
            }
        }
    }
}

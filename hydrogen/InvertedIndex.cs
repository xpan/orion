using Hydrogen.Index;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hydrogen
{
    public class InvertedIndex<T>
    {
        private Hydrogen.Index.HashSet<(int factId, int fact)> keys;
        private BinarySearchTree<(int entry, int val)> keyValues;
        private BinarySearchTree<T> vals;
        private int[] count;

        public InvertedIndex(Comparison<T> comparison)
        {
            int CompareIntIntValue((int entry, int val) x, (int entry, int val) y)
            {
                return (x.entry - y.entry) switch
                {
                    > 0 => 1,
                    < 0 => -1,
                    0 => x.val - y.val
                };
            }
            keys = new Index.HashSet<(int factId, int fact)>(new IntIntEqualityComparer());
            vals = new BinarySearchTree<T>(comparison);
            keyValues = new BinarySearchTree<(int entry, int val)>(CompareIntIntValue);
            count = new int[1024];
        }
        public void Add(int factId, int fact, T value)
        {
            var key = (factId, fact);
            var keyEntry = keys.GetEntry(key);
            if (keyEntry < 0)
            {
                keys.Insert(key);
                keyEntry = keys.GetEntry(key);
            }

            var valEntry = vals.GetEntry(value);
            if (valEntry < 0)
            {
                vals.Insert(value);
                valEntry = vals.GetEntry(value);
            }
            count[valEntry]++;
            keyValues.Insert((keyEntry, valEntry));
        }

        public void Delete(int factId, int fact, T value)
        {
            IEnumerable<int> It(int keyEntry)
            {
                foreach (var a in keyValues.Gt((keyEntry, -1)))
                {
                    if (a.entry != keyEntry)
                        yield break;
                    yield return a.val;
                }
            }

            var key = (factId, fact);
            var keyEntry = keys.GetEntry(key);
            var valEntry = vals.GetEntry(value);

            keyValues.Remove((keyEntry, valEntry));
            count[valEntry]--;

            if (!It(keyEntry).Any())
                keys.Remove(keyEntry);
        }

        public IEnumerable<T> GetPostings(int factId, int fact)
        {
            var key = (factId, fact);
            var entry = keys.GetEntry(key);
            if (entry < 0)
                yield break;

            foreach (var a in keyValues.Gt((entry, -1)))
            {
                if (a.entry != entry)
                    yield break;
                yield return vals.GetEntryValue(a.val);
            }
        }

        public int Count(T value)
        {
            var entry = vals.GetEntry(value);
            return count[entry];
        }

        public int GetEntry(T value)
        {
            return vals.GetEntry(value);
        }

        public T GetEntryValue(int entry)
        {
            return vals.GetEntryValue(entry);
        }
    }
}

using Hydrogen.Index;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hydrogen
{
    public class FieldIndex : IIndex
    {
        private Hydrogen.Index.HashSet<Variant> keys;
        private BinarySearchTree<(int entry, int index)> values;
        private int[] entries;
        public FieldIndex(int capacity)
        {
            int CompareIntInt((int entry, int index) x, (int entry, int index) y)
            {
                return (x.entry - y.entry) switch
                {
                    < 0 => -1,
                    > 0 => 1,
                    0 => x.index - y.index,
                };
            }
            keys = new Index.HashSet<Variant>(new VariantEqualityComparer(), capacity);
            values = new BinarySearchTree<(int entry, int index)>(CompareIntInt, capacity);
            entries = new int[capacity];
        }
        public int Count => keys.Count;

        public IEnumerable<int> GetEntries()
        {
            return keys.GetEntries();
        }

        public int GetEntry(Variant v)
        {
            return keys.GetEntry(v);
        }

        public Variant GetEntryValue(int entry)
        {
            return keys.GetEntryValue(entry);
        }

        public IEnumerable<int> GetPostings(int entry)
        {
            foreach (var (k, v) in values.Gt((entry, -1)))
            {
                if (k != entry)
                    yield break;
                yield return v;
            }
        }

        public void Add(int index, Variant v)
        {
            var entry = keys.GetEntry(v);
            if (entry >= 0)
            {
                values.Insert((entry, index));
                entries[index] = entry;
            }                
            else
            {
                keys.Insert(v);
                entry = keys.GetEntry(v);
                values.Insert((entry, index));
                entries[index] = entry;
            }
        }

        public void Update(int index, Variant v)
        {
            var entry = entries[index];
            var val = keys.GetEntryValue(entry);
            if (!val.Equals(v))
            {
                values.Remove((entry, index));
                Add(index, v);
            }
        }

        public void Delete(int index)
        {
            var entry = entries[index];
            if (entry >= 0)
                values.Remove((entry, index));
        }
    }
}

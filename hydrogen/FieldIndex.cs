using Hydrogen.Index;
using System;
using System.Collections;
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
            int CompareEntryIndex((int entry, int index) x, (int entry, int index) y)
            {
                return (x.entry - y.entry) switch
                {
                    < 0 => -1,
                    > 0 => 1,
                    0 => x.index - y.index,
                };
            }
            keys = new Index.HashSet<Variant>(new VariantEqualityComparer(), capacity);
            values = new BinarySearchTree<(int entry, int index)>(CompareEntryIndex, capacity);
            entries = new int[capacity];
        }
        public int Count => keys.Count;

        public struct Keys : IEnumerator<int>
        {
            internal Hydrogen.Index.HashSet<Variant>.Keys s;
            public int Current => s.Current;

            object IEnumerator.Current => throw new NotImplementedException();

            public void Dispose()
            {
                throw new NotImplementedException();
            }

            public bool MoveNext()
            {
                return s.MoveNext();
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }
        }

        public void Entries(ref Keys it)
        {
            keys.Entries(ref it.s);
        }

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

        public struct Values : IEnumerator<int>
        {
            internal BinarySearchTree<(int entry, int index)>.Values s;
            private int v;
            internal int state;
            internal int entry;
            public int Current => v;

            object IEnumerator.Current => throw new NotImplementedException();

            public void Dispose()
            {
                throw new NotImplementedException();
            }

            public bool MoveNext()
            {
                switch (state)
                {
                    case 0:
                        if (!s.MoveNext()) goto case 1;
                        if (s.Current.entry != entry) goto case 1;
                        v = s.Current.index;
                        state = 0;
                        return true;
                    case 1:
                        return false;
                    default:
                        throw new ApplicationException();
                }
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }
        }


        public void GetPostings(int entry, ref Values it)
        {
            it.state = 0;
            it.entry = entry;
            values.Gt((entry, -1), ref it.s);
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

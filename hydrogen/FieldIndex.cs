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
        private BinarySearchTree<Variant> keys;
        private BinarySearchTree<(int entry, int value)> indices;
        public int Count => keys.Count;

        public FieldIndex(int capacity = 1024)
        {            
            int CompareIntInt((int entry, int value)x, (int entry, int value) y)
            {
                var r = x.entry - y.entry;
                if (r != 0)
                    return r;
                else
                    return x.value - y.value;
            }
            keys = new BinarySearchTree<Variant>((x, y) => VariantComparer.Default.Compare(x, y), capacity);
            indices = new BinarySearchTree<(int, int)>(CompareIntInt, capacity);
        }

        public bool Contains(Variant v)
        {
            return keys.GetEntry(v) >= 0;
        }

        public IEnumerable<int> GetPostings(Variant value)
        {
            var entry = keys.GetEntry(value);
            if (entry < 0)
                yield break;

            foreach (var (e, v) in indices.Gt((entry, -1)))
            {
                if (e == entry)
                    yield return v;
                else
                    yield break;
            }
        }

        public IEnumerable<Variant> Values => keys.It();

        public void Put(int index, Variant value)
        {
            var entry = keys.GetEntry(value);
            if (entry >= 0)
                indices.Insert((entry, index));
            else
            {
                keys.Insert(value);
                entry = keys.GetEntry(value);
                indices.Insert((entry, index));
            }            
        }

        public void Delete(int index, Variant v)
        {
            IEnumerable<(int, int)> It(int entry)
            {
                foreach (var a in indices.Gt((entry, -1)))
                {
                    if (a.entry != entry)
                        yield break;
                    yield return a;
                }
            }

            var entry = keys.GetEntry(v);
            if (entry >= 0)
            {
                indices.Remove((entry, index));

                if (!It(entry)
                    .GetEnumerator()
                    .MoveNext())
                {
                    keys.Remove(v);
                }
            }
        }
    }
}

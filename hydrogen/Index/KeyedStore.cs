using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.Index
{
    public class KeyedStore<K, V>
    {
        private BinarySearchTree<K> bst;
        private V[] values;

        public KeyedStore(Comparison<K> comparison, int capacity = 1024)
        {
            bst = new BinarySearchTree<K>(comparison, capacity);
            values = new V[capacity];
        }
        public void Insert(K key, V value)
        {
            bst.Insert(key);
            var entry = bst.GetEntry(key);
            values[entry] = value;
        }

        public bool ContainsKey(K key)
        {
            var entry = bst.GetEntry(key);
            return entry >= 0;
        }

        public V this[K key]
        {
            get
            {
                var entry = bst.GetEntry(key);
                if (entry < 0)
                    throw new KeyNotFoundException();
                return values[entry];
            }
        }

        public void RemoveKey(K key)
        {
            bst.Remove(key);
        }

        public IEnumerable<K> GetKeys()
        {
            return bst.It();
        }
    }
}

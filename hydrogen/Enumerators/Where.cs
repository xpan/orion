using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hydrogen.Enumerators
{
    public struct Where<T, K> : IEnumerator<K> where T : IEnumerator<K>
    {
        private K v;
        public T s;
        public Func<K, bool> predicate;
        
        public K Current => v;

        object IEnumerator.Current => throw new NotImplementedException();

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            while (s.MoveNext())
            {
                v = s.Current;
                if (predicate(v))
                    return true;
            }
            return false;
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}

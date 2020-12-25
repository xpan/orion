using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hydrogen.Enumerators
{
    public struct SelectMany<T, K, U, V, R> : IEnumerator<R> where T : IEnumerator<K> where U : IEnumerator<V>
    {        
        public T s;
        private U u;
        private R r;
        public int state;
        public Func<K, U> flatMap;
        public Func<K, V, R> select;
        public R Current => r;

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
                    if (!s.MoveNext()) goto default;
                    u = flatMap(s.Current);
                    goto case 1;
                case 1:
                    if (!u.MoveNext()) goto case 0;
                    r = select(s.Current, u.Current);
                    state = 1;
                    return true;
                default:
                    return false;
            }
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}

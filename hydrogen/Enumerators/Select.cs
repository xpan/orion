using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hydrogen.Enumerators
{
    public struct Select<T, K, R> : IEnumerator<R> where T : IEnumerator<K>
    {
        private T s;
        private K k;
        private R r;
        private int state;
        private Func<K, R> select;
        public Select(T s, Func<K, R> select)
            :this()
        {
            this.s = s;
            this.select = select;
        }
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
                    goto s1;
                case 1:
                    goto s2;
            }
        s1:
            if (!s.MoveNext())
            {
                goto s3;
            }
            k = s.Current;
            r = select(k);
            state = 1;
            return true;
        s2:
            goto s1;
        s3:
            return false;
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}

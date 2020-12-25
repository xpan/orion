using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hydrogen.Enumerators
{
    public struct Concat<T, U, R> : IEnumerator<R> where T : IEnumerator<R> where U : IEnumerator<R>
    {
        private T s1;
        private U s2;
        private R r;
        private int state;
        public Concat(T s1, U s2)
            :this()
        {
            this.s1 = s1;
            this.s2 = s2;
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
                case 2:
                    goto s4;
            }
        s1:
            if (!s1.MoveNext())
            {
                goto s3;
            }
            r = s1.Current;
            state = 1;
            return true;
        s2:
            goto s1;
        s3:
            if (!s2.MoveNext())
            {
                goto s5;
            }
            r = s2.Current;
            state = 2;
            return true;
        s4:
            goto s3;
        s5:
            return false;
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}

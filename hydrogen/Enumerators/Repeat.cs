using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hydrogen.Enumerators
{
    public struct Repeat<T> : IEnumerator<T>
    {
        public T v;
        public int count;
        private int state;
        private int i;
        public T Current => v;

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
            if (i >= count)
            {
                goto s3;
            }
            state = 1;
            return true;
        s2:
            i++;
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

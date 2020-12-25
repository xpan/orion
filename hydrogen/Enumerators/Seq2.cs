using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hydrogen.Enumerators
{
    public struct Seq2<T> : IEnumerator<T>
    {
        public T d1;
        public T d2;
        private T v;
        private int state;
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
                case 2:
                    goto s3;
            }
        s1:
            v = d1;
            state = 1;
            return true;
        s2:
            v = d2;
            state = 2;
            return true;
        s3:
            return false;
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}

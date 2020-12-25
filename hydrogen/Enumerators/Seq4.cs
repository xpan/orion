using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hydrogen.Enumerators
{
    public struct Seq4<T> : IEnumerator<T>
    {
        public T d1;
        public T d2;
        public T d3;
        public T d4;
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
                case 3:
                    goto s4;
                case 4:
                    goto s5;
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
            v = d3;
            state = 3;
            return true;
        s4:
            v = d4;
            state = 4;
            return true;
        s5:
            return false;
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}

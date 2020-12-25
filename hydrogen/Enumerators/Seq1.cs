using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hydrogen.Enumerators
{
    public struct Seq1<T> : IEnumerator<T>
    {
        public T d1;
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
                    v = d1;
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

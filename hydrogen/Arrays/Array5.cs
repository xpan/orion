using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hydrogen.Arrays
{
    public struct Array5<T>
    {
        public T d1;
        public T d2;
        public T d3;
        public T d4;
        public T d5;
        public int Length => 5;

        public T this[int index] => index switch
        {
            0 => d1,
            1 => d2,
            2 => d3,
            3 => d4,
            4 => d5,
            _ => throw new IndexOutOfRangeException()
        };

        public override string ToString()
        {
            return $"[{d1},{d2},{d3},{d4},{d5}]";
        }
    }
}

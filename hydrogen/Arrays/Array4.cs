using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.Arrays
{
    public struct Array4<T>
    {
        public T d1;
        public T d2;
        public T d3;
        public T d4;
        public int Length => 4;

        public T this[int index] => index switch
        {
            0 => d1,
            1 => d2,
            2 => d3,
            3 => d4,
            _ => throw new IndexOutOfRangeException()
        };

        public override string ToString()
        {
            return $"[{d1},{d2},{d3},{d4}]";
        }
    }
}

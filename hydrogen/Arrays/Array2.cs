using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.Arrays
{
    public struct Array2<T> : IValueTypedArray<T>
    {
        public T d1;
        public T d2;
        public int Length { get; }
        public Array2(int length) : this()
        {
            if (length > 2)
            {
                throw new ArgumentOutOfRangeException(nameof(length));
            }
            Length = length;
        }
        public T this[int index]
        {
            get 
            {
                switch (index)
                {
                    case 0:
                        return d1;
                    case 1:
                        return d2;
                    default:
                        throw new IndexOutOfRangeException();
                } 
            }
            set 
            {
                switch (index)
                {
                    case 0:
                        d1 = value;
                        break;
                    case 1:
                        d2 = value;
                        break;
                    default:
                        throw new IndexOutOfRangeException();
                }
            }
        }

        public override string ToString()
        {
            return Length switch
            {
                0 => "[]",
                1 => $"[{d1}]",
                2 => $"[{d1},{d2}]",
                _ => throw new IndexOutOfRangeException()
            };
        }
    }
}

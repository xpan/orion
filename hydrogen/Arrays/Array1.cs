using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.Arrays
{
    public struct Array1<T> : IValueTypedArray<T>
    {
        public T d1;
        public Array1(int length) : this()
        {
            Length = length;
        }
        public int Length { get; }

        public T this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0:
                        return d1;
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
                _ => throw new IndexOutOfRangeException()
            };
        }
    }
}

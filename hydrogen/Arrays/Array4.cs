using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.Arrays
{
    public struct Array4<T> : IValueTypedArray<T>
    {
        public T d1;
        public T d2;
        public T d3;
        public T d4;
        public int Length { get; }
        public Array4(int length) : this()
        {
            if (length > 4)
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
                    case 2:
                        return d3;
                    case 3:
                        return d4;
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
                    case 2:
                        d3 = value;
                        break;
                    case 3:
                        d4 = value;
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
                3 => $"[{d1},{d2},{d3}]",
                4 => $"[{d1},{d2},{d3},{d4}]",
                _ => throw new IndexOutOfRangeException()
            };
        }
    }
}

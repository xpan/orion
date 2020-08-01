using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.Arrays
{
    public struct Array8<T> : IValueTypedArray<T>
    {
        public T d1;
        public T d2;
        public T d3;
        public T d4;
        public T d5;
        public T d6;
        public T d7;
        public T d8;
        public int Length { get; }
        public Array8(int length) : this()
        {
            if (length > 8)
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
                    case 4:
                        return d5;
                    case 5:
                        return d6;
                    case 6:
                        return d7;
                    case 7:
                        return d8;
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
                    case 4:
                        d5 = value;
                        break;
                    case 5:
                        d6 = value;
                        break;
                    case 6:
                        d7 = value;
                        break;
                    case 7:
                        d8 = value;
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
                5 => $"[{d1},{d2},{d3},{d4},{d5}]",
                6 => $"[{d1},{d2},{d3},{d4},{d5},{d6}]",
                7 => $"[{d1},{d2},{d3},{d4},{d5},{d6},{d7}]",
                8 => $"[{d1},{d2},{d3},{d4},{d5},{d6},{d7},{d8}]",
                _ => throw new IndexOutOfRangeException()
            };
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Hydrogen.Arrays
{
    public struct Array8
    {
        private int d1;
        private int d2;
        private int d3;
        private int d4;
        private int d5;
        private int d6;
        private int d7;
        private int d8;
        public Array8(int length) : this()
        {
            Length = length;
        }
        public int Length { get; }
        public int this[int index]
        {
            get
            {
                if (index < 0 || index >= Length)
                {
                    throw new IndexOutOfRangeException();
                }

                return index switch
                {
                    0 => d1,
                    1 => d2,
                    2 => d3,
                    3 => d4,
                    4 => d5,
                    5 => d6,
                    6 => d7,
                    7 => d8,
                    _ => throw new IndexOutOfRangeException()
                };
            }
            set
            {
                if (index < 0 || index >= Length)
                {
                    throw new IndexOutOfRangeException();
                }                    

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
                }
            }
        }

        public override string ToString()
        {
            return Length switch
            {
                1 => $"({d1})",
                2 => $"({d1},{d2})",
                3 => $"({d1},{d2},{d3})",
                4 => $"({d1},{d2},{d3},{d4})",
                5 => $"({d1},{d2},{d3},{d4},{d5})",
                6 => $"({d1},{d2},{d3},{d4},{d5},{d6})",
                7 => $"({d1},{d2},{d3},{d4},{d5},{d6},{d7})",
                8 => $"({d1},{d2},{d3},{d4},{d5},{d6},{d7},{d8})",
                _ => throw new InvalidOperationException()
            };
        }

        public static Array8 Join(Array8 x, Array8 y)
        {
            var r = new Array8(x.Length + y.Length);
            return (x.Length, y.Length) switch
            {
                (1, 1) => new Array8(2) { [0] = x[0], [1] = y[0] },
                _ => throw new ApplicationException()
            };
        }
    }
}

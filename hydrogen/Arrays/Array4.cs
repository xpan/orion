using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.Arrays
{
    public struct Array4
    {
        private int d1;
        private int d2;
        private int d3;
        private int d4;
        public Array4(int length) : this()
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
                }
            }
        }
    }
}

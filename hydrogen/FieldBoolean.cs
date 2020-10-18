using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen
{
    public class FieldBoolean : IField
    {
        private bool[] buf;
        public FieldBoolean(int capacity)
        {
            buf = new bool[capacity];
        }
        public Variant this[int index] 
        {
            get { return Variant.Boolean(buf[index]); } 
            set
            {
                if (value.bitMask != 256)
                    throw new ArgumentException();
                buf[index] = value.d9;
            }
        }

        public FieldType Type => FieldType.Boolean;
    }
}

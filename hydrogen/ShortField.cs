using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen
{
    public class ShortField : IField
    {
        private short[] buf;
        public ShortField(int capacity)
        {
            buf = new short[capacity];
        }
        public Variant this[int index]
        {
            get { return Variant.Short(buf[index]); }
            set
            {
                if (value.bitMask != 2)
                    throw new ArgumentException();
                buf[index] = value.d2;
            }
        }

        public FieldType Type => FieldType.Short;
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen
{
    public class UShortField : IField
    {
        private ushort[] buf;
        public UShortField(int capacity)
        {
            buf = new ushort[capacity];
        }
        public Variant this[int index]
        {
            get { return Variant.UShort(buf[index]); }
            set
            {
                if (value.bitMask != 32)
                    throw new ArgumentException();
                buf[index] = value.d6;
            }
        }

        public FieldType Type => FieldType.UShort;
    }
}

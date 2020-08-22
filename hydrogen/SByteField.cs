using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen
{
    public class SByteField : IField
    {
        private sbyte[] buf;
        public SByteField(int capacity)
        {
            buf = new sbyte[capacity];
        }
        public Variant this[int index]
        {
            get { return Variant.SByte(buf[index]); }
            set
            {
                if (value.bitMask != 1)
                    throw new ArgumentException();
                buf[index] = value.d1;
            }
        }

        public FieldType Type => FieldType.SByte;
    }
}

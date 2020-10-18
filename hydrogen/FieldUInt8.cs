using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen
{
    public class FieldUInt8 : IField
    {
        private sbyte[] buf;
        public FieldUInt8(int capacity)
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

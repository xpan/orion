using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen
{
    public class FieldUInt32 : IField
    {
        private uint[] buf;
        public FieldUInt32(int capacity)
        {
            buf = new uint[capacity];
        }
        public Variant this[int index]
        {
            get { return Variant.UInt(buf[index]); }
            set
            {
                if (value.bitMask != 64)
                    throw new ArgumentException();
                buf[index] = value.d7;
            }
        }

        public FieldType Type => FieldType.UInt;
    }
}

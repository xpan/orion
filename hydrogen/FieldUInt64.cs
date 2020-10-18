using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen
{
    public class FieldUInt64 : IField
    {
        private ulong[] buf;
        public FieldUInt64(int capacity)
        {
            buf = new ulong[capacity];
        }
        public Variant this[int index]
        {
            get { return Variant.ULong(buf[index]); }
            set
            {
                if (value.bitMask != 128)
                    throw new ArgumentException();
                buf[index] = value.d8;
            }
        }

        public FieldType Type => FieldType.ULong;
    }
}

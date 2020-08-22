using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen
{
    public class LongField : IField
    {
        private long[] buf;
        public LongField(int capacity)
        {
            buf = new long[capacity];
        }
        public Variant this[int index]
        {
            get { return Variant.Long(buf[index]); }
            set
            {
                if (value.bitMask != 8)
                    throw new ArgumentException();
                buf[index] = value.d4;
            }
        }

        public FieldType Type => FieldType.Long;
    }
}

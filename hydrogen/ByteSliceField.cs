using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen
{
    public class ByteSliceField : IField
    {
        private byte[] buf;
        private ByteSliceHasher hasher;
        public ByteSliceField(int capacity)
        {
            buf = new byte[capacity];
            hasher = new ByteSliceHasher();
        }
        public Variant this[int index]
        {
            get { return Variant.ByteSlice(hasher.GetEntryValue(buf[index])); }
            set
            {
                if (value.bitMask != 2048)
                    throw new ArgumentException();
                buf[index] = (byte)hasher.GetEntry(value.d12);
            }
        }

        public FieldType Type => FieldType.ByteSlice;
    }
}

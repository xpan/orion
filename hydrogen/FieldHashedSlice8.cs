using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen
{
    public class FieldHashedSlice8 : IField
    {
        private byte[] buf;
        private Hydrogen.Index.HashSet<ByteSlice> eq;
        private byte[] bytes = new byte[1024];
        private int offset = 0;
        public FieldHashedSlice8(int capacity)
        {
            buf = new byte[capacity];
            eq = new Hydrogen.Index.HashSet<ByteSlice>(new ByteSliceEqualityComparer(), 256);
        }
        public Variant this[int index]
        {
            get { return Variant.ByteSlice(eq.GetEntryValue(buf[index])); }
            set
            {
                if (value.bitMask != 2048)
                    throw new ArgumentException();
                
                var slice = value.d12;
                var entry = eq.GetEntry(slice);
                if (entry < 0)
                {
                    Array.Copy(slice.Bytes, slice.Offset, bytes, offset, slice.Count);
                    var bs = new ByteSlice(bytes, offset, slice.Count);
                    eq.Insert(bs);
                    offset += slice.Count;
                    buf[index] = (byte)eq.GetEntry(bs);
                }
                buf[index] = (byte)eq.GetEntry(slice);
            }
        }

        public FieldType Type => FieldType.ByteSlice;
    }
}

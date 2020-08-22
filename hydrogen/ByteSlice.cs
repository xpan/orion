using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Hydrogen
{
    [StructLayout(LayoutKind.Explicit)]
    public struct ByteSlice
    {
        [FieldOffset(0)] private int offset;
        [FieldOffset(4)] private int count;
        [FieldOffset(8)] private byte[] bytes;
        
        public ByteSlice(byte[] bytes, int offset, int count)
        {
            this.bytes = bytes;
            this.offset = offset;
            this.count = count;
        }
        public byte[] Bytes => bytes;
        public int Offset => offset;
        public int Count => count;
        public byte this[int index] => bytes[offset + index];
        public override string ToString()
        {
            return Encoding.UTF8.GetString(bytes, offset, count);
        }
    }
}

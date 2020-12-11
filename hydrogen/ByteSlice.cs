using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hydrogen
{
    public struct ByteSlice
    {
        public ByteSlice(byte[] bytes, int offset, int count)
        {
            Bytes = bytes;
            Offset = offset;
            Count = count;
        }
        public byte[] Bytes { get; }
        public int Offset { get; }
        public int Count { get; }
        public byte this[int index] => Bytes[Offset + index];
    }
}

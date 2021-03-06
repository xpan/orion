﻿using Hydrogen.Index;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Hydrogen
{
    [StructLayout(LayoutKind.Explicit)]
    public struct ByteSlice : IComparable<ByteSlice>
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

        public ByteSlice(ArraySegment<byte> buf) 
            : this(buf.Array, buf.Offset, buf.Count)
        {
        }
        public byte[] Bytes => bytes;
        public int Offset => offset;
        public int Count => count;
        public byte this[int index] => bytes[offset + index];
        public override string ToString()
        {
            if (bytes == null)
                return "INVALID";
            else
                return Encoding.UTF8.GetString(bytes, offset, count);
        }

        public override bool Equals(object obj)
        {
            return ByteSliceEqualityComparer.Default.Equals(this, (ByteSlice)obj);
        }

        public override int GetHashCode()
        {
            return ByteSliceEqualityComparer.Default.GetHashCode(this);
        }

        public static bool operator == (ByteSlice x, ByteSlice y)
        {
            return ByteSliceEqualityComparer.Default.Equals(x, y);
        }

        public static bool operator !=(ByteSlice x, ByteSlice y)
        {
            return !ByteSliceEqualityComparer.Default.Equals(x, y);
        }

        public int CompareTo(ByteSlice other)
        {
            var l = Math.Min(Count, other.Count);
            for (var i = 0; i < l; i++)
            {
                var r = this[i].CompareTo(other[i]);
                if (r != 0)
                    return r;
            }
            return Count - other.Count;
        }
    }
}

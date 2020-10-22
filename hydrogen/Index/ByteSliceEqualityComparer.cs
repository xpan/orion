using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Text;

namespace Hydrogen.Index
{
    public class ByteSliceEqualityComparer : IEqualityComparer<ByteSlice>
    {
        public bool Equals([AllowNull] ByteSlice x, [AllowNull] ByteSlice y)
        {
            if (x.Count != y.Count)
            {
                return false;
            }

            var sx = new Span<byte>(x.Bytes, x.Offset, x.Count);
            var sy = new Span<byte>(y.Bytes, y.Offset, y.Count);

            var a = x.Count >> 3;
            var b = a << 3;
            var c = (x.Count & 7) >> 2;
            var d = b | (c << 2);
            var e = (x.Count & 3) >> 1;
            var f = d | (e << 1);
            var g = x.Count & 1;

            if (a > 0)
            {
                var sxx = MemoryMarshal.Cast<byte, ulong>(sx[0..b]);
                var syy = MemoryMarshal.Cast<byte, ulong>(sy[0..b]);

                for (var i = 0; i < a; i++)
                {
                    if (sxx[i] != syy[i])
                    {
                        return false;
                    }                        
                }
            }

            if (c > 0)
            {
                var sxx = MemoryMarshal.Cast<byte, uint>(sx[b..d]);
                var syy = MemoryMarshal.Cast<byte, uint>(sy[b..d]);

                if (sxx[0] != syy[0])
                {
                    return false;
                }                    
            }

            if (e > 0)
            {
                var sxx = MemoryMarshal.Cast<byte, ushort>(sx[d..f]);
                var syy = MemoryMarshal.Cast<byte, ushort>(sy[d..f]);

                if (sxx[0] != syy[0])
                {
                    return false;
                }
            }

            if (g > 0)
            {
                if (sx[^1] != sy[^1])
                {
                    return false;
                }
            }
            return true;
        }

        public int GetHashCode([DisallowNull] ByteSlice obj)
        {
            var h = 1;
            for (var i = 0; i < obj.Count; i++)
            {
                h = h * 31 + obj[i];
            }
            return h;
        }
    }
}

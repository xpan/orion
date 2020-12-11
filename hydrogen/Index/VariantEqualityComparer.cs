using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hydrogen.Index
{
    public class VariantEqualityComparer : IEqualityComparer<Variant>
    {
        public bool Equals(Variant x, Variant y)
        {
            return (x.bitMask, y.bitMask) switch
            {
                (1, 1) => x.d1 == y.d1,
                (2, 2) => x.d2 == y.d2,
                (4, 4) => x.d3 == y.d3,
                (8, 8) => x.d4 == y.d4,
                (16, 16) => x.d5 == y.d5,
                (32, 32) => x.d6 == y.d6,
                (64, 64) => x.d7 == y.d7,
                (128, 128) => x.d8 == y.d8,
                (256, 256) => x.d9 == y.d9,
                (512, 512) => x.d10 == y.d10,
                (1024, 1024) => x.d11 == y.d11,
                (2048, 2048) => x.d12 == y.d12,
                _ => false
            }; ;
        }

        public int GetHashCode([DisallowNull] Variant obj)
        {
            return obj.bitMask switch
            {
                1 => 31 + obj.d1.GetHashCode(),
                2 => 62 + obj.d2.GetHashCode(),
                4 => 124 + obj.d3.GetHashCode(),
                8 => 248 + obj.d4.GetHashCode(),
                16 => 496 + obj.d5.GetHashCode(),
                32 => 992 + obj.d6.GetHashCode(),
                64 => 1984 + obj.d7.GetHashCode(),
                128 => 3968 + obj.d8.GetHashCode(),
                256 => 7936 + obj.d9.GetHashCode(),
                512 => 15872 + obj.d10.GetHashCode(),
                1024 => 31744 + obj.d11.GetHashCode(),
                2048 => 63488 + obj.d12.GetHashCode(),
                _ => throw new NotSupportedException()
            };
        }
    }
}

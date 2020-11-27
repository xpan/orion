using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hydrogen.Index
{
    public class VariantComparer : IComparer<Variant>
    {
        public static readonly VariantComparer Default = new VariantComparer();
        public int Compare(Variant x, Variant y)
        {
            return (x.bitMask, y.bitMask) switch
            {
                (0, _) => -1,
                (_, 0) => 1,
                (1, 1) => x.d1.CompareTo(y.d1),
                (2, 2) => x.d2.CompareTo(y.d2),
                (4, 4) => x.d3.CompareTo(y.d3),
                (8, 8) => x.d4.CompareTo(y.d4),
                (16, 16) => x.d5.CompareTo(y.d5),
                (32, 32) => x.d6.CompareTo(y.d6),
                (64, 64) => x.d7.CompareTo(y.d7),
                (128, 128) => x.d8.CompareTo(y.d8),
                (256, 256) => x.d9.CompareTo(y.d9),
                (512, 512) => x.d10.CompareTo(y.d10),
                (1024, 1024)=> x.d11.CompareTo(y.d11),
                (2048, 2048) => x.d12.CompareTo(y.d12),
                (4096, 4096)=> x.d13.CompareTo(y.d13),
                _ => throw new ApplicationException()
            };
        }
    }
}

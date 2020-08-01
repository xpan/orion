using Hydrogen.Arrays;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Hydrogen.Index
{
    public class Array2Comparer<T> : IComparer<Array2<T>>
    {
        private Comparison<T> comparison;
        public Array2Comparer(Comparison<T> comparison)
        {
            this.comparison = comparison;
        }
        public int Compare([AllowNull] Array2<T> x, [AllowNull] Array2<T> y)
        {
            return (x.Length, y.Length) switch
            {
                (0, 0) => 0,
                (1, 1) => comparison(x.d1, y.d1),
                (2, 2) => comparison(x.d1, y.d1) switch
                {
                    var a when a != 0 => a,
                    _ => comparison(x.d2, y.d2)
                },
                _ => throw new InvalidOperationException()
            };
        }
    }
}

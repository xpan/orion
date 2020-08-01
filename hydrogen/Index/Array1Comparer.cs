using Hydrogen.Arrays;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Hydrogen.Index
{
    public class Array1Comparer<T> : IComparer<Array1<T>>
    {
        private Comparison<T> comparison;
        public Array1Comparer(Comparison<T> comparison)
        {
            this.comparison = comparison;
        }

        public int Compare([AllowNull] Array1<T> x, [AllowNull] Array1<T> y)
        {
            return (x.Length, y.Length) switch
            {
                (0, 0) => 0,
                (1, 1) => comparison(x.d1, y.d1),
                _ => throw new InvalidOperationException()
            };
        }
    }
}

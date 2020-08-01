using Hydrogen.Arrays;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Hydrogen.Index
{
    public class Array4Comparer<T> : IComparer<Array4<T>>
    {
        private Comparison<T> comparison;
        public Array4Comparer(Comparison<T> comparison)
        {
            this.comparison = comparison;
        }
        public int Compare([AllowNull] Array4<T> x, [AllowNull] Array4<T> y)
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
                (3, 3) => comparison(x.d1, y.d1) switch
                {
                    var a when a != 0 => a,
                    _ => comparison(x.d2, y.d2) switch
                    {
                        var a when a != 0 => a,
                        _ => comparison(x.d3, y.d3)
                    }
                },
                (4, 4) => comparison(x.d1, y.d1) switch
                {
                    var a when a != 0 => a,
                    _ => comparison(x.d2, y.d2) switch
                    {
                        var a when a != 0 => a,
                        _ => comparison(x.d3, y.d3) switch
                        {
                            var a when a != 0 => a,
                            _ => comparison(x.d4, y.d4)
                        }
                    }
                },
                _ => throw new ApplicationException()
            };
        }
    }
}

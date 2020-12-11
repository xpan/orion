using Hydrogen.Arrays;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hydrogen.Index
{
    public class Array3IntComparer : IComparer<Array3<int>>
    {
        public int Compare(Array3<int> x, Array3<int> y)
        {
            return (x.d1 - y.d1) switch
            {
                > 0 => 1,
                < 0 => -1,
                0 => (x.d2 - y.d2) switch
                {
                    > 0 => 1,
                    < 0 => -1,
                    0 => (x.d3 - y.d3),
                },
            };
        }
    }
}

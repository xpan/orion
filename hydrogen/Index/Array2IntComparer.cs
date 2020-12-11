using Hydrogen.Arrays;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hydrogen.Index
{
    public class Array2IntComparer : IComparer<Array2<int>>
    {
        public int Compare(Array2<int> x, Array2<int> y)
        {
            return (x.d1 - y.d1) switch
            {
                > 0 => 1,
                < 0 => -1,
                0 => x.d2 - y.d2,
            };
        }
    }
}

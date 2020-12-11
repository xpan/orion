using Hydrogen.Arrays;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hydrogen.Index
{
    public class Array4IntComparer : IComparer<Array4<int>>
    {
        public int Compare(Array4<int> x, Array4<int> y)
        {
            return (x.d1 - y.d1) switch
            {
                > 0 => 1,
                < 0 => -1,
                0 => (x.d2 - y.d2) switch
                {
                    > 0 => 1,
                    < 0 => -1,
                    0 => (x.d3 - y.d3) switch
                    {
                        > 0 => 1,
                        < 0 => -1,
                        0 => (x.d4 - y.d4)
                    },
                },
            };
        }
    }
}

using Hydrogen.Arrays;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hydrogen.Index
{
    public class Array1IntComparer : IComparer<Array1<int>>
    {
        public int Compare(Array1<int> x, Array1<int> y)
        {
            return x.d1 - y.d1;
        }
    }
}

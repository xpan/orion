using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hydrogen
{
    public delegate void Test<T>(ITable table, int index, ref T it);
}

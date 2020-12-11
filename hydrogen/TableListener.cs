using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hydrogen
{
    public delegate void TableListener(ITable table, Op op, int index, ulong fieldMask);
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen
{
    public delegate void TableStoreListener(TableStore tableStore, Op op, int index, IEnumerable<IField> fields);
}

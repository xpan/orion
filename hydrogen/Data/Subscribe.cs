using Hydrogen.Arrays;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.Data
{
    public delegate void Subscribe(Record record, ChangeType changeType, IEnumerable<object> fields);
}

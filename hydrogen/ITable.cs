using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hydrogen
{
    public interface ITable
    {
        int Dim { get; }
        FieldSpec[] Fields { get; }
        int GetOrdinal(ITable table);
        ITable GetOwnerTable(FieldSpec fieldSpec);
        IField GetField(FieldSpec fieldSpec);
    }
}

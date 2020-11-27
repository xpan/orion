using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen
{
    public interface ITable
    {
        public IField GetField(FieldSpec fieldSpec);
        public FieldSpec[] Fields { get; }
        public int Dimension { get; }
        public int GetOrdinal(ITable tableStore);
        public TableStore GetTable(IField field);
    }
}

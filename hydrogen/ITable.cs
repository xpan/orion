using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen
{
    public interface ITable
    {
        public IField GetField(FieldSpec fieldSpec);
        public FieldSpec[] FieldSpecs { get; }
        public int Dimension { get; }
        public int GetOrdinal(TableStore tableStore);
        public TableStore GetTableStore(IField field);
    }
}

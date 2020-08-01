using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hydrogen
{
    public class Join : ITable
    {
        private ITable left;
        private ITable right;
        public Join(ITable left, ITable right)
        {
            this.left = left;
            this.right = right;
            FieldSpecs = left.FieldSpecs.Concat(right.FieldSpecs).ToArray();
            Dimension = left.Dimension + right.Dimension;
        }

        public FieldSpec[] FieldSpecs { get; }

        public int Dimension { get; }

        public IField GetField(FieldSpec fieldSpec) => left.GetField(fieldSpec) ?? right.GetField(fieldSpec);

        public int GetOrdinal(TableStore tableStore)
        {
            var ordinal = left.GetOrdinal(tableStore);
            if (ordinal >= 0)
            {
                return ordinal;
            }
            ordinal = right.GetOrdinal(tableStore);
            if (ordinal >= 0)
            {
                return ordinal + left.Dimension;
            }
            return ordinal;
        }

        public TableStore GetTableStore(IField field) => left.GetTableStore(field) ?? right.GetTableStore(field);
    }
}

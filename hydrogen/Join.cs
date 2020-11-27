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
            Fields = left.Fields.Concat(right.Fields).ToArray();
            Dimension = left.Dimension + right.Dimension;
        }

        public FieldSpec[] Fields { get; }

        public int Dimension { get; }

        public IField GetField(FieldSpec fieldSpec) => left.GetField(fieldSpec) ?? right.GetField(fieldSpec);

        public int GetOrdinal(ITable tableStore)
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

        public TableStore GetTable(IField field) => left.GetTable(field) ?? right.GetTable(field);
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Hydrogen
{
    public struct Row
    {        
        public Row(TableStore store, int row, Op op)
        {
            RowNum = row;
            TableStore = store;

            BitMask = 0;
            Op = op;
        }

        public Variant this[FieldSpec index]
        {
            get { return TableStore.GetField(index)[RowNum]; }
            set
            {
                var field = TableStore.GetField(index);
                var currentValue = field[RowNum];
                if (currentValue != value)
                {
                    field[RowNum] = value;
                    var n = Array.IndexOf(TableStore.FieldSpecs, index);
                    BitMask |= (1 << n);
                }
            }
        }

        public int BitMask { get; private set; }
        public int RowNum { get; }
        public TableStore TableStore { get; }

        public Op Op { get; }
        
        public void BeginEdit()
        {
            BitMask = 0;
        }

        public void EndEdit()
        {
            if (Op == Op.Update)
                TableStore.Notify(RowNum, BitMask, Op);
            else
                throw new InvalidOperationException();
        }

        public override string ToString()
        {
            StringBuilder s = new();
            foreach (var fs in TableStore.FieldSpecs)
            {
                var f = TableStore.GetField(fs);
                s.Append($"<{fs.Name}>={f[RowNum]}|");
            }
            return s.ToString();
        }

    }
}

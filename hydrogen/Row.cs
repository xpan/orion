using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace Hydrogen
{
    public struct Row
    {
        private (int fieldId, Variant v)[] status;
        private int count;
        public Row(TableStore store, int row, Op op, (int fieldId, Variant v)[] s)
        {
            status = s;
            count = 0;
            RowNum = row;
            TableStore = store;
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
                    var n = Array.IndexOf(TableStore.Fields, index);
                    var v = Op switch
                    {
                        Op.Add => value,
                        Op.Update => currentValue,
                        _ => throw new ApplicationException()
                    };

                    status[count++] = (n, v);
                    field[RowNum] = value;                    
                }
            }
        }

        public int RowNum { get; }
        public TableStore TableStore { get; }

        public Op Op { get; }
        
        public void BeginEdit()
        {
            count = 0;
        }

        public void EndEdit()
        {
            var s = status;
            if (count > 0)
                TableStore.Notify(RowNum, Op, Enumerable.Range(0, count).Select(i => s[i]));
        }

        public override string ToString()
        {
            StringBuilder s = new();
            foreach (var fs in TableStore.Fields)
            {
                var f = TableStore.GetField(fs);
                s.Append($"<{fs.Name}>={f[RowNum]}|");
            }
            return s.ToString();
        }

    }
}

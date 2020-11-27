using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Hydrogen
{
    public struct Row
    {
        private List<(int fieldId, Variant v)> fields;
        public Row(TableStore store, int row, Op op)
        {
            fields = new List<(int fieldId, Variant v)>(32);
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

                    fields.Add((n, v));
                    field[RowNum] = value;                    
                }
            }
        }

        public int RowNum { get; }
        public TableStore TableStore { get; }

        public Op Op { get; }
        
        public void BeginEdit()
        {
            fields.Clear();
        }

        public void EndEdit()
        {
            if (fields.Count > 0)
                TableStore.Notify(RowNum, Op, fields);
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

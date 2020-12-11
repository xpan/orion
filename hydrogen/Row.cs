using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hydrogen
{
    public class Row
    {
        private ulong bitMask;
        private TableStore store;
        public Row(TableStore store)
        {
            this.store = store;
        }
        public Variant this[int fieldId]
        {
            get { return store.GetField(store.Fields[fieldId])[RowId]; }
            set
            {
                var field = store.GetField(store.Fields[fieldId]);
                var current = field[RowId];
                if (!current.Equals(value))
                {                    
                    field[RowId] = value;
                    bitMask |= (1ul << fieldId);
                }
            }
        }

        public void Initialize(int rowId, Op op)
        {
            RowId = rowId;
            Op = op;
            bitMask = 0;
        }
        public int RowId { get; private set; }
        public Op Op { get; private set; }

        public ulong BitMask => bitMask;
    }
}

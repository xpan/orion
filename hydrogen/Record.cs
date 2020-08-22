using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen
{
    public class Record
    {
        private ITable table;
        internal Record(ITable table, int index, int bitMask)
        {
            this.table = table;
            Index = index;
            BitMask = bitMask;
        }

        public int Index { get; }
        public int BitMask { get; private set; }
        public void SetValue(FieldSpec fieldSpec, in Variant value)
        {
            if (BitMask >= 0)
            {
                var i = Array.IndexOf(table.FieldSpecs, fieldSpec);
                BitMask |= (1 << i);
            }

            var field = table.GetField(fieldSpec);
            field[Index] = value;            
        }
    }
}

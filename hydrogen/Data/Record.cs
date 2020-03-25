using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.Data
{
    public struct Record
    {
        private int index;
        private TableStore store;
        public Record(int index, TableStore store)
        {
            this.index = index;
            this.store = store;
        }

        public void Deconstruct(out int index, out TableStore store)
        {
            index = this.index;
            store = this.store;
        }

        public T GetValue<T>(in FieldSpec<T> fieldSpec)
        {
            var field = store.GetField(fieldSpec);
            return field[index];
        }
        
    }
}

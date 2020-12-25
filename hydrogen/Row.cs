using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hydrogen
{
    public struct Row
    {
        internal ulong bitMask;
        internal ITable store;
        internal int index;
        internal Op op;
        public Variant this[int fieldId]
        {
            get { return store.GetField(store.Fields[fieldId])[index]; }
            set
            {
                var field = store.GetField(store.Fields[fieldId]);
                var current = field[index];
                if (!current.Equals(value))
                {                    
                    field[index] = value;
                    bitMask |= (1ul << fieldId);
                }
            }
        }
    }
}

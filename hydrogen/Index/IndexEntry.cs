using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.Index
{
    public struct IndexEntry<T>
    {
        public int factId;
        public T value;
        public int fact;
        public void Deconstruct(out int factId, out int fact, out T value)
        {
            factId = this.factId;
            value = this.value;
            fact = this.fact;
        }
    }
}

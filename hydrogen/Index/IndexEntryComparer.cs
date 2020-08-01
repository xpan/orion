using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Hydrogen.Index
{
    public class IndexEntryComparer<T> : IComparer<IndexEntry<T>>
    {
        private Comparison<T> comparison;
        public IndexEntryComparer(Comparison<T> comparison)
        {
            this.comparison = comparison;
        }

        public int Compare([AllowNull] IndexEntry<T> x, [AllowNull] IndexEntry<T> y)
        {
            if (x.factId < y.factId)
                return -1;
            else if (x.factId > y.factId)
                return 1;
            else if (x.fact < y.fact)
                return -1;
            else if (x.fact > y.fact)
                return 1;
            else
                return comparison(x.value, y.value);
        }
    }
}

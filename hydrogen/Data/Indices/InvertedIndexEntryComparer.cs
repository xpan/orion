using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Hydrogen.Data.Indices
{
    public struct InvertedIndexEntryComparer<T> : IComparer<InvertedIndexEntry<T>>
    {
        private IComparer<T> comparer;
        public InvertedIndexEntryComparer(IComparer<T> comparer)
        {
            this.comparer = comparer;
        }

        public int Compare([AllowNull] InvertedIndexEntry<T> x, [AllowNull] InvertedIndexEntry<T> y)
        {
            return comparer.Compare(x.key, y.key) switch
            {
                0 => x.posting.CompareTo(y.posting),
                var r => r
            };
        }
    }
}

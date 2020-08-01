using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Hydrogen.Index
{
    public struct GuarderComparer<T> : IComparer<Guarder<T>>
    {
        private IComparer<T> comparer;
        public GuarderComparer(IComparer<T> comparer)
        {
            this.comparer = comparer;
        }
        public int Compare([AllowNull] Guarder<T> x, [AllowNull] Guarder<T> y)
        {
            if (x.minimum && !y.minimum)
                return -1;
            else
                return comparer.Compare(x.value, y.value);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.Data
{
    public interface IIndexable<T>
    {
        ref T this[int index] { get; }
    }
}

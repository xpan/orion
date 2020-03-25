using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.Data.Indices
{
    public struct Guarder<T>
    {
        public bool minimum;
        public T value;
    }
}

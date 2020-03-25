using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.Data
{
    public class Field<T> : IIndexable<T>
    {
        private T[] buffer = new T[1024];
        public ref T this[int index] => ref buffer[index];
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen
{
    public class Field<T> : IField
    {
        private T[] buf = new T[1024];
        public Type Type => typeof(T);

        public Variant this[int index] => Variant.Create(buf[index]);

    }
}

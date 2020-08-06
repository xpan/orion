using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen
{
    internal class Field<T> : IField
    {
        private T[] buf = new T[1024];
        public Type Type => typeof(T);

        Variant IField.this[int index] => Variant.Create(buf[index]);

        public T this[int index]
        {
            get { return buf[index]; }
            set { buf[index] = value; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.Data
{
    public struct FieldSpec<T>
    {
        public FieldSpec(string name, IComparer<T> comparer) => (Type, Name, Comparer) = (typeof(T), name, comparer);
        public FieldSpec(string name) : this(name, Comparer<T>.Default) 
        { 
        }
        public string Name { get; }
        public Type Type { get; }
        public IComparer<T> Comparer { get; }
    }
}

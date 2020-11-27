using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.Index
{
    struct HashSetNode<T>
    {
        public bool occupied;
        public int p;
        public int n;
        public T val;
        public int hash;
    }
}

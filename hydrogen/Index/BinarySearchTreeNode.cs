using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.Index
{
    struct BinarySearchTreeNode<T>
    {
        public int parent;
        public int l;
        public int r;
        public int h;
        public int p;
        public int n;
        public T val;
    }
}

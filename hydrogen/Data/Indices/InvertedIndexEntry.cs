using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.Data.Indices
{
    public struct InvertedIndexEntry<T>
    {
        public T key;
        public int posting;
        public void Deconstruct(out T key, out int posting)
        {
            key = this.key;
            posting = this.posting;
        }
    }
}

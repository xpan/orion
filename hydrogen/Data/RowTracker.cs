using Hydrogen.Data.Indices;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.Data
{
    public class RowTracker
    {
        private BinaryTree<int> indices = new BinaryTree<int>(1024, Comparer<int>.Default);
        public bool Test(int index)
        {
            var (_, b) = indices.Search(index);
            return b == 0;
        }

        public IEnumerable<int> Iter() => indices.Iter();

        public void AddRow(int s)
        {
            indices.Insert(s);
        }
        public void Delete(int index)
        {
            indices.Remove(index);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen
{
    public class RowTracker
    {
        private HashSet<int> rows = new HashSet<int>();
        public bool Test(int index)
        {
            return rows.Contains(index);
        }

        public IEnumerable<int> GetIndices()
        {
            return rows;
        }

        public void Put(int index)
        {
            rows.Add(index);
        }
    }
}

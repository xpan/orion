using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.Data
{
    public interface IRowTracker
    {
        bool Test(int index);
        IEnumerable<int> GetRows();
    }
}

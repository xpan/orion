using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hydrogen
{
    public interface IIndex
    {
        Variant GetEntryValue(int entry);
        IEnumerable<int> GetEntries();
        int GetEntry(Variant v);
        IEnumerable<int> GetPostings(int entry);
        int Count { get; }
    }
}

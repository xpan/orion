using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hydrogen
{
    public interface IIndex
    {
        IEnumerable<Variant> Values { get; }
        bool Contains(Variant v);
        IEnumerable<int> GetPostings(Variant v);
        int Count { get; }
    }
}

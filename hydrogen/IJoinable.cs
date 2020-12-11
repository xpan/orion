using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hydrogen
{
    public interface IJoinable
    {
        ITable Table { get; }
        IView View();
    }
}

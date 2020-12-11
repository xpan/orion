using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hydrogen
{
    public interface IView
    {
        void Subscribe(Subscribe subscribe);
        void OnUpdate(ITable table, Op op, int index, ulong bitMask);
        Variant GetValue(int index, int fieldId);
    }
}

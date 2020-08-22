using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen
{
    public interface IField
    {
        FieldType Type { get; }
        Variant this[int index] { get;set; }
    }
}

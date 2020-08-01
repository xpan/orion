using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen
{
    public class FieldSpec
    {
        public FieldSpec(FieldType type, string name)
        {
            Type = type;
            Name = name;
        }
        public FieldType Type { get; }
        public string Name { get; }
    }
}

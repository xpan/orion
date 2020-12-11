using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hydrogen
{
    public class FieldSpec
    {
        public FieldSpec(FieldType type, string name)
        {
            Type = type;
            Name = name;
        }
        public string Name { get; }
        public FieldType Type { get; }

        public override string ToString()
        {
            return $"{Name}: {Type}";
        }
    }
}

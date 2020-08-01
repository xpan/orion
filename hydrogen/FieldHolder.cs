using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen
{
    public class FieldHolder
    {
        public FieldHolder(IField field, FieldSpec fieldSpec)
        {
            Field = field;
            FieldSpec = fieldSpec;
        }
        public IField Field { get; }
        public FieldSpec FieldSpec { get; }

        public void Deconstruct(out IField field, out FieldSpec fieldSpec)
        {
            field = Field;
            fieldSpec = FieldSpec;
        }
    }
}

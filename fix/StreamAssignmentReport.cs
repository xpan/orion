using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class StreamAssignmentReport
    {
        public static readonly FieldSpec[] Schema = new FieldSpec[]
        {
        };
        public static FieldSpec GetFieldSpec(int tag)
        {
            return tag switch
            {
                _ => throw new ArgumentException($"Invalid tag value {tag}")
            };
        }
    }
}

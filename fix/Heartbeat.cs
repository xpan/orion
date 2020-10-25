using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class Heartbeat
    {
        public static readonly FieldSpec TestReqID = new FieldSpec(FieldType.HashedSlice8, "TestReqID");
        public static readonly FieldSpec[] Schema = new FieldSpec[]
        {
            TestReqID,
        };
        public static FieldSpec GetFieldSpec(int tag)
        {
            return tag switch
            {
                112 => TestReqID,
                _ => throw new ArgumentException($"Invalid tag value {tag}")
            };
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class ResendRequest
    {
        public static readonly FieldSpec BeginSeqNo = new FieldSpec(FieldType.Int, "BeginSeqNo");
        public static readonly FieldSpec EndSeqNo = new FieldSpec(FieldType.Int, "EndSeqNo");
        public static readonly FieldSpec[] Schema = new FieldSpec[]
        {
            BeginSeqNo,
            EndSeqNo,
        };
        public static FieldSpec GetFieldSpec(int tag)
        {
            return tag switch
            {
                7 => BeginSeqNo,
                16 => EndSeqNo,
                _ => throw new ArgumentException($"Invalid tag value {tag}")
            };
        }
    }
}

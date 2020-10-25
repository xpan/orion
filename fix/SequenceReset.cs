using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class SequenceReset
    {
        public static readonly FieldSpec GapFillFlag = new FieldSpec(FieldType.Char, "GapFillFlag");
        public static readonly FieldSpec NewSeqNo = new FieldSpec(FieldType.Int, "NewSeqNo");
        public static readonly FieldSpec[] Schema = new FieldSpec[]
        {
            GapFillFlag,
            NewSeqNo,
        };
        public static FieldSpec GetFieldSpec(int tag)
        {
            return tag switch
            {
                123 => GapFillFlag,
                36 => NewSeqNo,
                _ => throw new ArgumentException($"Invalid tag value {tag}")
            };
        }
    }
}

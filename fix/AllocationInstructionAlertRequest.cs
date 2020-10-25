using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class AllocationInstructionAlertRequest
    {
        public static readonly FieldSpec TradeDate = new FieldSpec(FieldType.HashedSlice8, "TradeDate");
        public static readonly FieldSpec[] Schema = new FieldSpec[]
        {
            TradeDate,
        };
        public static FieldSpec GetFieldSpec(int tag)
        {
            return tag switch
            {
                75 => TradeDate,
                _ => throw new ArgumentException($"Invalid tag value {tag}")
            };
        }
    }
}

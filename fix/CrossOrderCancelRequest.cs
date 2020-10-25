using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class CrossOrderCancelRequest
    {
        public static readonly FieldSpec OrderID = new FieldSpec(FieldType.HashedSlice8, "OrderID");
        public static readonly FieldSpec CrossID = new FieldSpec(FieldType.HashedSlice8, "CrossID");
        public static readonly FieldSpec OrigCrossID = new FieldSpec(FieldType.HashedSlice8, "OrigCrossID");
        public static readonly FieldSpec HostCrossID = new FieldSpec(FieldType.HashedSlice8, "HostCrossID");
        public static readonly FieldSpec CrossType = new FieldSpec(FieldType.Int, "CrossType");
        public static readonly FieldSpec CrossPrioritization = new FieldSpec(FieldType.Int, "CrossPrioritization");
        public static readonly FieldSpec TransactTime = new FieldSpec(FieldType.HashedSlice8, "TransactTime");
        public static readonly FieldSpec[] Schema = new FieldSpec[]
        {
            OrderID,
            CrossID,
            OrigCrossID,
            HostCrossID,
            CrossType,
            CrossPrioritization,
            TransactTime,
        };
        public static FieldSpec GetFieldSpec(int tag)
        {
            return tag switch
            {
                37 => OrderID,
                548 => CrossID,
                551 => OrigCrossID,
                961 => HostCrossID,
                549 => CrossType,
                550 => CrossPrioritization,
                60 => TransactTime,
                _ => throw new ArgumentException($"Invalid tag value {tag}")
            };
        }
    }
}

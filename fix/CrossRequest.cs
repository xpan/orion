using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class CrossRequest
    {
        public static readonly FieldSpec OrderQty = new FieldSpec(FieldType.Float, "OrderQty");
        public static readonly FieldSpec ComplianceID = new FieldSpec(FieldType.HashedSlice8, "ComplianceID");
        public static readonly FieldSpec[] Schema = new FieldSpec[]
        {
            OrderQty,
            ComplianceID,
        };
        public static FieldSpec GetFieldSpec(int tag)
        {
            return tag switch
            {
                38 => OrderQty,
                376 => ComplianceID,
                _ => throw new ArgumentException($"Invalid tag value {tag}")
            };
        }
    }
}

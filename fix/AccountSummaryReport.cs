using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class AccountSummaryReport
    {
        public static readonly FieldSpec ClearingBusinessDate = new FieldSpec(FieldType.HashedSlice8, "ClearingBusinessDate");
        public static readonly FieldSpec TotalNetValue = new FieldSpec(FieldType.Float, "TotalNetValue");
        public static readonly FieldSpec MarginExcess = new FieldSpec(FieldType.Float, "MarginExcess");
        public static readonly FieldSpec SettlSessID = new FieldSpec(FieldType.HashedSlice8, "SettlSessID");
        public static readonly FieldSpec SettlSessSubID = new FieldSpec(FieldType.HashedSlice8, "SettlSessSubID");
        public static readonly FieldSpec TransactTime = new FieldSpec(FieldType.HashedSlice8, "TransactTime");
        public static readonly FieldSpec Currency = new FieldSpec(FieldType.HashedSlice8, "Currency");
        public static readonly FieldSpec[] Schema = new FieldSpec[]
        {
            ClearingBusinessDate,
            TotalNetValue,
            MarginExcess,
            SettlSessID,
            SettlSessSubID,
            TransactTime,
            Currency,
        };
        public static FieldSpec GetFieldSpec(int tag)
        {
            return tag switch
            {
                715 => ClearingBusinessDate,
                900 => TotalNetValue,
                899 => MarginExcess,
                716 => SettlSessID,
                717 => SettlSessSubID,
                60 => TransactTime,
                15 => Currency,
                _ => throw new ArgumentException($"Invalid tag value {tag}")
            };
        }
    }
}

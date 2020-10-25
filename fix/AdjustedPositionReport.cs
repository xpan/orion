using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class AdjustedPositionReport
    {
        public static readonly FieldSpec PosMaintRptID = new FieldSpec(FieldType.HashedSlice8, "PosMaintRptID");
        public static readonly FieldSpec PosReqType = new FieldSpec(FieldType.Int, "PosReqType");
        public static readonly FieldSpec ClearingBusinessDate = new FieldSpec(FieldType.HashedSlice8, "ClearingBusinessDate");
        public static readonly FieldSpec SettlSessID = new FieldSpec(FieldType.HashedSlice8, "SettlSessID");
        public static readonly FieldSpec PosMaintRptRefID = new FieldSpec(FieldType.HashedSlice8, "PosMaintRptRefID");
        public static readonly FieldSpec SettlPrice = new FieldSpec(FieldType.Float, "SettlPrice");
        public static readonly FieldSpec PriorSettlPrice = new FieldSpec(FieldType.Float, "PriorSettlPrice");
        public static readonly FieldSpec[] Schema = new FieldSpec[]
        {
            PosMaintRptID,
            PosReqType,
            ClearingBusinessDate,
            SettlSessID,
            PosMaintRptRefID,
            SettlPrice,
            PriorSettlPrice,
        };
        public static FieldSpec GetFieldSpec(int tag)
        {
            return tag switch
            {
                721 => PosMaintRptID,
                724 => PosReqType,
                715 => ClearingBusinessDate,
                716 => SettlSessID,
                714 => PosMaintRptRefID,
                730 => SettlPrice,
                734 => PriorSettlPrice,
                _ => throw new ArgumentException($"Invalid tag value {tag}")
            };
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class SecurityList
    {
        public static readonly FieldSpec SecurityReportID = new FieldSpec(FieldType.Int, "SecurityReportID");
        public static readonly FieldSpec ClearingBusinessDate = new FieldSpec(FieldType.HashedSlice8, "ClearingBusinessDate");
        public static readonly FieldSpec SecurityReqID = new FieldSpec(FieldType.HashedSlice8, "SecurityReqID");
        public static readonly FieldSpec SecurityResponseID = new FieldSpec(FieldType.HashedSlice8, "SecurityResponseID");
        public static readonly FieldSpec SecurityRequestResult = new FieldSpec(FieldType.Int, "SecurityRequestResult");
        public static readonly FieldSpec TotNoRelatedSym = new FieldSpec(FieldType.Int, "TotNoRelatedSym");
        public static readonly FieldSpec LastFragment = new FieldSpec(FieldType.Char, "LastFragment");
        public static readonly FieldSpec TransactTime = new FieldSpec(FieldType.HashedSlice8, "TransactTime");
        public static readonly FieldSpec[] Schema = new FieldSpec[]
        {
            SecurityReportID,
            ClearingBusinessDate,
            SecurityReqID,
            SecurityResponseID,
            SecurityRequestResult,
            TotNoRelatedSym,
            LastFragment,
            TransactTime,
        };
        public static FieldSpec GetFieldSpec(int tag)
        {
            return tag switch
            {
                964 => SecurityReportID,
                715 => ClearingBusinessDate,
                320 => SecurityReqID,
                322 => SecurityResponseID,
                560 => SecurityRequestResult,
                393 => TotNoRelatedSym,
                893 => LastFragment,
                60 => TransactTime,
                _ => throw new ArgumentException($"Invalid tag value {tag}")
            };
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class SecurityListUpdateReport
    {
        public static readonly FieldSpec SecurityReportID = new FieldSpec(FieldType.Int, "SecurityReportID");
        public static readonly FieldSpec SecurityReqID = new FieldSpec(FieldType.HashedSlice8, "SecurityReqID");
        public static readonly FieldSpec SecurityResponseID = new FieldSpec(FieldType.HashedSlice8, "SecurityResponseID");
        public static readonly FieldSpec SecurityRequestResult = new FieldSpec(FieldType.Int, "SecurityRequestResult");
        public static readonly FieldSpec TotNoRelatedSym = new FieldSpec(FieldType.Int, "TotNoRelatedSym");
        public static readonly FieldSpec ClearingBusinessDate = new FieldSpec(FieldType.HashedSlice8, "ClearingBusinessDate");
        public static readonly FieldSpec SecurityUpdateAction = new FieldSpec(FieldType.Char, "SecurityUpdateAction");
        public static readonly FieldSpec CorporateAction = new FieldSpec(FieldType.HashedSlice8, "CorporateAction");
        public static readonly FieldSpec LastFragment = new FieldSpec(FieldType.Char, "LastFragment");
        public static readonly FieldSpec TransactTime = new FieldSpec(FieldType.HashedSlice8, "TransactTime");
        public static readonly FieldSpec[] Schema = new FieldSpec[]
        {
            SecurityReportID,
            SecurityReqID,
            SecurityResponseID,
            SecurityRequestResult,
            TotNoRelatedSym,
            ClearingBusinessDate,
            SecurityUpdateAction,
            CorporateAction,
            LastFragment,
            TransactTime,
        };
        public static FieldSpec GetFieldSpec(int tag)
        {
            return tag switch
            {
                964 => SecurityReportID,
                320 => SecurityReqID,
                322 => SecurityResponseID,
                560 => SecurityRequestResult,
                393 => TotNoRelatedSym,
                715 => ClearingBusinessDate,
                980 => SecurityUpdateAction,
                292 => CorporateAction,
                893 => LastFragment,
                60 => TransactTime,
                _ => throw new ArgumentException($"Invalid tag value {tag}")
            };
        }
    }
}

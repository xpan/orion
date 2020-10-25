using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class SecurityDefinitionUpdateReport
    {
        public static readonly FieldSpec SecurityReportID = new FieldSpec(FieldType.Int, "SecurityReportID");
        public static readonly FieldSpec SecurityReqID = new FieldSpec(FieldType.HashedSlice8, "SecurityReqID");
        public static readonly FieldSpec SecurityResponseID = new FieldSpec(FieldType.HashedSlice8, "SecurityResponseID");
        public static readonly FieldSpec SecurityResponseType = new FieldSpec(FieldType.Int, "SecurityResponseType");
        public static readonly FieldSpec ClearingBusinessDate = new FieldSpec(FieldType.HashedSlice8, "ClearingBusinessDate");
        public static readonly FieldSpec SecurityUpdateAction = new FieldSpec(FieldType.Char, "SecurityUpdateAction");
        public static readonly FieldSpec CorporateAction = new FieldSpec(FieldType.HashedSlice8, "CorporateAction");
        public static readonly FieldSpec Currency = new FieldSpec(FieldType.HashedSlice8, "Currency");
        public static readonly FieldSpec Text = new FieldSpec(FieldType.HashedSlice8, "Text");
        public static readonly FieldSpec EncodedTextLen = new FieldSpec(FieldType.Int, "EncodedTextLen");
        public static readonly FieldSpec EncodedText = new FieldSpec(FieldType.HashedSlice8, "EncodedText");
        public static readonly FieldSpec TransactTime = new FieldSpec(FieldType.HashedSlice8, "TransactTime");
        public static readonly FieldSpec LastUpdateTime = new FieldSpec(FieldType.HashedSlice8, "LastUpdateTime");
        public static readonly FieldSpec PriorSettlPrice = new FieldSpec(FieldType.Float, "PriorSettlPrice");
        public static readonly FieldSpec[] Schema = new FieldSpec[]
        {
            SecurityReportID,
            SecurityReqID,
            SecurityResponseID,
            SecurityResponseType,
            ClearingBusinessDate,
            SecurityUpdateAction,
            CorporateAction,
            Currency,
            Text,
            EncodedTextLen,
            EncodedText,
            TransactTime,
            LastUpdateTime,
            PriorSettlPrice,
        };
        public static FieldSpec GetFieldSpec(int tag)
        {
            return tag switch
            {
                964 => SecurityReportID,
                320 => SecurityReqID,
                322 => SecurityResponseID,
                323 => SecurityResponseType,
                715 => ClearingBusinessDate,
                980 => SecurityUpdateAction,
                292 => CorporateAction,
                15 => Currency,
                58 => Text,
                354 => EncodedTextLen,
                355 => EncodedText,
                60 => TransactTime,
                779 => LastUpdateTime,
                734 => PriorSettlPrice,
                _ => throw new ArgumentException($"Invalid tag value {tag}")
            };
        }
    }
}

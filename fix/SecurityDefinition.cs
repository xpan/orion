using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class SecurityDefinition
    {
        public static readonly FieldSpec SecurityReportID = new FieldSpec(FieldType.Int, "SecurityReportID");
        public static readonly FieldSpec ClearingBusinessDate = new FieldSpec(FieldType.HashedSlice8, "ClearingBusinessDate");
        public static readonly FieldSpec SecurityReqID = new FieldSpec(FieldType.HashedSlice8, "SecurityReqID");
        public static readonly FieldSpec SecurityResponseID = new FieldSpec(FieldType.HashedSlice8, "SecurityResponseID");
        public static readonly FieldSpec SecurityResponseType = new FieldSpec(FieldType.Int, "SecurityResponseType");
        public static readonly FieldSpec CorporateAction = new FieldSpec(FieldType.HashedSlice8, "CorporateAction");
        public static readonly FieldSpec Currency = new FieldSpec(FieldType.HashedSlice8, "Currency");
        public static readonly FieldSpec Text = new FieldSpec(FieldType.HashedSlice8, "Text");
        public static readonly FieldSpec EncodedTextLen = new FieldSpec(FieldType.Int, "EncodedTextLen");
        public static readonly FieldSpec EncodedText = new FieldSpec(FieldType.HashedSlice8, "EncodedText");
        public static readonly FieldSpec TransactTime = new FieldSpec(FieldType.HashedSlice8, "TransactTime");
        public static readonly FieldSpec SecurityRequestResult = new FieldSpec(FieldType.Int, "SecurityRequestResult");
        public static readonly FieldSpec LastUpdateTime = new FieldSpec(FieldType.HashedSlice8, "LastUpdateTime");
        public static readonly FieldSpec PriorSettlPrice = new FieldSpec(FieldType.Float, "PriorSettlPrice");
        public static readonly FieldSpec[] Schema = new FieldSpec[]
        {
            SecurityReportID,
            ClearingBusinessDate,
            SecurityReqID,
            SecurityResponseID,
            SecurityResponseType,
            CorporateAction,
            Currency,
            Text,
            EncodedTextLen,
            EncodedText,
            TransactTime,
            SecurityRequestResult,
            LastUpdateTime,
            PriorSettlPrice,
        };
        public static FieldSpec GetFieldSpec(int tag)
        {
            return tag switch
            {
                964 => SecurityReportID,
                715 => ClearingBusinessDate,
                320 => SecurityReqID,
                322 => SecurityResponseID,
                323 => SecurityResponseType,
                292 => CorporateAction,
                15 => Currency,
                58 => Text,
                354 => EncodedTextLen,
                355 => EncodedText,
                60 => TransactTime,
                560 => SecurityRequestResult,
                779 => LastUpdateTime,
                734 => PriorSettlPrice,
                _ => throw new ArgumentException($"Invalid tag value {tag}")
            };
        }
    }
}

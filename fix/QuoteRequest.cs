using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class QuoteRequest
    {
        public static readonly FieldSpec QuoteReqID = new FieldSpec(FieldType.HashedSlice8, "QuoteReqID");
        public static readonly FieldSpec RFQReqID = new FieldSpec(FieldType.HashedSlice8, "RFQReqID");
        public static readonly FieldSpec ClOrdID = new FieldSpec(FieldType.HashedSlice8, "ClOrdID");
        public static readonly FieldSpec OrderCapacity = new FieldSpec(FieldType.Char, "OrderCapacity");
        public static readonly FieldSpec PreTradeAnonymity = new FieldSpec(FieldType.Char, "PreTradeAnonymity");
        public static readonly FieldSpec Text = new FieldSpec(FieldType.HashedSlice8, "Text");
        public static readonly FieldSpec EncodedTextLen = new FieldSpec(FieldType.Int, "EncodedTextLen");
        public static readonly FieldSpec EncodedText = new FieldSpec(FieldType.HashedSlice8, "EncodedText");
        public static readonly FieldSpec BookingType = new FieldSpec(FieldType.Int, "BookingType");
        public static readonly FieldSpec OrderRestrictions = new FieldSpec(FieldType.HashedSlice8, "OrderRestrictions");
        public static readonly FieldSpec ComplianceID = new FieldSpec(FieldType.HashedSlice8, "ComplianceID");
        public static readonly FieldSpec[] Schema = new FieldSpec[]
        {
            QuoteReqID,
            RFQReqID,
            ClOrdID,
            OrderCapacity,
            PreTradeAnonymity,
            Text,
            EncodedTextLen,
            EncodedText,
            BookingType,
            OrderRestrictions,
            ComplianceID,
        };
        public static FieldSpec GetFieldSpec(int tag)
        {
            return tag switch
            {
                131 => QuoteReqID,
                644 => RFQReqID,
                11 => ClOrdID,
                528 => OrderCapacity,
                1091 => PreTradeAnonymity,
                58 => Text,
                354 => EncodedTextLen,
                355 => EncodedText,
                775 => BookingType,
                529 => OrderRestrictions,
                376 => ComplianceID,
                _ => throw new ArgumentException($"Invalid tag value {tag}")
            };
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class QuoteRequestReject
    {
        public static readonly FieldSpec QuoteReqID = new FieldSpec(FieldType.HashedSlice8, "QuoteReqID");
        public static readonly FieldSpec RFQReqID = new FieldSpec(FieldType.HashedSlice8, "RFQReqID");
        public static readonly FieldSpec QuoteRequestRejectReason = new FieldSpec(FieldType.Int, "QuoteRequestRejectReason");
        public static readonly FieldSpec PreTradeAnonymity = new FieldSpec(FieldType.Char, "PreTradeAnonymity");
        public static readonly FieldSpec Text = new FieldSpec(FieldType.HashedSlice8, "Text");
        public static readonly FieldSpec EncodedTextLen = new FieldSpec(FieldType.Int, "EncodedTextLen");
        public static readonly FieldSpec EncodedText = new FieldSpec(FieldType.HashedSlice8, "EncodedText");
        public static readonly FieldSpec[] Schema = new FieldSpec[]
        {
            QuoteReqID,
            RFQReqID,
            QuoteRequestRejectReason,
            PreTradeAnonymity,
            Text,
            EncodedTextLen,
            EncodedText,
        };
        public static FieldSpec GetFieldSpec(int tag)
        {
            return tag switch
            {
                131 => QuoteReqID,
                644 => RFQReqID,
                658 => QuoteRequestRejectReason,
                1091 => PreTradeAnonymity,
                58 => Text,
                354 => EncodedTextLen,
                355 => EncodedText,
                _ => throw new ArgumentException($"Invalid tag value {tag}")
            };
        }
    }
}

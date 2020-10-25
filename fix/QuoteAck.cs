using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class QuoteAck
    {
        public static readonly FieldSpec QuoteID = new FieldSpec(FieldType.HashedSlice8, "QuoteID");
        public static readonly FieldSpec QuoteReqID = new FieldSpec(FieldType.HashedSlice8, "QuoteReqID");
        public static readonly FieldSpec QuoteType = new FieldSpec(FieldType.Int, "QuoteType");
        public static readonly FieldSpec QuoteCancelType = new FieldSpec(FieldType.Int, "QuoteCancelType");
        public static readonly FieldSpec QuoteRejectReason = new FieldSpec(FieldType.Int, "QuoteRejectReason");
        public static readonly FieldSpec Text = new FieldSpec(FieldType.HashedSlice8, "Text");
        public static readonly FieldSpec EncodedTextLen = new FieldSpec(FieldType.Int, "EncodedTextLen");
        public static readonly FieldSpec EncodedText = new FieldSpec(FieldType.HashedSlice8, "EncodedText");
        public static readonly FieldSpec[] Schema = new FieldSpec[]
        {
            QuoteID,
            QuoteReqID,
            QuoteType,
            QuoteCancelType,
            QuoteRejectReason,
            Text,
            EncodedTextLen,
            EncodedText,
        };
        public static FieldSpec GetFieldSpec(int tag)
        {
            return tag switch
            {
                117 => QuoteID,
                131 => QuoteReqID,
                537 => QuoteType,
                298 => QuoteCancelType,
                300 => QuoteRejectReason,
                58 => Text,
                354 => EncodedTextLen,
                355 => EncodedText,
                _ => throw new ArgumentException($"Invalid tag value {tag}")
            };
        }
    }
}

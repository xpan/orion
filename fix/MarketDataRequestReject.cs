using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class MarketDataRequestReject
    {
        public static readonly FieldSpec MDReqID = new FieldSpec(FieldType.HashedSlice8, "MDReqID");
        public static readonly FieldSpec MDReqRejReason = new FieldSpec(FieldType.Char, "MDReqRejReason");
        public static readonly FieldSpec Text = new FieldSpec(FieldType.HashedSlice8, "Text");
        public static readonly FieldSpec EncodedTextLen = new FieldSpec(FieldType.Int, "EncodedTextLen");
        public static readonly FieldSpec EncodedText = new FieldSpec(FieldType.HashedSlice8, "EncodedText");
        public static readonly FieldSpec[] Schema = new FieldSpec[]
        {
            MDReqID,
            MDReqRejReason,
            Text,
            EncodedTextLen,
            EncodedText,
        };
        public static FieldSpec GetFieldSpec(int tag)
        {
            return tag switch
            {
                262 => MDReqID,
                281 => MDReqRejReason,
                58 => Text,
                354 => EncodedTextLen,
                355 => EncodedText,
                _ => throw new ArgumentException($"Invalid tag value {tag}")
            };
        }
    }
}

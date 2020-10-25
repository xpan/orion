using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class SecurityTypeRequest
    {
        public static readonly FieldSpec SecurityReqID = new FieldSpec(FieldType.HashedSlice8, "SecurityReqID");
        public static readonly FieldSpec Text = new FieldSpec(FieldType.HashedSlice8, "Text");
        public static readonly FieldSpec EncodedTextLen = new FieldSpec(FieldType.Int, "EncodedTextLen");
        public static readonly FieldSpec EncodedText = new FieldSpec(FieldType.HashedSlice8, "EncodedText");
        public static readonly FieldSpec TradingSessionID = new FieldSpec(FieldType.HashedSlice8, "TradingSessionID");
        public static readonly FieldSpec TradingSessionSubID = new FieldSpec(FieldType.HashedSlice8, "TradingSessionSubID");
        public static readonly FieldSpec Product = new FieldSpec(FieldType.Int, "Product");
        public static readonly FieldSpec SecurityType = new FieldSpec(FieldType.HashedSlice8, "SecurityType");
        public static readonly FieldSpec SecuritySubType = new FieldSpec(FieldType.HashedSlice8, "SecuritySubType");
        public static readonly FieldSpec[] Schema = new FieldSpec[]
        {
            SecurityReqID,
            Text,
            EncodedTextLen,
            EncodedText,
            TradingSessionID,
            TradingSessionSubID,
            Product,
            SecurityType,
            SecuritySubType,
        };
        public static FieldSpec GetFieldSpec(int tag)
        {
            return tag switch
            {
                320 => SecurityReqID,
                58 => Text,
                354 => EncodedTextLen,
                355 => EncodedText,
                336 => TradingSessionID,
                625 => TradingSessionSubID,
                460 => Product,
                167 => SecurityType,
                762 => SecuritySubType,
                _ => throw new ArgumentException($"Invalid tag value {tag}")
            };
        }
    }
}

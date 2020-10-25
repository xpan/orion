using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class PartyRiskLimitCheckRequest
    {
        public static readonly FieldSpec RefOrderID = new FieldSpec(FieldType.HashedSlice8, "RefOrderID");
        public static readonly FieldSpec RefOrderIDSource = new FieldSpec(FieldType.Char, "RefOrderIDSource");
        public static readonly FieldSpec Currency = new FieldSpec(FieldType.HashedSlice8, "Currency");
        public static readonly FieldSpec Side = new FieldSpec(FieldType.Char, "Side");
        public static readonly FieldSpec TransactTime = new FieldSpec(FieldType.HashedSlice8, "TransactTime");
        public static readonly FieldSpec Text = new FieldSpec(FieldType.HashedSlice8, "Text");
        public static readonly FieldSpec EncodedTextLen = new FieldSpec(FieldType.Int, "EncodedTextLen");
        public static readonly FieldSpec EncodedText = new FieldSpec(FieldType.HashedSlice8, "EncodedText");
        public static readonly FieldSpec[] Schema = new FieldSpec[]
        {
            RefOrderID,
            RefOrderIDSource,
            Currency,
            Side,
            TransactTime,
            Text,
            EncodedTextLen,
            EncodedText,
        };
        public static FieldSpec GetFieldSpec(int tag)
        {
            return tag switch
            {
                1080 => RefOrderID,
                1081 => RefOrderIDSource,
                15 => Currency,
                54 => Side,
                60 => TransactTime,
                58 => Text,
                354 => EncodedTextLen,
                355 => EncodedText,
                _ => throw new ArgumentException($"Invalid tag value {tag}")
            };
        }
    }
}

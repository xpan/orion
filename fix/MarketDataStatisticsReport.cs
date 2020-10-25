using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class MarketDataStatisticsReport
    {
        public static readonly FieldSpec UnsolicitedIndicator = new FieldSpec(FieldType.Char, "UnsolicitedIndicator");
        public static readonly FieldSpec TradeDate = new FieldSpec(FieldType.HashedSlice8, "TradeDate");
        public static readonly FieldSpec TransactTime = new FieldSpec(FieldType.HashedSlice8, "TransactTime");
        public static readonly FieldSpec Text = new FieldSpec(FieldType.HashedSlice8, "Text");
        public static readonly FieldSpec EncodedTextLen = new FieldSpec(FieldType.Int, "EncodedTextLen");
        public static readonly FieldSpec EncodedText = new FieldSpec(FieldType.HashedSlice8, "EncodedText");
        public static readonly FieldSpec CustOrderCapacity = new FieldSpec(FieldType.Int, "CustOrderCapacity");
        public static readonly FieldSpec Currency = new FieldSpec(FieldType.HashedSlice8, "Currency");
        public static readonly FieldSpec[] Schema = new FieldSpec[]
        {
            UnsolicitedIndicator,
            TradeDate,
            TransactTime,
            Text,
            EncodedTextLen,
            EncodedText,
            CustOrderCapacity,
            Currency,
        };
        public static FieldSpec GetFieldSpec(int tag)
        {
            return tag switch
            {
                325 => UnsolicitedIndicator,
                75 => TradeDate,
                60 => TransactTime,
                58 => Text,
                354 => EncodedTextLen,
                355 => EncodedText,
                582 => CustOrderCapacity,
                15 => Currency,
                _ => throw new ArgumentException($"Invalid tag value {tag}")
            };
        }
    }
}

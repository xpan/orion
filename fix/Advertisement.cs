using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class Advertisement
    {
        public static readonly FieldSpec AdvId = new FieldSpec(FieldType.HashedSlice8, "AdvId");
        public static readonly FieldSpec AdvTransType = new FieldSpec(FieldType.HashedSlice8, "AdvTransType");
        public static readonly FieldSpec AdvRefID = new FieldSpec(FieldType.HashedSlice8, "AdvRefID");
        public static readonly FieldSpec AdvSide = new FieldSpec(FieldType.Char, "AdvSide");
        public static readonly FieldSpec Quantity = new FieldSpec(FieldType.Float, "Quantity");
        public static readonly FieldSpec QtyType = new FieldSpec(FieldType.Int, "QtyType");
        public static readonly FieldSpec Price = new FieldSpec(FieldType.Float, "Price");
        public static readonly FieldSpec Currency = new FieldSpec(FieldType.HashedSlice8, "Currency");
        public static readonly FieldSpec TradeDate = new FieldSpec(FieldType.HashedSlice8, "TradeDate");
        public static readonly FieldSpec TransactTime = new FieldSpec(FieldType.HashedSlice8, "TransactTime");
        public static readonly FieldSpec Text = new FieldSpec(FieldType.HashedSlice8, "Text");
        public static readonly FieldSpec EncodedTextLen = new FieldSpec(FieldType.Int, "EncodedTextLen");
        public static readonly FieldSpec EncodedText = new FieldSpec(FieldType.HashedSlice8, "EncodedText");
        public static readonly FieldSpec URLLink = new FieldSpec(FieldType.HashedSlice8, "URLLink");
        public static readonly FieldSpec LastMkt = new FieldSpec(FieldType.HashedSlice8, "LastMkt");
        public static readonly FieldSpec TradingSessionID = new FieldSpec(FieldType.HashedSlice8, "TradingSessionID");
        public static readonly FieldSpec TradingSessionSubID = new FieldSpec(FieldType.HashedSlice8, "TradingSessionSubID");
        public static readonly FieldSpec[] Schema = new FieldSpec[]
        {
            AdvId,
            AdvTransType,
            AdvRefID,
            AdvSide,
            Quantity,
            QtyType,
            Price,
            Currency,
            TradeDate,
            TransactTime,
            Text,
            EncodedTextLen,
            EncodedText,
            URLLink,
            LastMkt,
            TradingSessionID,
            TradingSessionSubID,
        };
        public static FieldSpec GetFieldSpec(int tag)
        {
            return tag switch
            {
                2 => AdvId,
                5 => AdvTransType,
                3 => AdvRefID,
                4 => AdvSide,
                53 => Quantity,
                854 => QtyType,
                44 => Price,
                15 => Currency,
                75 => TradeDate,
                60 => TransactTime,
                58 => Text,
                354 => EncodedTextLen,
                355 => EncodedText,
                149 => URLLink,
                30 => LastMkt,
                336 => TradingSessionID,
                625 => TradingSessionSubID,
                _ => throw new ArgumentException($"Invalid tag value {tag}")
            };
        }
    }
}

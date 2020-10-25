using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class OrderMassActionReport
    {
        public static readonly FieldSpec ClOrdID = new FieldSpec(FieldType.HashedSlice8, "ClOrdID");
        public static readonly FieldSpec SecondaryClOrdID = new FieldSpec(FieldType.HashedSlice8, "SecondaryClOrdID");
        public static readonly FieldSpec TotalAffectedOrders = new FieldSpec(FieldType.Int, "TotalAffectedOrders");
        public static readonly FieldSpec TradingSessionID = new FieldSpec(FieldType.HashedSlice8, "TradingSessionID");
        public static readonly FieldSpec TradingSessionSubID = new FieldSpec(FieldType.HashedSlice8, "TradingSessionSubID");
        public static readonly FieldSpec Side = new FieldSpec(FieldType.Char, "Side");
        public static readonly FieldSpec TransactTime = new FieldSpec(FieldType.HashedSlice8, "TransactTime");
        public static readonly FieldSpec Text = new FieldSpec(FieldType.HashedSlice8, "Text");
        public static readonly FieldSpec EncodedTextLen = new FieldSpec(FieldType.Int, "EncodedTextLen");
        public static readonly FieldSpec EncodedText = new FieldSpec(FieldType.HashedSlice8, "EncodedText");
        public static readonly FieldSpec ComplianceID = new FieldSpec(FieldType.HashedSlice8, "ComplianceID");
        public static readonly FieldSpec LastFragment = new FieldSpec(FieldType.Char, "LastFragment");
        public static readonly FieldSpec Price = new FieldSpec(FieldType.Float, "Price");
        public static readonly FieldSpec[] Schema = new FieldSpec[]
        {
            ClOrdID,
            SecondaryClOrdID,
            TotalAffectedOrders,
            TradingSessionID,
            TradingSessionSubID,
            Side,
            TransactTime,
            Text,
            EncodedTextLen,
            EncodedText,
            ComplianceID,
            LastFragment,
            Price,
        };
        public static FieldSpec GetFieldSpec(int tag)
        {
            return tag switch
            {
                11 => ClOrdID,
                526 => SecondaryClOrdID,
                533 => TotalAffectedOrders,
                336 => TradingSessionID,
                625 => TradingSessionSubID,
                54 => Side,
                60 => TransactTime,
                58 => Text,
                354 => EncodedTextLen,
                355 => EncodedText,
                376 => ComplianceID,
                893 => LastFragment,
                44 => Price,
                _ => throw new ArgumentException($"Invalid tag value {tag}")
            };
        }
    }
}

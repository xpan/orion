using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class OrderMassCancelReport
    {
        public static readonly FieldSpec ClOrdID = new FieldSpec(FieldType.HashedSlice8, "ClOrdID");
        public static readonly FieldSpec SecondaryClOrdID = new FieldSpec(FieldType.HashedSlice8, "SecondaryClOrdID");
        public static readonly FieldSpec OrderID = new FieldSpec(FieldType.HashedSlice8, "OrderID");
        public static readonly FieldSpec SecondaryOrderID = new FieldSpec(FieldType.HashedSlice8, "SecondaryOrderID");
        public static readonly FieldSpec MassCancelRequestType = new FieldSpec(FieldType.Char, "MassCancelRequestType");
        public static readonly FieldSpec MassCancelResponse = new FieldSpec(FieldType.Char, "MassCancelResponse");
        public static readonly FieldSpec MassCancelRejectReason = new FieldSpec(FieldType.Int, "MassCancelRejectReason");
        public static readonly FieldSpec TotalAffectedOrders = new FieldSpec(FieldType.Int, "TotalAffectedOrders");
        public static readonly FieldSpec TradingSessionID = new FieldSpec(FieldType.HashedSlice8, "TradingSessionID");
        public static readonly FieldSpec TradingSessionSubID = new FieldSpec(FieldType.HashedSlice8, "TradingSessionSubID");
        public static readonly FieldSpec Side = new FieldSpec(FieldType.Char, "Side");
        public static readonly FieldSpec TransactTime = new FieldSpec(FieldType.HashedSlice8, "TransactTime");
        public static readonly FieldSpec Text = new FieldSpec(FieldType.HashedSlice8, "Text");
        public static readonly FieldSpec EncodedTextLen = new FieldSpec(FieldType.Int, "EncodedTextLen");
        public static readonly FieldSpec EncodedText = new FieldSpec(FieldType.HashedSlice8, "EncodedText");
        public static readonly FieldSpec[] Schema = new FieldSpec[]
        {
            ClOrdID,
            SecondaryClOrdID,
            OrderID,
            SecondaryOrderID,
            MassCancelRequestType,
            MassCancelResponse,
            MassCancelRejectReason,
            TotalAffectedOrders,
            TradingSessionID,
            TradingSessionSubID,
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
                11 => ClOrdID,
                526 => SecondaryClOrdID,
                37 => OrderID,
                198 => SecondaryOrderID,
                530 => MassCancelRequestType,
                531 => MassCancelResponse,
                532 => MassCancelRejectReason,
                533 => TotalAffectedOrders,
                336 => TradingSessionID,
                625 => TradingSessionSubID,
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

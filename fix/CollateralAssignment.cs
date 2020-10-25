using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class CollateralAssignment
    {
        public static readonly FieldSpec CollAsgnID = new FieldSpec(FieldType.HashedSlice8, "CollAsgnID");
        public static readonly FieldSpec CollReqID = new FieldSpec(FieldType.HashedSlice8, "CollReqID");
        public static readonly FieldSpec CollAsgnReason = new FieldSpec(FieldType.Int, "CollAsgnReason");
        public static readonly FieldSpec CollAsgnTransType = new FieldSpec(FieldType.Int, "CollAsgnTransType");
        public static readonly FieldSpec CollAsgnRefID = new FieldSpec(FieldType.HashedSlice8, "CollAsgnRefID");
        public static readonly FieldSpec TransactTime = new FieldSpec(FieldType.HashedSlice8, "TransactTime");
        public static readonly FieldSpec ExpireTime = new FieldSpec(FieldType.HashedSlice8, "ExpireTime");
        public static readonly FieldSpec Account = new FieldSpec(FieldType.HashedSlice8, "Account");
        public static readonly FieldSpec AccountType = new FieldSpec(FieldType.Int, "AccountType");
        public static readonly FieldSpec ClOrdID = new FieldSpec(FieldType.HashedSlice8, "ClOrdID");
        public static readonly FieldSpec OrderID = new FieldSpec(FieldType.HashedSlice8, "OrderID");
        public static readonly FieldSpec SecondaryOrderID = new FieldSpec(FieldType.HashedSlice8, "SecondaryOrderID");
        public static readonly FieldSpec SecondaryClOrdID = new FieldSpec(FieldType.HashedSlice8, "SecondaryClOrdID");
        public static readonly FieldSpec SettlDate = new FieldSpec(FieldType.HashedSlice8, "SettlDate");
        public static readonly FieldSpec Quantity = new FieldSpec(FieldType.Float, "Quantity");
        public static readonly FieldSpec QtyType = new FieldSpec(FieldType.Int, "QtyType");
        public static readonly FieldSpec Currency = new FieldSpec(FieldType.HashedSlice8, "Currency");
        public static readonly FieldSpec MarginExcess = new FieldSpec(FieldType.Float, "MarginExcess");
        public static readonly FieldSpec TotalNetValue = new FieldSpec(FieldType.Float, "TotalNetValue");
        public static readonly FieldSpec CashOutstanding = new FieldSpec(FieldType.Float, "CashOutstanding");
        public static readonly FieldSpec Side = new FieldSpec(FieldType.Char, "Side");
        public static readonly FieldSpec Price = new FieldSpec(FieldType.Float, "Price");
        public static readonly FieldSpec PriceType = new FieldSpec(FieldType.Int, "PriceType");
        public static readonly FieldSpec AccruedInterestAmt = new FieldSpec(FieldType.Float, "AccruedInterestAmt");
        public static readonly FieldSpec EndAccruedInterestAmt = new FieldSpec(FieldType.Float, "EndAccruedInterestAmt");
        public static readonly FieldSpec StartCash = new FieldSpec(FieldType.Float, "StartCash");
        public static readonly FieldSpec EndCash = new FieldSpec(FieldType.Float, "EndCash");
        public static readonly FieldSpec TradingSessionID = new FieldSpec(FieldType.HashedSlice8, "TradingSessionID");
        public static readonly FieldSpec TradingSessionSubID = new FieldSpec(FieldType.HashedSlice8, "TradingSessionSubID");
        public static readonly FieldSpec SettlSessID = new FieldSpec(FieldType.HashedSlice8, "SettlSessID");
        public static readonly FieldSpec SettlSessSubID = new FieldSpec(FieldType.HashedSlice8, "SettlSessSubID");
        public static readonly FieldSpec ClearingBusinessDate = new FieldSpec(FieldType.HashedSlice8, "ClearingBusinessDate");
        public static readonly FieldSpec Text = new FieldSpec(FieldType.HashedSlice8, "Text");
        public static readonly FieldSpec EncodedTextLen = new FieldSpec(FieldType.Int, "EncodedTextLen");
        public static readonly FieldSpec EncodedText = new FieldSpec(FieldType.HashedSlice8, "EncodedText");
        public static readonly FieldSpec TradeDate = new FieldSpec(FieldType.HashedSlice8, "TradeDate");
        public static readonly FieldSpec[] Schema = new FieldSpec[]
        {
            CollAsgnID,
            CollReqID,
            CollAsgnReason,
            CollAsgnTransType,
            CollAsgnRefID,
            TransactTime,
            ExpireTime,
            Account,
            AccountType,
            ClOrdID,
            OrderID,
            SecondaryOrderID,
            SecondaryClOrdID,
            SettlDate,
            Quantity,
            QtyType,
            Currency,
            MarginExcess,
            TotalNetValue,
            CashOutstanding,
            Side,
            Price,
            PriceType,
            AccruedInterestAmt,
            EndAccruedInterestAmt,
            StartCash,
            EndCash,
            TradingSessionID,
            TradingSessionSubID,
            SettlSessID,
            SettlSessSubID,
            ClearingBusinessDate,
            Text,
            EncodedTextLen,
            EncodedText,
            TradeDate,
        };
        public static FieldSpec GetFieldSpec(int tag)
        {
            return tag switch
            {
                902 => CollAsgnID,
                894 => CollReqID,
                895 => CollAsgnReason,
                903 => CollAsgnTransType,
                907 => CollAsgnRefID,
                60 => TransactTime,
                126 => ExpireTime,
                1 => Account,
                581 => AccountType,
                11 => ClOrdID,
                37 => OrderID,
                198 => SecondaryOrderID,
                526 => SecondaryClOrdID,
                64 => SettlDate,
                53 => Quantity,
                854 => QtyType,
                15 => Currency,
                899 => MarginExcess,
                900 => TotalNetValue,
                901 => CashOutstanding,
                54 => Side,
                44 => Price,
                423 => PriceType,
                159 => AccruedInterestAmt,
                920 => EndAccruedInterestAmt,
                921 => StartCash,
                922 => EndCash,
                336 => TradingSessionID,
                625 => TradingSessionSubID,
                716 => SettlSessID,
                717 => SettlSessSubID,
                715 => ClearingBusinessDate,
                58 => Text,
                354 => EncodedTextLen,
                355 => EncodedText,
                75 => TradeDate,
                _ => throw new ArgumentException($"Invalid tag value {tag}")
            };
        }
    }
}

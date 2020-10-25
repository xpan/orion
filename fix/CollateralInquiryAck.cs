using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class CollateralInquiryAck
    {
        public static readonly FieldSpec CollInquiryID = new FieldSpec(FieldType.HashedSlice8, "CollInquiryID");
        public static readonly FieldSpec CollInquiryStatus = new FieldSpec(FieldType.Int, "CollInquiryStatus");
        public static readonly FieldSpec CollInquiryResult = new FieldSpec(FieldType.Int, "CollInquiryResult");
        public static readonly FieldSpec TotNumReports = new FieldSpec(FieldType.Int, "TotNumReports");
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
        public static readonly FieldSpec TradingSessionID = new FieldSpec(FieldType.HashedSlice8, "TradingSessionID");
        public static readonly FieldSpec TradingSessionSubID = new FieldSpec(FieldType.HashedSlice8, "TradingSessionSubID");
        public static readonly FieldSpec SettlSessID = new FieldSpec(FieldType.HashedSlice8, "SettlSessID");
        public static readonly FieldSpec SettlSessSubID = new FieldSpec(FieldType.HashedSlice8, "SettlSessSubID");
        public static readonly FieldSpec ClearingBusinessDate = new FieldSpec(FieldType.HashedSlice8, "ClearingBusinessDate");
        public static readonly FieldSpec ResponseTransportType = new FieldSpec(FieldType.Int, "ResponseTransportType");
        public static readonly FieldSpec ResponseDestination = new FieldSpec(FieldType.HashedSlice8, "ResponseDestination");
        public static readonly FieldSpec Text = new FieldSpec(FieldType.HashedSlice8, "Text");
        public static readonly FieldSpec EncodedTextLen = new FieldSpec(FieldType.Int, "EncodedTextLen");
        public static readonly FieldSpec EncodedText = new FieldSpec(FieldType.HashedSlice8, "EncodedText");
        public static readonly FieldSpec[] Schema = new FieldSpec[]
        {
            CollInquiryID,
            CollInquiryStatus,
            CollInquiryResult,
            TotNumReports,
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
            TradingSessionID,
            TradingSessionSubID,
            SettlSessID,
            SettlSessSubID,
            ClearingBusinessDate,
            ResponseTransportType,
            ResponseDestination,
            Text,
            EncodedTextLen,
            EncodedText,
        };
        public static FieldSpec GetFieldSpec(int tag)
        {
            return tag switch
            {
                909 => CollInquiryID,
                945 => CollInquiryStatus,
                946 => CollInquiryResult,
                911 => TotNumReports,
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
                336 => TradingSessionID,
                625 => TradingSessionSubID,
                716 => SettlSessID,
                717 => SettlSessSubID,
                715 => ClearingBusinessDate,
                725 => ResponseTransportType,
                726 => ResponseDestination,
                58 => Text,
                354 => EncodedTextLen,
                355 => EncodedText,
                _ => throw new ArgumentException($"Invalid tag value {tag}")
            };
        }
    }
}

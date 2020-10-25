using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class PositionReport
    {
        public static readonly FieldSpec PosMaintRptID = new FieldSpec(FieldType.HashedSlice8, "PosMaintRptID");
        public static readonly FieldSpec PosReqID = new FieldSpec(FieldType.HashedSlice8, "PosReqID");
        public static readonly FieldSpec PosReqType = new FieldSpec(FieldType.Int, "PosReqType");
        public static readonly FieldSpec SubscriptionRequestType = new FieldSpec(FieldType.Char, "SubscriptionRequestType");
        public static readonly FieldSpec TotalNumPosReports = new FieldSpec(FieldType.Int, "TotalNumPosReports");
        public static readonly FieldSpec PosReqResult = new FieldSpec(FieldType.Int, "PosReqResult");
        public static readonly FieldSpec UnsolicitedIndicator = new FieldSpec(FieldType.Char, "UnsolicitedIndicator");
        public static readonly FieldSpec ClearingBusinessDate = new FieldSpec(FieldType.HashedSlice8, "ClearingBusinessDate");
        public static readonly FieldSpec SettlSessID = new FieldSpec(FieldType.HashedSlice8, "SettlSessID");
        public static readonly FieldSpec SettlSessSubID = new FieldSpec(FieldType.HashedSlice8, "SettlSessSubID");
        public static readonly FieldSpec PriceType = new FieldSpec(FieldType.Int, "PriceType");
        public static readonly FieldSpec SettlCurrency = new FieldSpec(FieldType.HashedSlice8, "SettlCurrency");
        public static readonly FieldSpec MessageEventSource = new FieldSpec(FieldType.HashedSlice8, "MessageEventSource");
        public static readonly FieldSpec Account = new FieldSpec(FieldType.HashedSlice8, "Account");
        public static readonly FieldSpec AcctIDSource = new FieldSpec(FieldType.Int, "AcctIDSource");
        public static readonly FieldSpec AccountType = new FieldSpec(FieldType.Int, "AccountType");
        public static readonly FieldSpec Currency = new FieldSpec(FieldType.HashedSlice8, "Currency");
        public static readonly FieldSpec SettlPrice = new FieldSpec(FieldType.Float, "SettlPrice");
        public static readonly FieldSpec SettlPriceType = new FieldSpec(FieldType.Int, "SettlPriceType");
        public static readonly FieldSpec PriorSettlPrice = new FieldSpec(FieldType.Float, "PriorSettlPrice");
        public static readonly FieldSpec MatchStatus = new FieldSpec(FieldType.Char, "MatchStatus");
        public static readonly FieldSpec RegistStatus = new FieldSpec(FieldType.Char, "RegistStatus");
        public static readonly FieldSpec DeliveryDate = new FieldSpec(FieldType.HashedSlice8, "DeliveryDate");
        public static readonly FieldSpec Text = new FieldSpec(FieldType.HashedSlice8, "Text");
        public static readonly FieldSpec EncodedTextLen = new FieldSpec(FieldType.Int, "EncodedTextLen");
        public static readonly FieldSpec EncodedText = new FieldSpec(FieldType.HashedSlice8, "EncodedText");
        public static readonly FieldSpec PriceDelta = new FieldSpec(FieldType.Float, "PriceDelta");
        public static readonly FieldSpec TotNumReports = new FieldSpec(FieldType.Int, "TotNumReports");
        public static readonly FieldSpec LastRptRequested = new FieldSpec(FieldType.Char, "LastRptRequested");
        public static readonly FieldSpec TransactTime = new FieldSpec(FieldType.HashedSlice8, "TransactTime");
        public static readonly FieldSpec SettlDate = new FieldSpec(FieldType.HashedSlice8, "SettlDate");
        public static readonly FieldSpec[] Schema = new FieldSpec[]
        {
            PosMaintRptID,
            PosReqID,
            PosReqType,
            SubscriptionRequestType,
            TotalNumPosReports,
            PosReqResult,
            UnsolicitedIndicator,
            ClearingBusinessDate,
            SettlSessID,
            SettlSessSubID,
            PriceType,
            SettlCurrency,
            MessageEventSource,
            Account,
            AcctIDSource,
            AccountType,
            Currency,
            SettlPrice,
            SettlPriceType,
            PriorSettlPrice,
            MatchStatus,
            RegistStatus,
            DeliveryDate,
            Text,
            EncodedTextLen,
            EncodedText,
            PriceDelta,
            TotNumReports,
            LastRptRequested,
            TransactTime,
            SettlDate,
        };
        public static FieldSpec GetFieldSpec(int tag)
        {
            return tag switch
            {
                721 => PosMaintRptID,
                710 => PosReqID,
                724 => PosReqType,
                263 => SubscriptionRequestType,
                727 => TotalNumPosReports,
                728 => PosReqResult,
                325 => UnsolicitedIndicator,
                715 => ClearingBusinessDate,
                716 => SettlSessID,
                717 => SettlSessSubID,
                423 => PriceType,
                120 => SettlCurrency,
                1011 => MessageEventSource,
                1 => Account,
                660 => AcctIDSource,
                581 => AccountType,
                15 => Currency,
                730 => SettlPrice,
                731 => SettlPriceType,
                734 => PriorSettlPrice,
                573 => MatchStatus,
                506 => RegistStatus,
                743 => DeliveryDate,
                58 => Text,
                354 => EncodedTextLen,
                355 => EncodedText,
                811 => PriceDelta,
                911 => TotNumReports,
                912 => LastRptRequested,
                60 => TransactTime,
                64 => SettlDate,
                _ => throw new ArgumentException($"Invalid tag value {tag}")
            };
        }
    }
}

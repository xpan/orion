using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class RequestForPositionsAck
    {
        public static readonly FieldSpec PosMaintRptID = new FieldSpec(FieldType.HashedSlice8, "PosMaintRptID");
        public static readonly FieldSpec PosReqID = new FieldSpec(FieldType.HashedSlice8, "PosReqID");
        public static readonly FieldSpec TotalNumPosReports = new FieldSpec(FieldType.Int, "TotalNumPosReports");
        public static readonly FieldSpec UnsolicitedIndicator = new FieldSpec(FieldType.Char, "UnsolicitedIndicator");
        public static readonly FieldSpec PosReqResult = new FieldSpec(FieldType.Int, "PosReqResult");
        public static readonly FieldSpec PosReqStatus = new FieldSpec(FieldType.Int, "PosReqStatus");
        public static readonly FieldSpec PosReqType = new FieldSpec(FieldType.Int, "PosReqType");
        public static readonly FieldSpec MatchStatus = new FieldSpec(FieldType.Char, "MatchStatus");
        public static readonly FieldSpec ClearingBusinessDate = new FieldSpec(FieldType.HashedSlice8, "ClearingBusinessDate");
        public static readonly FieldSpec SubscriptionRequestType = new FieldSpec(FieldType.Char, "SubscriptionRequestType");
        public static readonly FieldSpec SettlSessID = new FieldSpec(FieldType.HashedSlice8, "SettlSessID");
        public static readonly FieldSpec SettlSessSubID = new FieldSpec(FieldType.HashedSlice8, "SettlSessSubID");
        public static readonly FieldSpec SettlCurrency = new FieldSpec(FieldType.HashedSlice8, "SettlCurrency");
        public static readonly FieldSpec Account = new FieldSpec(FieldType.HashedSlice8, "Account");
        public static readonly FieldSpec AcctIDSource = new FieldSpec(FieldType.Int, "AcctIDSource");
        public static readonly FieldSpec AccountType = new FieldSpec(FieldType.Int, "AccountType");
        public static readonly FieldSpec Currency = new FieldSpec(FieldType.HashedSlice8, "Currency");
        public static readonly FieldSpec ResponseTransportType = new FieldSpec(FieldType.Int, "ResponseTransportType");
        public static readonly FieldSpec ResponseDestination = new FieldSpec(FieldType.HashedSlice8, "ResponseDestination");
        public static readonly FieldSpec Text = new FieldSpec(FieldType.HashedSlice8, "Text");
        public static readonly FieldSpec EncodedTextLen = new FieldSpec(FieldType.Int, "EncodedTextLen");
        public static readonly FieldSpec EncodedText = new FieldSpec(FieldType.HashedSlice8, "EncodedText");
        public static readonly FieldSpec TotNumReports = new FieldSpec(FieldType.Int, "TotNumReports");
        public static readonly FieldSpec[] Schema = new FieldSpec[]
        {
            PosMaintRptID,
            PosReqID,
            TotalNumPosReports,
            UnsolicitedIndicator,
            PosReqResult,
            PosReqStatus,
            PosReqType,
            MatchStatus,
            ClearingBusinessDate,
            SubscriptionRequestType,
            SettlSessID,
            SettlSessSubID,
            SettlCurrency,
            Account,
            AcctIDSource,
            AccountType,
            Currency,
            ResponseTransportType,
            ResponseDestination,
            Text,
            EncodedTextLen,
            EncodedText,
            TotNumReports,
        };
        public static FieldSpec GetFieldSpec(int tag)
        {
            return tag switch
            {
                721 => PosMaintRptID,
                710 => PosReqID,
                727 => TotalNumPosReports,
                325 => UnsolicitedIndicator,
                728 => PosReqResult,
                729 => PosReqStatus,
                724 => PosReqType,
                573 => MatchStatus,
                715 => ClearingBusinessDate,
                263 => SubscriptionRequestType,
                716 => SettlSessID,
                717 => SettlSessSubID,
                120 => SettlCurrency,
                1 => Account,
                660 => AcctIDSource,
                581 => AccountType,
                15 => Currency,
                725 => ResponseTransportType,
                726 => ResponseDestination,
                58 => Text,
                354 => EncodedTextLen,
                355 => EncodedText,
                911 => TotNumReports,
                _ => throw new ArgumentException($"Invalid tag value {tag}")
            };
        }
    }
}

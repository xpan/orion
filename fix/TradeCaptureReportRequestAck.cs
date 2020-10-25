using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class TradeCaptureReportRequestAck
    {
        public static readonly FieldSpec TradeRequestID = new FieldSpec(FieldType.HashedSlice8, "TradeRequestID");
        public static readonly FieldSpec TradeID = new FieldSpec(FieldType.HashedSlice8, "TradeID");
        public static readonly FieldSpec SecondaryTradeID = new FieldSpec(FieldType.HashedSlice8, "SecondaryTradeID");
        public static readonly FieldSpec FirmTradeID = new FieldSpec(FieldType.HashedSlice8, "FirmTradeID");
        public static readonly FieldSpec SecondaryFirmTradeID = new FieldSpec(FieldType.HashedSlice8, "SecondaryFirmTradeID");
        public static readonly FieldSpec TradeRequestType = new FieldSpec(FieldType.Int, "TradeRequestType");
        public static readonly FieldSpec SubscriptionRequestType = new FieldSpec(FieldType.Char, "SubscriptionRequestType");
        public static readonly FieldSpec TotNumTradeReports = new FieldSpec(FieldType.Int, "TotNumTradeReports");
        public static readonly FieldSpec TradeRequestResult = new FieldSpec(FieldType.Int, "TradeRequestResult");
        public static readonly FieldSpec TradeRequestStatus = new FieldSpec(FieldType.Int, "TradeRequestStatus");
        public static readonly FieldSpec MultiLegReportingType = new FieldSpec(FieldType.Char, "MultiLegReportingType");
        public static readonly FieldSpec ResponseTransportType = new FieldSpec(FieldType.Int, "ResponseTransportType");
        public static readonly FieldSpec ResponseDestination = new FieldSpec(FieldType.HashedSlice8, "ResponseDestination");
        public static readonly FieldSpec Text = new FieldSpec(FieldType.HashedSlice8, "Text");
        public static readonly FieldSpec EncodedTextLen = new FieldSpec(FieldType.Int, "EncodedTextLen");
        public static readonly FieldSpec EncodedText = new FieldSpec(FieldType.HashedSlice8, "EncodedText");
        public static readonly FieldSpec MessageEventSource = new FieldSpec(FieldType.HashedSlice8, "MessageEventSource");
        public static readonly FieldSpec[] Schema = new FieldSpec[]
        {
            TradeRequestID,
            TradeID,
            SecondaryTradeID,
            FirmTradeID,
            SecondaryFirmTradeID,
            TradeRequestType,
            SubscriptionRequestType,
            TotNumTradeReports,
            TradeRequestResult,
            TradeRequestStatus,
            MultiLegReportingType,
            ResponseTransportType,
            ResponseDestination,
            Text,
            EncodedTextLen,
            EncodedText,
            MessageEventSource,
        };
        public static FieldSpec GetFieldSpec(int tag)
        {
            return tag switch
            {
                568 => TradeRequestID,
                1003 => TradeID,
                1040 => SecondaryTradeID,
                1041 => FirmTradeID,
                1042 => SecondaryFirmTradeID,
                569 => TradeRequestType,
                263 => SubscriptionRequestType,
                748 => TotNumTradeReports,
                749 => TradeRequestResult,
                750 => TradeRequestStatus,
                442 => MultiLegReportingType,
                725 => ResponseTransportType,
                726 => ResponseDestination,
                58 => Text,
                354 => EncodedTextLen,
                355 => EncodedText,
                1011 => MessageEventSource,
                _ => throw new ArgumentException($"Invalid tag value {tag}")
            };
        }
    }
}

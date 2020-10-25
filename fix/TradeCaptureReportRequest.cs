using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class TradeCaptureReportRequest
    {
        public static readonly FieldSpec TradeRequestID = new FieldSpec(FieldType.HashedSlice8, "TradeRequestID");
        public static readonly FieldSpec TradeID = new FieldSpec(FieldType.HashedSlice8, "TradeID");
        public static readonly FieldSpec SecondaryTradeID = new FieldSpec(FieldType.HashedSlice8, "SecondaryTradeID");
        public static readonly FieldSpec FirmTradeID = new FieldSpec(FieldType.HashedSlice8, "FirmTradeID");
        public static readonly FieldSpec SecondaryFirmTradeID = new FieldSpec(FieldType.HashedSlice8, "SecondaryFirmTradeID");
        public static readonly FieldSpec TradeRequestType = new FieldSpec(FieldType.Int, "TradeRequestType");
        public static readonly FieldSpec SubscriptionRequestType = new FieldSpec(FieldType.Char, "SubscriptionRequestType");
        public static readonly FieldSpec TradeReportID = new FieldSpec(FieldType.HashedSlice8, "TradeReportID");
        public static readonly FieldSpec SecondaryTradeReportID = new FieldSpec(FieldType.HashedSlice8, "SecondaryTradeReportID");
        public static readonly FieldSpec ExecID = new FieldSpec(FieldType.HashedSlice8, "ExecID");
        public static readonly FieldSpec ExecType = new FieldSpec(FieldType.Char, "ExecType");
        public static readonly FieldSpec OrderID = new FieldSpec(FieldType.HashedSlice8, "OrderID");
        public static readonly FieldSpec ClOrdID = new FieldSpec(FieldType.HashedSlice8, "ClOrdID");
        public static readonly FieldSpec MatchStatus = new FieldSpec(FieldType.Char, "MatchStatus");
        public static readonly FieldSpec TrdType = new FieldSpec(FieldType.Int, "TrdType");
        public static readonly FieldSpec TrdSubType = new FieldSpec(FieldType.Int, "TrdSubType");
        public static readonly FieldSpec TradeHandlingInstr = new FieldSpec(FieldType.Char, "TradeHandlingInstr");
        public static readonly FieldSpec TransferReason = new FieldSpec(FieldType.HashedSlice8, "TransferReason");
        public static readonly FieldSpec SecondaryTrdType = new FieldSpec(FieldType.Int, "SecondaryTrdType");
        public static readonly FieldSpec TradeLinkID = new FieldSpec(FieldType.HashedSlice8, "TradeLinkID");
        public static readonly FieldSpec TrdMatchID = new FieldSpec(FieldType.HashedSlice8, "TrdMatchID");
        public static readonly FieldSpec ClearingBusinessDate = new FieldSpec(FieldType.HashedSlice8, "ClearingBusinessDate");
        public static readonly FieldSpec TradingSessionID = new FieldSpec(FieldType.HashedSlice8, "TradingSessionID");
        public static readonly FieldSpec TradingSessionSubID = new FieldSpec(FieldType.HashedSlice8, "TradingSessionSubID");
        public static readonly FieldSpec TimeBracket = new FieldSpec(FieldType.HashedSlice8, "TimeBracket");
        public static readonly FieldSpec Side = new FieldSpec(FieldType.Char, "Side");
        public static readonly FieldSpec MultiLegReportingType = new FieldSpec(FieldType.Char, "MultiLegReportingType");
        public static readonly FieldSpec TradeInputSource = new FieldSpec(FieldType.HashedSlice8, "TradeInputSource");
        public static readonly FieldSpec TradeInputDevice = new FieldSpec(FieldType.HashedSlice8, "TradeInputDevice");
        public static readonly FieldSpec ResponseTransportType = new FieldSpec(FieldType.Int, "ResponseTransportType");
        public static readonly FieldSpec ResponseDestination = new FieldSpec(FieldType.HashedSlice8, "ResponseDestination");
        public static readonly FieldSpec Text = new FieldSpec(FieldType.HashedSlice8, "Text");
        public static readonly FieldSpec EncodedTextLen = new FieldSpec(FieldType.Int, "EncodedTextLen");
        public static readonly FieldSpec EncodedText = new FieldSpec(FieldType.HashedSlice8, "EncodedText");
        public static readonly FieldSpec MessageEventSource = new FieldSpec(FieldType.HashedSlice8, "MessageEventSource");
        public static readonly FieldSpec SecondaryExecID = new FieldSpec(FieldType.HashedSlice8, "SecondaryExecID");
        public static readonly FieldSpec[] Schema = new FieldSpec[]
        {
            TradeRequestID,
            TradeID,
            SecondaryTradeID,
            FirmTradeID,
            SecondaryFirmTradeID,
            TradeRequestType,
            SubscriptionRequestType,
            TradeReportID,
            SecondaryTradeReportID,
            ExecID,
            ExecType,
            OrderID,
            ClOrdID,
            MatchStatus,
            TrdType,
            TrdSubType,
            TradeHandlingInstr,
            TransferReason,
            SecondaryTrdType,
            TradeLinkID,
            TrdMatchID,
            ClearingBusinessDate,
            TradingSessionID,
            TradingSessionSubID,
            TimeBracket,
            Side,
            MultiLegReportingType,
            TradeInputSource,
            TradeInputDevice,
            ResponseTransportType,
            ResponseDestination,
            Text,
            EncodedTextLen,
            EncodedText,
            MessageEventSource,
            SecondaryExecID,
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
                571 => TradeReportID,
                818 => SecondaryTradeReportID,
                17 => ExecID,
                150 => ExecType,
                37 => OrderID,
                11 => ClOrdID,
                573 => MatchStatus,
                828 => TrdType,
                829 => TrdSubType,
                1123 => TradeHandlingInstr,
                830 => TransferReason,
                855 => SecondaryTrdType,
                820 => TradeLinkID,
                880 => TrdMatchID,
                715 => ClearingBusinessDate,
                336 => TradingSessionID,
                625 => TradingSessionSubID,
                943 => TimeBracket,
                54 => Side,
                442 => MultiLegReportingType,
                578 => TradeInputSource,
                579 => TradeInputDevice,
                725 => ResponseTransportType,
                726 => ResponseDestination,
                58 => Text,
                354 => EncodedTextLen,
                355 => EncodedText,
                1011 => MessageEventSource,
                527 => SecondaryExecID,
                _ => throw new ArgumentException($"Invalid tag value {tag}")
            };
        }
    }
}

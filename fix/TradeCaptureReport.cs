using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class TradeCaptureReport
    {
        public static readonly FieldSpec TradeReportID = new FieldSpec(FieldType.HashedSlice8, "TradeReportID");
        public static readonly FieldSpec TradeID = new FieldSpec(FieldType.HashedSlice8, "TradeID");
        public static readonly FieldSpec SecondaryTradeID = new FieldSpec(FieldType.HashedSlice8, "SecondaryTradeID");
        public static readonly FieldSpec FirmTradeID = new FieldSpec(FieldType.HashedSlice8, "FirmTradeID");
        public static readonly FieldSpec SecondaryFirmTradeID = new FieldSpec(FieldType.HashedSlice8, "SecondaryFirmTradeID");
        public static readonly FieldSpec TradeReportTransType = new FieldSpec(FieldType.Int, "TradeReportTransType");
        public static readonly FieldSpec TradeReportType = new FieldSpec(FieldType.Int, "TradeReportType");
        public static readonly FieldSpec TrdRptStatus = new FieldSpec(FieldType.Int, "TrdRptStatus");
        public static readonly FieldSpec TradeRequestID = new FieldSpec(FieldType.HashedSlice8, "TradeRequestID");
        public static readonly FieldSpec TrdType = new FieldSpec(FieldType.Int, "TrdType");
        public static readonly FieldSpec TrdSubType = new FieldSpec(FieldType.Int, "TrdSubType");
        public static readonly FieldSpec SecondaryTrdType = new FieldSpec(FieldType.Int, "SecondaryTrdType");
        public static readonly FieldSpec TradeHandlingInstr = new FieldSpec(FieldType.Char, "TradeHandlingInstr");
        public static readonly FieldSpec OrigTradeHandlingInstr = new FieldSpec(FieldType.Char, "OrigTradeHandlingInstr");
        public static readonly FieldSpec OrigTradeDate = new FieldSpec(FieldType.HashedSlice8, "OrigTradeDate");
        public static readonly FieldSpec OrigTradeID = new FieldSpec(FieldType.HashedSlice8, "OrigTradeID");
        public static readonly FieldSpec OrigSecondaryTradeID = new FieldSpec(FieldType.HashedSlice8, "OrigSecondaryTradeID");
        public static readonly FieldSpec TransferReason = new FieldSpec(FieldType.HashedSlice8, "TransferReason");
        public static readonly FieldSpec ExecType = new FieldSpec(FieldType.Char, "ExecType");
        public static readonly FieldSpec TotNumTradeReports = new FieldSpec(FieldType.Int, "TotNumTradeReports");
        public static readonly FieldSpec LastRptRequested = new FieldSpec(FieldType.Char, "LastRptRequested");
        public static readonly FieldSpec UnsolicitedIndicator = new FieldSpec(FieldType.Char, "UnsolicitedIndicator");
        public static readonly FieldSpec SubscriptionRequestType = new FieldSpec(FieldType.Char, "SubscriptionRequestType");
        public static readonly FieldSpec TradeReportRefID = new FieldSpec(FieldType.HashedSlice8, "TradeReportRefID");
        public static readonly FieldSpec SecondaryTradeReportRefID = new FieldSpec(FieldType.HashedSlice8, "SecondaryTradeReportRefID");
        public static readonly FieldSpec SecondaryTradeReportID = new FieldSpec(FieldType.HashedSlice8, "SecondaryTradeReportID");
        public static readonly FieldSpec TradeLinkID = new FieldSpec(FieldType.HashedSlice8, "TradeLinkID");
        public static readonly FieldSpec TrdMatchID = new FieldSpec(FieldType.HashedSlice8, "TrdMatchID");
        public static readonly FieldSpec ExecID = new FieldSpec(FieldType.HashedSlice8, "ExecID");
        public static readonly FieldSpec SecondaryExecID = new FieldSpec(FieldType.HashedSlice8, "SecondaryExecID");
        public static readonly FieldSpec ExecRestatementReason = new FieldSpec(FieldType.Int, "ExecRestatementReason");
        public static readonly FieldSpec PreviouslyReported = new FieldSpec(FieldType.Char, "PreviouslyReported");
        public static readonly FieldSpec PriceType = new FieldSpec(FieldType.Int, "PriceType");
        public static readonly FieldSpec AsOfIndicator = new FieldSpec(FieldType.Char, "AsOfIndicator");
        public static readonly FieldSpec SettlSessID = new FieldSpec(FieldType.HashedSlice8, "SettlSessID");
        public static readonly FieldSpec SettlSessSubID = new FieldSpec(FieldType.HashedSlice8, "SettlSessSubID");
        public static readonly FieldSpec QtyType = new FieldSpec(FieldType.Int, "QtyType");
        public static readonly FieldSpec UnderlyingTradingSessionID = new FieldSpec(FieldType.HashedSlice8, "UnderlyingTradingSessionID");
        public static readonly FieldSpec UnderlyingTradingSessionSubID = new FieldSpec(FieldType.HashedSlice8, "UnderlyingTradingSessionSubID");
        public static readonly FieldSpec LastQty = new FieldSpec(FieldType.Float, "LastQty");
        public static readonly FieldSpec LastPx = new FieldSpec(FieldType.Float, "LastPx");
        public static readonly FieldSpec CalculatedCcyLastQty = new FieldSpec(FieldType.Float, "CalculatedCcyLastQty");
        public static readonly FieldSpec Currency = new FieldSpec(FieldType.HashedSlice8, "Currency");
        public static readonly FieldSpec SettlCurrency = new FieldSpec(FieldType.HashedSlice8, "SettlCurrency");
        public static readonly FieldSpec LastParPx = new FieldSpec(FieldType.Float, "LastParPx");
        public static readonly FieldSpec LastSpotRate = new FieldSpec(FieldType.Float, "LastSpotRate");
        public static readonly FieldSpec LastForwardPoints = new FieldSpec(FieldType.Float, "LastForwardPoints");
        public static readonly FieldSpec LastSwapPoints = new FieldSpec(FieldType.Float, "LastSwapPoints");
        public static readonly FieldSpec LastMkt = new FieldSpec(FieldType.HashedSlice8, "LastMkt");
        public static readonly FieldSpec TradeDate = new FieldSpec(FieldType.HashedSlice8, "TradeDate");
        public static readonly FieldSpec ClearingBusinessDate = new FieldSpec(FieldType.HashedSlice8, "ClearingBusinessDate");
        public static readonly FieldSpec AvgPx = new FieldSpec(FieldType.Float, "AvgPx");
        public static readonly FieldSpec AvgPxIndicator = new FieldSpec(FieldType.Int, "AvgPxIndicator");
        public static readonly FieldSpec MultiLegReportingType = new FieldSpec(FieldType.Char, "MultiLegReportingType");
        public static readonly FieldSpec TradeLegRefID = new FieldSpec(FieldType.HashedSlice8, "TradeLegRefID");
        public static readonly FieldSpec TransactTime = new FieldSpec(FieldType.HashedSlice8, "TransactTime");
        public static readonly FieldSpec SettlType = new FieldSpec(FieldType.HashedSlice8, "SettlType");
        public static readonly FieldSpec SettlDate = new FieldSpec(FieldType.HashedSlice8, "SettlDate");
        public static readonly FieldSpec UnderlyingSettlementDate = new FieldSpec(FieldType.HashedSlice8, "UnderlyingSettlementDate");
        public static readonly FieldSpec MatchStatus = new FieldSpec(FieldType.Char, "MatchStatus");
        public static readonly FieldSpec MatchType = new FieldSpec(FieldType.HashedSlice8, "MatchType");
        public static readonly FieldSpec CopyMsgIndicator = new FieldSpec(FieldType.Char, "CopyMsgIndicator");
        public static readonly FieldSpec PublishTrdIndicator = new FieldSpec(FieldType.Char, "PublishTrdIndicator");
        public static readonly FieldSpec ShortSaleReason = new FieldSpec(FieldType.Int, "ShortSaleReason");
        public static readonly FieldSpec TierCode = new FieldSpec(FieldType.HashedSlice8, "TierCode");
        public static readonly FieldSpec MessageEventSource = new FieldSpec(FieldType.HashedSlice8, "MessageEventSource");
        public static readonly FieldSpec LastUpdateTime = new FieldSpec(FieldType.HashedSlice8, "LastUpdateTime");
        public static readonly FieldSpec RndPx = new FieldSpec(FieldType.Float, "RndPx");
        public static readonly FieldSpec TZTransactTime = new FieldSpec(FieldType.HashedSlice8, "TZTransactTime");
        public static readonly FieldSpec ReportedPxDiff = new FieldSpec(FieldType.Char, "ReportedPxDiff");
        public static readonly FieldSpec GrossTradeAmt = new FieldSpec(FieldType.Float, "GrossTradeAmt");
        public static readonly FieldSpec CrossType = new FieldSpec(FieldType.Int, "CrossType");
        public static readonly FieldSpec TradeReportRejectReason = new FieldSpec(FieldType.Int, "TradeReportRejectReason");
        public static readonly FieldSpec PriceDelta = new FieldSpec(FieldType.Float, "PriceDelta");
        public static readonly FieldSpec MidPx = new FieldSpec(FieldType.Float, "MidPx");
        public static readonly FieldSpec[] Schema = new FieldSpec[]
        {
            TradeReportID,
            TradeID,
            SecondaryTradeID,
            FirmTradeID,
            SecondaryFirmTradeID,
            TradeReportTransType,
            TradeReportType,
            TrdRptStatus,
            TradeRequestID,
            TrdType,
            TrdSubType,
            SecondaryTrdType,
            TradeHandlingInstr,
            OrigTradeHandlingInstr,
            OrigTradeDate,
            OrigTradeID,
            OrigSecondaryTradeID,
            TransferReason,
            ExecType,
            TotNumTradeReports,
            LastRptRequested,
            UnsolicitedIndicator,
            SubscriptionRequestType,
            TradeReportRefID,
            SecondaryTradeReportRefID,
            SecondaryTradeReportID,
            TradeLinkID,
            TrdMatchID,
            ExecID,
            SecondaryExecID,
            ExecRestatementReason,
            PreviouslyReported,
            PriceType,
            AsOfIndicator,
            SettlSessID,
            SettlSessSubID,
            QtyType,
            UnderlyingTradingSessionID,
            UnderlyingTradingSessionSubID,
            LastQty,
            LastPx,
            CalculatedCcyLastQty,
            Currency,
            SettlCurrency,
            LastParPx,
            LastSpotRate,
            LastForwardPoints,
            LastSwapPoints,
            LastMkt,
            TradeDate,
            ClearingBusinessDate,
            AvgPx,
            AvgPxIndicator,
            MultiLegReportingType,
            TradeLegRefID,
            TransactTime,
            SettlType,
            SettlDate,
            UnderlyingSettlementDate,
            MatchStatus,
            MatchType,
            CopyMsgIndicator,
            PublishTrdIndicator,
            ShortSaleReason,
            TierCode,
            MessageEventSource,
            LastUpdateTime,
            RndPx,
            TZTransactTime,
            ReportedPxDiff,
            GrossTradeAmt,
            CrossType,
            TradeReportRejectReason,
            PriceDelta,
            MidPx,
        };
        public static FieldSpec GetFieldSpec(int tag)
        {
            return tag switch
            {
                571 => TradeReportID,
                1003 => TradeID,
                1040 => SecondaryTradeID,
                1041 => FirmTradeID,
                1042 => SecondaryFirmTradeID,
                487 => TradeReportTransType,
                856 => TradeReportType,
                939 => TrdRptStatus,
                568 => TradeRequestID,
                828 => TrdType,
                829 => TrdSubType,
                855 => SecondaryTrdType,
                1123 => TradeHandlingInstr,
                1124 => OrigTradeHandlingInstr,
                1125 => OrigTradeDate,
                1126 => OrigTradeID,
                1127 => OrigSecondaryTradeID,
                830 => TransferReason,
                150 => ExecType,
                748 => TotNumTradeReports,
                912 => LastRptRequested,
                325 => UnsolicitedIndicator,
                263 => SubscriptionRequestType,
                572 => TradeReportRefID,
                881 => SecondaryTradeReportRefID,
                818 => SecondaryTradeReportID,
                820 => TradeLinkID,
                880 => TrdMatchID,
                17 => ExecID,
                527 => SecondaryExecID,
                378 => ExecRestatementReason,
                570 => PreviouslyReported,
                423 => PriceType,
                1015 => AsOfIndicator,
                716 => SettlSessID,
                717 => SettlSessSubID,
                854 => QtyType,
                822 => UnderlyingTradingSessionID,
                823 => UnderlyingTradingSessionSubID,
                32 => LastQty,
                31 => LastPx,
                1056 => CalculatedCcyLastQty,
                15 => Currency,
                120 => SettlCurrency,
                669 => LastParPx,
                194 => LastSpotRate,
                195 => LastForwardPoints,
                1071 => LastSwapPoints,
                30 => LastMkt,
                75 => TradeDate,
                715 => ClearingBusinessDate,
                6 => AvgPx,
                819 => AvgPxIndicator,
                442 => MultiLegReportingType,
                824 => TradeLegRefID,
                60 => TransactTime,
                63 => SettlType,
                64 => SettlDate,
                987 => UnderlyingSettlementDate,
                573 => MatchStatus,
                574 => MatchType,
                797 => CopyMsgIndicator,
                852 => PublishTrdIndicator,
                853 => ShortSaleReason,
                994 => TierCode,
                1011 => MessageEventSource,
                779 => LastUpdateTime,
                991 => RndPx,
                1132 => TZTransactTime,
                1134 => ReportedPxDiff,
                381 => GrossTradeAmt,
                549 => CrossType,
                751 => TradeReportRejectReason,
                811 => PriceDelta,
                631 => MidPx,
                _ => throw new ArgumentException($"Invalid tag value {tag}")
            };
        }
    }
}

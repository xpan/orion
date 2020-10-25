using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class AllocationInstructionAlert
    {
        public static readonly FieldSpec AllocID = new FieldSpec(FieldType.HashedSlice8, "AllocID");
        public static readonly FieldSpec AllocTransType = new FieldSpec(FieldType.Char, "AllocTransType");
        public static readonly FieldSpec AllocType = new FieldSpec(FieldType.Int, "AllocType");
        public static readonly FieldSpec SecondaryAllocID = new FieldSpec(FieldType.HashedSlice8, "SecondaryAllocID");
        public static readonly FieldSpec RefAllocID = new FieldSpec(FieldType.HashedSlice8, "RefAllocID");
        public static readonly FieldSpec AllocCancReplaceReason = new FieldSpec(FieldType.Int, "AllocCancReplaceReason");
        public static readonly FieldSpec AllocIntermedReqType = new FieldSpec(FieldType.Int, "AllocIntermedReqType");
        public static readonly FieldSpec AllocLinkID = new FieldSpec(FieldType.HashedSlice8, "AllocLinkID");
        public static readonly FieldSpec AllocLinkType = new FieldSpec(FieldType.Int, "AllocLinkType");
        public static readonly FieldSpec BookingRefID = new FieldSpec(FieldType.HashedSlice8, "BookingRefID");
        public static readonly FieldSpec AllocNoOrdersType = new FieldSpec(FieldType.Int, "AllocNoOrdersType");
        public static readonly FieldSpec PreviouslyReported = new FieldSpec(FieldType.Char, "PreviouslyReported");
        public static readonly FieldSpec ReversalIndicator = new FieldSpec(FieldType.Char, "ReversalIndicator");
        public static readonly FieldSpec MatchType = new FieldSpec(FieldType.HashedSlice8, "MatchType");
        public static readonly FieldSpec Side = new FieldSpec(FieldType.Char, "Side");
        public static readonly FieldSpec Quantity = new FieldSpec(FieldType.Float, "Quantity");
        public static readonly FieldSpec QtyType = new FieldSpec(FieldType.Int, "QtyType");
        public static readonly FieldSpec LastMkt = new FieldSpec(FieldType.HashedSlice8, "LastMkt");
        public static readonly FieldSpec TradeOriginationDate = new FieldSpec(FieldType.HashedSlice8, "TradeOriginationDate");
        public static readonly FieldSpec TradingSessionID = new FieldSpec(FieldType.HashedSlice8, "TradingSessionID");
        public static readonly FieldSpec TradingSessionSubID = new FieldSpec(FieldType.HashedSlice8, "TradingSessionSubID");
        public static readonly FieldSpec PriceType = new FieldSpec(FieldType.Int, "PriceType");
        public static readonly FieldSpec AvgPx = new FieldSpec(FieldType.Float, "AvgPx");
        public static readonly FieldSpec AvgParPx = new FieldSpec(FieldType.Float, "AvgParPx");
        public static readonly FieldSpec Currency = new FieldSpec(FieldType.HashedSlice8, "Currency");
        public static readonly FieldSpec AvgPxPrecision = new FieldSpec(FieldType.Int, "AvgPxPrecision");
        public static readonly FieldSpec TradeDate = new FieldSpec(FieldType.HashedSlice8, "TradeDate");
        public static readonly FieldSpec TransactTime = new FieldSpec(FieldType.HashedSlice8, "TransactTime");
        public static readonly FieldSpec SettlType = new FieldSpec(FieldType.HashedSlice8, "SettlType");
        public static readonly FieldSpec SettlDate = new FieldSpec(FieldType.HashedSlice8, "SettlDate");
        public static readonly FieldSpec BookingType = new FieldSpec(FieldType.Int, "BookingType");
        public static readonly FieldSpec GrossTradeAmt = new FieldSpec(FieldType.Float, "GrossTradeAmt");
        public static readonly FieldSpec Concession = new FieldSpec(FieldType.Float, "Concession");
        public static readonly FieldSpec TotalTakedown = new FieldSpec(FieldType.Float, "TotalTakedown");
        public static readonly FieldSpec NetMoney = new FieldSpec(FieldType.Float, "NetMoney");
        public static readonly FieldSpec PositionEffect = new FieldSpec(FieldType.Char, "PositionEffect");
        public static readonly FieldSpec AutoAcceptIndicator = new FieldSpec(FieldType.Char, "AutoAcceptIndicator");
        public static readonly FieldSpec Text = new FieldSpec(FieldType.HashedSlice8, "Text");
        public static readonly FieldSpec EncodedTextLen = new FieldSpec(FieldType.Int, "EncodedTextLen");
        public static readonly FieldSpec EncodedText = new FieldSpec(FieldType.HashedSlice8, "EncodedText");
        public static readonly FieldSpec NumDaysInterest = new FieldSpec(FieldType.Int, "NumDaysInterest");
        public static readonly FieldSpec AccruedInterestRate = new FieldSpec(FieldType.Float, "AccruedInterestRate");
        public static readonly FieldSpec AccruedInterestAmt = new FieldSpec(FieldType.Float, "AccruedInterestAmt");
        public static readonly FieldSpec TotalAccruedInterestAmt = new FieldSpec(FieldType.Float, "TotalAccruedInterestAmt");
        public static readonly FieldSpec InterestAtMaturity = new FieldSpec(FieldType.Float, "InterestAtMaturity");
        public static readonly FieldSpec EndAccruedInterestAmt = new FieldSpec(FieldType.Float, "EndAccruedInterestAmt");
        public static readonly FieldSpec StartCash = new FieldSpec(FieldType.Float, "StartCash");
        public static readonly FieldSpec EndCash = new FieldSpec(FieldType.Float, "EndCash");
        public static readonly FieldSpec LegalConfirm = new FieldSpec(FieldType.Char, "LegalConfirm");
        public static readonly FieldSpec TotNoAllocs = new FieldSpec(FieldType.Int, "TotNoAllocs");
        public static readonly FieldSpec LastFragment = new FieldSpec(FieldType.Char, "LastFragment");
        public static readonly FieldSpec AvgPxIndicator = new FieldSpec(FieldType.Int, "AvgPxIndicator");
        public static readonly FieldSpec ClearingBusinessDate = new FieldSpec(FieldType.HashedSlice8, "ClearingBusinessDate");
        public static readonly FieldSpec TrdType = new FieldSpec(FieldType.Int, "TrdType");
        public static readonly FieldSpec TrdSubType = new FieldSpec(FieldType.Int, "TrdSubType");
        public static readonly FieldSpec CustOrderCapacity = new FieldSpec(FieldType.Int, "CustOrderCapacity");
        public static readonly FieldSpec TradeInputSource = new FieldSpec(FieldType.HashedSlice8, "TradeInputSource");
        public static readonly FieldSpec MultiLegReportingType = new FieldSpec(FieldType.Char, "MultiLegReportingType");
        public static readonly FieldSpec MessageEventSource = new FieldSpec(FieldType.HashedSlice8, "MessageEventSource");
        public static readonly FieldSpec RndPx = new FieldSpec(FieldType.Float, "RndPx");
        public static readonly FieldSpec AllocStatus = new FieldSpec(FieldType.Int, "AllocStatus");
        public static readonly FieldSpec CustOrderHandlingInst = new FieldSpec(FieldType.HashedSlice8, "CustOrderHandlingInst");
        public static readonly FieldSpec OrderHandlingInstSource = new FieldSpec(FieldType.Int, "OrderHandlingInstSource");
        public static readonly FieldSpec HighPx = new FieldSpec(FieldType.Float, "HighPx");
        public static readonly FieldSpec LowPx = new FieldSpec(FieldType.Float, "LowPx");
        public static readonly FieldSpec[] Schema = new FieldSpec[]
        {
            AllocID,
            AllocTransType,
            AllocType,
            SecondaryAllocID,
            RefAllocID,
            AllocCancReplaceReason,
            AllocIntermedReqType,
            AllocLinkID,
            AllocLinkType,
            BookingRefID,
            AllocNoOrdersType,
            PreviouslyReported,
            ReversalIndicator,
            MatchType,
            Side,
            Quantity,
            QtyType,
            LastMkt,
            TradeOriginationDate,
            TradingSessionID,
            TradingSessionSubID,
            PriceType,
            AvgPx,
            AvgParPx,
            Currency,
            AvgPxPrecision,
            TradeDate,
            TransactTime,
            SettlType,
            SettlDate,
            BookingType,
            GrossTradeAmt,
            Concession,
            TotalTakedown,
            NetMoney,
            PositionEffect,
            AutoAcceptIndicator,
            Text,
            EncodedTextLen,
            EncodedText,
            NumDaysInterest,
            AccruedInterestRate,
            AccruedInterestAmt,
            TotalAccruedInterestAmt,
            InterestAtMaturity,
            EndAccruedInterestAmt,
            StartCash,
            EndCash,
            LegalConfirm,
            TotNoAllocs,
            LastFragment,
            AvgPxIndicator,
            ClearingBusinessDate,
            TrdType,
            TrdSubType,
            CustOrderCapacity,
            TradeInputSource,
            MultiLegReportingType,
            MessageEventSource,
            RndPx,
            AllocStatus,
            CustOrderHandlingInst,
            OrderHandlingInstSource,
            HighPx,
            LowPx,
        };
        public static FieldSpec GetFieldSpec(int tag)
        {
            return tag switch
            {
                70 => AllocID,
                71 => AllocTransType,
                626 => AllocType,
                793 => SecondaryAllocID,
                72 => RefAllocID,
                796 => AllocCancReplaceReason,
                808 => AllocIntermedReqType,
                196 => AllocLinkID,
                197 => AllocLinkType,
                466 => BookingRefID,
                857 => AllocNoOrdersType,
                570 => PreviouslyReported,
                700 => ReversalIndicator,
                574 => MatchType,
                54 => Side,
                53 => Quantity,
                854 => QtyType,
                30 => LastMkt,
                229 => TradeOriginationDate,
                336 => TradingSessionID,
                625 => TradingSessionSubID,
                423 => PriceType,
                6 => AvgPx,
                860 => AvgParPx,
                15 => Currency,
                74 => AvgPxPrecision,
                75 => TradeDate,
                60 => TransactTime,
                63 => SettlType,
                64 => SettlDate,
                775 => BookingType,
                381 => GrossTradeAmt,
                238 => Concession,
                237 => TotalTakedown,
                118 => NetMoney,
                77 => PositionEffect,
                754 => AutoAcceptIndicator,
                58 => Text,
                354 => EncodedTextLen,
                355 => EncodedText,
                157 => NumDaysInterest,
                158 => AccruedInterestRate,
                159 => AccruedInterestAmt,
                540 => TotalAccruedInterestAmt,
                738 => InterestAtMaturity,
                920 => EndAccruedInterestAmt,
                921 => StartCash,
                922 => EndCash,
                650 => LegalConfirm,
                892 => TotNoAllocs,
                893 => LastFragment,
                819 => AvgPxIndicator,
                715 => ClearingBusinessDate,
                828 => TrdType,
                829 => TrdSubType,
                582 => CustOrderCapacity,
                578 => TradeInputSource,
                442 => MultiLegReportingType,
                1011 => MessageEventSource,
                991 => RndPx,
                87 => AllocStatus,
                1031 => CustOrderHandlingInst,
                1032 => OrderHandlingInstSource,
                332 => HighPx,
                333 => LowPx,
                _ => throw new ArgumentException($"Invalid tag value {tag}")
            };
        }
    }
}

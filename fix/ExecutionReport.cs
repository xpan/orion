using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class ExecutionReport
    {
        public static readonly FieldSpec OrderID = new FieldSpec(FieldType.HashedSlice8, "OrderID");
        public static readonly FieldSpec SecondaryOrderID = new FieldSpec(FieldType.HashedSlice8, "SecondaryOrderID");
        public static readonly FieldSpec SecondaryClOrdID = new FieldSpec(FieldType.HashedSlice8, "SecondaryClOrdID");
        public static readonly FieldSpec SecondaryExecID = new FieldSpec(FieldType.HashedSlice8, "SecondaryExecID");
        public static readonly FieldSpec ClOrdID = new FieldSpec(FieldType.HashedSlice8, "ClOrdID");
        public static readonly FieldSpec OrigClOrdID = new FieldSpec(FieldType.HashedSlice8, "OrigClOrdID");
        public static readonly FieldSpec ClOrdLinkID = new FieldSpec(FieldType.HashedSlice8, "ClOrdLinkID");
        public static readonly FieldSpec QuoteRespID = new FieldSpec(FieldType.HashedSlice8, "QuoteRespID");
        public static readonly FieldSpec OrdStatusReqID = new FieldSpec(FieldType.HashedSlice8, "OrdStatusReqID");
        public static readonly FieldSpec MassStatusReqID = new FieldSpec(FieldType.HashedSlice8, "MassStatusReqID");
        public static readonly FieldSpec HostCrossID = new FieldSpec(FieldType.HashedSlice8, "HostCrossID");
        public static readonly FieldSpec TotNumReports = new FieldSpec(FieldType.Int, "TotNumReports");
        public static readonly FieldSpec LastRptRequested = new FieldSpec(FieldType.Char, "LastRptRequested");
        public static readonly FieldSpec TradeOriginationDate = new FieldSpec(FieldType.HashedSlice8, "TradeOriginationDate");
        public static readonly FieldSpec ListID = new FieldSpec(FieldType.HashedSlice8, "ListID");
        public static readonly FieldSpec CrossID = new FieldSpec(FieldType.HashedSlice8, "CrossID");
        public static readonly FieldSpec OrigCrossID = new FieldSpec(FieldType.HashedSlice8, "OrigCrossID");
        public static readonly FieldSpec CrossType = new FieldSpec(FieldType.Int, "CrossType");
        public static readonly FieldSpec TrdMatchID = new FieldSpec(FieldType.HashedSlice8, "TrdMatchID");
        public static readonly FieldSpec ExecID = new FieldSpec(FieldType.HashedSlice8, "ExecID");
        public static readonly FieldSpec ExecRefID = new FieldSpec(FieldType.HashedSlice8, "ExecRefID");
        public static readonly FieldSpec ExecType = new FieldSpec(FieldType.Char, "ExecType");
        public static readonly FieldSpec OrdStatus = new FieldSpec(FieldType.Char, "OrdStatus");
        public static readonly FieldSpec WorkingIndicator = new FieldSpec(FieldType.Char, "WorkingIndicator");
        public static readonly FieldSpec OrdRejReason = new FieldSpec(FieldType.Int, "OrdRejReason");
        public static readonly FieldSpec ExecRestatementReason = new FieldSpec(FieldType.Int, "ExecRestatementReason");
        public static readonly FieldSpec Account = new FieldSpec(FieldType.HashedSlice8, "Account");
        public static readonly FieldSpec AcctIDSource = new FieldSpec(FieldType.Int, "AcctIDSource");
        public static readonly FieldSpec AccountType = new FieldSpec(FieldType.Int, "AccountType");
        public static readonly FieldSpec DayBookingInst = new FieldSpec(FieldType.Char, "DayBookingInst");
        public static readonly FieldSpec BookingUnit = new FieldSpec(FieldType.Char, "BookingUnit");
        public static readonly FieldSpec PreallocMethod = new FieldSpec(FieldType.Char, "PreallocMethod");
        public static readonly FieldSpec AllocID = new FieldSpec(FieldType.HashedSlice8, "AllocID");
        public static readonly FieldSpec SettlType = new FieldSpec(FieldType.HashedSlice8, "SettlType");
        public static readonly FieldSpec SettlDate = new FieldSpec(FieldType.HashedSlice8, "SettlDate");
        public static readonly FieldSpec MatchType = new FieldSpec(FieldType.HashedSlice8, "MatchType");
        public static readonly FieldSpec OrderCategory = new FieldSpec(FieldType.Char, "OrderCategory");
        public static readonly FieldSpec CashMargin = new FieldSpec(FieldType.Char, "CashMargin");
        public static readonly FieldSpec ClearingFeeIndicator = new FieldSpec(FieldType.HashedSlice8, "ClearingFeeIndicator");
        public static readonly FieldSpec Side = new FieldSpec(FieldType.Char, "Side");
        public static readonly FieldSpec QtyType = new FieldSpec(FieldType.Int, "QtyType");
        public static readonly FieldSpec LotType = new FieldSpec(FieldType.Char, "LotType");
        public static readonly FieldSpec OrdType = new FieldSpec(FieldType.Char, "OrdType");
        public static readonly FieldSpec PriceType = new FieldSpec(FieldType.Int, "PriceType");
        public static readonly FieldSpec Price = new FieldSpec(FieldType.Float, "Price");
        public static readonly FieldSpec PriceProtectionScope = new FieldSpec(FieldType.Char, "PriceProtectionScope");
        public static readonly FieldSpec StopPx = new FieldSpec(FieldType.Float, "StopPx");
        public static readonly FieldSpec PeggedPrice = new FieldSpec(FieldType.Float, "PeggedPrice");
        public static readonly FieldSpec PeggedRefPrice = new FieldSpec(FieldType.Float, "PeggedRefPrice");
        public static readonly FieldSpec DiscretionPrice = new FieldSpec(FieldType.Float, "DiscretionPrice");
        public static readonly FieldSpec TargetStrategy = new FieldSpec(FieldType.Int, "TargetStrategy");
        public static readonly FieldSpec TargetStrategyParameters = new FieldSpec(FieldType.HashedSlice8, "TargetStrategyParameters");
        public static readonly FieldSpec ParticipationRate = new FieldSpec(FieldType.Float, "ParticipationRate");
        public static readonly FieldSpec TargetStrategyPerformance = new FieldSpec(FieldType.Float, "TargetStrategyPerformance");
        public static readonly FieldSpec Currency = new FieldSpec(FieldType.HashedSlice8, "Currency");
        public static readonly FieldSpec ComplianceID = new FieldSpec(FieldType.HashedSlice8, "ComplianceID");
        public static readonly FieldSpec SolicitedFlag = new FieldSpec(FieldType.Char, "SolicitedFlag");
        public static readonly FieldSpec TimeInForce = new FieldSpec(FieldType.Char, "TimeInForce");
        public static readonly FieldSpec EffectiveTime = new FieldSpec(FieldType.HashedSlice8, "EffectiveTime");
        public static readonly FieldSpec ExpireDate = new FieldSpec(FieldType.HashedSlice8, "ExpireDate");
        public static readonly FieldSpec ExpireTime = new FieldSpec(FieldType.HashedSlice8, "ExpireTime");
        public static readonly FieldSpec ExecInst = new FieldSpec(FieldType.HashedSlice8, "ExecInst");
        public static readonly FieldSpec AggressorIndicator = new FieldSpec(FieldType.Char, "AggressorIndicator");
        public static readonly FieldSpec OrderCapacity = new FieldSpec(FieldType.Char, "OrderCapacity");
        public static readonly FieldSpec OrderRestrictions = new FieldSpec(FieldType.HashedSlice8, "OrderRestrictions");
        public static readonly FieldSpec PreTradeAnonymity = new FieldSpec(FieldType.Char, "PreTradeAnonymity");
        public static readonly FieldSpec CustOrderCapacity = new FieldSpec(FieldType.Int, "CustOrderCapacity");
        public static readonly FieldSpec LastQty = new FieldSpec(FieldType.Float, "LastQty");
        public static readonly FieldSpec CalculatedCcyLastQty = new FieldSpec(FieldType.Float, "CalculatedCcyLastQty");
        public static readonly FieldSpec LastSwapPoints = new FieldSpec(FieldType.Float, "LastSwapPoints");
        public static readonly FieldSpec UnderlyingLastQty = new FieldSpec(FieldType.Float, "UnderlyingLastQty");
        public static readonly FieldSpec LastPx = new FieldSpec(FieldType.Float, "LastPx");
        public static readonly FieldSpec UnderlyingLastPx = new FieldSpec(FieldType.Float, "UnderlyingLastPx");
        public static readonly FieldSpec LastParPx = new FieldSpec(FieldType.Float, "LastParPx");
        public static readonly FieldSpec LastSpotRate = new FieldSpec(FieldType.Float, "LastSpotRate");
        public static readonly FieldSpec LastForwardPoints = new FieldSpec(FieldType.Float, "LastForwardPoints");
        public static readonly FieldSpec LastMkt = new FieldSpec(FieldType.HashedSlice8, "LastMkt");
        public static readonly FieldSpec TradingSessionID = new FieldSpec(FieldType.HashedSlice8, "TradingSessionID");
        public static readonly FieldSpec TradingSessionSubID = new FieldSpec(FieldType.HashedSlice8, "TradingSessionSubID");
        public static readonly FieldSpec TimeBracket = new FieldSpec(FieldType.HashedSlice8, "TimeBracket");
        public static readonly FieldSpec LastCapacity = new FieldSpec(FieldType.Char, "LastCapacity");
        public static readonly FieldSpec LeavesQty = new FieldSpec(FieldType.Float, "LeavesQty");
        public static readonly FieldSpec CumQty = new FieldSpec(FieldType.Float, "CumQty");
        public static readonly FieldSpec AvgPx = new FieldSpec(FieldType.Float, "AvgPx");
        public static readonly FieldSpec DayOrderQty = new FieldSpec(FieldType.Float, "DayOrderQty");
        public static readonly FieldSpec DayCumQty = new FieldSpec(FieldType.Float, "DayCumQty");
        public static readonly FieldSpec DayAvgPx = new FieldSpec(FieldType.Float, "DayAvgPx");
        public static readonly FieldSpec LastFragment = new FieldSpec(FieldType.Char, "LastFragment");
        public static readonly FieldSpec GTBookingInst = new FieldSpec(FieldType.Int, "GTBookingInst");
        public static readonly FieldSpec TradeDate = new FieldSpec(FieldType.HashedSlice8, "TradeDate");
        public static readonly FieldSpec TransactTime = new FieldSpec(FieldType.HashedSlice8, "TransactTime");
        public static readonly FieldSpec ReportToExch = new FieldSpec(FieldType.Char, "ReportToExch");
        public static readonly FieldSpec GrossTradeAmt = new FieldSpec(FieldType.Float, "GrossTradeAmt");
        public static readonly FieldSpec NumDaysInterest = new FieldSpec(FieldType.Int, "NumDaysInterest");
        public static readonly FieldSpec ExDate = new FieldSpec(FieldType.HashedSlice8, "ExDate");
        public static readonly FieldSpec AccruedInterestRate = new FieldSpec(FieldType.Float, "AccruedInterestRate");
        public static readonly FieldSpec AccruedInterestAmt = new FieldSpec(FieldType.Float, "AccruedInterestAmt");
        public static readonly FieldSpec InterestAtMaturity = new FieldSpec(FieldType.Float, "InterestAtMaturity");
        public static readonly FieldSpec EndAccruedInterestAmt = new FieldSpec(FieldType.Float, "EndAccruedInterestAmt");
        public static readonly FieldSpec StartCash = new FieldSpec(FieldType.Float, "StartCash");
        public static readonly FieldSpec EndCash = new FieldSpec(FieldType.Float, "EndCash");
        public static readonly FieldSpec TradedFlatSwitch = new FieldSpec(FieldType.Char, "TradedFlatSwitch");
        public static readonly FieldSpec BasisFeatureDate = new FieldSpec(FieldType.HashedSlice8, "BasisFeatureDate");
        public static readonly FieldSpec BasisFeaturePrice = new FieldSpec(FieldType.Float, "BasisFeaturePrice");
        public static readonly FieldSpec Concession = new FieldSpec(FieldType.Float, "Concession");
        public static readonly FieldSpec TotalTakedown = new FieldSpec(FieldType.Float, "TotalTakedown");
        public static readonly FieldSpec NetMoney = new FieldSpec(FieldType.Float, "NetMoney");
        public static readonly FieldSpec SettlCurrAmt = new FieldSpec(FieldType.Float, "SettlCurrAmt");
        public static readonly FieldSpec SettlCurrency = new FieldSpec(FieldType.HashedSlice8, "SettlCurrency");
        public static readonly FieldSpec SettlCurrFxRate = new FieldSpec(FieldType.Float, "SettlCurrFxRate");
        public static readonly FieldSpec SettlCurrFxRateCalc = new FieldSpec(FieldType.Char, "SettlCurrFxRateCalc");
        public static readonly FieldSpec HandlInst = new FieldSpec(FieldType.Char, "HandlInst");
        public static readonly FieldSpec MinQty = new FieldSpec(FieldType.Float, "MinQty");
        public static readonly FieldSpec MatchIncrement = new FieldSpec(FieldType.Float, "MatchIncrement");
        public static readonly FieldSpec MaxPriceLevels = new FieldSpec(FieldType.Int, "MaxPriceLevels");
        public static readonly FieldSpec MaxFloor = new FieldSpec(FieldType.Float, "MaxFloor");
        public static readonly FieldSpec PositionEffect = new FieldSpec(FieldType.Char, "PositionEffect");
        public static readonly FieldSpec MaxShow = new FieldSpec(FieldType.Float, "MaxShow");
        public static readonly FieldSpec BookingType = new FieldSpec(FieldType.Int, "BookingType");
        public static readonly FieldSpec Text = new FieldSpec(FieldType.HashedSlice8, "Text");
        public static readonly FieldSpec EncodedTextLen = new FieldSpec(FieldType.Int, "EncodedTextLen");
        public static readonly FieldSpec EncodedText = new FieldSpec(FieldType.HashedSlice8, "EncodedText");
        public static readonly FieldSpec SettlDate2 = new FieldSpec(FieldType.HashedSlice8, "SettlDate2");
        public static readonly FieldSpec OrderQty2 = new FieldSpec(FieldType.Float, "OrderQty2");
        public static readonly FieldSpec LastForwardPoints2 = new FieldSpec(FieldType.Float, "LastForwardPoints2");
        public static readonly FieldSpec MultiLegReportingType = new FieldSpec(FieldType.Char, "MultiLegReportingType");
        public static readonly FieldSpec CancellationRights = new FieldSpec(FieldType.Char, "CancellationRights");
        public static readonly FieldSpec MoneyLaunderingStatus = new FieldSpec(FieldType.Char, "MoneyLaunderingStatus");
        public static readonly FieldSpec RegistID = new FieldSpec(FieldType.HashedSlice8, "RegistID");
        public static readonly FieldSpec Designation = new FieldSpec(FieldType.HashedSlice8, "Designation");
        public static readonly FieldSpec TransBkdTime = new FieldSpec(FieldType.HashedSlice8, "TransBkdTime");
        public static readonly FieldSpec ExecValuationPoint = new FieldSpec(FieldType.HashedSlice8, "ExecValuationPoint");
        public static readonly FieldSpec ExecPriceType = new FieldSpec(FieldType.Char, "ExecPriceType");
        public static readonly FieldSpec ExecPriceAdjustment = new FieldSpec(FieldType.Float, "ExecPriceAdjustment");
        public static readonly FieldSpec PriorityIndicator = new FieldSpec(FieldType.Int, "PriorityIndicator");
        public static readonly FieldSpec PriceImprovement = new FieldSpec(FieldType.Float, "PriceImprovement");
        public static readonly FieldSpec LastLiquidityInd = new FieldSpec(FieldType.Int, "LastLiquidityInd");
        public static readonly FieldSpec CopyMsgIndicator = new FieldSpec(FieldType.Char, "CopyMsgIndicator");
        public static readonly FieldSpec ManualOrderIndicator = new FieldSpec(FieldType.Char, "ManualOrderIndicator");
        public static readonly FieldSpec CustDirectedOrder = new FieldSpec(FieldType.Char, "CustDirectedOrder");
        public static readonly FieldSpec ReceivedDeptID = new FieldSpec(FieldType.HashedSlice8, "ReceivedDeptID");
        public static readonly FieldSpec CustOrderHandlingInst = new FieldSpec(FieldType.HashedSlice8, "CustOrderHandlingInst");
        public static readonly FieldSpec OrderHandlingInstSource = new FieldSpec(FieldType.Int, "OrderHandlingInstSource");
        public static readonly FieldSpec PriceDelta = new FieldSpec(FieldType.Float, "PriceDelta");
        public static readonly FieldSpec ExDestination = new FieldSpec(FieldType.HashedSlice8, "ExDestination");
        public static readonly FieldSpec ExDestinationIDSource = new FieldSpec(FieldType.Char, "ExDestinationIDSource");
        public static readonly FieldSpec MDEntryID = new FieldSpec(FieldType.HashedSlice8, "MDEntryID");
        public static readonly FieldSpec RefOrderID = new FieldSpec(FieldType.HashedSlice8, "RefOrderID");
        public static readonly FieldSpec RefOrderIDSource = new FieldSpec(FieldType.Char, "RefOrderIDSource");
        public static readonly FieldSpec OwnerType = new FieldSpec(FieldType.Int, "OwnerType");
        public static readonly FieldSpec MidPx = new FieldSpec(FieldType.Float, "MidPx");
        public static readonly FieldSpec TrdType = new FieldSpec(FieldType.Int, "TrdType");
        public static readonly FieldSpec CxlQty = new FieldSpec(FieldType.Float, "CxlQty");
        public static readonly FieldSpec TrdSubType = new FieldSpec(FieldType.Int, "TrdSubType");
        public static readonly FieldSpec SecondaryTrdType = new FieldSpec(FieldType.Int, "SecondaryTrdType");
        public static readonly FieldSpec PreviouslyReported = new FieldSpec(FieldType.Char, "PreviouslyReported");
        public static readonly FieldSpec[] Schema = new FieldSpec[]
        {
            OrderID,
            SecondaryOrderID,
            SecondaryClOrdID,
            SecondaryExecID,
            ClOrdID,
            OrigClOrdID,
            ClOrdLinkID,
            QuoteRespID,
            OrdStatusReqID,
            MassStatusReqID,
            HostCrossID,
            TotNumReports,
            LastRptRequested,
            TradeOriginationDate,
            ListID,
            CrossID,
            OrigCrossID,
            CrossType,
            TrdMatchID,
            ExecID,
            ExecRefID,
            ExecType,
            OrdStatus,
            WorkingIndicator,
            OrdRejReason,
            ExecRestatementReason,
            Account,
            AcctIDSource,
            AccountType,
            DayBookingInst,
            BookingUnit,
            PreallocMethod,
            AllocID,
            SettlType,
            SettlDate,
            MatchType,
            OrderCategory,
            CashMargin,
            ClearingFeeIndicator,
            Side,
            QtyType,
            LotType,
            OrdType,
            PriceType,
            Price,
            PriceProtectionScope,
            StopPx,
            PeggedPrice,
            PeggedRefPrice,
            DiscretionPrice,
            TargetStrategy,
            TargetStrategyParameters,
            ParticipationRate,
            TargetStrategyPerformance,
            Currency,
            ComplianceID,
            SolicitedFlag,
            TimeInForce,
            EffectiveTime,
            ExpireDate,
            ExpireTime,
            ExecInst,
            AggressorIndicator,
            OrderCapacity,
            OrderRestrictions,
            PreTradeAnonymity,
            CustOrderCapacity,
            LastQty,
            CalculatedCcyLastQty,
            LastSwapPoints,
            UnderlyingLastQty,
            LastPx,
            UnderlyingLastPx,
            LastParPx,
            LastSpotRate,
            LastForwardPoints,
            LastMkt,
            TradingSessionID,
            TradingSessionSubID,
            TimeBracket,
            LastCapacity,
            LeavesQty,
            CumQty,
            AvgPx,
            DayOrderQty,
            DayCumQty,
            DayAvgPx,
            LastFragment,
            GTBookingInst,
            TradeDate,
            TransactTime,
            ReportToExch,
            GrossTradeAmt,
            NumDaysInterest,
            ExDate,
            AccruedInterestRate,
            AccruedInterestAmt,
            InterestAtMaturity,
            EndAccruedInterestAmt,
            StartCash,
            EndCash,
            TradedFlatSwitch,
            BasisFeatureDate,
            BasisFeaturePrice,
            Concession,
            TotalTakedown,
            NetMoney,
            SettlCurrAmt,
            SettlCurrency,
            SettlCurrFxRate,
            SettlCurrFxRateCalc,
            HandlInst,
            MinQty,
            MatchIncrement,
            MaxPriceLevels,
            MaxFloor,
            PositionEffect,
            MaxShow,
            BookingType,
            Text,
            EncodedTextLen,
            EncodedText,
            SettlDate2,
            OrderQty2,
            LastForwardPoints2,
            MultiLegReportingType,
            CancellationRights,
            MoneyLaunderingStatus,
            RegistID,
            Designation,
            TransBkdTime,
            ExecValuationPoint,
            ExecPriceType,
            ExecPriceAdjustment,
            PriorityIndicator,
            PriceImprovement,
            LastLiquidityInd,
            CopyMsgIndicator,
            ManualOrderIndicator,
            CustDirectedOrder,
            ReceivedDeptID,
            CustOrderHandlingInst,
            OrderHandlingInstSource,
            PriceDelta,
            ExDestination,
            ExDestinationIDSource,
            MDEntryID,
            RefOrderID,
            RefOrderIDSource,
            OwnerType,
            MidPx,
            TrdType,
            CxlQty,
            TrdSubType,
            SecondaryTrdType,
            PreviouslyReported,
        };
        public static FieldSpec GetFieldSpec(int tag)
        {
            return tag switch
            {
                37 => OrderID,
                198 => SecondaryOrderID,
                526 => SecondaryClOrdID,
                527 => SecondaryExecID,
                11 => ClOrdID,
                41 => OrigClOrdID,
                583 => ClOrdLinkID,
                693 => QuoteRespID,
                790 => OrdStatusReqID,
                584 => MassStatusReqID,
                961 => HostCrossID,
                911 => TotNumReports,
                912 => LastRptRequested,
                229 => TradeOriginationDate,
                66 => ListID,
                548 => CrossID,
                551 => OrigCrossID,
                549 => CrossType,
                880 => TrdMatchID,
                17 => ExecID,
                19 => ExecRefID,
                150 => ExecType,
                39 => OrdStatus,
                636 => WorkingIndicator,
                103 => OrdRejReason,
                378 => ExecRestatementReason,
                1 => Account,
                660 => AcctIDSource,
                581 => AccountType,
                589 => DayBookingInst,
                590 => BookingUnit,
                591 => PreallocMethod,
                70 => AllocID,
                63 => SettlType,
                64 => SettlDate,
                574 => MatchType,
                1115 => OrderCategory,
                544 => CashMargin,
                635 => ClearingFeeIndicator,
                54 => Side,
                854 => QtyType,
                1093 => LotType,
                40 => OrdType,
                423 => PriceType,
                44 => Price,
                1092 => PriceProtectionScope,
                99 => StopPx,
                839 => PeggedPrice,
                1095 => PeggedRefPrice,
                845 => DiscretionPrice,
                847 => TargetStrategy,
                848 => TargetStrategyParameters,
                849 => ParticipationRate,
                850 => TargetStrategyPerformance,
                15 => Currency,
                376 => ComplianceID,
                377 => SolicitedFlag,
                59 => TimeInForce,
                168 => EffectiveTime,
                432 => ExpireDate,
                126 => ExpireTime,
                18 => ExecInst,
                1057 => AggressorIndicator,
                528 => OrderCapacity,
                529 => OrderRestrictions,
                1091 => PreTradeAnonymity,
                582 => CustOrderCapacity,
                32 => LastQty,
                1056 => CalculatedCcyLastQty,
                1071 => LastSwapPoints,
                652 => UnderlyingLastQty,
                31 => LastPx,
                651 => UnderlyingLastPx,
                669 => LastParPx,
                194 => LastSpotRate,
                195 => LastForwardPoints,
                30 => LastMkt,
                336 => TradingSessionID,
                625 => TradingSessionSubID,
                943 => TimeBracket,
                29 => LastCapacity,
                151 => LeavesQty,
                14 => CumQty,
                6 => AvgPx,
                424 => DayOrderQty,
                425 => DayCumQty,
                426 => DayAvgPx,
                893 => LastFragment,
                427 => GTBookingInst,
                75 => TradeDate,
                60 => TransactTime,
                113 => ReportToExch,
                381 => GrossTradeAmt,
                157 => NumDaysInterest,
                230 => ExDate,
                158 => AccruedInterestRate,
                159 => AccruedInterestAmt,
                738 => InterestAtMaturity,
                920 => EndAccruedInterestAmt,
                921 => StartCash,
                922 => EndCash,
                258 => TradedFlatSwitch,
                259 => BasisFeatureDate,
                260 => BasisFeaturePrice,
                238 => Concession,
                237 => TotalTakedown,
                118 => NetMoney,
                119 => SettlCurrAmt,
                120 => SettlCurrency,
                155 => SettlCurrFxRate,
                156 => SettlCurrFxRateCalc,
                21 => HandlInst,
                110 => MinQty,
                1089 => MatchIncrement,
                1090 => MaxPriceLevels,
                111 => MaxFloor,
                77 => PositionEffect,
                210 => MaxShow,
                775 => BookingType,
                58 => Text,
                354 => EncodedTextLen,
                355 => EncodedText,
                193 => SettlDate2,
                192 => OrderQty2,
                641 => LastForwardPoints2,
                442 => MultiLegReportingType,
                480 => CancellationRights,
                481 => MoneyLaunderingStatus,
                513 => RegistID,
                494 => Designation,
                483 => TransBkdTime,
                515 => ExecValuationPoint,
                484 => ExecPriceType,
                485 => ExecPriceAdjustment,
                638 => PriorityIndicator,
                639 => PriceImprovement,
                851 => LastLiquidityInd,
                797 => CopyMsgIndicator,
                1028 => ManualOrderIndicator,
                1029 => CustDirectedOrder,
                1030 => ReceivedDeptID,
                1031 => CustOrderHandlingInst,
                1032 => OrderHandlingInstSource,
                811 => PriceDelta,
                100 => ExDestination,
                1133 => ExDestinationIDSource,
                278 => MDEntryID,
                1080 => RefOrderID,
                1081 => RefOrderIDSource,
                522 => OwnerType,
                631 => MidPx,
                828 => TrdType,
                84 => CxlQty,
                829 => TrdSubType,
                855 => SecondaryTrdType,
                570 => PreviouslyReported,
                _ => throw new ArgumentException($"Invalid tag value {tag}")
            };
        }
    }
}

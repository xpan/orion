using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class OrderCancelReplaceRequest
    {
        public static readonly FieldSpec OrderID = new FieldSpec(FieldType.HashedSlice8, "OrderID");
        public static readonly FieldSpec TradeOriginationDate = new FieldSpec(FieldType.HashedSlice8, "TradeOriginationDate");
        public static readonly FieldSpec TradeDate = new FieldSpec(FieldType.HashedSlice8, "TradeDate");
        public static readonly FieldSpec OrigClOrdID = new FieldSpec(FieldType.HashedSlice8, "OrigClOrdID");
        public static readonly FieldSpec ClOrdID = new FieldSpec(FieldType.HashedSlice8, "ClOrdID");
        public static readonly FieldSpec SecondaryClOrdID = new FieldSpec(FieldType.HashedSlice8, "SecondaryClOrdID");
        public static readonly FieldSpec ClOrdLinkID = new FieldSpec(FieldType.HashedSlice8, "ClOrdLinkID");
        public static readonly FieldSpec ListID = new FieldSpec(FieldType.HashedSlice8, "ListID");
        public static readonly FieldSpec OrigOrdModTime = new FieldSpec(FieldType.HashedSlice8, "OrigOrdModTime");
        public static readonly FieldSpec Account = new FieldSpec(FieldType.HashedSlice8, "Account");
        public static readonly FieldSpec AcctIDSource = new FieldSpec(FieldType.Int, "AcctIDSource");
        public static readonly FieldSpec AccountType = new FieldSpec(FieldType.Int, "AccountType");
        public static readonly FieldSpec DayBookingInst = new FieldSpec(FieldType.Char, "DayBookingInst");
        public static readonly FieldSpec BookingUnit = new FieldSpec(FieldType.Char, "BookingUnit");
        public static readonly FieldSpec PreallocMethod = new FieldSpec(FieldType.Char, "PreallocMethod");
        public static readonly FieldSpec AllocID = new FieldSpec(FieldType.HashedSlice8, "AllocID");
        public static readonly FieldSpec SettlType = new FieldSpec(FieldType.HashedSlice8, "SettlType");
        public static readonly FieldSpec SettlDate = new FieldSpec(FieldType.HashedSlice8, "SettlDate");
        public static readonly FieldSpec CashMargin = new FieldSpec(FieldType.Char, "CashMargin");
        public static readonly FieldSpec ClearingFeeIndicator = new FieldSpec(FieldType.HashedSlice8, "ClearingFeeIndicator");
        public static readonly FieldSpec HandlInst = new FieldSpec(FieldType.Char, "HandlInst");
        public static readonly FieldSpec ExecInst = new FieldSpec(FieldType.HashedSlice8, "ExecInst");
        public static readonly FieldSpec MinQty = new FieldSpec(FieldType.Float, "MinQty");
        public static readonly FieldSpec MatchIncrement = new FieldSpec(FieldType.Float, "MatchIncrement");
        public static readonly FieldSpec MaxPriceLevels = new FieldSpec(FieldType.Int, "MaxPriceLevels");
        public static readonly FieldSpec MaxFloor = new FieldSpec(FieldType.Float, "MaxFloor");
        public static readonly FieldSpec ExDestination = new FieldSpec(FieldType.HashedSlice8, "ExDestination");
        public static readonly FieldSpec ExDestinationIDSource = new FieldSpec(FieldType.Char, "ExDestinationIDSource");
        public static readonly FieldSpec Side = new FieldSpec(FieldType.Char, "Side");
        public static readonly FieldSpec TransactTime = new FieldSpec(FieldType.HashedSlice8, "TransactTime");
        public static readonly FieldSpec QtyType = new FieldSpec(FieldType.Int, "QtyType");
        public static readonly FieldSpec OrdType = new FieldSpec(FieldType.Char, "OrdType");
        public static readonly FieldSpec PriceType = new FieldSpec(FieldType.Int, "PriceType");
        public static readonly FieldSpec Price = new FieldSpec(FieldType.Float, "Price");
        public static readonly FieldSpec PriceProtectionScope = new FieldSpec(FieldType.Char, "PriceProtectionScope");
        public static readonly FieldSpec StopPx = new FieldSpec(FieldType.Float, "StopPx");
        public static readonly FieldSpec TargetStrategy = new FieldSpec(FieldType.Int, "TargetStrategy");
        public static readonly FieldSpec TargetStrategyParameters = new FieldSpec(FieldType.HashedSlice8, "TargetStrategyParameters");
        public static readonly FieldSpec ParticipationRate = new FieldSpec(FieldType.Float, "ParticipationRate");
        public static readonly FieldSpec ComplianceID = new FieldSpec(FieldType.HashedSlice8, "ComplianceID");
        public static readonly FieldSpec SolicitedFlag = new FieldSpec(FieldType.Char, "SolicitedFlag");
        public static readonly FieldSpec Currency = new FieldSpec(FieldType.HashedSlice8, "Currency");
        public static readonly FieldSpec TimeInForce = new FieldSpec(FieldType.Char, "TimeInForce");
        public static readonly FieldSpec EffectiveTime = new FieldSpec(FieldType.HashedSlice8, "EffectiveTime");
        public static readonly FieldSpec ExpireDate = new FieldSpec(FieldType.HashedSlice8, "ExpireDate");
        public static readonly FieldSpec ExpireTime = new FieldSpec(FieldType.HashedSlice8, "ExpireTime");
        public static readonly FieldSpec GTBookingInst = new FieldSpec(FieldType.Int, "GTBookingInst");
        public static readonly FieldSpec OrderCapacity = new FieldSpec(FieldType.Char, "OrderCapacity");
        public static readonly FieldSpec OrderRestrictions = new FieldSpec(FieldType.HashedSlice8, "OrderRestrictions");
        public static readonly FieldSpec PreTradeAnonymity = new FieldSpec(FieldType.Char, "PreTradeAnonymity");
        public static readonly FieldSpec CustOrderCapacity = new FieldSpec(FieldType.Int, "CustOrderCapacity");
        public static readonly FieldSpec ForexReq = new FieldSpec(FieldType.Char, "ForexReq");
        public static readonly FieldSpec SettlCurrency = new FieldSpec(FieldType.HashedSlice8, "SettlCurrency");
        public static readonly FieldSpec BookingType = new FieldSpec(FieldType.Int, "BookingType");
        public static readonly FieldSpec Text = new FieldSpec(FieldType.HashedSlice8, "Text");
        public static readonly FieldSpec EncodedTextLen = new FieldSpec(FieldType.Int, "EncodedTextLen");
        public static readonly FieldSpec EncodedText = new FieldSpec(FieldType.HashedSlice8, "EncodedText");
        public static readonly FieldSpec SettlDate2 = new FieldSpec(FieldType.HashedSlice8, "SettlDate2");
        public static readonly FieldSpec OrderQty2 = new FieldSpec(FieldType.Float, "OrderQty2");
        public static readonly FieldSpec Price2 = new FieldSpec(FieldType.Float, "Price2");
        public static readonly FieldSpec PositionEffect = new FieldSpec(FieldType.Char, "PositionEffect");
        public static readonly FieldSpec CoveredOrUncovered = new FieldSpec(FieldType.Int, "CoveredOrUncovered");
        public static readonly FieldSpec MaxShow = new FieldSpec(FieldType.Float, "MaxShow");
        public static readonly FieldSpec LocateReqd = new FieldSpec(FieldType.Char, "LocateReqd");
        public static readonly FieldSpec CancellationRights = new FieldSpec(FieldType.Char, "CancellationRights");
        public static readonly FieldSpec MoneyLaunderingStatus = new FieldSpec(FieldType.Char, "MoneyLaunderingStatus");
        public static readonly FieldSpec RegistID = new FieldSpec(FieldType.HashedSlice8, "RegistID");
        public static readonly FieldSpec Designation = new FieldSpec(FieldType.HashedSlice8, "Designation");
        public static readonly FieldSpec ManualOrderIndicator = new FieldSpec(FieldType.Char, "ManualOrderIndicator");
        public static readonly FieldSpec CustDirectedOrder = new FieldSpec(FieldType.Char, "CustDirectedOrder");
        public static readonly FieldSpec ReceivedDeptID = new FieldSpec(FieldType.HashedSlice8, "ReceivedDeptID");
        public static readonly FieldSpec CustOrderHandlingInst = new FieldSpec(FieldType.HashedSlice8, "CustOrderHandlingInst");
        public static readonly FieldSpec OrderHandlingInstSource = new FieldSpec(FieldType.Int, "OrderHandlingInstSource");
        public static readonly FieldSpec OwnerType = new FieldSpec(FieldType.Int, "OwnerType");
        public static readonly FieldSpec[] Schema = new FieldSpec[]
        {
            OrderID,
            TradeOriginationDate,
            TradeDate,
            OrigClOrdID,
            ClOrdID,
            SecondaryClOrdID,
            ClOrdLinkID,
            ListID,
            OrigOrdModTime,
            Account,
            AcctIDSource,
            AccountType,
            DayBookingInst,
            BookingUnit,
            PreallocMethod,
            AllocID,
            SettlType,
            SettlDate,
            CashMargin,
            ClearingFeeIndicator,
            HandlInst,
            ExecInst,
            MinQty,
            MatchIncrement,
            MaxPriceLevels,
            MaxFloor,
            ExDestination,
            ExDestinationIDSource,
            Side,
            TransactTime,
            QtyType,
            OrdType,
            PriceType,
            Price,
            PriceProtectionScope,
            StopPx,
            TargetStrategy,
            TargetStrategyParameters,
            ParticipationRate,
            ComplianceID,
            SolicitedFlag,
            Currency,
            TimeInForce,
            EffectiveTime,
            ExpireDate,
            ExpireTime,
            GTBookingInst,
            OrderCapacity,
            OrderRestrictions,
            PreTradeAnonymity,
            CustOrderCapacity,
            ForexReq,
            SettlCurrency,
            BookingType,
            Text,
            EncodedTextLen,
            EncodedText,
            SettlDate2,
            OrderQty2,
            Price2,
            PositionEffect,
            CoveredOrUncovered,
            MaxShow,
            LocateReqd,
            CancellationRights,
            MoneyLaunderingStatus,
            RegistID,
            Designation,
            ManualOrderIndicator,
            CustDirectedOrder,
            ReceivedDeptID,
            CustOrderHandlingInst,
            OrderHandlingInstSource,
            OwnerType,
        };
        public static FieldSpec GetFieldSpec(int tag)
        {
            return tag switch
            {
                37 => OrderID,
                229 => TradeOriginationDate,
                75 => TradeDate,
                41 => OrigClOrdID,
                11 => ClOrdID,
                526 => SecondaryClOrdID,
                583 => ClOrdLinkID,
                66 => ListID,
                586 => OrigOrdModTime,
                1 => Account,
                660 => AcctIDSource,
                581 => AccountType,
                589 => DayBookingInst,
                590 => BookingUnit,
                591 => PreallocMethod,
                70 => AllocID,
                63 => SettlType,
                64 => SettlDate,
                544 => CashMargin,
                635 => ClearingFeeIndicator,
                21 => HandlInst,
                18 => ExecInst,
                110 => MinQty,
                1089 => MatchIncrement,
                1090 => MaxPriceLevels,
                111 => MaxFloor,
                100 => ExDestination,
                1133 => ExDestinationIDSource,
                54 => Side,
                60 => TransactTime,
                854 => QtyType,
                40 => OrdType,
                423 => PriceType,
                44 => Price,
                1092 => PriceProtectionScope,
                99 => StopPx,
                847 => TargetStrategy,
                848 => TargetStrategyParameters,
                849 => ParticipationRate,
                376 => ComplianceID,
                377 => SolicitedFlag,
                15 => Currency,
                59 => TimeInForce,
                168 => EffectiveTime,
                432 => ExpireDate,
                126 => ExpireTime,
                427 => GTBookingInst,
                528 => OrderCapacity,
                529 => OrderRestrictions,
                1091 => PreTradeAnonymity,
                582 => CustOrderCapacity,
                121 => ForexReq,
                120 => SettlCurrency,
                775 => BookingType,
                58 => Text,
                354 => EncodedTextLen,
                355 => EncodedText,
                193 => SettlDate2,
                192 => OrderQty2,
                640 => Price2,
                77 => PositionEffect,
                203 => CoveredOrUncovered,
                210 => MaxShow,
                114 => LocateReqd,
                480 => CancellationRights,
                481 => MoneyLaunderingStatus,
                513 => RegistID,
                494 => Designation,
                1028 => ManualOrderIndicator,
                1029 => CustDirectedOrder,
                1030 => ReceivedDeptID,
                1031 => CustOrderHandlingInst,
                1032 => OrderHandlingInstSource,
                522 => OwnerType,
                _ => throw new ArgumentException($"Invalid tag value {tag}")
            };
        }
    }
}

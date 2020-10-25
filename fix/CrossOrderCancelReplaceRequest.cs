using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class CrossOrderCancelReplaceRequest
    {
        public static readonly FieldSpec OrderID = new FieldSpec(FieldType.HashedSlice8, "OrderID");
        public static readonly FieldSpec CrossID = new FieldSpec(FieldType.HashedSlice8, "CrossID");
        public static readonly FieldSpec OrigCrossID = new FieldSpec(FieldType.HashedSlice8, "OrigCrossID");
        public static readonly FieldSpec HostCrossID = new FieldSpec(FieldType.HashedSlice8, "HostCrossID");
        public static readonly FieldSpec CrossType = new FieldSpec(FieldType.Int, "CrossType");
        public static readonly FieldSpec CrossPrioritization = new FieldSpec(FieldType.Int, "CrossPrioritization");
        public static readonly FieldSpec SettlType = new FieldSpec(FieldType.HashedSlice8, "SettlType");
        public static readonly FieldSpec SettlDate = new FieldSpec(FieldType.HashedSlice8, "SettlDate");
        public static readonly FieldSpec HandlInst = new FieldSpec(FieldType.Char, "HandlInst");
        public static readonly FieldSpec ExecInst = new FieldSpec(FieldType.HashedSlice8, "ExecInst");
        public static readonly FieldSpec MinQty = new FieldSpec(FieldType.Float, "MinQty");
        public static readonly FieldSpec MatchIncrement = new FieldSpec(FieldType.Float, "MatchIncrement");
        public static readonly FieldSpec MaxPriceLevels = new FieldSpec(FieldType.Int, "MaxPriceLevels");
        public static readonly FieldSpec MaxFloor = new FieldSpec(FieldType.Float, "MaxFloor");
        public static readonly FieldSpec ExDestination = new FieldSpec(FieldType.HashedSlice8, "ExDestination");
        public static readonly FieldSpec ExDestinationIDSource = new FieldSpec(FieldType.Char, "ExDestinationIDSource");
        public static readonly FieldSpec ProcessCode = new FieldSpec(FieldType.Char, "ProcessCode");
        public static readonly FieldSpec PrevClosePx = new FieldSpec(FieldType.Float, "PrevClosePx");
        public static readonly FieldSpec LocateReqd = new FieldSpec(FieldType.Char, "LocateReqd");
        public static readonly FieldSpec TransactTime = new FieldSpec(FieldType.HashedSlice8, "TransactTime");
        public static readonly FieldSpec TransBkdTime = new FieldSpec(FieldType.HashedSlice8, "TransBkdTime");
        public static readonly FieldSpec OrdType = new FieldSpec(FieldType.Char, "OrdType");
        public static readonly FieldSpec PriceType = new FieldSpec(FieldType.Int, "PriceType");
        public static readonly FieldSpec Price = new FieldSpec(FieldType.Float, "Price");
        public static readonly FieldSpec PriceProtectionScope = new FieldSpec(FieldType.Char, "PriceProtectionScope");
        public static readonly FieldSpec StopPx = new FieldSpec(FieldType.Float, "StopPx");
        public static readonly FieldSpec Currency = new FieldSpec(FieldType.HashedSlice8, "Currency");
        public static readonly FieldSpec ComplianceID = new FieldSpec(FieldType.HashedSlice8, "ComplianceID");
        public static readonly FieldSpec IOIID = new FieldSpec(FieldType.HashedSlice8, "IOIID");
        public static readonly FieldSpec QuoteID = new FieldSpec(FieldType.HashedSlice8, "QuoteID");
        public static readonly FieldSpec TimeInForce = new FieldSpec(FieldType.Char, "TimeInForce");
        public static readonly FieldSpec EffectiveTime = new FieldSpec(FieldType.HashedSlice8, "EffectiveTime");
        public static readonly FieldSpec ExpireDate = new FieldSpec(FieldType.HashedSlice8, "ExpireDate");
        public static readonly FieldSpec ExpireTime = new FieldSpec(FieldType.HashedSlice8, "ExpireTime");
        public static readonly FieldSpec GTBookingInst = new FieldSpec(FieldType.Int, "GTBookingInst");
        public static readonly FieldSpec MaxShow = new FieldSpec(FieldType.Float, "MaxShow");
        public static readonly FieldSpec TargetStrategy = new FieldSpec(FieldType.Int, "TargetStrategy");
        public static readonly FieldSpec TargetStrategyParameters = new FieldSpec(FieldType.HashedSlice8, "TargetStrategyParameters");
        public static readonly FieldSpec ParticipationRate = new FieldSpec(FieldType.Float, "ParticipationRate");
        public static readonly FieldSpec CancellationRights = new FieldSpec(FieldType.Char, "CancellationRights");
        public static readonly FieldSpec MoneyLaunderingStatus = new FieldSpec(FieldType.Char, "MoneyLaunderingStatus");
        public static readonly FieldSpec RegistID = new FieldSpec(FieldType.HashedSlice8, "RegistID");
        public static readonly FieldSpec Designation = new FieldSpec(FieldType.HashedSlice8, "Designation");
        public static readonly FieldSpec[] Schema = new FieldSpec[]
        {
            OrderID,
            CrossID,
            OrigCrossID,
            HostCrossID,
            CrossType,
            CrossPrioritization,
            SettlType,
            SettlDate,
            HandlInst,
            ExecInst,
            MinQty,
            MatchIncrement,
            MaxPriceLevels,
            MaxFloor,
            ExDestination,
            ExDestinationIDSource,
            ProcessCode,
            PrevClosePx,
            LocateReqd,
            TransactTime,
            TransBkdTime,
            OrdType,
            PriceType,
            Price,
            PriceProtectionScope,
            StopPx,
            Currency,
            ComplianceID,
            IOIID,
            QuoteID,
            TimeInForce,
            EffectiveTime,
            ExpireDate,
            ExpireTime,
            GTBookingInst,
            MaxShow,
            TargetStrategy,
            TargetStrategyParameters,
            ParticipationRate,
            CancellationRights,
            MoneyLaunderingStatus,
            RegistID,
            Designation,
        };
        public static FieldSpec GetFieldSpec(int tag)
        {
            return tag switch
            {
                37 => OrderID,
                548 => CrossID,
                551 => OrigCrossID,
                961 => HostCrossID,
                549 => CrossType,
                550 => CrossPrioritization,
                63 => SettlType,
                64 => SettlDate,
                21 => HandlInst,
                18 => ExecInst,
                110 => MinQty,
                1089 => MatchIncrement,
                1090 => MaxPriceLevels,
                111 => MaxFloor,
                100 => ExDestination,
                1133 => ExDestinationIDSource,
                81 => ProcessCode,
                140 => PrevClosePx,
                114 => LocateReqd,
                60 => TransactTime,
                483 => TransBkdTime,
                40 => OrdType,
                423 => PriceType,
                44 => Price,
                1092 => PriceProtectionScope,
                99 => StopPx,
                15 => Currency,
                376 => ComplianceID,
                23 => IOIID,
                117 => QuoteID,
                59 => TimeInForce,
                168 => EffectiveTime,
                432 => ExpireDate,
                126 => ExpireTime,
                427 => GTBookingInst,
                210 => MaxShow,
                847 => TargetStrategy,
                848 => TargetStrategyParameters,
                849 => ParticipationRate,
                480 => CancellationRights,
                481 => MoneyLaunderingStatus,
                513 => RegistID,
                494 => Designation,
                _ => throw new ArgumentException($"Invalid tag value {tag}")
            };
        }
    }
}

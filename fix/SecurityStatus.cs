using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class SecurityStatus
    {
        public static readonly FieldSpec SecurityStatusReqID = new FieldSpec(FieldType.HashedSlice8, "SecurityStatusReqID");
        public static readonly FieldSpec Currency = new FieldSpec(FieldType.HashedSlice8, "Currency");
        public static readonly FieldSpec TradingSessionID = new FieldSpec(FieldType.HashedSlice8, "TradingSessionID");
        public static readonly FieldSpec TradingSessionSubID = new FieldSpec(FieldType.HashedSlice8, "TradingSessionSubID");
        public static readonly FieldSpec UnsolicitedIndicator = new FieldSpec(FieldType.Char, "UnsolicitedIndicator");
        public static readonly FieldSpec SecurityTradingStatus = new FieldSpec(FieldType.Int, "SecurityTradingStatus");
        public static readonly FieldSpec FinancialStatus = new FieldSpec(FieldType.HashedSlice8, "FinancialStatus");
        public static readonly FieldSpec CorporateAction = new FieldSpec(FieldType.HashedSlice8, "CorporateAction");
        public static readonly FieldSpec HaltReason = new FieldSpec(FieldType.Int, "HaltReason");
        public static readonly FieldSpec InViewOfCommon = new FieldSpec(FieldType.Char, "InViewOfCommon");
        public static readonly FieldSpec DueToRelated = new FieldSpec(FieldType.Char, "DueToRelated");
        public static readonly FieldSpec MDBookType = new FieldSpec(FieldType.Int, "MDBookType");
        public static readonly FieldSpec MarketDepth = new FieldSpec(FieldType.Int, "MarketDepth");
        public static readonly FieldSpec BuyVolume = new FieldSpec(FieldType.Float, "BuyVolume");
        public static readonly FieldSpec SellVolume = new FieldSpec(FieldType.Float, "SellVolume");
        public static readonly FieldSpec HighPx = new FieldSpec(FieldType.Float, "HighPx");
        public static readonly FieldSpec LowPx = new FieldSpec(FieldType.Float, "LowPx");
        public static readonly FieldSpec LastPx = new FieldSpec(FieldType.Float, "LastPx");
        public static readonly FieldSpec TransactTime = new FieldSpec(FieldType.HashedSlice8, "TransactTime");
        public static readonly FieldSpec Adjustment = new FieldSpec(FieldType.Int, "Adjustment");
        public static readonly FieldSpec FirstPx = new FieldSpec(FieldType.Float, "FirstPx");
        public static readonly FieldSpec Text = new FieldSpec(FieldType.HashedSlice8, "Text");
        public static readonly FieldSpec EncodedTextLen = new FieldSpec(FieldType.Int, "EncodedTextLen");
        public static readonly FieldSpec EncodedText = new FieldSpec(FieldType.HashedSlice8, "EncodedText");
        public static readonly FieldSpec TradeDate = new FieldSpec(FieldType.HashedSlice8, "TradeDate");
        public static readonly FieldSpec SettlPrice = new FieldSpec(FieldType.Float, "SettlPrice");
        public static readonly FieldSpec SettlPriceType = new FieldSpec(FieldType.Int, "SettlPriceType");
        public static readonly FieldSpec[] Schema = new FieldSpec[]
        {
            SecurityStatusReqID,
            Currency,
            TradingSessionID,
            TradingSessionSubID,
            UnsolicitedIndicator,
            SecurityTradingStatus,
            FinancialStatus,
            CorporateAction,
            HaltReason,
            InViewOfCommon,
            DueToRelated,
            MDBookType,
            MarketDepth,
            BuyVolume,
            SellVolume,
            HighPx,
            LowPx,
            LastPx,
            TransactTime,
            Adjustment,
            FirstPx,
            Text,
            EncodedTextLen,
            EncodedText,
            TradeDate,
            SettlPrice,
            SettlPriceType,
        };
        public static FieldSpec GetFieldSpec(int tag)
        {
            return tag switch
            {
                324 => SecurityStatusReqID,
                15 => Currency,
                336 => TradingSessionID,
                625 => TradingSessionSubID,
                325 => UnsolicitedIndicator,
                326 => SecurityTradingStatus,
                291 => FinancialStatus,
                292 => CorporateAction,
                327 => HaltReason,
                328 => InViewOfCommon,
                329 => DueToRelated,
                1021 => MDBookType,
                264 => MarketDepth,
                330 => BuyVolume,
                331 => SellVolume,
                332 => HighPx,
                333 => LowPx,
                31 => LastPx,
                60 => TransactTime,
                334 => Adjustment,
                1025 => FirstPx,
                58 => Text,
                354 => EncodedTextLen,
                355 => EncodedText,
                75 => TradeDate,
                730 => SettlPrice,
                731 => SettlPriceType,
                _ => throw new ArgumentException($"Invalid tag value {tag}")
            };
        }
    }
}

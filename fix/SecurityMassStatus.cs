using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class SecurityMassStatus
    {
        public static readonly FieldSpec SecurityStatusReqID = new FieldSpec(FieldType.HashedSlice8, "SecurityStatusReqID");
        public static readonly FieldSpec TradingSessionID = new FieldSpec(FieldType.HashedSlice8, "TradingSessionID");
        public static readonly FieldSpec TradingSessionSubID = new FieldSpec(FieldType.HashedSlice8, "TradingSessionSubID");
        public static readonly FieldSpec UnsolicitedIndicator = new FieldSpec(FieldType.Char, "UnsolicitedIndicator");
        public static readonly FieldSpec MDBookType = new FieldSpec(FieldType.Int, "MDBookType");
        public static readonly FieldSpec MarketDepth = new FieldSpec(FieldType.Int, "MarketDepth");
        public static readonly FieldSpec TransactTime = new FieldSpec(FieldType.HashedSlice8, "TransactTime");
        public static readonly FieldSpec Adjustment = new FieldSpec(FieldType.Int, "Adjustment");
        public static readonly FieldSpec TradeDate = new FieldSpec(FieldType.HashedSlice8, "TradeDate");
        public static readonly FieldSpec[] Schema = new FieldSpec[]
        {
            SecurityStatusReqID,
            TradingSessionID,
            TradingSessionSubID,
            UnsolicitedIndicator,
            MDBookType,
            MarketDepth,
            TransactTime,
            Adjustment,
            TradeDate,
        };
        public static FieldSpec GetFieldSpec(int tag)
        {
            return tag switch
            {
                324 => SecurityStatusReqID,
                336 => TradingSessionID,
                625 => TradingSessionSubID,
                325 => UnsolicitedIndicator,
                1021 => MDBookType,
                264 => MarketDepth,
                60 => TransactTime,
                334 => Adjustment,
                75 => TradeDate,
                _ => throw new ArgumentException($"Invalid tag value {tag}")
            };
        }
    }
}

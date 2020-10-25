using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class TradingSessionStatus
    {
        public static readonly FieldSpec TradSesReqID = new FieldSpec(FieldType.HashedSlice8, "TradSesReqID");
        public static readonly FieldSpec TradingSessionID = new FieldSpec(FieldType.HashedSlice8, "TradingSessionID");
        public static readonly FieldSpec TradingSessionSubID = new FieldSpec(FieldType.HashedSlice8, "TradingSessionSubID");
        public static readonly FieldSpec TradSesMethod = new FieldSpec(FieldType.Int, "TradSesMethod");
        public static readonly FieldSpec TradSesMode = new FieldSpec(FieldType.Int, "TradSesMode");
        public static readonly FieldSpec UnsolicitedIndicator = new FieldSpec(FieldType.Char, "UnsolicitedIndicator");
        public static readonly FieldSpec TradSesStatus = new FieldSpec(FieldType.Int, "TradSesStatus");
        public static readonly FieldSpec TradSesStatusRejReason = new FieldSpec(FieldType.Int, "TradSesStatusRejReason");
        public static readonly FieldSpec TradSesStartTime = new FieldSpec(FieldType.HashedSlice8, "TradSesStartTime");
        public static readonly FieldSpec TradSesOpenTime = new FieldSpec(FieldType.HashedSlice8, "TradSesOpenTime");
        public static readonly FieldSpec TradSesPreCloseTime = new FieldSpec(FieldType.HashedSlice8, "TradSesPreCloseTime");
        public static readonly FieldSpec TradSesCloseTime = new FieldSpec(FieldType.HashedSlice8, "TradSesCloseTime");
        public static readonly FieldSpec TradSesEndTime = new FieldSpec(FieldType.HashedSlice8, "TradSesEndTime");
        public static readonly FieldSpec TotalVolumeTraded = new FieldSpec(FieldType.Float, "TotalVolumeTraded");
        public static readonly FieldSpec Text = new FieldSpec(FieldType.HashedSlice8, "Text");
        public static readonly FieldSpec EncodedTextLen = new FieldSpec(FieldType.Int, "EncodedTextLen");
        public static readonly FieldSpec EncodedText = new FieldSpec(FieldType.HashedSlice8, "EncodedText");
        public static readonly FieldSpec TradeDate = new FieldSpec(FieldType.HashedSlice8, "TradeDate");
        public static readonly FieldSpec TransactTime = new FieldSpec(FieldType.HashedSlice8, "TransactTime");
        public static readonly FieldSpec[] Schema = new FieldSpec[]
        {
            TradSesReqID,
            TradingSessionID,
            TradingSessionSubID,
            TradSesMethod,
            TradSesMode,
            UnsolicitedIndicator,
            TradSesStatus,
            TradSesStatusRejReason,
            TradSesStartTime,
            TradSesOpenTime,
            TradSesPreCloseTime,
            TradSesCloseTime,
            TradSesEndTime,
            TotalVolumeTraded,
            Text,
            EncodedTextLen,
            EncodedText,
            TradeDate,
            TransactTime,
        };
        public static FieldSpec GetFieldSpec(int tag)
        {
            return tag switch
            {
                335 => TradSesReqID,
                336 => TradingSessionID,
                625 => TradingSessionSubID,
                338 => TradSesMethod,
                339 => TradSesMode,
                325 => UnsolicitedIndicator,
                340 => TradSesStatus,
                567 => TradSesStatusRejReason,
                341 => TradSesStartTime,
                342 => TradSesOpenTime,
                343 => TradSesPreCloseTime,
                344 => TradSesCloseTime,
                345 => TradSesEndTime,
                387 => TotalVolumeTraded,
                58 => Text,
                354 => EncodedTextLen,
                355 => EncodedText,
                75 => TradeDate,
                60 => TransactTime,
                _ => throw new ArgumentException($"Invalid tag value {tag}")
            };
        }
    }
}

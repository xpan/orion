using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class TradeMatchReport
    {
        public static readonly FieldSpec TrdMatchID = new FieldSpec(FieldType.HashedSlice8, "TrdMatchID");
        public static readonly FieldSpec MatchType = new FieldSpec(FieldType.HashedSlice8, "MatchType");
        public static readonly FieldSpec TradeReportType = new FieldSpec(FieldType.Int, "TradeReportType");
        public static readonly FieldSpec ClearingBusinessDate = new FieldSpec(FieldType.HashedSlice8, "ClearingBusinessDate");
        public static readonly FieldSpec TrdType = new FieldSpec(FieldType.Int, "TrdType");
        public static readonly FieldSpec TrdSubType = new FieldSpec(FieldType.Int, "TrdSubType");
        public static readonly FieldSpec TradeDate = new FieldSpec(FieldType.HashedSlice8, "TradeDate");
        public static readonly FieldSpec TradingSessionID = new FieldSpec(FieldType.HashedSlice8, "TradingSessionID");
        public static readonly FieldSpec TradingSessionSubID = new FieldSpec(FieldType.HashedSlice8, "TradingSessionSubID");
        public static readonly FieldSpec TransactTime = new FieldSpec(FieldType.HashedSlice8, "TransactTime");
        public static readonly FieldSpec MultiLegReportingType = new FieldSpec(FieldType.Char, "MultiLegReportingType");
        public static readonly FieldSpec[] Schema = new FieldSpec[]
        {
            TrdMatchID,
            MatchType,
            TradeReportType,
            ClearingBusinessDate,
            TrdType,
            TrdSubType,
            TradeDate,
            TradingSessionID,
            TradingSessionSubID,
            TransactTime,
            MultiLegReportingType,
        };
        public static FieldSpec GetFieldSpec(int tag)
        {
            return tag switch
            {
                880 => TrdMatchID,
                574 => MatchType,
                856 => TradeReportType,
                715 => ClearingBusinessDate,
                828 => TrdType,
                829 => TrdSubType,
                75 => TradeDate,
                336 => TradingSessionID,
                625 => TradingSessionSubID,
                60 => TransactTime,
                442 => MultiLegReportingType,
                _ => throw new ArgumentException($"Invalid tag value {tag}")
            };
        }
    }
}

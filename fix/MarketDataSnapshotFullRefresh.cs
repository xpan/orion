using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class MarketDataSnapshotFullRefresh
    {
        public static readonly FieldSpec TotNumReports = new FieldSpec(FieldType.Int, "TotNumReports");
        public static readonly FieldSpec MDReportID = new FieldSpec(FieldType.Int, "MDReportID");
        public static readonly FieldSpec ClearingBusinessDate = new FieldSpec(FieldType.HashedSlice8, "ClearingBusinessDate");
        public static readonly FieldSpec MDBookType = new FieldSpec(FieldType.Int, "MDBookType");
        public static readonly FieldSpec MarketDepth = new FieldSpec(FieldType.Int, "MarketDepth");
        public static readonly FieldSpec MDFeedType = new FieldSpec(FieldType.HashedSlice8, "MDFeedType");
        public static readonly FieldSpec TradeDate = new FieldSpec(FieldType.HashedSlice8, "TradeDate");
        public static readonly FieldSpec MDReqID = new FieldSpec(FieldType.HashedSlice8, "MDReqID");
        public static readonly FieldSpec FinancialStatus = new FieldSpec(FieldType.HashedSlice8, "FinancialStatus");
        public static readonly FieldSpec CorporateAction = new FieldSpec(FieldType.HashedSlice8, "CorporateAction");
        public static readonly FieldSpec NetChgPrevDay = new FieldSpec(FieldType.Float, "NetChgPrevDay");
        public static readonly FieldSpec ApplQueueDepth = new FieldSpec(FieldType.Int, "ApplQueueDepth");
        public static readonly FieldSpec ApplQueueResolution = new FieldSpec(FieldType.Int, "ApplQueueResolution");
        public static readonly FieldSpec LastUpdateTime = new FieldSpec(FieldType.HashedSlice8, "LastUpdateTime");
        public static readonly FieldSpec[] Schema = new FieldSpec[]
        {
            TotNumReports,
            MDReportID,
            ClearingBusinessDate,
            MDBookType,
            MarketDepth,
            MDFeedType,
            TradeDate,
            MDReqID,
            FinancialStatus,
            CorporateAction,
            NetChgPrevDay,
            ApplQueueDepth,
            ApplQueueResolution,
            LastUpdateTime,
        };
        public static FieldSpec GetFieldSpec(int tag)
        {
            return tag switch
            {
                911 => TotNumReports,
                963 => MDReportID,
                715 => ClearingBusinessDate,
                1021 => MDBookType,
                264 => MarketDepth,
                1022 => MDFeedType,
                75 => TradeDate,
                262 => MDReqID,
                291 => FinancialStatus,
                292 => CorporateAction,
                451 => NetChgPrevDay,
                813 => ApplQueueDepth,
                814 => ApplQueueResolution,
                779 => LastUpdateTime,
                _ => throw new ArgumentException($"Invalid tag value {tag}")
            };
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class MarketDataIncrementalRefresh
    {
        public static readonly FieldSpec MDBookType = new FieldSpec(FieldType.Int, "MDBookType");
        public static readonly FieldSpec MDFeedType = new FieldSpec(FieldType.HashedSlice8, "MDFeedType");
        public static readonly FieldSpec TradeDate = new FieldSpec(FieldType.HashedSlice8, "TradeDate");
        public static readonly FieldSpec MDReqID = new FieldSpec(FieldType.HashedSlice8, "MDReqID");
        public static readonly FieldSpec ApplQueueDepth = new FieldSpec(FieldType.Int, "ApplQueueDepth");
        public static readonly FieldSpec ApplQueueResolution = new FieldSpec(FieldType.Int, "ApplQueueResolution");
        public static readonly FieldSpec[] Schema = new FieldSpec[]
        {
            MDBookType,
            MDFeedType,
            TradeDate,
            MDReqID,
            ApplQueueDepth,
            ApplQueueResolution,
        };
        public static FieldSpec GetFieldSpec(int tag)
        {
            return tag switch
            {
                1021 => MDBookType,
                1022 => MDFeedType,
                75 => TradeDate,
                262 => MDReqID,
                813 => ApplQueueDepth,
                814 => ApplQueueResolution,
                _ => throw new ArgumentException($"Invalid tag value {tag}")
            };
        }
    }
}

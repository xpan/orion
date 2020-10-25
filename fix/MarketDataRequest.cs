using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class MarketDataRequest
    {
        public static readonly FieldSpec MDReqID = new FieldSpec(FieldType.HashedSlice8, "MDReqID");
        public static readonly FieldSpec SubscriptionRequestType = new FieldSpec(FieldType.Char, "SubscriptionRequestType");
        public static readonly FieldSpec MarketDepth = new FieldSpec(FieldType.Int, "MarketDepth");
        public static readonly FieldSpec MDUpdateType = new FieldSpec(FieldType.Int, "MDUpdateType");
        public static readonly FieldSpec AggregatedBook = new FieldSpec(FieldType.Char, "AggregatedBook");
        public static readonly FieldSpec OpenCloseSettlFlag = new FieldSpec(FieldType.HashedSlice8, "OpenCloseSettlFlag");
        public static readonly FieldSpec Scope = new FieldSpec(FieldType.HashedSlice8, "Scope");
        public static readonly FieldSpec MDImplicitDelete = new FieldSpec(FieldType.Char, "MDImplicitDelete");
        public static readonly FieldSpec ApplQueueAction = new FieldSpec(FieldType.Int, "ApplQueueAction");
        public static readonly FieldSpec ApplQueueMax = new FieldSpec(FieldType.Int, "ApplQueueMax");
        public static readonly FieldSpec MDQuoteType = new FieldSpec(FieldType.Int, "MDQuoteType");
        public static readonly FieldSpec[] Schema = new FieldSpec[]
        {
            MDReqID,
            SubscriptionRequestType,
            MarketDepth,
            MDUpdateType,
            AggregatedBook,
            OpenCloseSettlFlag,
            Scope,
            MDImplicitDelete,
            ApplQueueAction,
            ApplQueueMax,
            MDQuoteType,
        };
        public static FieldSpec GetFieldSpec(int tag)
        {
            return tag switch
            {
                262 => MDReqID,
                263 => SubscriptionRequestType,
                264 => MarketDepth,
                265 => MDUpdateType,
                266 => AggregatedBook,
                286 => OpenCloseSettlFlag,
                546 => Scope,
                547 => MDImplicitDelete,
                815 => ApplQueueAction,
                812 => ApplQueueMax,
                1070 => MDQuoteType,
                _ => throw new ArgumentException($"Invalid tag value {tag}")
            };
        }
    }
}

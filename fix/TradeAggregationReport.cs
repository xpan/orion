using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class TradeAggregationReport
    {
        public static readonly FieldSpec TradeID = new FieldSpec(FieldType.HashedSlice8, "TradeID");
        public static readonly FieldSpec AvgPx = new FieldSpec(FieldType.Float, "AvgPx");
        public static readonly FieldSpec SettlDate = new FieldSpec(FieldType.HashedSlice8, "SettlDate");
        public static readonly FieldSpec Side = new FieldSpec(FieldType.Char, "Side");
        public static readonly FieldSpec[] Schema = new FieldSpec[]
        {
            TradeID,
            AvgPx,
            SettlDate,
            Side,
        };
        public static FieldSpec GetFieldSpec(int tag)
        {
            return tag switch
            {
                1003 => TradeID,
                6 => AvgPx,
                64 => SettlDate,
                54 => Side,
                _ => throw new ArgumentException($"Invalid tag value {tag}")
            };
        }
    }
}

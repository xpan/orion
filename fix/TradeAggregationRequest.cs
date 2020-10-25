using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class TradeAggregationRequest
    {
        public static readonly FieldSpec Currency = new FieldSpec(FieldType.HashedSlice8, "Currency");
        public static readonly FieldSpec AvgPx = new FieldSpec(FieldType.Float, "AvgPx");
        public static readonly FieldSpec Side = new FieldSpec(FieldType.Char, "Side");
        public static readonly FieldSpec Account = new FieldSpec(FieldType.HashedSlice8, "Account");
        public static readonly FieldSpec[] Schema = new FieldSpec[]
        {
            Currency,
            AvgPx,
            Side,
            Account,
        };
        public static FieldSpec GetFieldSpec(int tag)
        {
            return tag switch
            {
                15 => Currency,
                6 => AvgPx,
                54 => Side,
                1 => Account,
                _ => throw new ArgumentException($"Invalid tag value {tag}")
            };
        }
    }
}

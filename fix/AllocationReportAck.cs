using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class AllocationReportAck
    {
        public static readonly FieldSpec AllocReportID = new FieldSpec(FieldType.HashedSlice8, "AllocReportID");
        public static readonly FieldSpec AllocID = new FieldSpec(FieldType.HashedSlice8, "AllocID");
        public static readonly FieldSpec ClearingBusinessDate = new FieldSpec(FieldType.HashedSlice8, "ClearingBusinessDate");
        public static readonly FieldSpec AvgPxIndicator = new FieldSpec(FieldType.Int, "AvgPxIndicator");
        public static readonly FieldSpec Quantity = new FieldSpec(FieldType.Float, "Quantity");
        public static readonly FieldSpec AllocTransType = new FieldSpec(FieldType.Char, "AllocTransType");
        public static readonly FieldSpec SecondaryAllocID = new FieldSpec(FieldType.HashedSlice8, "SecondaryAllocID");
        public static readonly FieldSpec TradeDate = new FieldSpec(FieldType.HashedSlice8, "TradeDate");
        public static readonly FieldSpec TransactTime = new FieldSpec(FieldType.HashedSlice8, "TransactTime");
        public static readonly FieldSpec AllocStatus = new FieldSpec(FieldType.Int, "AllocStatus");
        public static readonly FieldSpec AllocRejCode = new FieldSpec(FieldType.Int, "AllocRejCode");
        public static readonly FieldSpec AllocReportType = new FieldSpec(FieldType.Int, "AllocReportType");
        public static readonly FieldSpec AllocIntermedReqType = new FieldSpec(FieldType.Int, "AllocIntermedReqType");
        public static readonly FieldSpec MatchStatus = new FieldSpec(FieldType.Char, "MatchStatus");
        public static readonly FieldSpec Text = new FieldSpec(FieldType.HashedSlice8, "Text");
        public static readonly FieldSpec EncodedTextLen = new FieldSpec(FieldType.Int, "EncodedTextLen");
        public static readonly FieldSpec EncodedText = new FieldSpec(FieldType.HashedSlice8, "EncodedText");
        public static readonly FieldSpec CustOrderHandlingInst = new FieldSpec(FieldType.HashedSlice8, "CustOrderHandlingInst");
        public static readonly FieldSpec OrderHandlingInstSource = new FieldSpec(FieldType.Int, "OrderHandlingInstSource");
        public static readonly FieldSpec[] Schema = new FieldSpec[]
        {
            AllocReportID,
            AllocID,
            ClearingBusinessDate,
            AvgPxIndicator,
            Quantity,
            AllocTransType,
            SecondaryAllocID,
            TradeDate,
            TransactTime,
            AllocStatus,
            AllocRejCode,
            AllocReportType,
            AllocIntermedReqType,
            MatchStatus,
            Text,
            EncodedTextLen,
            EncodedText,
            CustOrderHandlingInst,
            OrderHandlingInstSource,
        };
        public static FieldSpec GetFieldSpec(int tag)
        {
            return tag switch
            {
                755 => AllocReportID,
                70 => AllocID,
                715 => ClearingBusinessDate,
                819 => AvgPxIndicator,
                53 => Quantity,
                71 => AllocTransType,
                793 => SecondaryAllocID,
                75 => TradeDate,
                60 => TransactTime,
                87 => AllocStatus,
                88 => AllocRejCode,
                794 => AllocReportType,
                808 => AllocIntermedReqType,
                573 => MatchStatus,
                58 => Text,
                354 => EncodedTextLen,
                355 => EncodedText,
                1031 => CustOrderHandlingInst,
                1032 => OrderHandlingInstSource,
                _ => throw new ArgumentException($"Invalid tag value {tag}")
            };
        }
    }
}

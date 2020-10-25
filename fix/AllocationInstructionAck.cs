using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class AllocationInstructionAck
    {
        public static readonly FieldSpec AllocID = new FieldSpec(FieldType.HashedSlice8, "AllocID");
        public static readonly FieldSpec SecondaryAllocID = new FieldSpec(FieldType.HashedSlice8, "SecondaryAllocID");
        public static readonly FieldSpec TradeDate = new FieldSpec(FieldType.HashedSlice8, "TradeDate");
        public static readonly FieldSpec TransactTime = new FieldSpec(FieldType.HashedSlice8, "TransactTime");
        public static readonly FieldSpec AllocStatus = new FieldSpec(FieldType.Int, "AllocStatus");
        public static readonly FieldSpec AllocRejCode = new FieldSpec(FieldType.Int, "AllocRejCode");
        public static readonly FieldSpec AllocType = new FieldSpec(FieldType.Int, "AllocType");
        public static readonly FieldSpec AllocIntermedReqType = new FieldSpec(FieldType.Int, "AllocIntermedReqType");
        public static readonly FieldSpec MatchStatus = new FieldSpec(FieldType.Char, "MatchStatus");
        public static readonly FieldSpec Text = new FieldSpec(FieldType.HashedSlice8, "Text");
        public static readonly FieldSpec EncodedTextLen = new FieldSpec(FieldType.Int, "EncodedTextLen");
        public static readonly FieldSpec EncodedText = new FieldSpec(FieldType.HashedSlice8, "EncodedText");
        public static readonly FieldSpec[] Schema = new FieldSpec[]
        {
            AllocID,
            SecondaryAllocID,
            TradeDate,
            TransactTime,
            AllocStatus,
            AllocRejCode,
            AllocType,
            AllocIntermedReqType,
            MatchStatus,
            Text,
            EncodedTextLen,
            EncodedText,
        };
        public static FieldSpec GetFieldSpec(int tag)
        {
            return tag switch
            {
                70 => AllocID,
                793 => SecondaryAllocID,
                75 => TradeDate,
                60 => TransactTime,
                87 => AllocStatus,
                88 => AllocRejCode,
                626 => AllocType,
                808 => AllocIntermedReqType,
                573 => MatchStatus,
                58 => Text,
                354 => EncodedTextLen,
                355 => EncodedText,
                _ => throw new ArgumentException($"Invalid tag value {tag}")
            };
        }
    }
}

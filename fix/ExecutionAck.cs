using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class ExecutionAck
    {
        public static readonly FieldSpec OrderID = new FieldSpec(FieldType.HashedSlice8, "OrderID");
        public static readonly FieldSpec SecondaryOrderID = new FieldSpec(FieldType.HashedSlice8, "SecondaryOrderID");
        public static readonly FieldSpec ClOrdID = new FieldSpec(FieldType.HashedSlice8, "ClOrdID");
        public static readonly FieldSpec ExecAckStatus = new FieldSpec(FieldType.Char, "ExecAckStatus");
        public static readonly FieldSpec ExecID = new FieldSpec(FieldType.HashedSlice8, "ExecID");
        public static readonly FieldSpec DKReason = new FieldSpec(FieldType.Char, "DKReason");
        public static readonly FieldSpec Side = new FieldSpec(FieldType.Char, "Side");
        public static readonly FieldSpec LastQty = new FieldSpec(FieldType.Float, "LastQty");
        public static readonly FieldSpec LastPx = new FieldSpec(FieldType.Float, "LastPx");
        public static readonly FieldSpec PriceType = new FieldSpec(FieldType.Int, "PriceType");
        public static readonly FieldSpec LastParPx = new FieldSpec(FieldType.Float, "LastParPx");
        public static readonly FieldSpec CumQty = new FieldSpec(FieldType.Float, "CumQty");
        public static readonly FieldSpec AvgPx = new FieldSpec(FieldType.Float, "AvgPx");
        public static readonly FieldSpec Text = new FieldSpec(FieldType.HashedSlice8, "Text");
        public static readonly FieldSpec EncodedTextLen = new FieldSpec(FieldType.Int, "EncodedTextLen");
        public static readonly FieldSpec EncodedText = new FieldSpec(FieldType.HashedSlice8, "EncodedText");
        public static readonly FieldSpec[] Schema = new FieldSpec[]
        {
            OrderID,
            SecondaryOrderID,
            ClOrdID,
            ExecAckStatus,
            ExecID,
            DKReason,
            Side,
            LastQty,
            LastPx,
            PriceType,
            LastParPx,
            CumQty,
            AvgPx,
            Text,
            EncodedTextLen,
            EncodedText,
        };
        public static FieldSpec GetFieldSpec(int tag)
        {
            return tag switch
            {
                37 => OrderID,
                198 => SecondaryOrderID,
                11 => ClOrdID,
                1036 => ExecAckStatus,
                17 => ExecID,
                127 => DKReason,
                54 => Side,
                32 => LastQty,
                31 => LastPx,
                423 => PriceType,
                669 => LastParPx,
                14 => CumQty,
                6 => AvgPx,
                58 => Text,
                354 => EncodedTextLen,
                355 => EncodedText,
                _ => throw new ArgumentException($"Invalid tag value {tag}")
            };
        }
    }
}

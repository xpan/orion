using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class SettlementInstructions
    {
        public static readonly FieldSpec SettlInstMsgID = new FieldSpec(FieldType.HashedSlice8, "SettlInstMsgID");
        public static readonly FieldSpec SettlInstReqID = new FieldSpec(FieldType.HashedSlice8, "SettlInstReqID");
        public static readonly FieldSpec SettlInstMode = new FieldSpec(FieldType.Char, "SettlInstMode");
        public static readonly FieldSpec SettlInstReqRejCode = new FieldSpec(FieldType.Int, "SettlInstReqRejCode");
        public static readonly FieldSpec Text = new FieldSpec(FieldType.HashedSlice8, "Text");
        public static readonly FieldSpec EncodedTextLen = new FieldSpec(FieldType.Int, "EncodedTextLen");
        public static readonly FieldSpec EncodedText = new FieldSpec(FieldType.HashedSlice8, "EncodedText");
        public static readonly FieldSpec ClOrdID = new FieldSpec(FieldType.HashedSlice8, "ClOrdID");
        public static readonly FieldSpec TransactTime = new FieldSpec(FieldType.HashedSlice8, "TransactTime");
        public static readonly FieldSpec[] Schema = new FieldSpec[]
        {
            SettlInstMsgID,
            SettlInstReqID,
            SettlInstMode,
            SettlInstReqRejCode,
            Text,
            EncodedTextLen,
            EncodedText,
            ClOrdID,
            TransactTime,
        };
        public static FieldSpec GetFieldSpec(int tag)
        {
            return tag switch
            {
                777 => SettlInstMsgID,
                791 => SettlInstReqID,
                160 => SettlInstMode,
                792 => SettlInstReqRejCode,
                58 => Text,
                354 => EncodedTextLen,
                355 => EncodedText,
                11 => ClOrdID,
                60 => TransactTime,
                _ => throw new ArgumentException($"Invalid tag value {tag}")
            };
        }
    }
}

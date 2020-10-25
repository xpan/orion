using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class ConfirmationAck
    {
        public static readonly FieldSpec ConfirmID = new FieldSpec(FieldType.HashedSlice8, "ConfirmID");
        public static readonly FieldSpec TradeDate = new FieldSpec(FieldType.HashedSlice8, "TradeDate");
        public static readonly FieldSpec TransactTime = new FieldSpec(FieldType.HashedSlice8, "TransactTime");
        public static readonly FieldSpec AffirmStatus = new FieldSpec(FieldType.Int, "AffirmStatus");
        public static readonly FieldSpec ConfirmRejReason = new FieldSpec(FieldType.Int, "ConfirmRejReason");
        public static readonly FieldSpec MatchStatus = new FieldSpec(FieldType.Char, "MatchStatus");
        public static readonly FieldSpec Text = new FieldSpec(FieldType.HashedSlice8, "Text");
        public static readonly FieldSpec EncodedTextLen = new FieldSpec(FieldType.Int, "EncodedTextLen");
        public static readonly FieldSpec EncodedText = new FieldSpec(FieldType.HashedSlice8, "EncodedText");
        public static readonly FieldSpec[] Schema = new FieldSpec[]
        {
            ConfirmID,
            TradeDate,
            TransactTime,
            AffirmStatus,
            ConfirmRejReason,
            MatchStatus,
            Text,
            EncodedTextLen,
            EncodedText,
        };
        public static FieldSpec GetFieldSpec(int tag)
        {
            return tag switch
            {
                664 => ConfirmID,
                75 => TradeDate,
                60 => TransactTime,
                940 => AffirmStatus,
                774 => ConfirmRejReason,
                573 => MatchStatus,
                58 => Text,
                354 => EncodedTextLen,
                355 => EncodedText,
                _ => throw new ArgumentException($"Invalid tag value {tag}")
            };
        }
    }
}

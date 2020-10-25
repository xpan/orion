using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class PartyActionReport
    {
        public static readonly FieldSpec TransactTime = new FieldSpec(FieldType.HashedSlice8, "TransactTime");
        public static readonly FieldSpec Text = new FieldSpec(FieldType.HashedSlice8, "Text");
        public static readonly FieldSpec EncodedTextLen = new FieldSpec(FieldType.Int, "EncodedTextLen");
        public static readonly FieldSpec EncodedText = new FieldSpec(FieldType.HashedSlice8, "EncodedText");
        public static readonly FieldSpec CopyMsgIndicator = new FieldSpec(FieldType.Char, "CopyMsgIndicator");
        public static readonly FieldSpec[] Schema = new FieldSpec[]
        {
            TransactTime,
            Text,
            EncodedTextLen,
            EncodedText,
            CopyMsgIndicator,
        };
        public static FieldSpec GetFieldSpec(int tag)
        {
            return tag switch
            {
                60 => TransactTime,
                58 => Text,
                354 => EncodedTextLen,
                355 => EncodedText,
                797 => CopyMsgIndicator,
                _ => throw new ArgumentException($"Invalid tag value {tag}")
            };
        }
    }
}

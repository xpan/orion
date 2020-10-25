using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class ContraryIntentionReport
    {
        public static readonly FieldSpec ContIntRptID = new FieldSpec(FieldType.HashedSlice8, "ContIntRptID");
        public static readonly FieldSpec TransactTime = new FieldSpec(FieldType.HashedSlice8, "TransactTime");
        public static readonly FieldSpec LateIndicator = new FieldSpec(FieldType.Char, "LateIndicator");
        public static readonly FieldSpec InputSource = new FieldSpec(FieldType.HashedSlice8, "InputSource");
        public static readonly FieldSpec ClearingBusinessDate = new FieldSpec(FieldType.HashedSlice8, "ClearingBusinessDate");
        public static readonly FieldSpec Text = new FieldSpec(FieldType.HashedSlice8, "Text");
        public static readonly FieldSpec EncodedTextLen = new FieldSpec(FieldType.Int, "EncodedTextLen");
        public static readonly FieldSpec EncodedText = new FieldSpec(FieldType.HashedSlice8, "EncodedText");
        public static readonly FieldSpec[] Schema = new FieldSpec[]
        {
            ContIntRptID,
            TransactTime,
            LateIndicator,
            InputSource,
            ClearingBusinessDate,
            Text,
            EncodedTextLen,
            EncodedText,
        };
        public static FieldSpec GetFieldSpec(int tag)
        {
            return tag switch
            {
                977 => ContIntRptID,
                60 => TransactTime,
                978 => LateIndicator,
                979 => InputSource,
                715 => ClearingBusinessDate,
                58 => Text,
                354 => EncodedTextLen,
                355 => EncodedText,
                _ => throw new ArgumentException($"Invalid tag value {tag}")
            };
        }
    }
}

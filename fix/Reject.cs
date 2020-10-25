using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class Reject
    {
        public static readonly FieldSpec RefSeqNum = new FieldSpec(FieldType.Int, "RefSeqNum");
        public static readonly FieldSpec RefTagID = new FieldSpec(FieldType.Int, "RefTagID");
        public static readonly FieldSpec RefMsgType = new FieldSpec(FieldType.HashedSlice8, "RefMsgType");
        public static readonly FieldSpec RefApplVerID = new FieldSpec(FieldType.HashedSlice8, "RefApplVerID");
        public static readonly FieldSpec RefCstmApplVerID = new FieldSpec(FieldType.HashedSlice8, "RefCstmApplVerID");
        public static readonly FieldSpec SessionRejectReason = new FieldSpec(FieldType.Int, "SessionRejectReason");
        public static readonly FieldSpec Text = new FieldSpec(FieldType.HashedSlice8, "Text");
        public static readonly FieldSpec EncodedTextLen = new FieldSpec(FieldType.Int, "EncodedTextLen");
        public static readonly FieldSpec EncodedText = new FieldSpec(FieldType.HashedSlice8, "EncodedText");
        public static readonly FieldSpec[] Schema = new FieldSpec[]
        {
            RefSeqNum,
            RefTagID,
            RefMsgType,
            RefApplVerID,
            RefCstmApplVerID,
            SessionRejectReason,
            Text,
            EncodedTextLen,
            EncodedText,
        };
        public static FieldSpec GetFieldSpec(int tag)
        {
            return tag switch
            {
                45 => RefSeqNum,
                371 => RefTagID,
                372 => RefMsgType,
                1130 => RefApplVerID,
                1131 => RefCstmApplVerID,
                373 => SessionRejectReason,
                58 => Text,
                354 => EncodedTextLen,
                355 => EncodedText,
                _ => throw new ArgumentException($"Invalid tag value {tag}")
            };
        }
    }
}

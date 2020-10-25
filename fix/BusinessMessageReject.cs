using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class BusinessMessageReject
    {
        public static readonly FieldSpec RefSeqNum = new FieldSpec(FieldType.Int, "RefSeqNum");
        public static readonly FieldSpec RefMsgType = new FieldSpec(FieldType.HashedSlice8, "RefMsgType");
        public static readonly FieldSpec RefApplVerID = new FieldSpec(FieldType.HashedSlice8, "RefApplVerID");
        public static readonly FieldSpec RefCstmApplVerID = new FieldSpec(FieldType.HashedSlice8, "RefCstmApplVerID");
        public static readonly FieldSpec BusinessRejectRefID = new FieldSpec(FieldType.HashedSlice8, "BusinessRejectRefID");
        public static readonly FieldSpec BusinessRejectReason = new FieldSpec(FieldType.Int, "BusinessRejectReason");
        public static readonly FieldSpec Text = new FieldSpec(FieldType.HashedSlice8, "Text");
        public static readonly FieldSpec EncodedTextLen = new FieldSpec(FieldType.Int, "EncodedTextLen");
        public static readonly FieldSpec EncodedText = new FieldSpec(FieldType.HashedSlice8, "EncodedText");
        public static readonly FieldSpec[] Schema = new FieldSpec[]
        {
            RefSeqNum,
            RefMsgType,
            RefApplVerID,
            RefCstmApplVerID,
            BusinessRejectRefID,
            BusinessRejectReason,
            Text,
            EncodedTextLen,
            EncodedText,
        };
        public static FieldSpec GetFieldSpec(int tag)
        {
            return tag switch
            {
                45 => RefSeqNum,
                372 => RefMsgType,
                1130 => RefApplVerID,
                1131 => RefCstmApplVerID,
                379 => BusinessRejectRefID,
                380 => BusinessRejectReason,
                58 => Text,
                354 => EncodedTextLen,
                355 => EncodedText,
                _ => throw new ArgumentException($"Invalid tag value {tag}")
            };
        }
    }
}

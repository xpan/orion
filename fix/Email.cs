using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class Email
    {
        public static readonly FieldSpec EmailThreadID = new FieldSpec(FieldType.HashedSlice8, "EmailThreadID");
        public static readonly FieldSpec EmailType = new FieldSpec(FieldType.Char, "EmailType");
        public static readonly FieldSpec OrigTime = new FieldSpec(FieldType.HashedSlice8, "OrigTime");
        public static readonly FieldSpec Subject = new FieldSpec(FieldType.HashedSlice8, "Subject");
        public static readonly FieldSpec EncodedSubjectLen = new FieldSpec(FieldType.Int, "EncodedSubjectLen");
        public static readonly FieldSpec EncodedSubject = new FieldSpec(FieldType.HashedSlice8, "EncodedSubject");
        public static readonly FieldSpec OrderID = new FieldSpec(FieldType.HashedSlice8, "OrderID");
        public static readonly FieldSpec ClOrdID = new FieldSpec(FieldType.HashedSlice8, "ClOrdID");
        public static readonly FieldSpec RawDataLength = new FieldSpec(FieldType.Int, "RawDataLength");
        public static readonly FieldSpec RawData = new FieldSpec(FieldType.HashedSlice8, "RawData");
        public static readonly FieldSpec[] Schema = new FieldSpec[]
        {
            EmailThreadID,
            EmailType,
            OrigTime,
            Subject,
            EncodedSubjectLen,
            EncodedSubject,
            OrderID,
            ClOrdID,
            RawDataLength,
            RawData,
        };
        public static FieldSpec GetFieldSpec(int tag)
        {
            return tag switch
            {
                164 => EmailThreadID,
                94 => EmailType,
                42 => OrigTime,
                147 => Subject,
                356 => EncodedSubjectLen,
                357 => EncodedSubject,
                37 => OrderID,
                11 => ClOrdID,
                95 => RawDataLength,
                96 => RawData,
                _ => throw new ArgumentException($"Invalid tag value {tag}")
            };
        }
    }
}

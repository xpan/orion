using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class News
    {
        public static readonly FieldSpec OrigTime = new FieldSpec(FieldType.HashedSlice8, "OrigTime");
        public static readonly FieldSpec Urgency = new FieldSpec(FieldType.Char, "Urgency");
        public static readonly FieldSpec Headline = new FieldSpec(FieldType.HashedSlice8, "Headline");
        public static readonly FieldSpec EncodedHeadlineLen = new FieldSpec(FieldType.Int, "EncodedHeadlineLen");
        public static readonly FieldSpec EncodedHeadline = new FieldSpec(FieldType.HashedSlice8, "EncodedHeadline");
        public static readonly FieldSpec URLLink = new FieldSpec(FieldType.HashedSlice8, "URLLink");
        public static readonly FieldSpec RawDataLength = new FieldSpec(FieldType.Int, "RawDataLength");
        public static readonly FieldSpec RawData = new FieldSpec(FieldType.HashedSlice8, "RawData");
        public static readonly FieldSpec[] Schema = new FieldSpec[]
        {
            OrigTime,
            Urgency,
            Headline,
            EncodedHeadlineLen,
            EncodedHeadline,
            URLLink,
            RawDataLength,
            RawData,
        };
        public static FieldSpec GetFieldSpec(int tag)
        {
            return tag switch
            {
                42 => OrigTime,
                61 => Urgency,
                148 => Headline,
                358 => EncodedHeadlineLen,
                359 => EncodedHeadline,
                149 => URLLink,
                95 => RawDataLength,
                96 => RawData,
                _ => throw new ArgumentException($"Invalid tag value {tag}")
            };
        }
    }
}

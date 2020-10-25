using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class Logon
    {
        public static readonly FieldSpec EncryptMethod = new FieldSpec(FieldType.Int, "EncryptMethod");
        public static readonly FieldSpec HeartBtInt = new FieldSpec(FieldType.Int, "HeartBtInt");
        public static readonly FieldSpec RawDataLength = new FieldSpec(FieldType.Int, "RawDataLength");
        public static readonly FieldSpec RawData = new FieldSpec(FieldType.HashedSlice8, "RawData");
        public static readonly FieldSpec ResetSeqNumFlag = new FieldSpec(FieldType.Char, "ResetSeqNumFlag");
        public static readonly FieldSpec NextExpectedMsgSeqNum = new FieldSpec(FieldType.Int, "NextExpectedMsgSeqNum");
        public static readonly FieldSpec MaxMessageSize = new FieldSpec(FieldType.Int, "MaxMessageSize");
        public static readonly FieldSpec TestMessageIndicator = new FieldSpec(FieldType.Char, "TestMessageIndicator");
        public static readonly FieldSpec Username = new FieldSpec(FieldType.HashedSlice8, "Username");
        public static readonly FieldSpec Password = new FieldSpec(FieldType.HashedSlice8, "Password");
        public static readonly FieldSpec NewPassword = new FieldSpec(FieldType.HashedSlice8, "NewPassword");
        public static readonly FieldSpec DefaultApplVerID = new FieldSpec(FieldType.HashedSlice8, "DefaultApplVerID");
        public static readonly FieldSpec Text = new FieldSpec(FieldType.HashedSlice8, "Text");
        public static readonly FieldSpec EncodedTextLen = new FieldSpec(FieldType.Int, "EncodedTextLen");
        public static readonly FieldSpec EncodedText = new FieldSpec(FieldType.HashedSlice8, "EncodedText");
        public static readonly FieldSpec[] Schema = new FieldSpec[]
        {
            EncryptMethod,
            HeartBtInt,
            RawDataLength,
            RawData,
            ResetSeqNumFlag,
            NextExpectedMsgSeqNum,
            MaxMessageSize,
            TestMessageIndicator,
            Username,
            Password,
            NewPassword,
            DefaultApplVerID,
            Text,
            EncodedTextLen,
            EncodedText,
        };
        public static FieldSpec GetFieldSpec(int tag)
        {
            return tag switch
            {
                98 => EncryptMethod,
                108 => HeartBtInt,
                95 => RawDataLength,
                96 => RawData,
                141 => ResetSeqNumFlag,
                789 => NextExpectedMsgSeqNum,
                383 => MaxMessageSize,
                464 => TestMessageIndicator,
                553 => Username,
                554 => Password,
                925 => NewPassword,
                1137 => DefaultApplVerID,
                58 => Text,
                354 => EncodedTextLen,
                355 => EncodedText,
                _ => throw new ArgumentException($"Invalid tag value {tag}")
            };
        }
    }
}

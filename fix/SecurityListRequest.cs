using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class SecurityListRequest
    {
        public static readonly FieldSpec SecurityReqID = new FieldSpec(FieldType.HashedSlice8, "SecurityReqID");
        public static readonly FieldSpec SecurityListRequestType = new FieldSpec(FieldType.Int, "SecurityListRequestType");
        public static readonly FieldSpec Currency = new FieldSpec(FieldType.HashedSlice8, "Currency");
        public static readonly FieldSpec Text = new FieldSpec(FieldType.HashedSlice8, "Text");
        public static readonly FieldSpec EncodedTextLen = new FieldSpec(FieldType.Int, "EncodedTextLen");
        public static readonly FieldSpec EncodedText = new FieldSpec(FieldType.HashedSlice8, "EncodedText");
        public static readonly FieldSpec TradingSessionID = new FieldSpec(FieldType.HashedSlice8, "TradingSessionID");
        public static readonly FieldSpec TradingSessionSubID = new FieldSpec(FieldType.HashedSlice8, "TradingSessionSubID");
        public static readonly FieldSpec SubscriptionRequestType = new FieldSpec(FieldType.Char, "SubscriptionRequestType");
        public static readonly FieldSpec[] Schema = new FieldSpec[]
        {
            SecurityReqID,
            SecurityListRequestType,
            Currency,
            Text,
            EncodedTextLen,
            EncodedText,
            TradingSessionID,
            TradingSessionSubID,
            SubscriptionRequestType,
        };
        public static FieldSpec GetFieldSpec(int tag)
        {
            return tag switch
            {
                320 => SecurityReqID,
                559 => SecurityListRequestType,
                15 => Currency,
                58 => Text,
                354 => EncodedTextLen,
                355 => EncodedText,
                336 => TradingSessionID,
                625 => TradingSessionSubID,
                263 => SubscriptionRequestType,
                _ => throw new ArgumentException($"Invalid tag value {tag}")
            };
        }
    }
}

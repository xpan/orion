using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class SecurityDefinitionRequest
    {
        public static readonly FieldSpec SecurityReqID = new FieldSpec(FieldType.HashedSlice8, "SecurityReqID");
        public static readonly FieldSpec SecurityRequestType = new FieldSpec(FieldType.Int, "SecurityRequestType");
        public static readonly FieldSpec Currency = new FieldSpec(FieldType.HashedSlice8, "Currency");
        public static readonly FieldSpec Text = new FieldSpec(FieldType.HashedSlice8, "Text");
        public static readonly FieldSpec EncodedTextLen = new FieldSpec(FieldType.Int, "EncodedTextLen");
        public static readonly FieldSpec EncodedText = new FieldSpec(FieldType.HashedSlice8, "EncodedText");
        public static readonly FieldSpec TradingSessionID = new FieldSpec(FieldType.HashedSlice8, "TradingSessionID");
        public static readonly FieldSpec TradingSessionSubID = new FieldSpec(FieldType.HashedSlice8, "TradingSessionSubID");
        public static readonly FieldSpec ExpirationCycle = new FieldSpec(FieldType.Int, "ExpirationCycle");
        public static readonly FieldSpec SubscriptionRequestType = new FieldSpec(FieldType.Char, "SubscriptionRequestType");
        public static readonly FieldSpec ComplianceID = new FieldSpec(FieldType.HashedSlice8, "ComplianceID");
        public static readonly FieldSpec[] Schema = new FieldSpec[]
        {
            SecurityReqID,
            SecurityRequestType,
            Currency,
            Text,
            EncodedTextLen,
            EncodedText,
            TradingSessionID,
            TradingSessionSubID,
            ExpirationCycle,
            SubscriptionRequestType,
            ComplianceID,
        };
        public static FieldSpec GetFieldSpec(int tag)
        {
            return tag switch
            {
                320 => SecurityReqID,
                321 => SecurityRequestType,
                15 => Currency,
                58 => Text,
                354 => EncodedTextLen,
                355 => EncodedText,
                336 => TradingSessionID,
                625 => TradingSessionSubID,
                827 => ExpirationCycle,
                263 => SubscriptionRequestType,
                376 => ComplianceID,
                _ => throw new ArgumentException($"Invalid tag value {tag}")
            };
        }
    }
}

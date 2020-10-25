using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class SecurityStatusRequest
    {
        public static readonly FieldSpec SecurityStatusReqID = new FieldSpec(FieldType.HashedSlice8, "SecurityStatusReqID");
        public static readonly FieldSpec Currency = new FieldSpec(FieldType.HashedSlice8, "Currency");
        public static readonly FieldSpec SubscriptionRequestType = new FieldSpec(FieldType.Char, "SubscriptionRequestType");
        public static readonly FieldSpec TradingSessionID = new FieldSpec(FieldType.HashedSlice8, "TradingSessionID");
        public static readonly FieldSpec TradingSessionSubID = new FieldSpec(FieldType.HashedSlice8, "TradingSessionSubID");
        public static readonly FieldSpec[] Schema = new FieldSpec[]
        {
            SecurityStatusReqID,
            Currency,
            SubscriptionRequestType,
            TradingSessionID,
            TradingSessionSubID,
        };
        public static FieldSpec GetFieldSpec(int tag)
        {
            return tag switch
            {
                324 => SecurityStatusReqID,
                15 => Currency,
                263 => SubscriptionRequestType,
                336 => TradingSessionID,
                625 => TradingSessionSubID,
                _ => throw new ArgumentException($"Invalid tag value {tag}")
            };
        }
    }
}

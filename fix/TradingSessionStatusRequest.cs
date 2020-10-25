using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class TradingSessionStatusRequest
    {
        public static readonly FieldSpec TradSesReqID = new FieldSpec(FieldType.HashedSlice8, "TradSesReqID");
        public static readonly FieldSpec TradingSessionID = new FieldSpec(FieldType.HashedSlice8, "TradingSessionID");
        public static readonly FieldSpec TradingSessionSubID = new FieldSpec(FieldType.HashedSlice8, "TradingSessionSubID");
        public static readonly FieldSpec TradSesMethod = new FieldSpec(FieldType.Int, "TradSesMethod");
        public static readonly FieldSpec TradSesMode = new FieldSpec(FieldType.Int, "TradSesMode");
        public static readonly FieldSpec SubscriptionRequestType = new FieldSpec(FieldType.Char, "SubscriptionRequestType");
        public static readonly FieldSpec SecurityExchange = new FieldSpec(FieldType.HashedSlice8, "SecurityExchange");
        public static readonly FieldSpec[] Schema = new FieldSpec[]
        {
            TradSesReqID,
            TradingSessionID,
            TradingSessionSubID,
            TradSesMethod,
            TradSesMode,
            SubscriptionRequestType,
            SecurityExchange,
        };
        public static FieldSpec GetFieldSpec(int tag)
        {
            return tag switch
            {
                335 => TradSesReqID,
                336 => TradingSessionID,
                625 => TradingSessionSubID,
                338 => TradSesMethod,
                339 => TradSesMode,
                263 => SubscriptionRequestType,
                207 => SecurityExchange,
                _ => throw new ArgumentException($"Invalid tag value {tag}")
            };
        }
    }
}

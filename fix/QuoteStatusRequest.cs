using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class QuoteStatusRequest
    {
        public static readonly FieldSpec QuoteStatusReqID = new FieldSpec(FieldType.HashedSlice8, "QuoteStatusReqID");
        public static readonly FieldSpec QuoteID = new FieldSpec(FieldType.HashedSlice8, "QuoteID");
        public static readonly FieldSpec Account = new FieldSpec(FieldType.HashedSlice8, "Account");
        public static readonly FieldSpec AcctIDSource = new FieldSpec(FieldType.Int, "AcctIDSource");
        public static readonly FieldSpec AccountType = new FieldSpec(FieldType.Int, "AccountType");
        public static readonly FieldSpec TradingSessionID = new FieldSpec(FieldType.HashedSlice8, "TradingSessionID");
        public static readonly FieldSpec TradingSessionSubID = new FieldSpec(FieldType.HashedSlice8, "TradingSessionSubID");
        public static readonly FieldSpec SubscriptionRequestType = new FieldSpec(FieldType.Char, "SubscriptionRequestType");
        public static readonly FieldSpec[] Schema = new FieldSpec[]
        {
            QuoteStatusReqID,
            QuoteID,
            Account,
            AcctIDSource,
            AccountType,
            TradingSessionID,
            TradingSessionSubID,
            SubscriptionRequestType,
        };
        public static FieldSpec GetFieldSpec(int tag)
        {
            return tag switch
            {
                649 => QuoteStatusReqID,
                117 => QuoteID,
                1 => Account,
                660 => AcctIDSource,
                581 => AccountType,
                336 => TradingSessionID,
                625 => TradingSessionSubID,
                263 => SubscriptionRequestType,
                _ => throw new ArgumentException($"Invalid tag value {tag}")
            };
        }
    }
}

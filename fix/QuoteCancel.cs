using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class QuoteCancel
    {
        public static readonly FieldSpec QuoteReqID = new FieldSpec(FieldType.HashedSlice8, "QuoteReqID");
        public static readonly FieldSpec QuoteID = new FieldSpec(FieldType.HashedSlice8, "QuoteID");
        public static readonly FieldSpec QuoteCancelType = new FieldSpec(FieldType.Int, "QuoteCancelType");
        public static readonly FieldSpec QuoteResponseLevel = new FieldSpec(FieldType.Int, "QuoteResponseLevel");
        public static readonly FieldSpec Account = new FieldSpec(FieldType.HashedSlice8, "Account");
        public static readonly FieldSpec AcctIDSource = new FieldSpec(FieldType.Int, "AcctIDSource");
        public static readonly FieldSpec AccountType = new FieldSpec(FieldType.Int, "AccountType");
        public static readonly FieldSpec TradingSessionID = new FieldSpec(FieldType.HashedSlice8, "TradingSessionID");
        public static readonly FieldSpec TradingSessionSubID = new FieldSpec(FieldType.HashedSlice8, "TradingSessionSubID");
        public static readonly FieldSpec QuoteType = new FieldSpec(FieldType.Int, "QuoteType");
        public static readonly FieldSpec[] Schema = new FieldSpec[]
        {
            QuoteReqID,
            QuoteID,
            QuoteCancelType,
            QuoteResponseLevel,
            Account,
            AcctIDSource,
            AccountType,
            TradingSessionID,
            TradingSessionSubID,
            QuoteType,
        };
        public static FieldSpec GetFieldSpec(int tag)
        {
            return tag switch
            {
                131 => QuoteReqID,
                117 => QuoteID,
                298 => QuoteCancelType,
                301 => QuoteResponseLevel,
                1 => Account,
                660 => AcctIDSource,
                581 => AccountType,
                336 => TradingSessionID,
                625 => TradingSessionSubID,
                537 => QuoteType,
                _ => throw new ArgumentException($"Invalid tag value {tag}")
            };
        }
    }
}

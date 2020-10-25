using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class MassQuote
    {
        public static readonly FieldSpec QuoteReqID = new FieldSpec(FieldType.HashedSlice8, "QuoteReqID");
        public static readonly FieldSpec QuoteID = new FieldSpec(FieldType.HashedSlice8, "QuoteID");
        public static readonly FieldSpec QuoteType = new FieldSpec(FieldType.Int, "QuoteType");
        public static readonly FieldSpec QuoteResponseLevel = new FieldSpec(FieldType.Int, "QuoteResponseLevel");
        public static readonly FieldSpec Account = new FieldSpec(FieldType.HashedSlice8, "Account");
        public static readonly FieldSpec AcctIDSource = new FieldSpec(FieldType.Int, "AcctIDSource");
        public static readonly FieldSpec AccountType = new FieldSpec(FieldType.Int, "AccountType");
        public static readonly FieldSpec DefBidSize = new FieldSpec(FieldType.Float, "DefBidSize");
        public static readonly FieldSpec DefOfferSize = new FieldSpec(FieldType.Float, "DefOfferSize");
        public static readonly FieldSpec ComplianceID = new FieldSpec(FieldType.HashedSlice8, "ComplianceID");
        public static readonly FieldSpec[] Schema = new FieldSpec[]
        {
            QuoteReqID,
            QuoteID,
            QuoteType,
            QuoteResponseLevel,
            Account,
            AcctIDSource,
            AccountType,
            DefBidSize,
            DefOfferSize,
            ComplianceID,
        };
        public static FieldSpec GetFieldSpec(int tag)
        {
            return tag switch
            {
                131 => QuoteReqID,
                117 => QuoteID,
                537 => QuoteType,
                301 => QuoteResponseLevel,
                1 => Account,
                660 => AcctIDSource,
                581 => AccountType,
                293 => DefBidSize,
                294 => DefOfferSize,
                376 => ComplianceID,
                _ => throw new ArgumentException($"Invalid tag value {tag}")
            };
        }
    }
}

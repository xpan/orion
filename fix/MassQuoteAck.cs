using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class MassQuoteAck
    {
        public static readonly FieldSpec QuoteReqID = new FieldSpec(FieldType.HashedSlice8, "QuoteReqID");
        public static readonly FieldSpec QuoteID = new FieldSpec(FieldType.HashedSlice8, "QuoteID");
        public static readonly FieldSpec QuoteStatus = new FieldSpec(FieldType.Int, "QuoteStatus");
        public static readonly FieldSpec QuoteRejectReason = new FieldSpec(FieldType.Int, "QuoteRejectReason");
        public static readonly FieldSpec QuoteResponseLevel = new FieldSpec(FieldType.Int, "QuoteResponseLevel");
        public static readonly FieldSpec QuoteType = new FieldSpec(FieldType.Int, "QuoteType");
        public static readonly FieldSpec QuoteCancelType = new FieldSpec(FieldType.Int, "QuoteCancelType");
        public static readonly FieldSpec Account = new FieldSpec(FieldType.HashedSlice8, "Account");
        public static readonly FieldSpec AcctIDSource = new FieldSpec(FieldType.Int, "AcctIDSource");
        public static readonly FieldSpec AccountType = new FieldSpec(FieldType.Int, "AccountType");
        public static readonly FieldSpec Text = new FieldSpec(FieldType.HashedSlice8, "Text");
        public static readonly FieldSpec EncodedTextLen = new FieldSpec(FieldType.Int, "EncodedTextLen");
        public static readonly FieldSpec EncodedText = new FieldSpec(FieldType.HashedSlice8, "EncodedText");
        public static readonly FieldSpec ComplianceID = new FieldSpec(FieldType.HashedSlice8, "ComplianceID");
        public static readonly FieldSpec[] Schema = new FieldSpec[]
        {
            QuoteReqID,
            QuoteID,
            QuoteStatus,
            QuoteRejectReason,
            QuoteResponseLevel,
            QuoteType,
            QuoteCancelType,
            Account,
            AcctIDSource,
            AccountType,
            Text,
            EncodedTextLen,
            EncodedText,
            ComplianceID,
        };
        public static FieldSpec GetFieldSpec(int tag)
        {
            return tag switch
            {
                131 => QuoteReqID,
                117 => QuoteID,
                297 => QuoteStatus,
                300 => QuoteRejectReason,
                301 => QuoteResponseLevel,
                537 => QuoteType,
                298 => QuoteCancelType,
                1 => Account,
                660 => AcctIDSource,
                581 => AccountType,
                58 => Text,
                354 => EncodedTextLen,
                355 => EncodedText,
                376 => ComplianceID,
                _ => throw new ArgumentException($"Invalid tag value {tag}")
            };
        }
    }
}

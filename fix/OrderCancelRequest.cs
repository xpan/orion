using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class OrderCancelRequest
    {
        public static readonly FieldSpec OrigClOrdID = new FieldSpec(FieldType.HashedSlice8, "OrigClOrdID");
        public static readonly FieldSpec OrderID = new FieldSpec(FieldType.HashedSlice8, "OrderID");
        public static readonly FieldSpec ClOrdID = new FieldSpec(FieldType.HashedSlice8, "ClOrdID");
        public static readonly FieldSpec SecondaryClOrdID = new FieldSpec(FieldType.HashedSlice8, "SecondaryClOrdID");
        public static readonly FieldSpec ClOrdLinkID = new FieldSpec(FieldType.HashedSlice8, "ClOrdLinkID");
        public static readonly FieldSpec ListID = new FieldSpec(FieldType.HashedSlice8, "ListID");
        public static readonly FieldSpec OrigOrdModTime = new FieldSpec(FieldType.HashedSlice8, "OrigOrdModTime");
        public static readonly FieldSpec Account = new FieldSpec(FieldType.HashedSlice8, "Account");
        public static readonly FieldSpec AcctIDSource = new FieldSpec(FieldType.Int, "AcctIDSource");
        public static readonly FieldSpec AccountType = new FieldSpec(FieldType.Int, "AccountType");
        public static readonly FieldSpec Side = new FieldSpec(FieldType.Char, "Side");
        public static readonly FieldSpec TransactTime = new FieldSpec(FieldType.HashedSlice8, "TransactTime");
        public static readonly FieldSpec ComplianceID = new FieldSpec(FieldType.HashedSlice8, "ComplianceID");
        public static readonly FieldSpec Text = new FieldSpec(FieldType.HashedSlice8, "Text");
        public static readonly FieldSpec EncodedTextLen = new FieldSpec(FieldType.Int, "EncodedTextLen");
        public static readonly FieldSpec EncodedText = new FieldSpec(FieldType.HashedSlice8, "EncodedText");
        public static readonly FieldSpec ExDestination = new FieldSpec(FieldType.HashedSlice8, "ExDestination");
        public static readonly FieldSpec ExDestinationIDSource = new FieldSpec(FieldType.Char, "ExDestinationIDSource");
        public static readonly FieldSpec[] Schema = new FieldSpec[]
        {
            OrigClOrdID,
            OrderID,
            ClOrdID,
            SecondaryClOrdID,
            ClOrdLinkID,
            ListID,
            OrigOrdModTime,
            Account,
            AcctIDSource,
            AccountType,
            Side,
            TransactTime,
            ComplianceID,
            Text,
            EncodedTextLen,
            EncodedText,
            ExDestination,
            ExDestinationIDSource,
        };
        public static FieldSpec GetFieldSpec(int tag)
        {
            return tag switch
            {
                41 => OrigClOrdID,
                37 => OrderID,
                11 => ClOrdID,
                526 => SecondaryClOrdID,
                583 => ClOrdLinkID,
                66 => ListID,
                586 => OrigOrdModTime,
                1 => Account,
                660 => AcctIDSource,
                581 => AccountType,
                54 => Side,
                60 => TransactTime,
                376 => ComplianceID,
                58 => Text,
                354 => EncodedTextLen,
                355 => EncodedText,
                100 => ExDestination,
                1133 => ExDestinationIDSource,
                _ => throw new ArgumentException($"Invalid tag value {tag}")
            };
        }
    }
}

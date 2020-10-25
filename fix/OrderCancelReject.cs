using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class OrderCancelReject
    {
        public static readonly FieldSpec OrderID = new FieldSpec(FieldType.HashedSlice8, "OrderID");
        public static readonly FieldSpec SecondaryOrderID = new FieldSpec(FieldType.HashedSlice8, "SecondaryOrderID");
        public static readonly FieldSpec SecondaryClOrdID = new FieldSpec(FieldType.HashedSlice8, "SecondaryClOrdID");
        public static readonly FieldSpec ClOrdID = new FieldSpec(FieldType.HashedSlice8, "ClOrdID");
        public static readonly FieldSpec ClOrdLinkID = new FieldSpec(FieldType.HashedSlice8, "ClOrdLinkID");
        public static readonly FieldSpec OrigClOrdID = new FieldSpec(FieldType.HashedSlice8, "OrigClOrdID");
        public static readonly FieldSpec OrdStatus = new FieldSpec(FieldType.Char, "OrdStatus");
        public static readonly FieldSpec WorkingIndicator = new FieldSpec(FieldType.Char, "WorkingIndicator");
        public static readonly FieldSpec OrigOrdModTime = new FieldSpec(FieldType.HashedSlice8, "OrigOrdModTime");
        public static readonly FieldSpec ListID = new FieldSpec(FieldType.HashedSlice8, "ListID");
        public static readonly FieldSpec Account = new FieldSpec(FieldType.HashedSlice8, "Account");
        public static readonly FieldSpec AcctIDSource = new FieldSpec(FieldType.Int, "AcctIDSource");
        public static readonly FieldSpec AccountType = new FieldSpec(FieldType.Int, "AccountType");
        public static readonly FieldSpec TradeOriginationDate = new FieldSpec(FieldType.HashedSlice8, "TradeOriginationDate");
        public static readonly FieldSpec TradeDate = new FieldSpec(FieldType.HashedSlice8, "TradeDate");
        public static readonly FieldSpec TransactTime = new FieldSpec(FieldType.HashedSlice8, "TransactTime");
        public static readonly FieldSpec CxlRejResponseTo = new FieldSpec(FieldType.Char, "CxlRejResponseTo");
        public static readonly FieldSpec CxlRejReason = new FieldSpec(FieldType.Int, "CxlRejReason");
        public static readonly FieldSpec Text = new FieldSpec(FieldType.HashedSlice8, "Text");
        public static readonly FieldSpec EncodedTextLen = new FieldSpec(FieldType.Int, "EncodedTextLen");
        public static readonly FieldSpec EncodedText = new FieldSpec(FieldType.HashedSlice8, "EncodedText");
        public static readonly FieldSpec ExDestination = new FieldSpec(FieldType.HashedSlice8, "ExDestination");
        public static readonly FieldSpec ExDestinationIDSource = new FieldSpec(FieldType.Char, "ExDestinationIDSource");
        public static readonly FieldSpec[] Schema = new FieldSpec[]
        {
            OrderID,
            SecondaryOrderID,
            SecondaryClOrdID,
            ClOrdID,
            ClOrdLinkID,
            OrigClOrdID,
            OrdStatus,
            WorkingIndicator,
            OrigOrdModTime,
            ListID,
            Account,
            AcctIDSource,
            AccountType,
            TradeOriginationDate,
            TradeDate,
            TransactTime,
            CxlRejResponseTo,
            CxlRejReason,
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
                37 => OrderID,
                198 => SecondaryOrderID,
                526 => SecondaryClOrdID,
                11 => ClOrdID,
                583 => ClOrdLinkID,
                41 => OrigClOrdID,
                39 => OrdStatus,
                636 => WorkingIndicator,
                586 => OrigOrdModTime,
                66 => ListID,
                1 => Account,
                660 => AcctIDSource,
                581 => AccountType,
                229 => TradeOriginationDate,
                75 => TradeDate,
                60 => TransactTime,
                434 => CxlRejResponseTo,
                102 => CxlRejReason,
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

using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class OrderStatusRequest
    {
        public static readonly FieldSpec OrderID = new FieldSpec(FieldType.HashedSlice8, "OrderID");
        public static readonly FieldSpec ClOrdID = new FieldSpec(FieldType.HashedSlice8, "ClOrdID");
        public static readonly FieldSpec SecondaryClOrdID = new FieldSpec(FieldType.HashedSlice8, "SecondaryClOrdID");
        public static readonly FieldSpec ClOrdLinkID = new FieldSpec(FieldType.HashedSlice8, "ClOrdLinkID");
        public static readonly FieldSpec OrdStatusReqID = new FieldSpec(FieldType.HashedSlice8, "OrdStatusReqID");
        public static readonly FieldSpec Account = new FieldSpec(FieldType.HashedSlice8, "Account");
        public static readonly FieldSpec AcctIDSource = new FieldSpec(FieldType.Int, "AcctIDSource");
        public static readonly FieldSpec Side = new FieldSpec(FieldType.Char, "Side");
        public static readonly FieldSpec[] Schema = new FieldSpec[]
        {
            OrderID,
            ClOrdID,
            SecondaryClOrdID,
            ClOrdLinkID,
            OrdStatusReqID,
            Account,
            AcctIDSource,
            Side,
        };
        public static FieldSpec GetFieldSpec(int tag)
        {
            return tag switch
            {
                37 => OrderID,
                11 => ClOrdID,
                526 => SecondaryClOrdID,
                583 => ClOrdLinkID,
                790 => OrdStatusReqID,
                1 => Account,
                660 => AcctIDSource,
                54 => Side,
                _ => throw new ArgumentException($"Invalid tag value {tag}")
            };
        }
    }
}

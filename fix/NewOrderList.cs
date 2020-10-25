using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class NewOrderList
    {
        public static readonly FieldSpec ListID = new FieldSpec(FieldType.HashedSlice8, "ListID");
        public static readonly FieldSpec BidID = new FieldSpec(FieldType.HashedSlice8, "BidID");
        public static readonly FieldSpec ClientBidID = new FieldSpec(FieldType.HashedSlice8, "ClientBidID");
        public static readonly FieldSpec ProgRptReqs = new FieldSpec(FieldType.Int, "ProgRptReqs");
        public static readonly FieldSpec BidType = new FieldSpec(FieldType.Int, "BidType");
        public static readonly FieldSpec ProgPeriodInterval = new FieldSpec(FieldType.Int, "ProgPeriodInterval");
        public static readonly FieldSpec CancellationRights = new FieldSpec(FieldType.Char, "CancellationRights");
        public static readonly FieldSpec MoneyLaunderingStatus = new FieldSpec(FieldType.Char, "MoneyLaunderingStatus");
        public static readonly FieldSpec RegistID = new FieldSpec(FieldType.HashedSlice8, "RegistID");
        public static readonly FieldSpec ListExecInstType = new FieldSpec(FieldType.Char, "ListExecInstType");
        public static readonly FieldSpec ListExecInst = new FieldSpec(FieldType.HashedSlice8, "ListExecInst");
        public static readonly FieldSpec EncodedListExecInstLen = new FieldSpec(FieldType.Int, "EncodedListExecInstLen");
        public static readonly FieldSpec EncodedListExecInst = new FieldSpec(FieldType.HashedSlice8, "EncodedListExecInst");
        public static readonly FieldSpec AllowableOneSidednessPct = new FieldSpec(FieldType.Float, "AllowableOneSidednessPct");
        public static readonly FieldSpec AllowableOneSidednessValue = new FieldSpec(FieldType.Float, "AllowableOneSidednessValue");
        public static readonly FieldSpec AllowableOneSidednessCurr = new FieldSpec(FieldType.HashedSlice8, "AllowableOneSidednessCurr");
        public static readonly FieldSpec TotNoOrders = new FieldSpec(FieldType.Int, "TotNoOrders");
        public static readonly FieldSpec LastFragment = new FieldSpec(FieldType.Char, "LastFragment");
        public static readonly FieldSpec[] Schema = new FieldSpec[]
        {
            ListID,
            BidID,
            ClientBidID,
            ProgRptReqs,
            BidType,
            ProgPeriodInterval,
            CancellationRights,
            MoneyLaunderingStatus,
            RegistID,
            ListExecInstType,
            ListExecInst,
            EncodedListExecInstLen,
            EncodedListExecInst,
            AllowableOneSidednessPct,
            AllowableOneSidednessValue,
            AllowableOneSidednessCurr,
            TotNoOrders,
            LastFragment,
        };
        public static FieldSpec GetFieldSpec(int tag)
        {
            return tag switch
            {
                66 => ListID,
                390 => BidID,
                391 => ClientBidID,
                414 => ProgRptReqs,
                394 => BidType,
                415 => ProgPeriodInterval,
                480 => CancellationRights,
                481 => MoneyLaunderingStatus,
                513 => RegistID,
                433 => ListExecInstType,
                69 => ListExecInst,
                352 => EncodedListExecInstLen,
                353 => EncodedListExecInst,
                765 => AllowableOneSidednessPct,
                766 => AllowableOneSidednessValue,
                767 => AllowableOneSidednessCurr,
                68 => TotNoOrders,
                893 => LastFragment,
                _ => throw new ArgumentException($"Invalid tag value {tag}")
            };
        }
    }
}

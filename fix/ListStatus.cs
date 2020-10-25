using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class ListStatus
    {
        public static readonly FieldSpec ListID = new FieldSpec(FieldType.HashedSlice8, "ListID");
        public static readonly FieldSpec ListStatusType = new FieldSpec(FieldType.Int, "ListStatusType");
        public static readonly FieldSpec NoRpts = new FieldSpec(FieldType.Int, "NoRpts");
        public static readonly FieldSpec ListOrderStatus = new FieldSpec(FieldType.Int, "ListOrderStatus");
        public static readonly FieldSpec RptSeq = new FieldSpec(FieldType.Int, "RptSeq");
        public static readonly FieldSpec ListStatusText = new FieldSpec(FieldType.HashedSlice8, "ListStatusText");
        public static readonly FieldSpec EncodedListStatusTextLen = new FieldSpec(FieldType.Int, "EncodedListStatusTextLen");
        public static readonly FieldSpec EncodedListStatusText = new FieldSpec(FieldType.HashedSlice8, "EncodedListStatusText");
        public static readonly FieldSpec TransactTime = new FieldSpec(FieldType.HashedSlice8, "TransactTime");
        public static readonly FieldSpec TotNoOrders = new FieldSpec(FieldType.Int, "TotNoOrders");
        public static readonly FieldSpec LastFragment = new FieldSpec(FieldType.Char, "LastFragment");
        public static readonly FieldSpec[] Schema = new FieldSpec[]
        {
            ListID,
            ListStatusType,
            NoRpts,
            ListOrderStatus,
            RptSeq,
            ListStatusText,
            EncodedListStatusTextLen,
            EncodedListStatusText,
            TransactTime,
            TotNoOrders,
            LastFragment,
        };
        public static FieldSpec GetFieldSpec(int tag)
        {
            return tag switch
            {
                66 => ListID,
                429 => ListStatusType,
                82 => NoRpts,
                431 => ListOrderStatus,
                83 => RptSeq,
                444 => ListStatusText,
                445 => EncodedListStatusTextLen,
                446 => EncodedListStatusText,
                60 => TransactTime,
                68 => TotNoOrders,
                893 => LastFragment,
                _ => throw new ArgumentException($"Invalid tag value {tag}")
            };
        }
    }
}

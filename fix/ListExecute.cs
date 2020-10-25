using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class ListExecute
    {
        public static readonly FieldSpec ListID = new FieldSpec(FieldType.HashedSlice8, "ListID");
        public static readonly FieldSpec ClientBidID = new FieldSpec(FieldType.HashedSlice8, "ClientBidID");
        public static readonly FieldSpec BidID = new FieldSpec(FieldType.HashedSlice8, "BidID");
        public static readonly FieldSpec TransactTime = new FieldSpec(FieldType.HashedSlice8, "TransactTime");
        public static readonly FieldSpec Text = new FieldSpec(FieldType.HashedSlice8, "Text");
        public static readonly FieldSpec EncodedTextLen = new FieldSpec(FieldType.Int, "EncodedTextLen");
        public static readonly FieldSpec EncodedText = new FieldSpec(FieldType.HashedSlice8, "EncodedText");
        public static readonly FieldSpec[] Schema = new FieldSpec[]
        {
            ListID,
            ClientBidID,
            BidID,
            TransactTime,
            Text,
            EncodedTextLen,
            EncodedText,
        };
        public static FieldSpec GetFieldSpec(int tag)
        {
            return tag switch
            {
                66 => ListID,
                391 => ClientBidID,
                390 => BidID,
                60 => TransactTime,
                58 => Text,
                354 => EncodedTextLen,
                355 => EncodedText,
                _ => throw new ArgumentException($"Invalid tag value {tag}")
            };
        }
    }
}

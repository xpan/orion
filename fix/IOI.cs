using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class IOI
    {
        public static readonly FieldSpec IOIID = new FieldSpec(FieldType.HashedSlice8, "IOIID");
        public static readonly FieldSpec IOITransType = new FieldSpec(FieldType.Char, "IOITransType");
        public static readonly FieldSpec IOIRefID = new FieldSpec(FieldType.HashedSlice8, "IOIRefID");
        public static readonly FieldSpec Side = new FieldSpec(FieldType.Char, "Side");
        public static readonly FieldSpec QtyType = new FieldSpec(FieldType.Int, "QtyType");
        public static readonly FieldSpec IOIQty = new FieldSpec(FieldType.HashedSlice8, "IOIQty");
        public static readonly FieldSpec Currency = new FieldSpec(FieldType.HashedSlice8, "Currency");
        public static readonly FieldSpec PriceType = new FieldSpec(FieldType.Int, "PriceType");
        public static readonly FieldSpec Price = new FieldSpec(FieldType.Float, "Price");
        public static readonly FieldSpec ValidUntilTime = new FieldSpec(FieldType.HashedSlice8, "ValidUntilTime");
        public static readonly FieldSpec IOIQltyInd = new FieldSpec(FieldType.Char, "IOIQltyInd");
        public static readonly FieldSpec IOINaturalFlag = new FieldSpec(FieldType.Char, "IOINaturalFlag");
        public static readonly FieldSpec Text = new FieldSpec(FieldType.HashedSlice8, "Text");
        public static readonly FieldSpec EncodedTextLen = new FieldSpec(FieldType.Int, "EncodedTextLen");
        public static readonly FieldSpec EncodedText = new FieldSpec(FieldType.HashedSlice8, "EncodedText");
        public static readonly FieldSpec TransactTime = new FieldSpec(FieldType.HashedSlice8, "TransactTime");
        public static readonly FieldSpec URLLink = new FieldSpec(FieldType.HashedSlice8, "URLLink");
        public static readonly FieldSpec[] Schema = new FieldSpec[]
        {
            IOIID,
            IOITransType,
            IOIRefID,
            Side,
            QtyType,
            IOIQty,
            Currency,
            PriceType,
            Price,
            ValidUntilTime,
            IOIQltyInd,
            IOINaturalFlag,
            Text,
            EncodedTextLen,
            EncodedText,
            TransactTime,
            URLLink,
        };
        public static FieldSpec GetFieldSpec(int tag)
        {
            return tag switch
            {
                23 => IOIID,
                28 => IOITransType,
                26 => IOIRefID,
                54 => Side,
                854 => QtyType,
                27 => IOIQty,
                15 => Currency,
                423 => PriceType,
                44 => Price,
                62 => ValidUntilTime,
                25 => IOIQltyInd,
                130 => IOINaturalFlag,
                58 => Text,
                354 => EncodedTextLen,
                355 => EncodedText,
                60 => TransactTime,
                149 => URLLink,
                _ => throw new ArgumentException($"Invalid tag value {tag}")
            };
        }
    }
}

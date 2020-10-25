using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class BidRequest
    {
        public static readonly FieldSpec BidID = new FieldSpec(FieldType.HashedSlice8, "BidID");
        public static readonly FieldSpec ClientBidID = new FieldSpec(FieldType.HashedSlice8, "ClientBidID");
        public static readonly FieldSpec BidRequestTransType = new FieldSpec(FieldType.Char, "BidRequestTransType");
        public static readonly FieldSpec ListName = new FieldSpec(FieldType.HashedSlice8, "ListName");
        public static readonly FieldSpec TotNoRelatedSym = new FieldSpec(FieldType.Int, "TotNoRelatedSym");
        public static readonly FieldSpec BidType = new FieldSpec(FieldType.Int, "BidType");
        public static readonly FieldSpec NumTickets = new FieldSpec(FieldType.Int, "NumTickets");
        public static readonly FieldSpec Currency = new FieldSpec(FieldType.HashedSlice8, "Currency");
        public static readonly FieldSpec SideValue1 = new FieldSpec(FieldType.Float, "SideValue1");
        public static readonly FieldSpec SideValue2 = new FieldSpec(FieldType.Float, "SideValue2");
        public static readonly FieldSpec LiquidityIndType = new FieldSpec(FieldType.Int, "LiquidityIndType");
        public static readonly FieldSpec WtAverageLiquidity = new FieldSpec(FieldType.Float, "WtAverageLiquidity");
        public static readonly FieldSpec ExchangeForPhysical = new FieldSpec(FieldType.Char, "ExchangeForPhysical");
        public static readonly FieldSpec OutMainCntryUIndex = new FieldSpec(FieldType.Float, "OutMainCntryUIndex");
        public static readonly FieldSpec CrossPercent = new FieldSpec(FieldType.Float, "CrossPercent");
        public static readonly FieldSpec ProgRptReqs = new FieldSpec(FieldType.Int, "ProgRptReqs");
        public static readonly FieldSpec ProgPeriodInterval = new FieldSpec(FieldType.Int, "ProgPeriodInterval");
        public static readonly FieldSpec IncTaxInd = new FieldSpec(FieldType.Int, "IncTaxInd");
        public static readonly FieldSpec ForexReq = new FieldSpec(FieldType.Char, "ForexReq");
        public static readonly FieldSpec NumBidders = new FieldSpec(FieldType.Int, "NumBidders");
        public static readonly FieldSpec TradeDate = new FieldSpec(FieldType.HashedSlice8, "TradeDate");
        public static readonly FieldSpec BidTradeType = new FieldSpec(FieldType.Char, "BidTradeType");
        public static readonly FieldSpec BasisPxType = new FieldSpec(FieldType.Char, "BasisPxType");
        public static readonly FieldSpec StrikeTime = new FieldSpec(FieldType.HashedSlice8, "StrikeTime");
        public static readonly FieldSpec Text = new FieldSpec(FieldType.HashedSlice8, "Text");
        public static readonly FieldSpec EncodedTextLen = new FieldSpec(FieldType.Int, "EncodedTextLen");
        public static readonly FieldSpec EncodedText = new FieldSpec(FieldType.HashedSlice8, "EncodedText");
        public static readonly FieldSpec[] Schema = new FieldSpec[]
        {
            BidID,
            ClientBidID,
            BidRequestTransType,
            ListName,
            TotNoRelatedSym,
            BidType,
            NumTickets,
            Currency,
            SideValue1,
            SideValue2,
            LiquidityIndType,
            WtAverageLiquidity,
            ExchangeForPhysical,
            OutMainCntryUIndex,
            CrossPercent,
            ProgRptReqs,
            ProgPeriodInterval,
            IncTaxInd,
            ForexReq,
            NumBidders,
            TradeDate,
            BidTradeType,
            BasisPxType,
            StrikeTime,
            Text,
            EncodedTextLen,
            EncodedText,
        };
        public static FieldSpec GetFieldSpec(int tag)
        {
            return tag switch
            {
                390 => BidID,
                391 => ClientBidID,
                374 => BidRequestTransType,
                392 => ListName,
                393 => TotNoRelatedSym,
                394 => BidType,
                395 => NumTickets,
                15 => Currency,
                396 => SideValue1,
                397 => SideValue2,
                409 => LiquidityIndType,
                410 => WtAverageLiquidity,
                411 => ExchangeForPhysical,
                412 => OutMainCntryUIndex,
                413 => CrossPercent,
                414 => ProgRptReqs,
                415 => ProgPeriodInterval,
                416 => IncTaxInd,
                121 => ForexReq,
                417 => NumBidders,
                75 => TradeDate,
                418 => BidTradeType,
                419 => BasisPxType,
                443 => StrikeTime,
                58 => Text,
                354 => EncodedTextLen,
                355 => EncodedText,
                _ => throw new ArgumentException($"Invalid tag value {tag}")
            };
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class Quote
    {
        public static readonly FieldSpec QuoteReqID = new FieldSpec(FieldType.HashedSlice8, "QuoteReqID");
        public static readonly FieldSpec QuoteID = new FieldSpec(FieldType.HashedSlice8, "QuoteID");
        public static readonly FieldSpec QuoteRespID = new FieldSpec(FieldType.HashedSlice8, "QuoteRespID");
        public static readonly FieldSpec QuoteType = new FieldSpec(FieldType.Int, "QuoteType");
        public static readonly FieldSpec QuoteResponseLevel = new FieldSpec(FieldType.Int, "QuoteResponseLevel");
        public static readonly FieldSpec TradingSessionID = new FieldSpec(FieldType.HashedSlice8, "TradingSessionID");
        public static readonly FieldSpec TradingSessionSubID = new FieldSpec(FieldType.HashedSlice8, "TradingSessionSubID");
        public static readonly FieldSpec Side = new FieldSpec(FieldType.Char, "Side");
        public static readonly FieldSpec SettlType = new FieldSpec(FieldType.HashedSlice8, "SettlType");
        public static readonly FieldSpec SettlDate = new FieldSpec(FieldType.HashedSlice8, "SettlDate");
        public static readonly FieldSpec SettlDate2 = new FieldSpec(FieldType.HashedSlice8, "SettlDate2");
        public static readonly FieldSpec OrderQty2 = new FieldSpec(FieldType.Float, "OrderQty2");
        public static readonly FieldSpec Currency = new FieldSpec(FieldType.HashedSlice8, "Currency");
        public static readonly FieldSpec Account = new FieldSpec(FieldType.HashedSlice8, "Account");
        public static readonly FieldSpec AcctIDSource = new FieldSpec(FieldType.Int, "AcctIDSource");
        public static readonly FieldSpec AccountType = new FieldSpec(FieldType.Int, "AccountType");
        public static readonly FieldSpec BidPx = new FieldSpec(FieldType.Float, "BidPx");
        public static readonly FieldSpec OfferPx = new FieldSpec(FieldType.Float, "OfferPx");
        public static readonly FieldSpec MktBidPx = new FieldSpec(FieldType.Float, "MktBidPx");
        public static readonly FieldSpec MktOfferPx = new FieldSpec(FieldType.Float, "MktOfferPx");
        public static readonly FieldSpec MinBidSize = new FieldSpec(FieldType.Float, "MinBidSize");
        public static readonly FieldSpec BidSize = new FieldSpec(FieldType.Float, "BidSize");
        public static readonly FieldSpec MinOfferSize = new FieldSpec(FieldType.Float, "MinOfferSize");
        public static readonly FieldSpec OfferSize = new FieldSpec(FieldType.Float, "OfferSize");
        public static readonly FieldSpec MinQty = new FieldSpec(FieldType.Float, "MinQty");
        public static readonly FieldSpec ValidUntilTime = new FieldSpec(FieldType.HashedSlice8, "ValidUntilTime");
        public static readonly FieldSpec BidSpotRate = new FieldSpec(FieldType.Float, "BidSpotRate");
        public static readonly FieldSpec OfferSpotRate = new FieldSpec(FieldType.Float, "OfferSpotRate");
        public static readonly FieldSpec BidForwardPoints = new FieldSpec(FieldType.Float, "BidForwardPoints");
        public static readonly FieldSpec OfferForwardPoints = new FieldSpec(FieldType.Float, "OfferForwardPoints");
        public static readonly FieldSpec BidSwapPoints = new FieldSpec(FieldType.Float, "BidSwapPoints");
        public static readonly FieldSpec OfferSwapPoints = new FieldSpec(FieldType.Float, "OfferSwapPoints");
        public static readonly FieldSpec MidPx = new FieldSpec(FieldType.Float, "MidPx");
        public static readonly FieldSpec BidYield = new FieldSpec(FieldType.Float, "BidYield");
        public static readonly FieldSpec MidYield = new FieldSpec(FieldType.Float, "MidYield");
        public static readonly FieldSpec OfferYield = new FieldSpec(FieldType.Float, "OfferYield");
        public static readonly FieldSpec TransactTime = new FieldSpec(FieldType.HashedSlice8, "TransactTime");
        public static readonly FieldSpec OrdType = new FieldSpec(FieldType.Char, "OrdType");
        public static readonly FieldSpec BidForwardPoints2 = new FieldSpec(FieldType.Float, "BidForwardPoints2");
        public static readonly FieldSpec OfferForwardPoints2 = new FieldSpec(FieldType.Float, "OfferForwardPoints2");
        public static readonly FieldSpec SettlCurrBidFxRate = new FieldSpec(FieldType.Float, "SettlCurrBidFxRate");
        public static readonly FieldSpec SettlCurrOfferFxRate = new FieldSpec(FieldType.Float, "SettlCurrOfferFxRate");
        public static readonly FieldSpec SettlCurrFxRateCalc = new FieldSpec(FieldType.Char, "SettlCurrFxRateCalc");
        public static readonly FieldSpec CustOrderCapacity = new FieldSpec(FieldType.Int, "CustOrderCapacity");
        public static readonly FieldSpec ExDestination = new FieldSpec(FieldType.HashedSlice8, "ExDestination");
        public static readonly FieldSpec ExDestinationIDSource = new FieldSpec(FieldType.Char, "ExDestinationIDSource");
        public static readonly FieldSpec OrderCapacity = new FieldSpec(FieldType.Char, "OrderCapacity");
        public static readonly FieldSpec PriceType = new FieldSpec(FieldType.Int, "PriceType");
        public static readonly FieldSpec Text = new FieldSpec(FieldType.HashedSlice8, "Text");
        public static readonly FieldSpec EncodedTextLen = new FieldSpec(FieldType.Int, "EncodedTextLen");
        public static readonly FieldSpec EncodedText = new FieldSpec(FieldType.HashedSlice8, "EncodedText");
        public static readonly FieldSpec BookingType = new FieldSpec(FieldType.Int, "BookingType");
        public static readonly FieldSpec OrderRestrictions = new FieldSpec(FieldType.HashedSlice8, "OrderRestrictions");
        public static readonly FieldSpec SettlCurrency = new FieldSpec(FieldType.HashedSlice8, "SettlCurrency");
        public static readonly FieldSpec BidID = new FieldSpec(FieldType.HashedSlice8, "BidID");
        public static readonly FieldSpec ComplianceID = new FieldSpec(FieldType.HashedSlice8, "ComplianceID");
        public static readonly FieldSpec StrikeTime = new FieldSpec(FieldType.HashedSlice8, "StrikeTime");
        public static readonly FieldSpec OwnerType = new FieldSpec(FieldType.Int, "OwnerType");
        public static readonly FieldSpec SolicitedFlag = new FieldSpec(FieldType.Char, "SolicitedFlag");
        public static readonly FieldSpec TrdType = new FieldSpec(FieldType.Int, "TrdType");
        public static readonly FieldSpec[] Schema = new FieldSpec[]
        {
            QuoteReqID,
            QuoteID,
            QuoteRespID,
            QuoteType,
            QuoteResponseLevel,
            TradingSessionID,
            TradingSessionSubID,
            Side,
            SettlType,
            SettlDate,
            SettlDate2,
            OrderQty2,
            Currency,
            Account,
            AcctIDSource,
            AccountType,
            BidPx,
            OfferPx,
            MktBidPx,
            MktOfferPx,
            MinBidSize,
            BidSize,
            MinOfferSize,
            OfferSize,
            MinQty,
            ValidUntilTime,
            BidSpotRate,
            OfferSpotRate,
            BidForwardPoints,
            OfferForwardPoints,
            BidSwapPoints,
            OfferSwapPoints,
            MidPx,
            BidYield,
            MidYield,
            OfferYield,
            TransactTime,
            OrdType,
            BidForwardPoints2,
            OfferForwardPoints2,
            SettlCurrBidFxRate,
            SettlCurrOfferFxRate,
            SettlCurrFxRateCalc,
            CustOrderCapacity,
            ExDestination,
            ExDestinationIDSource,
            OrderCapacity,
            PriceType,
            Text,
            EncodedTextLen,
            EncodedText,
            BookingType,
            OrderRestrictions,
            SettlCurrency,
            BidID,
            ComplianceID,
            StrikeTime,
            OwnerType,
            SolicitedFlag,
            TrdType,
        };
        public static FieldSpec GetFieldSpec(int tag)
        {
            return tag switch
            {
                131 => QuoteReqID,
                117 => QuoteID,
                693 => QuoteRespID,
                537 => QuoteType,
                301 => QuoteResponseLevel,
                336 => TradingSessionID,
                625 => TradingSessionSubID,
                54 => Side,
                63 => SettlType,
                64 => SettlDate,
                193 => SettlDate2,
                192 => OrderQty2,
                15 => Currency,
                1 => Account,
                660 => AcctIDSource,
                581 => AccountType,
                132 => BidPx,
                133 => OfferPx,
                645 => MktBidPx,
                646 => MktOfferPx,
                647 => MinBidSize,
                134 => BidSize,
                648 => MinOfferSize,
                135 => OfferSize,
                110 => MinQty,
                62 => ValidUntilTime,
                188 => BidSpotRate,
                190 => OfferSpotRate,
                189 => BidForwardPoints,
                191 => OfferForwardPoints,
                1065 => BidSwapPoints,
                1066 => OfferSwapPoints,
                631 => MidPx,
                632 => BidYield,
                633 => MidYield,
                634 => OfferYield,
                60 => TransactTime,
                40 => OrdType,
                642 => BidForwardPoints2,
                643 => OfferForwardPoints2,
                656 => SettlCurrBidFxRate,
                657 => SettlCurrOfferFxRate,
                156 => SettlCurrFxRateCalc,
                582 => CustOrderCapacity,
                100 => ExDestination,
                1133 => ExDestinationIDSource,
                528 => OrderCapacity,
                423 => PriceType,
                58 => Text,
                354 => EncodedTextLen,
                355 => EncodedText,
                775 => BookingType,
                529 => OrderRestrictions,
                120 => SettlCurrency,
                390 => BidID,
                376 => ComplianceID,
                443 => StrikeTime,
                522 => OwnerType,
                377 => SolicitedFlag,
                828 => TrdType,
                _ => throw new ArgumentException($"Invalid tag value {tag}")
            };
        }
    }
}

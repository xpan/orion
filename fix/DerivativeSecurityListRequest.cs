using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class DerivativeSecurityListRequest
    {
        // Begin StandardHeader
        public static readonly FieldSpec BeginString = new FieldSpec(FieldType.HashedSlice16, "BeginString");
        public static readonly FieldSpec BodyLength = new FieldSpec(FieldType.Int, "BodyLength");
        public static readonly FieldSpec MsgType = new FieldSpec(FieldType.HashedSlice16, "MsgType");
        public static readonly FieldSpec ApplVerID = new FieldSpec(FieldType.HashedSlice16, "ApplVerID");
        public static readonly FieldSpec CstmApplVerID = new FieldSpec(FieldType.HashedSlice16, "CstmApplVerID");
        public static readonly FieldSpec SenderCompID = new FieldSpec(FieldType.HashedSlice16, "SenderCompID");
        public static readonly FieldSpec TargetCompID = new FieldSpec(FieldType.HashedSlice16, "TargetCompID");
        public static readonly FieldSpec OnBehalfOfCompID = new FieldSpec(FieldType.HashedSlice16, "OnBehalfOfCompID");
        public static readonly FieldSpec DeliverToCompID = new FieldSpec(FieldType.HashedSlice16, "DeliverToCompID");
        public static readonly FieldSpec SecureDataLen = new FieldSpec(FieldType.Int, "SecureDataLen");
        public static readonly FieldSpec SecureData = new FieldSpec(FieldType.HashedSlice16, "SecureData");
        public static readonly FieldSpec MsgSeqNum = new FieldSpec(FieldType.Int, "MsgSeqNum");
        public static readonly FieldSpec SenderSubID = new FieldSpec(FieldType.HashedSlice16, "SenderSubID");
        public static readonly FieldSpec SenderLocationID = new FieldSpec(FieldType.HashedSlice16, "SenderLocationID");
        public static readonly FieldSpec TargetSubID = new FieldSpec(FieldType.HashedSlice16, "TargetSubID");
        public static readonly FieldSpec TargetLocationID = new FieldSpec(FieldType.HashedSlice16, "TargetLocationID");
        public static readonly FieldSpec OnBehalfOfSubID = new FieldSpec(FieldType.HashedSlice16, "OnBehalfOfSubID");
        public static readonly FieldSpec OnBehalfOfLocationID = new FieldSpec(FieldType.HashedSlice16, "OnBehalfOfLocationID");
        public static readonly FieldSpec DeliverToSubID = new FieldSpec(FieldType.HashedSlice16, "DeliverToSubID");
        public static readonly FieldSpec DeliverToLocationID = new FieldSpec(FieldType.HashedSlice16, "DeliverToLocationID");
        public static readonly FieldSpec PossDupFlag = new FieldSpec(FieldType.Char, "PossDupFlag");
        public static readonly FieldSpec PossResend = new FieldSpec(FieldType.Char, "PossResend");
        public static readonly FieldSpec SendingTime = new FieldSpec(FieldType.HashedSlice16, "SendingTime");
        public static readonly FieldSpec OrigSendingTime = new FieldSpec(FieldType.HashedSlice16, "OrigSendingTime");
        public static readonly FieldSpec XmlDataLen = new FieldSpec(FieldType.Int, "XmlDataLen");
        public static readonly FieldSpec XmlData = new FieldSpec(FieldType.HashedSlice16, "XmlData");
        public static readonly FieldSpec MessageEncoding = new FieldSpec(FieldType.HashedSlice16, "MessageEncoding");
        public static readonly FieldSpec LastMsgSeqNumProcessed = new FieldSpec(FieldType.Int, "LastMsgSeqNumProcessed");
        // Begin HopGrp
        public static readonly FieldSpec NoHops = new FieldSpec(FieldType.Int, "NoHops");
        public static readonly FieldSpec HopCompID = new FieldSpec(FieldType.HashedSlice16, "HopCompID");
        public static readonly FieldSpec HopSendingTime = new FieldSpec(FieldType.HashedSlice16, "HopSendingTime");
        public static readonly FieldSpec HopRefID = new FieldSpec(FieldType.Int, "HopRefID");
        // End HopGrp
        // End StandardHeader
        public static readonly FieldSpec SecurityReqID = new FieldSpec(FieldType.HashedSlice16, "SecurityReqID");
        public static readonly FieldSpec SecurityListRequestType = new FieldSpec(FieldType.Int, "SecurityListRequestType");
        // Begin UnderlyingInstrument
        public static readonly FieldSpec UnderlyingSymbol = new FieldSpec(FieldType.HashedSlice16, "UnderlyingSymbol");
        public static readonly FieldSpec UnderlyingSymbolSfx = new FieldSpec(FieldType.HashedSlice16, "UnderlyingSymbolSfx");
        public static readonly FieldSpec UnderlyingSecurityID = new FieldSpec(FieldType.HashedSlice16, "UnderlyingSecurityID");
        public static readonly FieldSpec UnderlyingSecurityIDSource = new FieldSpec(FieldType.HashedSlice16, "UnderlyingSecurityIDSource");
        // Begin UndSecAltIDGrp
        public static readonly FieldSpec NoUnderlyingSecurityAltID = new FieldSpec(FieldType.Int, "NoUnderlyingSecurityAltID");
        public static readonly FieldSpec UnderlyingSecurityAltID = new FieldSpec(FieldType.HashedSlice16, "UnderlyingSecurityAltID");
        public static readonly FieldSpec UnderlyingSecurityAltIDSource = new FieldSpec(FieldType.HashedSlice16, "UnderlyingSecurityAltIDSource");
        // End UndSecAltIDGrp
        public static readonly FieldSpec UnderlyingProduct = new FieldSpec(FieldType.Int, "UnderlyingProduct");
        public static readonly FieldSpec UnderlyingCFICode = new FieldSpec(FieldType.HashedSlice16, "UnderlyingCFICode");
        public static readonly FieldSpec UnderlyingSecurityType = new FieldSpec(FieldType.HashedSlice16, "UnderlyingSecurityType");
        public static readonly FieldSpec UnderlyingSecuritySubType = new FieldSpec(FieldType.HashedSlice16, "UnderlyingSecuritySubType");
        public static readonly FieldSpec UnderlyingMaturityMonthYear = new FieldSpec(FieldType.HashedSlice16, "UnderlyingMaturityMonthYear");
        public static readonly FieldSpec UnderlyingMaturityDate = new FieldSpec(FieldType.HashedSlice16, "UnderlyingMaturityDate");
        public static readonly FieldSpec UnderlyingCouponPaymentDate = new FieldSpec(FieldType.HashedSlice16, "UnderlyingCouponPaymentDate");
        public static readonly FieldSpec UnderlyingIssueDate = new FieldSpec(FieldType.HashedSlice16, "UnderlyingIssueDate");
        public static readonly FieldSpec UnderlyingRepoCollateralSecurityType = new FieldSpec(FieldType.HashedSlice16, "UnderlyingRepoCollateralSecurityType");
        public static readonly FieldSpec UnderlyingRepurchaseTerm = new FieldSpec(FieldType.Int, "UnderlyingRepurchaseTerm");
        public static readonly FieldSpec UnderlyingRepurchaseRate = new FieldSpec(FieldType.Float, "UnderlyingRepurchaseRate");
        public static readonly FieldSpec UnderlyingFactor = new FieldSpec(FieldType.Float, "UnderlyingFactor");
        public static readonly FieldSpec UnderlyingCreditRating = new FieldSpec(FieldType.HashedSlice16, "UnderlyingCreditRating");
        public static readonly FieldSpec UnderlyingInstrRegistry = new FieldSpec(FieldType.HashedSlice16, "UnderlyingInstrRegistry");
        public static readonly FieldSpec UnderlyingCountryOfIssue = new FieldSpec(FieldType.HashedSlice16, "UnderlyingCountryOfIssue");
        public static readonly FieldSpec UnderlyingStateOrProvinceOfIssue = new FieldSpec(FieldType.HashedSlice16, "UnderlyingStateOrProvinceOfIssue");
        public static readonly FieldSpec UnderlyingLocaleOfIssue = new FieldSpec(FieldType.HashedSlice16, "UnderlyingLocaleOfIssue");
        public static readonly FieldSpec UnderlyingRedemptionDate = new FieldSpec(FieldType.HashedSlice16, "UnderlyingRedemptionDate");
        public static readonly FieldSpec UnderlyingStrikePrice = new FieldSpec(FieldType.Float, "UnderlyingStrikePrice");
        public static readonly FieldSpec UnderlyingStrikeCurrency = new FieldSpec(FieldType.HashedSlice16, "UnderlyingStrikeCurrency");
        public static readonly FieldSpec UnderlyingOptAttribute = new FieldSpec(FieldType.Char, "UnderlyingOptAttribute");
        public static readonly FieldSpec UnderlyingContractMultiplier = new FieldSpec(FieldType.Float, "UnderlyingContractMultiplier");
        public static readonly FieldSpec UnderlyingUnitOfMeasure = new FieldSpec(FieldType.HashedSlice16, "UnderlyingUnitOfMeasure");
        public static readonly FieldSpec UnderlyingTimeUnit = new FieldSpec(FieldType.HashedSlice16, "UnderlyingTimeUnit");
        public static readonly FieldSpec UnderlyingCouponRate = new FieldSpec(FieldType.Float, "UnderlyingCouponRate");
        public static readonly FieldSpec UnderlyingSecurityExchange = new FieldSpec(FieldType.HashedSlice16, "UnderlyingSecurityExchange");
        public static readonly FieldSpec UnderlyingIssuer = new FieldSpec(FieldType.HashedSlice16, "UnderlyingIssuer");
        public static readonly FieldSpec EncodedUnderlyingIssuerLen = new FieldSpec(FieldType.Int, "EncodedUnderlyingIssuerLen");
        public static readonly FieldSpec EncodedUnderlyingIssuer = new FieldSpec(FieldType.HashedSlice16, "EncodedUnderlyingIssuer");
        public static readonly FieldSpec UnderlyingSecurityDesc = new FieldSpec(FieldType.HashedSlice16, "UnderlyingSecurityDesc");
        public static readonly FieldSpec EncodedUnderlyingSecurityDescLen = new FieldSpec(FieldType.Int, "EncodedUnderlyingSecurityDescLen");
        public static readonly FieldSpec EncodedUnderlyingSecurityDesc = new FieldSpec(FieldType.HashedSlice16, "EncodedUnderlyingSecurityDesc");
        public static readonly FieldSpec UnderlyingCPProgram = new FieldSpec(FieldType.Int, "UnderlyingCPProgram");
        public static readonly FieldSpec UnderlyingCPRegType = new FieldSpec(FieldType.HashedSlice16, "UnderlyingCPRegType");
        public static readonly FieldSpec UnderlyingAllocationPercent = new FieldSpec(FieldType.Float, "UnderlyingAllocationPercent");
        public static readonly FieldSpec UnderlyingCurrency = new FieldSpec(FieldType.HashedSlice16, "UnderlyingCurrency");
        public static readonly FieldSpec UnderlyingQty = new FieldSpec(FieldType.Float, "UnderlyingQty");
        public static readonly FieldSpec UnderlyingSettlementType = new FieldSpec(FieldType.Int, "UnderlyingSettlementType");
        public static readonly FieldSpec UnderlyingCashAmount = new FieldSpec(FieldType.Float, "UnderlyingCashAmount");
        public static readonly FieldSpec UnderlyingCashType = new FieldSpec(FieldType.HashedSlice16, "UnderlyingCashType");
        public static readonly FieldSpec UnderlyingPx = new FieldSpec(FieldType.Float, "UnderlyingPx");
        public static readonly FieldSpec UnderlyingDirtyPrice = new FieldSpec(FieldType.Float, "UnderlyingDirtyPrice");
        public static readonly FieldSpec UnderlyingEndPrice = new FieldSpec(FieldType.Float, "UnderlyingEndPrice");
        public static readonly FieldSpec UnderlyingStartValue = new FieldSpec(FieldType.Float, "UnderlyingStartValue");
        public static readonly FieldSpec UnderlyingCurrentValue = new FieldSpec(FieldType.Float, "UnderlyingCurrentValue");
        public static readonly FieldSpec UnderlyingEndValue = new FieldSpec(FieldType.Float, "UnderlyingEndValue");
        // Begin UnderlyingStipulations
        public static readonly FieldSpec NoUnderlyingStips = new FieldSpec(FieldType.Int, "NoUnderlyingStips");
        public static readonly FieldSpec UnderlyingStipType = new FieldSpec(FieldType.HashedSlice16, "UnderlyingStipType");
        public static readonly FieldSpec UnderlyingStipValue = new FieldSpec(FieldType.HashedSlice16, "UnderlyingStipValue");
        // End UnderlyingStipulations
        public static readonly FieldSpec UnderlyingAdjustedQuantity = new FieldSpec(FieldType.Float, "UnderlyingAdjustedQuantity");
        public static readonly FieldSpec UnderlyingFXRate = new FieldSpec(FieldType.Float, "UnderlyingFXRate");
        public static readonly FieldSpec UnderlyingFXRateCalc = new FieldSpec(FieldType.Char, "UnderlyingFXRateCalc");
        public static readonly FieldSpec UnderlyingCapValue = new FieldSpec(FieldType.Float, "UnderlyingCapValue");
        // Begin UndlyInstrumentParties
        public static readonly FieldSpec NoUndlyInstrumentParties = new FieldSpec(FieldType.Int, "NoUndlyInstrumentParties");
        public static readonly FieldSpec UnderlyingInstrumentPartyID = new FieldSpec(FieldType.HashedSlice16, "UnderlyingInstrumentPartyID");
        public static readonly FieldSpec UnderlyingInstrumentPartyIDSource = new FieldSpec(FieldType.Char, "UnderlyingInstrumentPartyIDSource");
        public static readonly FieldSpec UnderlyingInstrumentPartyRole = new FieldSpec(FieldType.Int, "UnderlyingInstrumentPartyRole");
        // Begin UndlyInstrumentPtysSubGrp
        public static readonly FieldSpec NoUndlyInstrumentPartySubIDs = new FieldSpec(FieldType.Int, "NoUndlyInstrumentPartySubIDs");
        public static readonly FieldSpec UnderlyingInstrumentPartySubID = new FieldSpec(FieldType.HashedSlice16, "UnderlyingInstrumentPartySubID");
        public static readonly FieldSpec UnderlyingInstrumentPartySubIDType = new FieldSpec(FieldType.Int, "UnderlyingInstrumentPartySubIDType");
        // End UndlyInstrumentPtysSubGrp
        // End UndlyInstrumentParties
        public static readonly FieldSpec UnderlyingSettlMethod = new FieldSpec(FieldType.HashedSlice16, "UnderlyingSettlMethod");
        public static readonly FieldSpec UnderlyingPutOrCall = new FieldSpec(FieldType.Int, "UnderlyingPutOrCall");
        // End UnderlyingInstrument
        public static readonly FieldSpec SecuritySubType = new FieldSpec(FieldType.HashedSlice16, "SecuritySubType");
        public static readonly FieldSpec Currency = new FieldSpec(FieldType.HashedSlice16, "Currency");
        public static readonly FieldSpec Text = new FieldSpec(FieldType.HashedSlice16, "Text");
        public static readonly FieldSpec EncodedTextLen = new FieldSpec(FieldType.Int, "EncodedTextLen");
        public static readonly FieldSpec EncodedText = new FieldSpec(FieldType.HashedSlice16, "EncodedText");
        public static readonly FieldSpec TradingSessionID = new FieldSpec(FieldType.HashedSlice16, "TradingSessionID");
        public static readonly FieldSpec TradingSessionSubID = new FieldSpec(FieldType.HashedSlice16, "TradingSessionSubID");
        public static readonly FieldSpec SubscriptionRequestType = new FieldSpec(FieldType.Char, "SubscriptionRequestType");
        // Begin StandardTrailer
        public static readonly FieldSpec SignatureLength = new FieldSpec(FieldType.Int, "SignatureLength");
        public static readonly FieldSpec Signature = new FieldSpec(FieldType.HashedSlice16, "Signature");
        public static readonly FieldSpec CheckSum = new FieldSpec(FieldType.HashedSlice16, "CheckSum");
        // End StandardTrailer
        public static readonly FieldSpec[] Schema = new FieldSpec[]
        {
            BeginString,
            BodyLength,
            MsgType,
            ApplVerID,
            CstmApplVerID,
            SenderCompID,
            TargetCompID,
            OnBehalfOfCompID,
            DeliverToCompID,
            SecureDataLen,
            SecureData,
            MsgSeqNum,
            SenderSubID,
            SenderLocationID,
            TargetSubID,
            TargetLocationID,
            OnBehalfOfSubID,
            OnBehalfOfLocationID,
            DeliverToSubID,
            DeliverToLocationID,
            PossDupFlag,
            PossResend,
            SendingTime,
            OrigSendingTime,
            XmlDataLen,
            XmlData,
            MessageEncoding,
            LastMsgSeqNumProcessed,
            NoHops,
            HopCompID,
            HopSendingTime,
            HopRefID,
            SecurityReqID,
            SecurityListRequestType,
            UnderlyingSymbol,
            UnderlyingSymbolSfx,
            UnderlyingSecurityID,
            UnderlyingSecurityIDSource,
            NoUnderlyingSecurityAltID,
            UnderlyingSecurityAltID,
            UnderlyingSecurityAltIDSource,
            UnderlyingProduct,
            UnderlyingCFICode,
            UnderlyingSecurityType,
            UnderlyingSecuritySubType,
            UnderlyingMaturityMonthYear,
            UnderlyingMaturityDate,
            UnderlyingCouponPaymentDate,
            UnderlyingIssueDate,
            UnderlyingRepoCollateralSecurityType,
            UnderlyingRepurchaseTerm,
            UnderlyingRepurchaseRate,
            UnderlyingFactor,
            UnderlyingCreditRating,
            UnderlyingInstrRegistry,
            UnderlyingCountryOfIssue,
            UnderlyingStateOrProvinceOfIssue,
            UnderlyingLocaleOfIssue,
            UnderlyingRedemptionDate,
            UnderlyingStrikePrice,
            UnderlyingStrikeCurrency,
            UnderlyingOptAttribute,
            UnderlyingContractMultiplier,
            UnderlyingUnitOfMeasure,
            UnderlyingTimeUnit,
            UnderlyingCouponRate,
            UnderlyingSecurityExchange,
            UnderlyingIssuer,
            EncodedUnderlyingIssuerLen,
            EncodedUnderlyingIssuer,
            UnderlyingSecurityDesc,
            EncodedUnderlyingSecurityDescLen,
            EncodedUnderlyingSecurityDesc,
            UnderlyingCPProgram,
            UnderlyingCPRegType,
            UnderlyingAllocationPercent,
            UnderlyingCurrency,
            UnderlyingQty,
            UnderlyingSettlementType,
            UnderlyingCashAmount,
            UnderlyingCashType,
            UnderlyingPx,
            UnderlyingDirtyPrice,
            UnderlyingEndPrice,
            UnderlyingStartValue,
            UnderlyingCurrentValue,
            UnderlyingEndValue,
            NoUnderlyingStips,
            UnderlyingStipType,
            UnderlyingStipValue,
            UnderlyingAdjustedQuantity,
            UnderlyingFXRate,
            UnderlyingFXRateCalc,
            UnderlyingCapValue,
            NoUndlyInstrumentParties,
            UnderlyingInstrumentPartyID,
            UnderlyingInstrumentPartyIDSource,
            UnderlyingInstrumentPartyRole,
            NoUndlyInstrumentPartySubIDs,
            UnderlyingInstrumentPartySubID,
            UnderlyingInstrumentPartySubIDType,
            UnderlyingSettlMethod,
            UnderlyingPutOrCall,
            SecuritySubType,
            Currency,
            Text,
            EncodedTextLen,
            EncodedText,
            TradingSessionID,
            TradingSessionSubID,
            SubscriptionRequestType,
            SignatureLength,
            Signature,
            CheckSum,
        };
        private static readonly Dictionary<int, FieldSpec> tagToFieldSpec = new Dictionary<int, FieldSpec>
        {
            { 8, BeginString },
            { 9, BodyLength },
            { 35, MsgType },
            { 1128, ApplVerID },
            { 1129, CstmApplVerID },
            { 49, SenderCompID },
            { 56, TargetCompID },
            { 115, OnBehalfOfCompID },
            { 128, DeliverToCompID },
            { 90, SecureDataLen },
            { 91, SecureData },
            { 34, MsgSeqNum },
            { 50, SenderSubID },
            { 142, SenderLocationID },
            { 57, TargetSubID },
            { 143, TargetLocationID },
            { 116, OnBehalfOfSubID },
            { 144, OnBehalfOfLocationID },
            { 129, DeliverToSubID },
            { 145, DeliverToLocationID },
            { 43, PossDupFlag },
            { 97, PossResend },
            { 52, SendingTime },
            { 122, OrigSendingTime },
            { 212, XmlDataLen },
            { 213, XmlData },
            { 347, MessageEncoding },
            { 369, LastMsgSeqNumProcessed },
            { 627, NoHops },
            { 628, HopCompID },
            { 629, HopSendingTime },
            { 630, HopRefID },
            { 320, SecurityReqID },
            { 559, SecurityListRequestType },
            { 311, UnderlyingSymbol },
            { 312, UnderlyingSymbolSfx },
            { 309, UnderlyingSecurityID },
            { 305, UnderlyingSecurityIDSource },
            { 457, NoUnderlyingSecurityAltID },
            { 458, UnderlyingSecurityAltID },
            { 459, UnderlyingSecurityAltIDSource },
            { 462, UnderlyingProduct },
            { 463, UnderlyingCFICode },
            { 310, UnderlyingSecurityType },
            { 763, UnderlyingSecuritySubType },
            { 313, UnderlyingMaturityMonthYear },
            { 542, UnderlyingMaturityDate },
            { 241, UnderlyingCouponPaymentDate },
            { 242, UnderlyingIssueDate },
            { 243, UnderlyingRepoCollateralSecurityType },
            { 244, UnderlyingRepurchaseTerm },
            { 245, UnderlyingRepurchaseRate },
            { 246, UnderlyingFactor },
            { 256, UnderlyingCreditRating },
            { 595, UnderlyingInstrRegistry },
            { 592, UnderlyingCountryOfIssue },
            { 593, UnderlyingStateOrProvinceOfIssue },
            { 594, UnderlyingLocaleOfIssue },
            { 247, UnderlyingRedemptionDate },
            { 316, UnderlyingStrikePrice },
            { 941, UnderlyingStrikeCurrency },
            { 317, UnderlyingOptAttribute },
            { 436, UnderlyingContractMultiplier },
            { 998, UnderlyingUnitOfMeasure },
            { 1000, UnderlyingTimeUnit },
            { 435, UnderlyingCouponRate },
            { 308, UnderlyingSecurityExchange },
            { 306, UnderlyingIssuer },
            { 362, EncodedUnderlyingIssuerLen },
            { 363, EncodedUnderlyingIssuer },
            { 307, UnderlyingSecurityDesc },
            { 364, EncodedUnderlyingSecurityDescLen },
            { 365, EncodedUnderlyingSecurityDesc },
            { 877, UnderlyingCPProgram },
            { 878, UnderlyingCPRegType },
            { 972, UnderlyingAllocationPercent },
            { 318, UnderlyingCurrency },
            { 879, UnderlyingQty },
            { 975, UnderlyingSettlementType },
            { 973, UnderlyingCashAmount },
            { 974, UnderlyingCashType },
            { 810, UnderlyingPx },
            { 882, UnderlyingDirtyPrice },
            { 883, UnderlyingEndPrice },
            { 884, UnderlyingStartValue },
            { 885, UnderlyingCurrentValue },
            { 886, UnderlyingEndValue },
            { 887, NoUnderlyingStips },
            { 888, UnderlyingStipType },
            { 889, UnderlyingStipValue },
            { 1044, UnderlyingAdjustedQuantity },
            { 1045, UnderlyingFXRate },
            { 1046, UnderlyingFXRateCalc },
            { 1038, UnderlyingCapValue },
            { 1058, NoUndlyInstrumentParties },
            { 1059, UnderlyingInstrumentPartyID },
            { 1060, UnderlyingInstrumentPartyIDSource },
            { 1061, UnderlyingInstrumentPartyRole },
            { 1062, NoUndlyInstrumentPartySubIDs },
            { 1063, UnderlyingInstrumentPartySubID },
            { 1064, UnderlyingInstrumentPartySubIDType },
            { 1039, UnderlyingSettlMethod },
            { 315, UnderlyingPutOrCall },
            { 762, SecuritySubType },
            { 15, Currency },
            { 58, Text },
            { 354, EncodedTextLen },
            { 355, EncodedText },
            { 336, TradingSessionID },
            { 625, TradingSessionSubID },
            { 263, SubscriptionRequestType },
            { 93, SignatureLength },
            { 89, Signature },
            { 10, CheckSum },
        };
        public static FieldSpec GetFieldSpec(int tag) => tagToFieldSpec[tag];
    }
}

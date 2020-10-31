using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class Email
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
        public static readonly FieldSpec EmailThreadID = new FieldSpec(FieldType.HashedSlice16, "EmailThreadID");
        public static readonly FieldSpec EmailType = new FieldSpec(FieldType.Char, "EmailType");
        public static readonly FieldSpec OrigTime = new FieldSpec(FieldType.HashedSlice16, "OrigTime");
        public static readonly FieldSpec Subject = new FieldSpec(FieldType.HashedSlice16, "Subject");
        public static readonly FieldSpec EncodedSubjectLen = new FieldSpec(FieldType.Int, "EncodedSubjectLen");
        public static readonly FieldSpec EncodedSubject = new FieldSpec(FieldType.HashedSlice16, "EncodedSubject");
        // Begin RoutingGrp
        public static readonly FieldSpec NoRoutingIDs = new FieldSpec(FieldType.Int, "NoRoutingIDs");
        public static readonly FieldSpec RoutingType = new FieldSpec(FieldType.Int, "RoutingType");
        public static readonly FieldSpec RoutingID = new FieldSpec(FieldType.HashedSlice16, "RoutingID");
        // End RoutingGrp
        // Begin InstrmtGrp
        public static readonly FieldSpec NoRelatedSym = new FieldSpec(FieldType.Int, "NoRelatedSym");
        // Begin Instrument
        public static readonly FieldSpec Symbol = new FieldSpec(FieldType.HashedSlice16, "Symbol");
        public static readonly FieldSpec SymbolSfx = new FieldSpec(FieldType.HashedSlice16, "SymbolSfx");
        public static readonly FieldSpec SecurityID = new FieldSpec(FieldType.HashedSlice16, "SecurityID");
        public static readonly FieldSpec SecurityIDSource = new FieldSpec(FieldType.HashedSlice16, "SecurityIDSource");
        // Begin SecAltIDGrp
        public static readonly FieldSpec NoSecurityAltID = new FieldSpec(FieldType.Int, "NoSecurityAltID");
        public static readonly FieldSpec SecurityAltID = new FieldSpec(FieldType.HashedSlice16, "SecurityAltID");
        public static readonly FieldSpec SecurityAltIDSource = new FieldSpec(FieldType.HashedSlice16, "SecurityAltIDSource");
        // End SecAltIDGrp
        public static readonly FieldSpec Product = new FieldSpec(FieldType.Int, "Product");
        public static readonly FieldSpec CFICode = new FieldSpec(FieldType.HashedSlice16, "CFICode");
        public static readonly FieldSpec SecurityType = new FieldSpec(FieldType.HashedSlice16, "SecurityType");
        public static readonly FieldSpec SecuritySubType = new FieldSpec(FieldType.HashedSlice16, "SecuritySubType");
        public static readonly FieldSpec MaturityMonthYear = new FieldSpec(FieldType.HashedSlice16, "MaturityMonthYear");
        public static readonly FieldSpec MaturityDate = new FieldSpec(FieldType.HashedSlice16, "MaturityDate");
        public static readonly FieldSpec MaturityTime = new FieldSpec(FieldType.HashedSlice16, "MaturityTime");
        public static readonly FieldSpec SettleOnOpenFlag = new FieldSpec(FieldType.HashedSlice16, "SettleOnOpenFlag");
        public static readonly FieldSpec InstrmtAssignmentMethod = new FieldSpec(FieldType.Char, "InstrmtAssignmentMethod");
        public static readonly FieldSpec SecurityStatus = new FieldSpec(FieldType.HashedSlice16, "SecurityStatus");
        public static readonly FieldSpec CouponPaymentDate = new FieldSpec(FieldType.HashedSlice16, "CouponPaymentDate");
        public static readonly FieldSpec IssueDate = new FieldSpec(FieldType.HashedSlice16, "IssueDate");
        public static readonly FieldSpec RepoCollateralSecurityType = new FieldSpec(FieldType.HashedSlice16, "RepoCollateralSecurityType");
        public static readonly FieldSpec RepurchaseTerm = new FieldSpec(FieldType.Int, "RepurchaseTerm");
        public static readonly FieldSpec RepurchaseRate = new FieldSpec(FieldType.Float, "RepurchaseRate");
        public static readonly FieldSpec Factor = new FieldSpec(FieldType.Float, "Factor");
        public static readonly FieldSpec CreditRating = new FieldSpec(FieldType.HashedSlice16, "CreditRating");
        public static readonly FieldSpec InstrRegistry = new FieldSpec(FieldType.HashedSlice16, "InstrRegistry");
        public static readonly FieldSpec CountryOfIssue = new FieldSpec(FieldType.HashedSlice16, "CountryOfIssue");
        public static readonly FieldSpec StateOrProvinceOfIssue = new FieldSpec(FieldType.HashedSlice16, "StateOrProvinceOfIssue");
        public static readonly FieldSpec LocaleOfIssue = new FieldSpec(FieldType.HashedSlice16, "LocaleOfIssue");
        public static readonly FieldSpec RedemptionDate = new FieldSpec(FieldType.HashedSlice16, "RedemptionDate");
        public static readonly FieldSpec StrikePrice = new FieldSpec(FieldType.Float, "StrikePrice");
        public static readonly FieldSpec StrikeCurrency = new FieldSpec(FieldType.HashedSlice16, "StrikeCurrency");
        public static readonly FieldSpec StrikeMultiplier = new FieldSpec(FieldType.Float, "StrikeMultiplier");
        public static readonly FieldSpec StrikeValue = new FieldSpec(FieldType.Float, "StrikeValue");
        public static readonly FieldSpec OptAttribute = new FieldSpec(FieldType.Char, "OptAttribute");
        public static readonly FieldSpec ContractMultiplier = new FieldSpec(FieldType.Float, "ContractMultiplier");
        public static readonly FieldSpec MinPriceIncrement = new FieldSpec(FieldType.Float, "MinPriceIncrement");
        public static readonly FieldSpec UnitOfMeasure = new FieldSpec(FieldType.HashedSlice16, "UnitOfMeasure");
        public static readonly FieldSpec PutOrCall = new FieldSpec(FieldType.Int, "PutOrCall");
        public static readonly FieldSpec TimeUnit = new FieldSpec(FieldType.HashedSlice16, "TimeUnit");
        public static readonly FieldSpec CouponRate = new FieldSpec(FieldType.Float, "CouponRate");
        public static readonly FieldSpec SecurityExchange = new FieldSpec(FieldType.HashedSlice16, "SecurityExchange");
        public static readonly FieldSpec PositionLimit = new FieldSpec(FieldType.Int, "PositionLimit");
        public static readonly FieldSpec NTPositionLimit = new FieldSpec(FieldType.Int, "NTPositionLimit");
        public static readonly FieldSpec Issuer = new FieldSpec(FieldType.HashedSlice16, "Issuer");
        public static readonly FieldSpec EncodedIssuerLen = new FieldSpec(FieldType.Int, "EncodedIssuerLen");
        public static readonly FieldSpec EncodedIssuer = new FieldSpec(FieldType.HashedSlice16, "EncodedIssuer");
        public static readonly FieldSpec SecurityDesc = new FieldSpec(FieldType.HashedSlice16, "SecurityDesc");
        public static readonly FieldSpec EncodedSecurityDescLen = new FieldSpec(FieldType.Int, "EncodedSecurityDescLen");
        public static readonly FieldSpec EncodedSecurityDesc = new FieldSpec(FieldType.HashedSlice16, "EncodedSecurityDesc");
        public static readonly FieldSpec Pool = new FieldSpec(FieldType.HashedSlice16, "Pool");
        public static readonly FieldSpec ContractSettlMonth = new FieldSpec(FieldType.HashedSlice16, "ContractSettlMonth");
        public static readonly FieldSpec CPProgram = new FieldSpec(FieldType.Int, "CPProgram");
        public static readonly FieldSpec CPRegType = new FieldSpec(FieldType.HashedSlice16, "CPRegType");
        // Begin EvntGrp
        public static readonly FieldSpec NoEvents = new FieldSpec(FieldType.Int, "NoEvents");
        public static readonly FieldSpec EventType = new FieldSpec(FieldType.Int, "EventType");
        public static readonly FieldSpec EventDate = new FieldSpec(FieldType.HashedSlice16, "EventDate");
        public static readonly FieldSpec EventPx = new FieldSpec(FieldType.Float, "EventPx");
        public static readonly FieldSpec EventText = new FieldSpec(FieldType.HashedSlice16, "EventText");
        // End EvntGrp
        public static readonly FieldSpec DatedDate = new FieldSpec(FieldType.HashedSlice16, "DatedDate");
        public static readonly FieldSpec InterestAccrualDate = new FieldSpec(FieldType.HashedSlice16, "InterestAccrualDate");
        // Begin InstrumentParties
        public static readonly FieldSpec NoInstrumentParties = new FieldSpec(FieldType.Int, "NoInstrumentParties");
        public static readonly FieldSpec InstrumentPartyID = new FieldSpec(FieldType.HashedSlice16, "InstrumentPartyID");
        public static readonly FieldSpec InstrumentPartyIDSource = new FieldSpec(FieldType.Char, "InstrumentPartyIDSource");
        public static readonly FieldSpec InstrumentPartyRole = new FieldSpec(FieldType.Int, "InstrumentPartyRole");
        // Begin InstrumentPtysSubGrp
        public static readonly FieldSpec NoInstrumentPartySubIDs = new FieldSpec(FieldType.Int, "NoInstrumentPartySubIDs");
        public static readonly FieldSpec InstrumentPartySubID = new FieldSpec(FieldType.HashedSlice16, "InstrumentPartySubID");
        public static readonly FieldSpec InstrumentPartySubIDType = new FieldSpec(FieldType.Int, "InstrumentPartySubIDType");
        // End InstrumentPtysSubGrp
        // End InstrumentParties
        // End Instrument
        // End InstrmtGrp
        // Begin UndInstrmtGrp
        public static readonly FieldSpec NoUnderlyings = new FieldSpec(FieldType.Int, "NoUnderlyings");
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
        // End UndInstrmtGrp
        // Begin InstrmtLegGrp
        public static readonly FieldSpec NoLegs = new FieldSpec(FieldType.Int, "NoLegs");
        // Begin InstrumentLeg
        public static readonly FieldSpec LegSymbol = new FieldSpec(FieldType.HashedSlice16, "LegSymbol");
        public static readonly FieldSpec LegSymbolSfx = new FieldSpec(FieldType.HashedSlice16, "LegSymbolSfx");
        public static readonly FieldSpec LegSecurityID = new FieldSpec(FieldType.HashedSlice16, "LegSecurityID");
        public static readonly FieldSpec LegSecurityIDSource = new FieldSpec(FieldType.HashedSlice16, "LegSecurityIDSource");
        // Begin LegSecAltIDGrp
        public static readonly FieldSpec NoLegSecurityAltID = new FieldSpec(FieldType.Int, "NoLegSecurityAltID");
        public static readonly FieldSpec LegSecurityAltID = new FieldSpec(FieldType.HashedSlice16, "LegSecurityAltID");
        public static readonly FieldSpec LegSecurityAltIDSource = new FieldSpec(FieldType.HashedSlice16, "LegSecurityAltIDSource");
        // End LegSecAltIDGrp
        public static readonly FieldSpec LegProduct = new FieldSpec(FieldType.Int, "LegProduct");
        public static readonly FieldSpec LegCFICode = new FieldSpec(FieldType.HashedSlice16, "LegCFICode");
        public static readonly FieldSpec LegSecurityType = new FieldSpec(FieldType.HashedSlice16, "LegSecurityType");
        public static readonly FieldSpec LegSecuritySubType = new FieldSpec(FieldType.HashedSlice16, "LegSecuritySubType");
        public static readonly FieldSpec LegMaturityMonthYear = new FieldSpec(FieldType.HashedSlice16, "LegMaturityMonthYear");
        public static readonly FieldSpec LegMaturityDate = new FieldSpec(FieldType.HashedSlice16, "LegMaturityDate");
        public static readonly FieldSpec LegCouponPaymentDate = new FieldSpec(FieldType.HashedSlice16, "LegCouponPaymentDate");
        public static readonly FieldSpec LegIssueDate = new FieldSpec(FieldType.HashedSlice16, "LegIssueDate");
        public static readonly FieldSpec LegRepoCollateralSecurityType = new FieldSpec(FieldType.HashedSlice16, "LegRepoCollateralSecurityType");
        public static readonly FieldSpec LegRepurchaseTerm = new FieldSpec(FieldType.Int, "LegRepurchaseTerm");
        public static readonly FieldSpec LegRepurchaseRate = new FieldSpec(FieldType.Float, "LegRepurchaseRate");
        public static readonly FieldSpec LegFactor = new FieldSpec(FieldType.Float, "LegFactor");
        public static readonly FieldSpec LegCreditRating = new FieldSpec(FieldType.HashedSlice16, "LegCreditRating");
        public static readonly FieldSpec LegInstrRegistry = new FieldSpec(FieldType.HashedSlice16, "LegInstrRegistry");
        public static readonly FieldSpec LegCountryOfIssue = new FieldSpec(FieldType.HashedSlice16, "LegCountryOfIssue");
        public static readonly FieldSpec LegStateOrProvinceOfIssue = new FieldSpec(FieldType.HashedSlice16, "LegStateOrProvinceOfIssue");
        public static readonly FieldSpec LegLocaleOfIssue = new FieldSpec(FieldType.HashedSlice16, "LegLocaleOfIssue");
        public static readonly FieldSpec LegRedemptionDate = new FieldSpec(FieldType.HashedSlice16, "LegRedemptionDate");
        public static readonly FieldSpec LegStrikePrice = new FieldSpec(FieldType.Float, "LegStrikePrice");
        public static readonly FieldSpec LegStrikeCurrency = new FieldSpec(FieldType.HashedSlice16, "LegStrikeCurrency");
        public static readonly FieldSpec LegOptAttribute = new FieldSpec(FieldType.Char, "LegOptAttribute");
        public static readonly FieldSpec LegContractMultiplier = new FieldSpec(FieldType.Float, "LegContractMultiplier");
        public static readonly FieldSpec LegUnitOfMeasure = new FieldSpec(FieldType.HashedSlice16, "LegUnitOfMeasure");
        public static readonly FieldSpec LegTimeUnit = new FieldSpec(FieldType.HashedSlice16, "LegTimeUnit");
        public static readonly FieldSpec LegCouponRate = new FieldSpec(FieldType.Float, "LegCouponRate");
        public static readonly FieldSpec LegSecurityExchange = new FieldSpec(FieldType.HashedSlice16, "LegSecurityExchange");
        public static readonly FieldSpec LegIssuer = new FieldSpec(FieldType.HashedSlice16, "LegIssuer");
        public static readonly FieldSpec EncodedLegIssuerLen = new FieldSpec(FieldType.Int, "EncodedLegIssuerLen");
        public static readonly FieldSpec EncodedLegIssuer = new FieldSpec(FieldType.HashedSlice16, "EncodedLegIssuer");
        public static readonly FieldSpec LegSecurityDesc = new FieldSpec(FieldType.HashedSlice16, "LegSecurityDesc");
        public static readonly FieldSpec EncodedLegSecurityDescLen = new FieldSpec(FieldType.Int, "EncodedLegSecurityDescLen");
        public static readonly FieldSpec EncodedLegSecurityDesc = new FieldSpec(FieldType.HashedSlice16, "EncodedLegSecurityDesc");
        public static readonly FieldSpec LegRatioQty = new FieldSpec(FieldType.Float, "LegRatioQty");
        public static readonly FieldSpec LegSide = new FieldSpec(FieldType.Char, "LegSide");
        public static readonly FieldSpec LegCurrency = new FieldSpec(FieldType.HashedSlice16, "LegCurrency");
        public static readonly FieldSpec LegPool = new FieldSpec(FieldType.HashedSlice16, "LegPool");
        public static readonly FieldSpec LegDatedDate = new FieldSpec(FieldType.HashedSlice16, "LegDatedDate");
        public static readonly FieldSpec LegContractSettlMonth = new FieldSpec(FieldType.HashedSlice16, "LegContractSettlMonth");
        public static readonly FieldSpec LegInterestAccrualDate = new FieldSpec(FieldType.HashedSlice16, "LegInterestAccrualDate");
        public static readonly FieldSpec LegOptionRatio = new FieldSpec(FieldType.Float, "LegOptionRatio");
        public static readonly FieldSpec LegPrice = new FieldSpec(FieldType.Float, "LegPrice");
        // End InstrumentLeg
        // End InstrmtLegGrp
        public static readonly FieldSpec OrderID = new FieldSpec(FieldType.HashedSlice16, "OrderID");
        public static readonly FieldSpec ClOrdID = new FieldSpec(FieldType.HashedSlice16, "ClOrdID");
        // Begin LinesOfTextGrp
        public static readonly FieldSpec NoLinesOfText = new FieldSpec(FieldType.Int, "NoLinesOfText");
        public static readonly FieldSpec Text = new FieldSpec(FieldType.HashedSlice16, "Text");
        public static readonly FieldSpec EncodedTextLen = new FieldSpec(FieldType.Int, "EncodedTextLen");
        public static readonly FieldSpec EncodedText = new FieldSpec(FieldType.HashedSlice16, "EncodedText");
        // End LinesOfTextGrp
        public static readonly FieldSpec RawDataLength = new FieldSpec(FieldType.Int, "RawDataLength");
        public static readonly FieldSpec RawData = new FieldSpec(FieldType.HashedSlice16, "RawData");
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
            EmailThreadID,
            EmailType,
            OrigTime,
            Subject,
            EncodedSubjectLen,
            EncodedSubject,
            NoRoutingIDs,
            RoutingType,
            RoutingID,
            NoRelatedSym,
            Symbol,
            SymbolSfx,
            SecurityID,
            SecurityIDSource,
            NoSecurityAltID,
            SecurityAltID,
            SecurityAltIDSource,
            Product,
            CFICode,
            SecurityType,
            SecuritySubType,
            MaturityMonthYear,
            MaturityDate,
            MaturityTime,
            SettleOnOpenFlag,
            InstrmtAssignmentMethod,
            SecurityStatus,
            CouponPaymentDate,
            IssueDate,
            RepoCollateralSecurityType,
            RepurchaseTerm,
            RepurchaseRate,
            Factor,
            CreditRating,
            InstrRegistry,
            CountryOfIssue,
            StateOrProvinceOfIssue,
            LocaleOfIssue,
            RedemptionDate,
            StrikePrice,
            StrikeCurrency,
            StrikeMultiplier,
            StrikeValue,
            OptAttribute,
            ContractMultiplier,
            MinPriceIncrement,
            UnitOfMeasure,
            PutOrCall,
            TimeUnit,
            CouponRate,
            SecurityExchange,
            PositionLimit,
            NTPositionLimit,
            Issuer,
            EncodedIssuerLen,
            EncodedIssuer,
            SecurityDesc,
            EncodedSecurityDescLen,
            EncodedSecurityDesc,
            Pool,
            ContractSettlMonth,
            CPProgram,
            CPRegType,
            NoEvents,
            EventType,
            EventDate,
            EventPx,
            EventText,
            DatedDate,
            InterestAccrualDate,
            NoInstrumentParties,
            InstrumentPartyID,
            InstrumentPartyIDSource,
            InstrumentPartyRole,
            NoInstrumentPartySubIDs,
            InstrumentPartySubID,
            InstrumentPartySubIDType,
            NoUnderlyings,
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
            NoLegs,
            LegSymbol,
            LegSymbolSfx,
            LegSecurityID,
            LegSecurityIDSource,
            NoLegSecurityAltID,
            LegSecurityAltID,
            LegSecurityAltIDSource,
            LegProduct,
            LegCFICode,
            LegSecurityType,
            LegSecuritySubType,
            LegMaturityMonthYear,
            LegMaturityDate,
            LegCouponPaymentDate,
            LegIssueDate,
            LegRepoCollateralSecurityType,
            LegRepurchaseTerm,
            LegRepurchaseRate,
            LegFactor,
            LegCreditRating,
            LegInstrRegistry,
            LegCountryOfIssue,
            LegStateOrProvinceOfIssue,
            LegLocaleOfIssue,
            LegRedemptionDate,
            LegStrikePrice,
            LegStrikeCurrency,
            LegOptAttribute,
            LegContractMultiplier,
            LegUnitOfMeasure,
            LegTimeUnit,
            LegCouponRate,
            LegSecurityExchange,
            LegIssuer,
            EncodedLegIssuerLen,
            EncodedLegIssuer,
            LegSecurityDesc,
            EncodedLegSecurityDescLen,
            EncodedLegSecurityDesc,
            LegRatioQty,
            LegSide,
            LegCurrency,
            LegPool,
            LegDatedDate,
            LegContractSettlMonth,
            LegInterestAccrualDate,
            LegOptionRatio,
            LegPrice,
            OrderID,
            ClOrdID,
            NoLinesOfText,
            Text,
            EncodedTextLen,
            EncodedText,
            RawDataLength,
            RawData,
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
            { 164, EmailThreadID },
            { 94, EmailType },
            { 42, OrigTime },
            { 147, Subject },
            { 356, EncodedSubjectLen },
            { 357, EncodedSubject },
            { 215, NoRoutingIDs },
            { 216, RoutingType },
            { 217, RoutingID },
            { 146, NoRelatedSym },
            { 55, Symbol },
            { 65, SymbolSfx },
            { 48, SecurityID },
            { 22, SecurityIDSource },
            { 454, NoSecurityAltID },
            { 455, SecurityAltID },
            { 456, SecurityAltIDSource },
            { 460, Product },
            { 461, CFICode },
            { 167, SecurityType },
            { 762, SecuritySubType },
            { 200, MaturityMonthYear },
            { 541, MaturityDate },
            { 1079, MaturityTime },
            { 966, SettleOnOpenFlag },
            { 1049, InstrmtAssignmentMethod },
            { 965, SecurityStatus },
            { 224, CouponPaymentDate },
            { 225, IssueDate },
            { 239, RepoCollateralSecurityType },
            { 226, RepurchaseTerm },
            { 227, RepurchaseRate },
            { 228, Factor },
            { 255, CreditRating },
            { 543, InstrRegistry },
            { 470, CountryOfIssue },
            { 471, StateOrProvinceOfIssue },
            { 472, LocaleOfIssue },
            { 240, RedemptionDate },
            { 202, StrikePrice },
            { 947, StrikeCurrency },
            { 967, StrikeMultiplier },
            { 968, StrikeValue },
            { 206, OptAttribute },
            { 231, ContractMultiplier },
            { 969, MinPriceIncrement },
            { 996, UnitOfMeasure },
            { 201, PutOrCall },
            { 997, TimeUnit },
            { 223, CouponRate },
            { 207, SecurityExchange },
            { 970, PositionLimit },
            { 971, NTPositionLimit },
            { 106, Issuer },
            { 348, EncodedIssuerLen },
            { 349, EncodedIssuer },
            { 107, SecurityDesc },
            { 350, EncodedSecurityDescLen },
            { 351, EncodedSecurityDesc },
            { 691, Pool },
            { 667, ContractSettlMonth },
            { 875, CPProgram },
            { 876, CPRegType },
            { 864, NoEvents },
            { 865, EventType },
            { 866, EventDate },
            { 867, EventPx },
            { 868, EventText },
            { 873, DatedDate },
            { 874, InterestAccrualDate },
            { 1018, NoInstrumentParties },
            { 1019, InstrumentPartyID },
            { 1050, InstrumentPartyIDSource },
            { 1051, InstrumentPartyRole },
            { 1052, NoInstrumentPartySubIDs },
            { 1053, InstrumentPartySubID },
            { 1054, InstrumentPartySubIDType },
            { 711, NoUnderlyings },
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
            { 555, NoLegs },
            { 600, LegSymbol },
            { 601, LegSymbolSfx },
            { 602, LegSecurityID },
            { 603, LegSecurityIDSource },
            { 604, NoLegSecurityAltID },
            { 605, LegSecurityAltID },
            { 606, LegSecurityAltIDSource },
            { 607, LegProduct },
            { 608, LegCFICode },
            { 609, LegSecurityType },
            { 764, LegSecuritySubType },
            { 610, LegMaturityMonthYear },
            { 611, LegMaturityDate },
            { 248, LegCouponPaymentDate },
            { 249, LegIssueDate },
            { 250, LegRepoCollateralSecurityType },
            { 251, LegRepurchaseTerm },
            { 252, LegRepurchaseRate },
            { 253, LegFactor },
            { 257, LegCreditRating },
            { 599, LegInstrRegistry },
            { 596, LegCountryOfIssue },
            { 597, LegStateOrProvinceOfIssue },
            { 598, LegLocaleOfIssue },
            { 254, LegRedemptionDate },
            { 612, LegStrikePrice },
            { 942, LegStrikeCurrency },
            { 613, LegOptAttribute },
            { 614, LegContractMultiplier },
            { 999, LegUnitOfMeasure },
            { 1001, LegTimeUnit },
            { 615, LegCouponRate },
            { 616, LegSecurityExchange },
            { 617, LegIssuer },
            { 618, EncodedLegIssuerLen },
            { 619, EncodedLegIssuer },
            { 620, LegSecurityDesc },
            { 621, EncodedLegSecurityDescLen },
            { 622, EncodedLegSecurityDesc },
            { 623, LegRatioQty },
            { 624, LegSide },
            { 556, LegCurrency },
            { 740, LegPool },
            { 739, LegDatedDate },
            { 955, LegContractSettlMonth },
            { 956, LegInterestAccrualDate },
            { 1017, LegOptionRatio },
            { 566, LegPrice },
            { 37, OrderID },
            { 11, ClOrdID },
            { 33, NoLinesOfText },
            { 58, Text },
            { 354, EncodedTextLen },
            { 355, EncodedText },
            { 95, RawDataLength },
            { 96, RawData },
            { 93, SignatureLength },
            { 89, Signature },
            { 10, CheckSum },
        };
        public static FieldSpec GetFieldSpec(int tag) => tagToFieldSpec[tag];
    }
}

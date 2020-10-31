using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class Confirmation
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
        public static readonly FieldSpec ConfirmID = new FieldSpec(FieldType.HashedSlice16, "ConfirmID");
        public static readonly FieldSpec ConfirmRefID = new FieldSpec(FieldType.HashedSlice16, "ConfirmRefID");
        public static readonly FieldSpec ConfirmReqID = new FieldSpec(FieldType.HashedSlice16, "ConfirmReqID");
        public static readonly FieldSpec ConfirmTransType = new FieldSpec(FieldType.Int, "ConfirmTransType");
        public static readonly FieldSpec ConfirmType = new FieldSpec(FieldType.Int, "ConfirmType");
        public static readonly FieldSpec CopyMsgIndicator = new FieldSpec(FieldType.Char, "CopyMsgIndicator");
        public static readonly FieldSpec LegalConfirm = new FieldSpec(FieldType.Char, "LegalConfirm");
        public static readonly FieldSpec ConfirmStatus = new FieldSpec(FieldType.Int, "ConfirmStatus");
        // Begin Parties
        public static readonly FieldSpec NoPartyIDs = new FieldSpec(FieldType.Int, "NoPartyIDs");
        public static readonly FieldSpec PartyID = new FieldSpec(FieldType.HashedSlice16, "PartyID");
        public static readonly FieldSpec PartyIDSource = new FieldSpec(FieldType.Char, "PartyIDSource");
        public static readonly FieldSpec PartyRole = new FieldSpec(FieldType.Int, "PartyRole");
        // Begin PtysSubGrp
        public static readonly FieldSpec NoPartySubIDs = new FieldSpec(FieldType.Int, "NoPartySubIDs");
        public static readonly FieldSpec PartySubID = new FieldSpec(FieldType.HashedSlice16, "PartySubID");
        public static readonly FieldSpec PartySubIDType = new FieldSpec(FieldType.Int, "PartySubIDType");
        // End PtysSubGrp
        // End Parties
        // Begin OrdAllocGrp
        public static readonly FieldSpec NoOrders = new FieldSpec(FieldType.Int, "NoOrders");
        public static readonly FieldSpec ClOrdID = new FieldSpec(FieldType.HashedSlice16, "ClOrdID");
        public static readonly FieldSpec OrderID = new FieldSpec(FieldType.HashedSlice16, "OrderID");
        public static readonly FieldSpec SecondaryOrderID = new FieldSpec(FieldType.HashedSlice16, "SecondaryOrderID");
        public static readonly FieldSpec SecondaryClOrdID = new FieldSpec(FieldType.HashedSlice16, "SecondaryClOrdID");
        public static readonly FieldSpec ListID = new FieldSpec(FieldType.HashedSlice16, "ListID");
        // Begin NestedParties2
        public static readonly FieldSpec NoNested2PartyIDs = new FieldSpec(FieldType.Int, "NoNested2PartyIDs");
        public static readonly FieldSpec Nested2PartyID = new FieldSpec(FieldType.HashedSlice16, "Nested2PartyID");
        public static readonly FieldSpec Nested2PartyIDSource = new FieldSpec(FieldType.Char, "Nested2PartyIDSource");
        public static readonly FieldSpec Nested2PartyRole = new FieldSpec(FieldType.Int, "Nested2PartyRole");
        // Begin NstdPtys2SubGrp
        public static readonly FieldSpec NoNested2PartySubIDs = new FieldSpec(FieldType.Int, "NoNested2PartySubIDs");
        public static readonly FieldSpec Nested2PartySubID = new FieldSpec(FieldType.HashedSlice16, "Nested2PartySubID");
        public static readonly FieldSpec Nested2PartySubIDType = new FieldSpec(FieldType.Int, "Nested2PartySubIDType");
        // End NstdPtys2SubGrp
        // End NestedParties2
        public static readonly FieldSpec OrderQty = new FieldSpec(FieldType.Float, "OrderQty");
        public static readonly FieldSpec OrderAvgPx = new FieldSpec(FieldType.Float, "OrderAvgPx");
        public static readonly FieldSpec OrderBookingQty = new FieldSpec(FieldType.Float, "OrderBookingQty");
        // End OrdAllocGrp
        public static readonly FieldSpec AllocID = new FieldSpec(FieldType.HashedSlice16, "AllocID");
        public static readonly FieldSpec SecondaryAllocID = new FieldSpec(FieldType.HashedSlice16, "SecondaryAllocID");
        public static readonly FieldSpec IndividualAllocID = new FieldSpec(FieldType.HashedSlice16, "IndividualAllocID");
        public static readonly FieldSpec TransactTime = new FieldSpec(FieldType.HashedSlice16, "TransactTime");
        public static readonly FieldSpec TradeDate = new FieldSpec(FieldType.HashedSlice16, "TradeDate");
        // Begin TrdRegTimestamps
        public static readonly FieldSpec NoTrdRegTimestamps = new FieldSpec(FieldType.Int, "NoTrdRegTimestamps");
        public static readonly FieldSpec TrdRegTimestamp = new FieldSpec(FieldType.HashedSlice16, "TrdRegTimestamp");
        public static readonly FieldSpec TrdRegTimestampType = new FieldSpec(FieldType.Int, "TrdRegTimestampType");
        public static readonly FieldSpec TrdRegTimestampOrigin = new FieldSpec(FieldType.HashedSlice16, "TrdRegTimestampOrigin");
        public static readonly FieldSpec DeskType = new FieldSpec(FieldType.HashedSlice16, "DeskType");
        public static readonly FieldSpec DeskTypeSource = new FieldSpec(FieldType.Int, "DeskTypeSource");
        public static readonly FieldSpec DeskOrderHandlingInst = new FieldSpec(FieldType.HashedSlice16, "DeskOrderHandlingInst");
        // End TrdRegTimestamps
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
        // Begin InstrumentExtension
        public static readonly FieldSpec DeliveryForm = new FieldSpec(FieldType.Int, "DeliveryForm");
        public static readonly FieldSpec PctAtRisk = new FieldSpec(FieldType.Float, "PctAtRisk");
        // Begin AttrbGrp
        public static readonly FieldSpec NoInstrAttrib = new FieldSpec(FieldType.Int, "NoInstrAttrib");
        public static readonly FieldSpec InstrAttribType = new FieldSpec(FieldType.Int, "InstrAttribType");
        public static readonly FieldSpec InstrAttribValue = new FieldSpec(FieldType.HashedSlice16, "InstrAttribValue");
        // End AttrbGrp
        // End InstrumentExtension
        // Begin FinancingDetails
        public static readonly FieldSpec AgreementDesc = new FieldSpec(FieldType.HashedSlice16, "AgreementDesc");
        public static readonly FieldSpec AgreementID = new FieldSpec(FieldType.HashedSlice16, "AgreementID");
        public static readonly FieldSpec AgreementDate = new FieldSpec(FieldType.HashedSlice16, "AgreementDate");
        public static readonly FieldSpec AgreementCurrency = new FieldSpec(FieldType.HashedSlice16, "AgreementCurrency");
        public static readonly FieldSpec TerminationType = new FieldSpec(FieldType.Int, "TerminationType");
        public static readonly FieldSpec StartDate = new FieldSpec(FieldType.HashedSlice16, "StartDate");
        public static readonly FieldSpec EndDate = new FieldSpec(FieldType.HashedSlice16, "EndDate");
        public static readonly FieldSpec DeliveryType = new FieldSpec(FieldType.Int, "DeliveryType");
        public static readonly FieldSpec MarginRatio = new FieldSpec(FieldType.Float, "MarginRatio");
        // End FinancingDetails
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
        // Begin YieldData
        public static readonly FieldSpec YieldType = new FieldSpec(FieldType.HashedSlice16, "YieldType");
        public static readonly FieldSpec Yield = new FieldSpec(FieldType.Float, "Yield");
        public static readonly FieldSpec YieldCalcDate = new FieldSpec(FieldType.HashedSlice16, "YieldCalcDate");
        public static readonly FieldSpec YieldRedemptionDate = new FieldSpec(FieldType.HashedSlice16, "YieldRedemptionDate");
        public static readonly FieldSpec YieldRedemptionPrice = new FieldSpec(FieldType.Float, "YieldRedemptionPrice");
        public static readonly FieldSpec YieldRedemptionPriceType = new FieldSpec(FieldType.Int, "YieldRedemptionPriceType");
        // End YieldData
        public static readonly FieldSpec AllocQty = new FieldSpec(FieldType.Float, "AllocQty");
        public static readonly FieldSpec QtyType = new FieldSpec(FieldType.Int, "QtyType");
        public static readonly FieldSpec Side = new FieldSpec(FieldType.Char, "Side");
        public static readonly FieldSpec Currency = new FieldSpec(FieldType.HashedSlice16, "Currency");
        public static readonly FieldSpec LastMkt = new FieldSpec(FieldType.HashedSlice16, "LastMkt");
        // Begin CpctyConfGrp
        public static readonly FieldSpec NoCapacities = new FieldSpec(FieldType.Int, "NoCapacities");
        public static readonly FieldSpec OrderCapacity = new FieldSpec(FieldType.Char, "OrderCapacity");
        public static readonly FieldSpec OrderRestrictions = new FieldSpec(FieldType.HashedSlice16, "OrderRestrictions");
        public static readonly FieldSpec OrderCapacityQty = new FieldSpec(FieldType.Float, "OrderCapacityQty");
        // End CpctyConfGrp
        public static readonly FieldSpec AllocAccount = new FieldSpec(FieldType.HashedSlice16, "AllocAccount");
        public static readonly FieldSpec AllocAcctIDSource = new FieldSpec(FieldType.Int, "AllocAcctIDSource");
        public static readonly FieldSpec AllocAccountType = new FieldSpec(FieldType.Int, "AllocAccountType");
        public static readonly FieldSpec AvgPx = new FieldSpec(FieldType.Float, "AvgPx");
        public static readonly FieldSpec AvgPxPrecision = new FieldSpec(FieldType.Int, "AvgPxPrecision");
        public static readonly FieldSpec PriceType = new FieldSpec(FieldType.Int, "PriceType");
        public static readonly FieldSpec AvgParPx = new FieldSpec(FieldType.Float, "AvgParPx");
        // Begin SpreadOrBenchmarkCurveData
        public static readonly FieldSpec Spread = new FieldSpec(FieldType.Float, "Spread");
        public static readonly FieldSpec BenchmarkCurveCurrency = new FieldSpec(FieldType.HashedSlice16, "BenchmarkCurveCurrency");
        public static readonly FieldSpec BenchmarkCurveName = new FieldSpec(FieldType.HashedSlice16, "BenchmarkCurveName");
        public static readonly FieldSpec BenchmarkCurvePoint = new FieldSpec(FieldType.HashedSlice16, "BenchmarkCurvePoint");
        public static readonly FieldSpec BenchmarkPrice = new FieldSpec(FieldType.Float, "BenchmarkPrice");
        public static readonly FieldSpec BenchmarkPriceType = new FieldSpec(FieldType.Int, "BenchmarkPriceType");
        public static readonly FieldSpec BenchmarkSecurityID = new FieldSpec(FieldType.HashedSlice16, "BenchmarkSecurityID");
        public static readonly FieldSpec BenchmarkSecurityIDSource = new FieldSpec(FieldType.HashedSlice16, "BenchmarkSecurityIDSource");
        // End SpreadOrBenchmarkCurveData
        public static readonly FieldSpec ReportedPx = new FieldSpec(FieldType.Float, "ReportedPx");
        public static readonly FieldSpec Text = new FieldSpec(FieldType.HashedSlice16, "Text");
        public static readonly FieldSpec EncodedTextLen = new FieldSpec(FieldType.Int, "EncodedTextLen");
        public static readonly FieldSpec EncodedText = new FieldSpec(FieldType.HashedSlice16, "EncodedText");
        public static readonly FieldSpec ProcessCode = new FieldSpec(FieldType.Char, "ProcessCode");
        public static readonly FieldSpec GrossTradeAmt = new FieldSpec(FieldType.Float, "GrossTradeAmt");
        public static readonly FieldSpec NumDaysInterest = new FieldSpec(FieldType.Int, "NumDaysInterest");
        public static readonly FieldSpec ExDate = new FieldSpec(FieldType.HashedSlice16, "ExDate");
        public static readonly FieldSpec AccruedInterestRate = new FieldSpec(FieldType.Float, "AccruedInterestRate");
        public static readonly FieldSpec AccruedInterestAmt = new FieldSpec(FieldType.Float, "AccruedInterestAmt");
        public static readonly FieldSpec InterestAtMaturity = new FieldSpec(FieldType.Float, "InterestAtMaturity");
        public static readonly FieldSpec EndAccruedInterestAmt = new FieldSpec(FieldType.Float, "EndAccruedInterestAmt");
        public static readonly FieldSpec StartCash = new FieldSpec(FieldType.Float, "StartCash");
        public static readonly FieldSpec EndCash = new FieldSpec(FieldType.Float, "EndCash");
        public static readonly FieldSpec Concession = new FieldSpec(FieldType.Float, "Concession");
        public static readonly FieldSpec TotalTakedown = new FieldSpec(FieldType.Float, "TotalTakedown");
        public static readonly FieldSpec NetMoney = new FieldSpec(FieldType.Float, "NetMoney");
        public static readonly FieldSpec MaturityNetMoney = new FieldSpec(FieldType.Float, "MaturityNetMoney");
        public static readonly FieldSpec SettlCurrAmt = new FieldSpec(FieldType.Float, "SettlCurrAmt");
        public static readonly FieldSpec SettlCurrency = new FieldSpec(FieldType.HashedSlice16, "SettlCurrency");
        public static readonly FieldSpec SettlCurrFxRate = new FieldSpec(FieldType.Float, "SettlCurrFxRate");
        public static readonly FieldSpec SettlCurrFxRateCalc = new FieldSpec(FieldType.Char, "SettlCurrFxRateCalc");
        public static readonly FieldSpec SettlType = new FieldSpec(FieldType.HashedSlice16, "SettlType");
        public static readonly FieldSpec SettlDate = new FieldSpec(FieldType.HashedSlice16, "SettlDate");
        // Begin SettlInstructionsData
        public static readonly FieldSpec SettlDeliveryType = new FieldSpec(FieldType.Int, "SettlDeliveryType");
        public static readonly FieldSpec StandInstDbType = new FieldSpec(FieldType.Int, "StandInstDbType");
        public static readonly FieldSpec StandInstDbName = new FieldSpec(FieldType.HashedSlice16, "StandInstDbName");
        public static readonly FieldSpec StandInstDbID = new FieldSpec(FieldType.HashedSlice16, "StandInstDbID");
        // Begin DlvyInstGrp
        public static readonly FieldSpec NoDlvyInst = new FieldSpec(FieldType.Int, "NoDlvyInst");
        public static readonly FieldSpec SettlInstSource = new FieldSpec(FieldType.Char, "SettlInstSource");
        public static readonly FieldSpec DlvyInstType = new FieldSpec(FieldType.Char, "DlvyInstType");
        // Begin SettlParties
        public static readonly FieldSpec NoSettlPartyIDs = new FieldSpec(FieldType.Int, "NoSettlPartyIDs");
        public static readonly FieldSpec SettlPartyID = new FieldSpec(FieldType.HashedSlice16, "SettlPartyID");
        public static readonly FieldSpec SettlPartyIDSource = new FieldSpec(FieldType.Char, "SettlPartyIDSource");
        public static readonly FieldSpec SettlPartyRole = new FieldSpec(FieldType.Int, "SettlPartyRole");
        // Begin SettlPtysSubGrp
        public static readonly FieldSpec NoSettlPartySubIDs = new FieldSpec(FieldType.Int, "NoSettlPartySubIDs");
        public static readonly FieldSpec SettlPartySubID = new FieldSpec(FieldType.HashedSlice16, "SettlPartySubID");
        public static readonly FieldSpec SettlPartySubIDType = new FieldSpec(FieldType.Int, "SettlPartySubIDType");
        // End SettlPtysSubGrp
        // End SettlParties
        // End DlvyInstGrp
        // End SettlInstructionsData
        // Begin CommissionData
        public static readonly FieldSpec Commission = new FieldSpec(FieldType.Float, "Commission");
        public static readonly FieldSpec CommType = new FieldSpec(FieldType.Char, "CommType");
        public static readonly FieldSpec CommCurrency = new FieldSpec(FieldType.HashedSlice16, "CommCurrency");
        public static readonly FieldSpec FundRenewWaiv = new FieldSpec(FieldType.Char, "FundRenewWaiv");
        // End CommissionData
        public static readonly FieldSpec SharedCommission = new FieldSpec(FieldType.Float, "SharedCommission");
        // Begin Stipulations
        public static readonly FieldSpec NoStipulations = new FieldSpec(FieldType.Int, "NoStipulations");
        public static readonly FieldSpec StipulationType = new FieldSpec(FieldType.HashedSlice16, "StipulationType");
        public static readonly FieldSpec StipulationValue = new FieldSpec(FieldType.HashedSlice16, "StipulationValue");
        // End Stipulations
        // Begin MiscFeesGrp
        public static readonly FieldSpec NoMiscFees = new FieldSpec(FieldType.Int, "NoMiscFees");
        public static readonly FieldSpec MiscFeeAmt = new FieldSpec(FieldType.Float, "MiscFeeAmt");
        public static readonly FieldSpec MiscFeeCurr = new FieldSpec(FieldType.HashedSlice16, "MiscFeeCurr");
        public static readonly FieldSpec MiscFeeType = new FieldSpec(FieldType.HashedSlice16, "MiscFeeType");
        public static readonly FieldSpec MiscFeeBasis = new FieldSpec(FieldType.Int, "MiscFeeBasis");
        // End MiscFeesGrp
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
            ConfirmID,
            ConfirmRefID,
            ConfirmReqID,
            ConfirmTransType,
            ConfirmType,
            CopyMsgIndicator,
            LegalConfirm,
            ConfirmStatus,
            NoPartyIDs,
            PartyID,
            PartyIDSource,
            PartyRole,
            NoPartySubIDs,
            PartySubID,
            PartySubIDType,
            NoOrders,
            ClOrdID,
            OrderID,
            SecondaryOrderID,
            SecondaryClOrdID,
            ListID,
            NoNested2PartyIDs,
            Nested2PartyID,
            Nested2PartyIDSource,
            Nested2PartyRole,
            NoNested2PartySubIDs,
            Nested2PartySubID,
            Nested2PartySubIDType,
            OrderQty,
            OrderAvgPx,
            OrderBookingQty,
            AllocID,
            SecondaryAllocID,
            IndividualAllocID,
            TransactTime,
            TradeDate,
            NoTrdRegTimestamps,
            TrdRegTimestamp,
            TrdRegTimestampType,
            TrdRegTimestampOrigin,
            DeskType,
            DeskTypeSource,
            DeskOrderHandlingInst,
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
            DeliveryForm,
            PctAtRisk,
            NoInstrAttrib,
            InstrAttribType,
            InstrAttribValue,
            AgreementDesc,
            AgreementID,
            AgreementDate,
            AgreementCurrency,
            TerminationType,
            StartDate,
            EndDate,
            DeliveryType,
            MarginRatio,
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
            YieldType,
            Yield,
            YieldCalcDate,
            YieldRedemptionDate,
            YieldRedemptionPrice,
            YieldRedemptionPriceType,
            AllocQty,
            QtyType,
            Side,
            Currency,
            LastMkt,
            NoCapacities,
            OrderCapacity,
            OrderRestrictions,
            OrderCapacityQty,
            AllocAccount,
            AllocAcctIDSource,
            AllocAccountType,
            AvgPx,
            AvgPxPrecision,
            PriceType,
            AvgParPx,
            Spread,
            BenchmarkCurveCurrency,
            BenchmarkCurveName,
            BenchmarkCurvePoint,
            BenchmarkPrice,
            BenchmarkPriceType,
            BenchmarkSecurityID,
            BenchmarkSecurityIDSource,
            ReportedPx,
            Text,
            EncodedTextLen,
            EncodedText,
            ProcessCode,
            GrossTradeAmt,
            NumDaysInterest,
            ExDate,
            AccruedInterestRate,
            AccruedInterestAmt,
            InterestAtMaturity,
            EndAccruedInterestAmt,
            StartCash,
            EndCash,
            Concession,
            TotalTakedown,
            NetMoney,
            MaturityNetMoney,
            SettlCurrAmt,
            SettlCurrency,
            SettlCurrFxRate,
            SettlCurrFxRateCalc,
            SettlType,
            SettlDate,
            SettlDeliveryType,
            StandInstDbType,
            StandInstDbName,
            StandInstDbID,
            NoDlvyInst,
            SettlInstSource,
            DlvyInstType,
            NoSettlPartyIDs,
            SettlPartyID,
            SettlPartyIDSource,
            SettlPartyRole,
            NoSettlPartySubIDs,
            SettlPartySubID,
            SettlPartySubIDType,
            Commission,
            CommType,
            CommCurrency,
            FundRenewWaiv,
            SharedCommission,
            NoStipulations,
            StipulationType,
            StipulationValue,
            NoMiscFees,
            MiscFeeAmt,
            MiscFeeCurr,
            MiscFeeType,
            MiscFeeBasis,
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
            { 664, ConfirmID },
            { 772, ConfirmRefID },
            { 859, ConfirmReqID },
            { 666, ConfirmTransType },
            { 773, ConfirmType },
            { 797, CopyMsgIndicator },
            { 650, LegalConfirm },
            { 665, ConfirmStatus },
            { 453, NoPartyIDs },
            { 448, PartyID },
            { 447, PartyIDSource },
            { 452, PartyRole },
            { 802, NoPartySubIDs },
            { 523, PartySubID },
            { 803, PartySubIDType },
            { 73, NoOrders },
            { 11, ClOrdID },
            { 37, OrderID },
            { 198, SecondaryOrderID },
            { 526, SecondaryClOrdID },
            { 66, ListID },
            { 756, NoNested2PartyIDs },
            { 757, Nested2PartyID },
            { 758, Nested2PartyIDSource },
            { 759, Nested2PartyRole },
            { 806, NoNested2PartySubIDs },
            { 760, Nested2PartySubID },
            { 807, Nested2PartySubIDType },
            { 38, OrderQty },
            { 799, OrderAvgPx },
            { 800, OrderBookingQty },
            { 70, AllocID },
            { 793, SecondaryAllocID },
            { 467, IndividualAllocID },
            { 60, TransactTime },
            { 75, TradeDate },
            { 768, NoTrdRegTimestamps },
            { 769, TrdRegTimestamp },
            { 770, TrdRegTimestampType },
            { 771, TrdRegTimestampOrigin },
            { 1033, DeskType },
            { 1034, DeskTypeSource },
            { 1035, DeskOrderHandlingInst },
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
            { 668, DeliveryForm },
            { 869, PctAtRisk },
            { 870, NoInstrAttrib },
            { 871, InstrAttribType },
            { 872, InstrAttribValue },
            { 913, AgreementDesc },
            { 914, AgreementID },
            { 915, AgreementDate },
            { 918, AgreementCurrency },
            { 788, TerminationType },
            { 916, StartDate },
            { 917, EndDate },
            { 919, DeliveryType },
            { 898, MarginRatio },
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
            { 235, YieldType },
            { 236, Yield },
            { 701, YieldCalcDate },
            { 696, YieldRedemptionDate },
            { 697, YieldRedemptionPrice },
            { 698, YieldRedemptionPriceType },
            { 80, AllocQty },
            { 854, QtyType },
            { 54, Side },
            { 15, Currency },
            { 30, LastMkt },
            { 862, NoCapacities },
            { 528, OrderCapacity },
            { 529, OrderRestrictions },
            { 863, OrderCapacityQty },
            { 79, AllocAccount },
            { 661, AllocAcctIDSource },
            { 798, AllocAccountType },
            { 6, AvgPx },
            { 74, AvgPxPrecision },
            { 423, PriceType },
            { 860, AvgParPx },
            { 218, Spread },
            { 220, BenchmarkCurveCurrency },
            { 221, BenchmarkCurveName },
            { 222, BenchmarkCurvePoint },
            { 662, BenchmarkPrice },
            { 663, BenchmarkPriceType },
            { 699, BenchmarkSecurityID },
            { 761, BenchmarkSecurityIDSource },
            { 861, ReportedPx },
            { 58, Text },
            { 354, EncodedTextLen },
            { 355, EncodedText },
            { 81, ProcessCode },
            { 381, GrossTradeAmt },
            { 157, NumDaysInterest },
            { 230, ExDate },
            { 158, AccruedInterestRate },
            { 159, AccruedInterestAmt },
            { 738, InterestAtMaturity },
            { 920, EndAccruedInterestAmt },
            { 921, StartCash },
            { 922, EndCash },
            { 238, Concession },
            { 237, TotalTakedown },
            { 118, NetMoney },
            { 890, MaturityNetMoney },
            { 119, SettlCurrAmt },
            { 120, SettlCurrency },
            { 155, SettlCurrFxRate },
            { 156, SettlCurrFxRateCalc },
            { 63, SettlType },
            { 64, SettlDate },
            { 172, SettlDeliveryType },
            { 169, StandInstDbType },
            { 170, StandInstDbName },
            { 171, StandInstDbID },
            { 85, NoDlvyInst },
            { 165, SettlInstSource },
            { 787, DlvyInstType },
            { 781, NoSettlPartyIDs },
            { 782, SettlPartyID },
            { 783, SettlPartyIDSource },
            { 784, SettlPartyRole },
            { 801, NoSettlPartySubIDs },
            { 785, SettlPartySubID },
            { 786, SettlPartySubIDType },
            { 12, Commission },
            { 13, CommType },
            { 479, CommCurrency },
            { 497, FundRenewWaiv },
            { 858, SharedCommission },
            { 232, NoStipulations },
            { 233, StipulationType },
            { 234, StipulationValue },
            { 136, NoMiscFees },
            { 137, MiscFeeAmt },
            { 138, MiscFeeCurr },
            { 139, MiscFeeType },
            { 891, MiscFeeBasis },
            { 93, SignatureLength },
            { 89, Signature },
            { 10, CheckSum },
        };
        public static FieldSpec GetFieldSpec(int tag) => tagToFieldSpec[tag];
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class TradeCaptureReport
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
        public static readonly FieldSpec TradeReportID = new FieldSpec(FieldType.HashedSlice16, "TradeReportID");
        public static readonly FieldSpec TradeID = new FieldSpec(FieldType.HashedSlice16, "TradeID");
        public static readonly FieldSpec SecondaryTradeID = new FieldSpec(FieldType.HashedSlice16, "SecondaryTradeID");
        public static readonly FieldSpec FirmTradeID = new FieldSpec(FieldType.HashedSlice16, "FirmTradeID");
        public static readonly FieldSpec SecondaryFirmTradeID = new FieldSpec(FieldType.HashedSlice16, "SecondaryFirmTradeID");
        public static readonly FieldSpec TradeReportTransType = new FieldSpec(FieldType.Int, "TradeReportTransType");
        public static readonly FieldSpec TradeReportType = new FieldSpec(FieldType.Int, "TradeReportType");
        public static readonly FieldSpec TrdRptStatus = new FieldSpec(FieldType.Int, "TrdRptStatus");
        public static readonly FieldSpec TradeRequestID = new FieldSpec(FieldType.HashedSlice16, "TradeRequestID");
        public static readonly FieldSpec TrdType = new FieldSpec(FieldType.Int, "TrdType");
        public static readonly FieldSpec TrdSubType = new FieldSpec(FieldType.Int, "TrdSubType");
        public static readonly FieldSpec SecondaryTrdType = new FieldSpec(FieldType.Int, "SecondaryTrdType");
        public static readonly FieldSpec TradeHandlingInstr = new FieldSpec(FieldType.Char, "TradeHandlingInstr");
        public static readonly FieldSpec OrigTradeHandlingInstr = new FieldSpec(FieldType.Char, "OrigTradeHandlingInstr");
        public static readonly FieldSpec OrigTradeDate = new FieldSpec(FieldType.HashedSlice16, "OrigTradeDate");
        public static readonly FieldSpec OrigTradeID = new FieldSpec(FieldType.HashedSlice16, "OrigTradeID");
        public static readonly FieldSpec OrigSecondaryTradeID = new FieldSpec(FieldType.HashedSlice16, "OrigSecondaryTradeID");
        public static readonly FieldSpec TransferReason = new FieldSpec(FieldType.HashedSlice16, "TransferReason");
        public static readonly FieldSpec ExecType = new FieldSpec(FieldType.Char, "ExecType");
        public static readonly FieldSpec TotNumTradeReports = new FieldSpec(FieldType.Int, "TotNumTradeReports");
        public static readonly FieldSpec LastRptRequested = new FieldSpec(FieldType.Char, "LastRptRequested");
        public static readonly FieldSpec UnsolicitedIndicator = new FieldSpec(FieldType.Char, "UnsolicitedIndicator");
        public static readonly FieldSpec SubscriptionRequestType = new FieldSpec(FieldType.Char, "SubscriptionRequestType");
        public static readonly FieldSpec TradeReportRefID = new FieldSpec(FieldType.HashedSlice16, "TradeReportRefID");
        public static readonly FieldSpec SecondaryTradeReportRefID = new FieldSpec(FieldType.HashedSlice16, "SecondaryTradeReportRefID");
        public static readonly FieldSpec SecondaryTradeReportID = new FieldSpec(FieldType.HashedSlice16, "SecondaryTradeReportID");
        public static readonly FieldSpec TradeLinkID = new FieldSpec(FieldType.HashedSlice16, "TradeLinkID");
        public static readonly FieldSpec TrdMatchID = new FieldSpec(FieldType.HashedSlice16, "TrdMatchID");
        public static readonly FieldSpec ExecID = new FieldSpec(FieldType.HashedSlice16, "ExecID");
        public static readonly FieldSpec SecondaryExecID = new FieldSpec(FieldType.HashedSlice16, "SecondaryExecID");
        public static readonly FieldSpec ExecRestatementReason = new FieldSpec(FieldType.Int, "ExecRestatementReason");
        public static readonly FieldSpec PreviouslyReported = new FieldSpec(FieldType.Char, "PreviouslyReported");
        public static readonly FieldSpec PriceType = new FieldSpec(FieldType.Int, "PriceType");
        // Begin RootParties
        public static readonly FieldSpec NoRootPartyIDs = new FieldSpec(FieldType.Int, "NoRootPartyIDs");
        public static readonly FieldSpec RootPartyID = new FieldSpec(FieldType.HashedSlice16, "RootPartyID");
        public static readonly FieldSpec RootPartyIDSource = new FieldSpec(FieldType.Char, "RootPartyIDSource");
        public static readonly FieldSpec RootPartyRole = new FieldSpec(FieldType.Int, "RootPartyRole");
        // Begin RootSubParties
        public static readonly FieldSpec NoRootPartySubIDs = new FieldSpec(FieldType.Int, "NoRootPartySubIDs");
        public static readonly FieldSpec RootPartySubID = new FieldSpec(FieldType.HashedSlice16, "RootPartySubID");
        public static readonly FieldSpec RootPartySubIDType = new FieldSpec(FieldType.Int, "RootPartySubIDType");
        // End RootSubParties
        // End RootParties
        public static readonly FieldSpec AsOfIndicator = new FieldSpec(FieldType.Char, "AsOfIndicator");
        public static readonly FieldSpec SettlSessID = new FieldSpec(FieldType.HashedSlice16, "SettlSessID");
        public static readonly FieldSpec SettlSessSubID = new FieldSpec(FieldType.HashedSlice16, "SettlSessSubID");
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
        public static readonly FieldSpec QtyType = new FieldSpec(FieldType.Int, "QtyType");
        // Begin YieldData
        public static readonly FieldSpec YieldType = new FieldSpec(FieldType.HashedSlice16, "YieldType");
        public static readonly FieldSpec Yield = new FieldSpec(FieldType.Float, "Yield");
        public static readonly FieldSpec YieldCalcDate = new FieldSpec(FieldType.HashedSlice16, "YieldCalcDate");
        public static readonly FieldSpec YieldRedemptionDate = new FieldSpec(FieldType.HashedSlice16, "YieldRedemptionDate");
        public static readonly FieldSpec YieldRedemptionPrice = new FieldSpec(FieldType.Float, "YieldRedemptionPrice");
        public static readonly FieldSpec YieldRedemptionPriceType = new FieldSpec(FieldType.Int, "YieldRedemptionPriceType");
        // End YieldData
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
        public static readonly FieldSpec UnderlyingTradingSessionID = new FieldSpec(FieldType.HashedSlice16, "UnderlyingTradingSessionID");
        public static readonly FieldSpec UnderlyingTradingSessionSubID = new FieldSpec(FieldType.HashedSlice16, "UnderlyingTradingSessionSubID");
        public static readonly FieldSpec LastQty = new FieldSpec(FieldType.Float, "LastQty");
        public static readonly FieldSpec LastPx = new FieldSpec(FieldType.Float, "LastPx");
        public static readonly FieldSpec CalculatedCcyLastQty = new FieldSpec(FieldType.Float, "CalculatedCcyLastQty");
        public static readonly FieldSpec Currency = new FieldSpec(FieldType.HashedSlice16, "Currency");
        public static readonly FieldSpec SettlCurrency = new FieldSpec(FieldType.HashedSlice16, "SettlCurrency");
        public static readonly FieldSpec LastParPx = new FieldSpec(FieldType.Float, "LastParPx");
        public static readonly FieldSpec LastSpotRate = new FieldSpec(FieldType.Float, "LastSpotRate");
        public static readonly FieldSpec LastForwardPoints = new FieldSpec(FieldType.Float, "LastForwardPoints");
        public static readonly FieldSpec LastSwapPoints = new FieldSpec(FieldType.Float, "LastSwapPoints");
        public static readonly FieldSpec LastMkt = new FieldSpec(FieldType.HashedSlice16, "LastMkt");
        public static readonly FieldSpec TradeDate = new FieldSpec(FieldType.HashedSlice16, "TradeDate");
        public static readonly FieldSpec ClearingBusinessDate = new FieldSpec(FieldType.HashedSlice16, "ClearingBusinessDate");
        public static readonly FieldSpec AvgPx = new FieldSpec(FieldType.Float, "AvgPx");
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
        public static readonly FieldSpec AvgPxIndicator = new FieldSpec(FieldType.Int, "AvgPxIndicator");
        // Begin PositionAmountData
        public static readonly FieldSpec NoPosAmt = new FieldSpec(FieldType.Int, "NoPosAmt");
        public static readonly FieldSpec PosAmtType = new FieldSpec(FieldType.HashedSlice16, "PosAmtType");
        public static readonly FieldSpec PosAmt = new FieldSpec(FieldType.Float, "PosAmt");
        public static readonly FieldSpec PositionCurrency = new FieldSpec(FieldType.HashedSlice16, "PositionCurrency");
        // End PositionAmountData
        public static readonly FieldSpec MultiLegReportingType = new FieldSpec(FieldType.Char, "MultiLegReportingType");
        public static readonly FieldSpec TradeLegRefID = new FieldSpec(FieldType.HashedSlice16, "TradeLegRefID");
        // Begin TrdInstrmtLegGrp
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
        public static readonly FieldSpec LegQty = new FieldSpec(FieldType.Float, "LegQty");
        public static readonly FieldSpec LegSwapType = new FieldSpec(FieldType.Int, "LegSwapType");
        public static readonly FieldSpec LegReportID = new FieldSpec(FieldType.HashedSlice16, "LegReportID");
        // Begin LegStipulations
        public static readonly FieldSpec NoLegStipulations = new FieldSpec(FieldType.Int, "NoLegStipulations");
        public static readonly FieldSpec LegStipulationType = new FieldSpec(FieldType.HashedSlice16, "LegStipulationType");
        public static readonly FieldSpec LegStipulationValue = new FieldSpec(FieldType.HashedSlice16, "LegStipulationValue");
        // End LegStipulations
        public static readonly FieldSpec LegPositionEffect = new FieldSpec(FieldType.Char, "LegPositionEffect");
        public static readonly FieldSpec LegCoveredOrUncovered = new FieldSpec(FieldType.Int, "LegCoveredOrUncovered");
        // Begin NestedParties
        public static readonly FieldSpec NoNestedPartyIDs = new FieldSpec(FieldType.Int, "NoNestedPartyIDs");
        public static readonly FieldSpec NestedPartyID = new FieldSpec(FieldType.HashedSlice16, "NestedPartyID");
        public static readonly FieldSpec NestedPartyIDSource = new FieldSpec(FieldType.Char, "NestedPartyIDSource");
        public static readonly FieldSpec NestedPartyRole = new FieldSpec(FieldType.Int, "NestedPartyRole");
        // Begin NstdPtysSubGrp
        public static readonly FieldSpec NoNestedPartySubIDs = new FieldSpec(FieldType.Int, "NoNestedPartySubIDs");
        public static readonly FieldSpec NestedPartySubID = new FieldSpec(FieldType.HashedSlice16, "NestedPartySubID");
        public static readonly FieldSpec NestedPartySubIDType = new FieldSpec(FieldType.Int, "NestedPartySubIDType");
        // End NstdPtysSubGrp
        // End NestedParties
        public static readonly FieldSpec LegRefID = new FieldSpec(FieldType.HashedSlice16, "LegRefID");
        public static readonly FieldSpec LegSettlType = new FieldSpec(FieldType.HashedSlice16, "LegSettlType");
        public static readonly FieldSpec LegSettlDate = new FieldSpec(FieldType.HashedSlice16, "LegSettlDate");
        public static readonly FieldSpec LegLastPx = new FieldSpec(FieldType.Float, "LegLastPx");
        public static readonly FieldSpec LegSettlCurrency = new FieldSpec(FieldType.HashedSlice16, "LegSettlCurrency");
        public static readonly FieldSpec LegLastForwardPoints = new FieldSpec(FieldType.Float, "LegLastForwardPoints");
        public static readonly FieldSpec LegCalculatedCcyLastQty = new FieldSpec(FieldType.Float, "LegCalculatedCcyLastQty");
        public static readonly FieldSpec LegGrossTradeAmt = new FieldSpec(FieldType.Float, "LegGrossTradeAmt");
        // End TrdInstrmtLegGrp
        public static readonly FieldSpec TransactTime = new FieldSpec(FieldType.HashedSlice16, "TransactTime");
        // Begin TrdRegTimestamps
        public static readonly FieldSpec NoTrdRegTimestamps = new FieldSpec(FieldType.Int, "NoTrdRegTimestamps");
        public static readonly FieldSpec TrdRegTimestamp = new FieldSpec(FieldType.HashedSlice16, "TrdRegTimestamp");
        public static readonly FieldSpec TrdRegTimestampType = new FieldSpec(FieldType.Int, "TrdRegTimestampType");
        public static readonly FieldSpec TrdRegTimestampOrigin = new FieldSpec(FieldType.HashedSlice16, "TrdRegTimestampOrigin");
        public static readonly FieldSpec DeskType = new FieldSpec(FieldType.HashedSlice16, "DeskType");
        public static readonly FieldSpec DeskTypeSource = new FieldSpec(FieldType.Int, "DeskTypeSource");
        public static readonly FieldSpec DeskOrderHandlingInst = new FieldSpec(FieldType.HashedSlice16, "DeskOrderHandlingInst");
        // End TrdRegTimestamps
        public static readonly FieldSpec SettlType = new FieldSpec(FieldType.HashedSlice16, "SettlType");
        public static readonly FieldSpec SettlDate = new FieldSpec(FieldType.HashedSlice16, "SettlDate");
        public static readonly FieldSpec UnderlyingSettlementDate = new FieldSpec(FieldType.HashedSlice16, "UnderlyingSettlementDate");
        public static readonly FieldSpec MatchStatus = new FieldSpec(FieldType.Char, "MatchStatus");
        public static readonly FieldSpec MatchType = new FieldSpec(FieldType.HashedSlice16, "MatchType");
        // Begin TrdCapRptSideGrp
        public static readonly FieldSpec NoSides = new FieldSpec(FieldType.Int, "NoSides");
        public static readonly FieldSpec Side = new FieldSpec(FieldType.Char, "Side");
        public static readonly FieldSpec SideLastQty = new FieldSpec(FieldType.Float, "SideLastQty");
        public static readonly FieldSpec SideTradeReportID = new FieldSpec(FieldType.HashedSlice16, "SideTradeReportID");
        public static readonly FieldSpec SideFillStationCd = new FieldSpec(FieldType.HashedSlice16, "SideFillStationCd");
        public static readonly FieldSpec SideReasonCd = new FieldSpec(FieldType.HashedSlice16, "SideReasonCd");
        public static readonly FieldSpec RptSeq = new FieldSpec(FieldType.Int, "RptSeq");
        public static readonly FieldSpec SideTrdSubTyp = new FieldSpec(FieldType.Int, "SideTrdSubTyp");
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
        public static readonly FieldSpec Account = new FieldSpec(FieldType.HashedSlice16, "Account");
        public static readonly FieldSpec AcctIDSource = new FieldSpec(FieldType.Int, "AcctIDSource");
        public static readonly FieldSpec AccountType = new FieldSpec(FieldType.Int, "AccountType");
        public static readonly FieldSpec ProcessCode = new FieldSpec(FieldType.Char, "ProcessCode");
        public static readonly FieldSpec OddLot = new FieldSpec(FieldType.Char, "OddLot");
        // Begin ClrInstGrp
        public static readonly FieldSpec NoClearingInstructions = new FieldSpec(FieldType.Int, "NoClearingInstructions");
        public static readonly FieldSpec ClearingInstruction = new FieldSpec(FieldType.Int, "ClearingInstruction");
        // End ClrInstGrp
        public static readonly FieldSpec TradeInputSource = new FieldSpec(FieldType.HashedSlice16, "TradeInputSource");
        public static readonly FieldSpec TradeInputDevice = new FieldSpec(FieldType.HashedSlice16, "TradeInputDevice");
        public static readonly FieldSpec ComplianceID = new FieldSpec(FieldType.HashedSlice16, "ComplianceID");
        public static readonly FieldSpec SolicitedFlag = new FieldSpec(FieldType.Char, "SolicitedFlag");
        public static readonly FieldSpec CustOrderCapacity = new FieldSpec(FieldType.Int, "CustOrderCapacity");
        public static readonly FieldSpec TradingSessionID = new FieldSpec(FieldType.HashedSlice16, "TradingSessionID");
        public static readonly FieldSpec TradingSessionSubID = new FieldSpec(FieldType.HashedSlice16, "TradingSessionSubID");
        public static readonly FieldSpec TimeBracket = new FieldSpec(FieldType.HashedSlice16, "TimeBracket");
        // Begin CommissionData
        public static readonly FieldSpec Commission = new FieldSpec(FieldType.Float, "Commission");
        public static readonly FieldSpec CommType = new FieldSpec(FieldType.Char, "CommType");
        public static readonly FieldSpec CommCurrency = new FieldSpec(FieldType.HashedSlice16, "CommCurrency");
        public static readonly FieldSpec FundRenewWaiv = new FieldSpec(FieldType.Char, "FundRenewWaiv");
        // End CommissionData
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
        public static readonly FieldSpec SettlCurrAmt = new FieldSpec(FieldType.Float, "SettlCurrAmt");
        public static readonly FieldSpec SettlCurrFxRate = new FieldSpec(FieldType.Float, "SettlCurrFxRate");
        public static readonly FieldSpec SettlCurrFxRateCalc = new FieldSpec(FieldType.Char, "SettlCurrFxRateCalc");
        public static readonly FieldSpec PositionEffect = new FieldSpec(FieldType.Char, "PositionEffect");
        public static readonly FieldSpec Text = new FieldSpec(FieldType.HashedSlice16, "Text");
        public static readonly FieldSpec EncodedTextLen = new FieldSpec(FieldType.Int, "EncodedTextLen");
        public static readonly FieldSpec EncodedText = new FieldSpec(FieldType.HashedSlice16, "EncodedText");
        public static readonly FieldSpec SideMultiLegReportingType = new FieldSpec(FieldType.Int, "SideMultiLegReportingType");
        // Begin ContAmtGrp
        public static readonly FieldSpec NoContAmts = new FieldSpec(FieldType.Int, "NoContAmts");
        public static readonly FieldSpec ContAmtType = new FieldSpec(FieldType.Int, "ContAmtType");
        public static readonly FieldSpec ContAmtValue = new FieldSpec(FieldType.Float, "ContAmtValue");
        public static readonly FieldSpec ContAmtCurr = new FieldSpec(FieldType.HashedSlice16, "ContAmtCurr");
        // End ContAmtGrp
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
        public static readonly FieldSpec ExchangeRule = new FieldSpec(FieldType.HashedSlice16, "ExchangeRule");
        public static readonly FieldSpec TradeAllocIndicator = new FieldSpec(FieldType.Int, "TradeAllocIndicator");
        public static readonly FieldSpec PreallocMethod = new FieldSpec(FieldType.Char, "PreallocMethod");
        public static readonly FieldSpec AllocID = new FieldSpec(FieldType.HashedSlice16, "AllocID");
        // Begin TrdAllocGrp
        public static readonly FieldSpec NoAllocs = new FieldSpec(FieldType.Int, "NoAllocs");
        public static readonly FieldSpec AllocAccount = new FieldSpec(FieldType.HashedSlice16, "AllocAccount");
        public static readonly FieldSpec AllocAcctIDSource = new FieldSpec(FieldType.Int, "AllocAcctIDSource");
        public static readonly FieldSpec AllocSettlCurrency = new FieldSpec(FieldType.HashedSlice16, "AllocSettlCurrency");
        public static readonly FieldSpec IndividualAllocID = new FieldSpec(FieldType.HashedSlice16, "IndividualAllocID");
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
        public static readonly FieldSpec AllocQty = new FieldSpec(FieldType.Float, "AllocQty");
        public static readonly FieldSpec AllocCustomerCapacity = new FieldSpec(FieldType.HashedSlice16, "AllocCustomerCapacity");
        public static readonly FieldSpec AllocMethod = new FieldSpec(FieldType.Int, "AllocMethod");
        public static readonly FieldSpec SecondaryIndividualAllocID = new FieldSpec(FieldType.HashedSlice16, "SecondaryIndividualAllocID");
        public static readonly FieldSpec AllocClearingFeeIndicator = new FieldSpec(FieldType.HashedSlice16, "AllocClearingFeeIndicator");
        // End TrdAllocGrp
        // Begin SideTrdRegTS
        public static readonly FieldSpec NoSideTrdRegTS = new FieldSpec(FieldType.Int, "NoSideTrdRegTS");
        public static readonly FieldSpec SideTrdRegTimestamp = new FieldSpec(FieldType.HashedSlice16, "SideTrdRegTimestamp");
        public static readonly FieldSpec SideTrdRegTimestampType = new FieldSpec(FieldType.Int, "SideTrdRegTimestampType");
        public static readonly FieldSpec SideTrdRegTimestampSrc = new FieldSpec(FieldType.HashedSlice16, "SideTrdRegTimestampSrc");
        // End SideTrdRegTS
        public static readonly FieldSpec SideGrossTradeAmt = new FieldSpec(FieldType.Float, "SideGrossTradeAmt");
        public static readonly FieldSpec AggressorIndicator = new FieldSpec(FieldType.Char, "AggressorIndicator");
        public static readonly FieldSpec ExchangeSpecialInstructions = new FieldSpec(FieldType.HashedSlice16, "ExchangeSpecialInstructions");
        // End TrdCapRptSideGrp
        public static readonly FieldSpec CopyMsgIndicator = new FieldSpec(FieldType.Char, "CopyMsgIndicator");
        public static readonly FieldSpec PublishTrdIndicator = new FieldSpec(FieldType.Char, "PublishTrdIndicator");
        public static readonly FieldSpec ShortSaleReason = new FieldSpec(FieldType.Int, "ShortSaleReason");
        public static readonly FieldSpec TierCode = new FieldSpec(FieldType.HashedSlice16, "TierCode");
        public static readonly FieldSpec MessageEventSource = new FieldSpec(FieldType.HashedSlice16, "MessageEventSource");
        public static readonly FieldSpec LastUpdateTime = new FieldSpec(FieldType.HashedSlice16, "LastUpdateTime");
        public static readonly FieldSpec RndPx = new FieldSpec(FieldType.Float, "RndPx");
        public static readonly FieldSpec TZTransactTime = new FieldSpec(FieldType.HashedSlice16, "TZTransactTime");
        public static readonly FieldSpec ReportedPxDiff = new FieldSpec(FieldType.Char, "ReportedPxDiff");
        public static readonly FieldSpec GrossTradeAmt = new FieldSpec(FieldType.Float, "GrossTradeAmt");
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
            TradeReportID,
            TradeID,
            SecondaryTradeID,
            FirmTradeID,
            SecondaryFirmTradeID,
            TradeReportTransType,
            TradeReportType,
            TrdRptStatus,
            TradeRequestID,
            TrdType,
            TrdSubType,
            SecondaryTrdType,
            TradeHandlingInstr,
            OrigTradeHandlingInstr,
            OrigTradeDate,
            OrigTradeID,
            OrigSecondaryTradeID,
            TransferReason,
            ExecType,
            TotNumTradeReports,
            LastRptRequested,
            UnsolicitedIndicator,
            SubscriptionRequestType,
            TradeReportRefID,
            SecondaryTradeReportRefID,
            SecondaryTradeReportID,
            TradeLinkID,
            TrdMatchID,
            ExecID,
            SecondaryExecID,
            ExecRestatementReason,
            PreviouslyReported,
            PriceType,
            NoRootPartyIDs,
            RootPartyID,
            RootPartyIDSource,
            RootPartyRole,
            NoRootPartySubIDs,
            RootPartySubID,
            RootPartySubIDType,
            AsOfIndicator,
            SettlSessID,
            SettlSessSubID,
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
            AgreementDesc,
            AgreementID,
            AgreementDate,
            AgreementCurrency,
            TerminationType,
            StartDate,
            EndDate,
            DeliveryType,
            MarginRatio,
            QtyType,
            YieldType,
            Yield,
            YieldCalcDate,
            YieldRedemptionDate,
            YieldRedemptionPrice,
            YieldRedemptionPriceType,
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
            UnderlyingTradingSessionID,
            UnderlyingTradingSessionSubID,
            LastQty,
            LastPx,
            CalculatedCcyLastQty,
            Currency,
            SettlCurrency,
            LastParPx,
            LastSpotRate,
            LastForwardPoints,
            LastSwapPoints,
            LastMkt,
            TradeDate,
            ClearingBusinessDate,
            AvgPx,
            Spread,
            BenchmarkCurveCurrency,
            BenchmarkCurveName,
            BenchmarkCurvePoint,
            BenchmarkPrice,
            BenchmarkPriceType,
            BenchmarkSecurityID,
            BenchmarkSecurityIDSource,
            AvgPxIndicator,
            NoPosAmt,
            PosAmtType,
            PosAmt,
            PositionCurrency,
            MultiLegReportingType,
            TradeLegRefID,
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
            LegQty,
            LegSwapType,
            LegReportID,
            NoLegStipulations,
            LegStipulationType,
            LegStipulationValue,
            LegPositionEffect,
            LegCoveredOrUncovered,
            NoNestedPartyIDs,
            NestedPartyID,
            NestedPartyIDSource,
            NestedPartyRole,
            NoNestedPartySubIDs,
            NestedPartySubID,
            NestedPartySubIDType,
            LegRefID,
            LegSettlType,
            LegSettlDate,
            LegLastPx,
            LegSettlCurrency,
            LegLastForwardPoints,
            LegCalculatedCcyLastQty,
            LegGrossTradeAmt,
            TransactTime,
            NoTrdRegTimestamps,
            TrdRegTimestamp,
            TrdRegTimestampType,
            TrdRegTimestampOrigin,
            DeskType,
            DeskTypeSource,
            DeskOrderHandlingInst,
            SettlType,
            SettlDate,
            UnderlyingSettlementDate,
            MatchStatus,
            MatchType,
            NoSides,
            Side,
            SideLastQty,
            SideTradeReportID,
            SideFillStationCd,
            SideReasonCd,
            RptSeq,
            SideTrdSubTyp,
            NoPartyIDs,
            PartyID,
            PartyIDSource,
            PartyRole,
            NoPartySubIDs,
            PartySubID,
            PartySubIDType,
            Account,
            AcctIDSource,
            AccountType,
            ProcessCode,
            OddLot,
            NoClearingInstructions,
            ClearingInstruction,
            TradeInputSource,
            TradeInputDevice,
            ComplianceID,
            SolicitedFlag,
            CustOrderCapacity,
            TradingSessionID,
            TradingSessionSubID,
            TimeBracket,
            Commission,
            CommType,
            CommCurrency,
            FundRenewWaiv,
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
            SettlCurrAmt,
            SettlCurrFxRate,
            SettlCurrFxRateCalc,
            PositionEffect,
            Text,
            EncodedTextLen,
            EncodedText,
            SideMultiLegReportingType,
            NoContAmts,
            ContAmtType,
            ContAmtValue,
            ContAmtCurr,
            NoStipulations,
            StipulationType,
            StipulationValue,
            NoMiscFees,
            MiscFeeAmt,
            MiscFeeCurr,
            MiscFeeType,
            MiscFeeBasis,
            ExchangeRule,
            TradeAllocIndicator,
            PreallocMethod,
            AllocID,
            NoAllocs,
            AllocAccount,
            AllocAcctIDSource,
            AllocSettlCurrency,
            IndividualAllocID,
            NoNested2PartyIDs,
            Nested2PartyID,
            Nested2PartyIDSource,
            Nested2PartyRole,
            NoNested2PartySubIDs,
            Nested2PartySubID,
            Nested2PartySubIDType,
            AllocQty,
            AllocCustomerCapacity,
            AllocMethod,
            SecondaryIndividualAllocID,
            AllocClearingFeeIndicator,
            NoSideTrdRegTS,
            SideTrdRegTimestamp,
            SideTrdRegTimestampType,
            SideTrdRegTimestampSrc,
            SideGrossTradeAmt,
            AggressorIndicator,
            ExchangeSpecialInstructions,
            CopyMsgIndicator,
            PublishTrdIndicator,
            ShortSaleReason,
            TierCode,
            MessageEventSource,
            LastUpdateTime,
            RndPx,
            TZTransactTime,
            ReportedPxDiff,
            GrossTradeAmt,
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
            { 571, TradeReportID },
            { 1003, TradeID },
            { 1040, SecondaryTradeID },
            { 1041, FirmTradeID },
            { 1042, SecondaryFirmTradeID },
            { 487, TradeReportTransType },
            { 856, TradeReportType },
            { 939, TrdRptStatus },
            { 568, TradeRequestID },
            { 828, TrdType },
            { 829, TrdSubType },
            { 855, SecondaryTrdType },
            { 1123, TradeHandlingInstr },
            { 1124, OrigTradeHandlingInstr },
            { 1125, OrigTradeDate },
            { 1126, OrigTradeID },
            { 1127, OrigSecondaryTradeID },
            { 830, TransferReason },
            { 150, ExecType },
            { 748, TotNumTradeReports },
            { 912, LastRptRequested },
            { 325, UnsolicitedIndicator },
            { 263, SubscriptionRequestType },
            { 572, TradeReportRefID },
            { 881, SecondaryTradeReportRefID },
            { 818, SecondaryTradeReportID },
            { 820, TradeLinkID },
            { 880, TrdMatchID },
            { 17, ExecID },
            { 527, SecondaryExecID },
            { 378, ExecRestatementReason },
            { 570, PreviouslyReported },
            { 423, PriceType },
            { 1116, NoRootPartyIDs },
            { 1117, RootPartyID },
            { 1118, RootPartyIDSource },
            { 1119, RootPartyRole },
            { 1120, NoRootPartySubIDs },
            { 1121, RootPartySubID },
            { 1122, RootPartySubIDType },
            { 1015, AsOfIndicator },
            { 716, SettlSessID },
            { 717, SettlSessSubID },
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
            { 913, AgreementDesc },
            { 914, AgreementID },
            { 915, AgreementDate },
            { 918, AgreementCurrency },
            { 788, TerminationType },
            { 916, StartDate },
            { 917, EndDate },
            { 919, DeliveryType },
            { 898, MarginRatio },
            { 854, QtyType },
            { 235, YieldType },
            { 236, Yield },
            { 701, YieldCalcDate },
            { 696, YieldRedemptionDate },
            { 697, YieldRedemptionPrice },
            { 698, YieldRedemptionPriceType },
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
            { 822, UnderlyingTradingSessionID },
            { 823, UnderlyingTradingSessionSubID },
            { 32, LastQty },
            { 31, LastPx },
            { 1056, CalculatedCcyLastQty },
            { 15, Currency },
            { 120, SettlCurrency },
            { 669, LastParPx },
            { 194, LastSpotRate },
            { 195, LastForwardPoints },
            { 1071, LastSwapPoints },
            { 30, LastMkt },
            { 75, TradeDate },
            { 715, ClearingBusinessDate },
            { 6, AvgPx },
            { 218, Spread },
            { 220, BenchmarkCurveCurrency },
            { 221, BenchmarkCurveName },
            { 222, BenchmarkCurvePoint },
            { 662, BenchmarkPrice },
            { 663, BenchmarkPriceType },
            { 699, BenchmarkSecurityID },
            { 761, BenchmarkSecurityIDSource },
            { 819, AvgPxIndicator },
            { 753, NoPosAmt },
            { 707, PosAmtType },
            { 708, PosAmt },
            { 1055, PositionCurrency },
            { 442, MultiLegReportingType },
            { 824, TradeLegRefID },
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
            { 687, LegQty },
            { 690, LegSwapType },
            { 990, LegReportID },
            { 683, NoLegStipulations },
            { 688, LegStipulationType },
            { 689, LegStipulationValue },
            { 564, LegPositionEffect },
            { 565, LegCoveredOrUncovered },
            { 539, NoNestedPartyIDs },
            { 524, NestedPartyID },
            { 525, NestedPartyIDSource },
            { 538, NestedPartyRole },
            { 804, NoNestedPartySubIDs },
            { 545, NestedPartySubID },
            { 805, NestedPartySubIDType },
            { 654, LegRefID },
            { 587, LegSettlType },
            { 588, LegSettlDate },
            { 637, LegLastPx },
            { 675, LegSettlCurrency },
            { 1073, LegLastForwardPoints },
            { 1074, LegCalculatedCcyLastQty },
            { 1075, LegGrossTradeAmt },
            { 60, TransactTime },
            { 768, NoTrdRegTimestamps },
            { 769, TrdRegTimestamp },
            { 770, TrdRegTimestampType },
            { 771, TrdRegTimestampOrigin },
            { 1033, DeskType },
            { 1034, DeskTypeSource },
            { 1035, DeskOrderHandlingInst },
            { 63, SettlType },
            { 64, SettlDate },
            { 987, UnderlyingSettlementDate },
            { 573, MatchStatus },
            { 574, MatchType },
            { 552, NoSides },
            { 54, Side },
            { 1009, SideLastQty },
            { 1005, SideTradeReportID },
            { 1006, SideFillStationCd },
            { 1007, SideReasonCd },
            { 83, RptSeq },
            { 1008, SideTrdSubTyp },
            { 453, NoPartyIDs },
            { 448, PartyID },
            { 447, PartyIDSource },
            { 452, PartyRole },
            { 802, NoPartySubIDs },
            { 523, PartySubID },
            { 803, PartySubIDType },
            { 1, Account },
            { 660, AcctIDSource },
            { 581, AccountType },
            { 81, ProcessCode },
            { 575, OddLot },
            { 576, NoClearingInstructions },
            { 577, ClearingInstruction },
            { 578, TradeInputSource },
            { 579, TradeInputDevice },
            { 376, ComplianceID },
            { 377, SolicitedFlag },
            { 582, CustOrderCapacity },
            { 336, TradingSessionID },
            { 625, TradingSessionSubID },
            { 943, TimeBracket },
            { 12, Commission },
            { 13, CommType },
            { 479, CommCurrency },
            { 497, FundRenewWaiv },
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
            { 119, SettlCurrAmt },
            { 155, SettlCurrFxRate },
            { 156, SettlCurrFxRateCalc },
            { 77, PositionEffect },
            { 58, Text },
            { 354, EncodedTextLen },
            { 355, EncodedText },
            { 752, SideMultiLegReportingType },
            { 518, NoContAmts },
            { 519, ContAmtType },
            { 520, ContAmtValue },
            { 521, ContAmtCurr },
            { 232, NoStipulations },
            { 233, StipulationType },
            { 234, StipulationValue },
            { 136, NoMiscFees },
            { 137, MiscFeeAmt },
            { 138, MiscFeeCurr },
            { 139, MiscFeeType },
            { 891, MiscFeeBasis },
            { 825, ExchangeRule },
            { 826, TradeAllocIndicator },
            { 591, PreallocMethod },
            { 70, AllocID },
            { 78, NoAllocs },
            { 79, AllocAccount },
            { 661, AllocAcctIDSource },
            { 736, AllocSettlCurrency },
            { 467, IndividualAllocID },
            { 756, NoNested2PartyIDs },
            { 757, Nested2PartyID },
            { 758, Nested2PartyIDSource },
            { 759, Nested2PartyRole },
            { 806, NoNested2PartySubIDs },
            { 760, Nested2PartySubID },
            { 807, Nested2PartySubIDType },
            { 80, AllocQty },
            { 993, AllocCustomerCapacity },
            { 1002, AllocMethod },
            { 989, SecondaryIndividualAllocID },
            { 1136, AllocClearingFeeIndicator },
            { 1016, NoSideTrdRegTS },
            { 1012, SideTrdRegTimestamp },
            { 1013, SideTrdRegTimestampType },
            { 1014, SideTrdRegTimestampSrc },
            { 1072, SideGrossTradeAmt },
            { 1057, AggressorIndicator },
            { 1139, ExchangeSpecialInstructions },
            { 797, CopyMsgIndicator },
            { 852, PublishTrdIndicator },
            { 853, ShortSaleReason },
            { 994, TierCode },
            { 1011, MessageEventSource },
            { 779, LastUpdateTime },
            { 991, RndPx },
            { 1132, TZTransactTime },
            { 1134, ReportedPxDiff },
            { 381, GrossTradeAmt },
            { 93, SignatureLength },
            { 89, Signature },
            { 10, CheckSum },
        };
        public static FieldSpec GetFieldSpec(int tag) => tagToFieldSpec[tag];
    }
}

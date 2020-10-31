using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class NewOrderList
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
        public static readonly FieldSpec ListID = new FieldSpec(FieldType.HashedSlice16, "ListID");
        public static readonly FieldSpec BidID = new FieldSpec(FieldType.HashedSlice16, "BidID");
        public static readonly FieldSpec ClientBidID = new FieldSpec(FieldType.HashedSlice16, "ClientBidID");
        public static readonly FieldSpec ProgRptReqs = new FieldSpec(FieldType.Int, "ProgRptReqs");
        public static readonly FieldSpec BidType = new FieldSpec(FieldType.Int, "BidType");
        public static readonly FieldSpec ProgPeriodInterval = new FieldSpec(FieldType.Int, "ProgPeriodInterval");
        public static readonly FieldSpec CancellationRights = new FieldSpec(FieldType.Char, "CancellationRights");
        public static readonly FieldSpec MoneyLaunderingStatus = new FieldSpec(FieldType.Char, "MoneyLaunderingStatus");
        public static readonly FieldSpec RegistID = new FieldSpec(FieldType.HashedSlice16, "RegistID");
        public static readonly FieldSpec ListExecInstType = new FieldSpec(FieldType.Char, "ListExecInstType");
        public static readonly FieldSpec ListExecInst = new FieldSpec(FieldType.HashedSlice16, "ListExecInst");
        public static readonly FieldSpec EncodedListExecInstLen = new FieldSpec(FieldType.Int, "EncodedListExecInstLen");
        public static readonly FieldSpec EncodedListExecInst = new FieldSpec(FieldType.HashedSlice16, "EncodedListExecInst");
        public static readonly FieldSpec AllowableOneSidednessPct = new FieldSpec(FieldType.Float, "AllowableOneSidednessPct");
        public static readonly FieldSpec AllowableOneSidednessValue = new FieldSpec(FieldType.Float, "AllowableOneSidednessValue");
        public static readonly FieldSpec AllowableOneSidednessCurr = new FieldSpec(FieldType.HashedSlice16, "AllowableOneSidednessCurr");
        public static readonly FieldSpec TotNoOrders = new FieldSpec(FieldType.Int, "TotNoOrders");
        public static readonly FieldSpec LastFragment = new FieldSpec(FieldType.Char, "LastFragment");
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
        // Begin ListOrdGrp
        public static readonly FieldSpec NoOrders = new FieldSpec(FieldType.Int, "NoOrders");
        public static readonly FieldSpec ClOrdID = new FieldSpec(FieldType.HashedSlice16, "ClOrdID");
        public static readonly FieldSpec SecondaryClOrdID = new FieldSpec(FieldType.HashedSlice16, "SecondaryClOrdID");
        public static readonly FieldSpec ListSeqNo = new FieldSpec(FieldType.Int, "ListSeqNo");
        public static readonly FieldSpec ClOrdLinkID = new FieldSpec(FieldType.HashedSlice16, "ClOrdLinkID");
        public static readonly FieldSpec SettlInstMode = new FieldSpec(FieldType.Char, "SettlInstMode");
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
        public static readonly FieldSpec TradeOriginationDate = new FieldSpec(FieldType.HashedSlice16, "TradeOriginationDate");
        public static readonly FieldSpec TradeDate = new FieldSpec(FieldType.HashedSlice16, "TradeDate");
        public static readonly FieldSpec Account = new FieldSpec(FieldType.HashedSlice16, "Account");
        public static readonly FieldSpec AcctIDSource = new FieldSpec(FieldType.Int, "AcctIDSource");
        public static readonly FieldSpec AccountType = new FieldSpec(FieldType.Int, "AccountType");
        public static readonly FieldSpec DayBookingInst = new FieldSpec(FieldType.Char, "DayBookingInst");
        public static readonly FieldSpec BookingUnit = new FieldSpec(FieldType.Char, "BookingUnit");
        public static readonly FieldSpec AllocID = new FieldSpec(FieldType.HashedSlice16, "AllocID");
        public static readonly FieldSpec PreallocMethod = new FieldSpec(FieldType.Char, "PreallocMethod");
        // Begin PreAllocGrp
        public static readonly FieldSpec NoAllocs = new FieldSpec(FieldType.Int, "NoAllocs");
        public static readonly FieldSpec AllocAccount = new FieldSpec(FieldType.HashedSlice16, "AllocAccount");
        public static readonly FieldSpec AllocAcctIDSource = new FieldSpec(FieldType.Int, "AllocAcctIDSource");
        public static readonly FieldSpec AllocSettlCurrency = new FieldSpec(FieldType.HashedSlice16, "AllocSettlCurrency");
        public static readonly FieldSpec IndividualAllocID = new FieldSpec(FieldType.HashedSlice16, "IndividualAllocID");
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
        public static readonly FieldSpec AllocQty = new FieldSpec(FieldType.Float, "AllocQty");
        // End PreAllocGrp
        public static readonly FieldSpec SettlType = new FieldSpec(FieldType.HashedSlice16, "SettlType");
        public static readonly FieldSpec SettlDate = new FieldSpec(FieldType.HashedSlice16, "SettlDate");
        public static readonly FieldSpec CashMargin = new FieldSpec(FieldType.Char, "CashMargin");
        public static readonly FieldSpec ClearingFeeIndicator = new FieldSpec(FieldType.HashedSlice16, "ClearingFeeIndicator");
        public static readonly FieldSpec HandlInst = new FieldSpec(FieldType.Char, "HandlInst");
        public static readonly FieldSpec ExecInst = new FieldSpec(FieldType.HashedSlice16, "ExecInst");
        public static readonly FieldSpec MinQty = new FieldSpec(FieldType.Float, "MinQty");
        public static readonly FieldSpec MatchIncrement = new FieldSpec(FieldType.Float, "MatchIncrement");
        public static readonly FieldSpec MaxPriceLevels = new FieldSpec(FieldType.Int, "MaxPriceLevels");
        // Begin DisplayInstruction
        public static readonly FieldSpec DisplayQty = new FieldSpec(FieldType.Float, "DisplayQty");
        public static readonly FieldSpec SecondaryDisplayQty = new FieldSpec(FieldType.Float, "SecondaryDisplayQty");
        public static readonly FieldSpec DisplayWhen = new FieldSpec(FieldType.Char, "DisplayWhen");
        public static readonly FieldSpec DisplayMethod = new FieldSpec(FieldType.Char, "DisplayMethod");
        public static readonly FieldSpec DisplayLowQty = new FieldSpec(FieldType.Float, "DisplayLowQty");
        public static readonly FieldSpec DisplayHighQty = new FieldSpec(FieldType.Float, "DisplayHighQty");
        public static readonly FieldSpec DisplayMinIncr = new FieldSpec(FieldType.Float, "DisplayMinIncr");
        public static readonly FieldSpec RefreshQty = new FieldSpec(FieldType.Float, "RefreshQty");
        // End DisplayInstruction
        public static readonly FieldSpec MaxFloor = new FieldSpec(FieldType.Float, "MaxFloor");
        public static readonly FieldSpec ExDestination = new FieldSpec(FieldType.HashedSlice16, "ExDestination");
        public static readonly FieldSpec ExDestinationIDSource = new FieldSpec(FieldType.Char, "ExDestinationIDSource");
        // Begin TrdgSesGrp
        public static readonly FieldSpec NoTradingSessions = new FieldSpec(FieldType.Int, "NoTradingSessions");
        public static readonly FieldSpec TradingSessionID = new FieldSpec(FieldType.HashedSlice16, "TradingSessionID");
        public static readonly FieldSpec TradingSessionSubID = new FieldSpec(FieldType.HashedSlice16, "TradingSessionSubID");
        // End TrdgSesGrp
        public static readonly FieldSpec ProcessCode = new FieldSpec(FieldType.Char, "ProcessCode");
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
        public static readonly FieldSpec PrevClosePx = new FieldSpec(FieldType.Float, "PrevClosePx");
        public static readonly FieldSpec Side = new FieldSpec(FieldType.Char, "Side");
        public static readonly FieldSpec SideValueInd = new FieldSpec(FieldType.Int, "SideValueInd");
        public static readonly FieldSpec LocateReqd = new FieldSpec(FieldType.Char, "LocateReqd");
        public static readonly FieldSpec TransactTime = new FieldSpec(FieldType.HashedSlice16, "TransactTime");
        // Begin Stipulations
        public static readonly FieldSpec NoStipulations = new FieldSpec(FieldType.Int, "NoStipulations");
        public static readonly FieldSpec StipulationType = new FieldSpec(FieldType.HashedSlice16, "StipulationType");
        public static readonly FieldSpec StipulationValue = new FieldSpec(FieldType.HashedSlice16, "StipulationValue");
        // End Stipulations
        public static readonly FieldSpec QtyType = new FieldSpec(FieldType.Int, "QtyType");
        // Begin OrderQtyData
        public static readonly FieldSpec OrderQty = new FieldSpec(FieldType.Float, "OrderQty");
        public static readonly FieldSpec CashOrderQty = new FieldSpec(FieldType.Float, "CashOrderQty");
        public static readonly FieldSpec OrderPercent = new FieldSpec(FieldType.Float, "OrderPercent");
        public static readonly FieldSpec RoundingDirection = new FieldSpec(FieldType.Char, "RoundingDirection");
        public static readonly FieldSpec RoundingModulus = new FieldSpec(FieldType.Float, "RoundingModulus");
        // End OrderQtyData
        public static readonly FieldSpec OrdType = new FieldSpec(FieldType.Char, "OrdType");
        public static readonly FieldSpec PriceType = new FieldSpec(FieldType.Int, "PriceType");
        public static readonly FieldSpec Price = new FieldSpec(FieldType.Float, "Price");
        public static readonly FieldSpec PriceProtectionScope = new FieldSpec(FieldType.Char, "PriceProtectionScope");
        public static readonly FieldSpec StopPx = new FieldSpec(FieldType.Float, "StopPx");
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
        // Begin YieldData
        public static readonly FieldSpec YieldType = new FieldSpec(FieldType.HashedSlice16, "YieldType");
        public static readonly FieldSpec Yield = new FieldSpec(FieldType.Float, "Yield");
        public static readonly FieldSpec YieldCalcDate = new FieldSpec(FieldType.HashedSlice16, "YieldCalcDate");
        public static readonly FieldSpec YieldRedemptionDate = new FieldSpec(FieldType.HashedSlice16, "YieldRedemptionDate");
        public static readonly FieldSpec YieldRedemptionPrice = new FieldSpec(FieldType.Float, "YieldRedemptionPrice");
        public static readonly FieldSpec YieldRedemptionPriceType = new FieldSpec(FieldType.Int, "YieldRedemptionPriceType");
        // End YieldData
        public static readonly FieldSpec Currency = new FieldSpec(FieldType.HashedSlice16, "Currency");
        public static readonly FieldSpec ComplianceID = new FieldSpec(FieldType.HashedSlice16, "ComplianceID");
        public static readonly FieldSpec SolicitedFlag = new FieldSpec(FieldType.Char, "SolicitedFlag");
        public static readonly FieldSpec IOIID = new FieldSpec(FieldType.HashedSlice16, "IOIID");
        public static readonly FieldSpec QuoteID = new FieldSpec(FieldType.HashedSlice16, "QuoteID");
        public static readonly FieldSpec RefOrderID = new FieldSpec(FieldType.HashedSlice16, "RefOrderID");
        public static readonly FieldSpec RefOrderIDSource = new FieldSpec(FieldType.Char, "RefOrderIDSource");
        public static readonly FieldSpec TimeInForce = new FieldSpec(FieldType.Char, "TimeInForce");
        public static readonly FieldSpec EffectiveTime = new FieldSpec(FieldType.HashedSlice16, "EffectiveTime");
        public static readonly FieldSpec ExpireDate = new FieldSpec(FieldType.HashedSlice16, "ExpireDate");
        public static readonly FieldSpec ExpireTime = new FieldSpec(FieldType.HashedSlice16, "ExpireTime");
        public static readonly FieldSpec GTBookingInst = new FieldSpec(FieldType.Int, "GTBookingInst");
        // Begin CommissionData
        public static readonly FieldSpec Commission = new FieldSpec(FieldType.Float, "Commission");
        public static readonly FieldSpec CommType = new FieldSpec(FieldType.Char, "CommType");
        public static readonly FieldSpec CommCurrency = new FieldSpec(FieldType.HashedSlice16, "CommCurrency");
        public static readonly FieldSpec FundRenewWaiv = new FieldSpec(FieldType.Char, "FundRenewWaiv");
        // End CommissionData
        public static readonly FieldSpec OrderCapacity = new FieldSpec(FieldType.Char, "OrderCapacity");
        public static readonly FieldSpec OrderRestrictions = new FieldSpec(FieldType.HashedSlice16, "OrderRestrictions");
        public static readonly FieldSpec PreTradeAnonymity = new FieldSpec(FieldType.Char, "PreTradeAnonymity");
        public static readonly FieldSpec CustOrderCapacity = new FieldSpec(FieldType.Int, "CustOrderCapacity");
        public static readonly FieldSpec ForexReq = new FieldSpec(FieldType.Char, "ForexReq");
        public static readonly FieldSpec SettlCurrency = new FieldSpec(FieldType.HashedSlice16, "SettlCurrency");
        public static readonly FieldSpec BookingType = new FieldSpec(FieldType.Int, "BookingType");
        public static readonly FieldSpec Text = new FieldSpec(FieldType.HashedSlice16, "Text");
        public static readonly FieldSpec EncodedTextLen = new FieldSpec(FieldType.Int, "EncodedTextLen");
        public static readonly FieldSpec EncodedText = new FieldSpec(FieldType.HashedSlice16, "EncodedText");
        public static readonly FieldSpec SettlDate2 = new FieldSpec(FieldType.HashedSlice16, "SettlDate2");
        public static readonly FieldSpec OrderQty2 = new FieldSpec(FieldType.Float, "OrderQty2");
        public static readonly FieldSpec Price2 = new FieldSpec(FieldType.Float, "Price2");
        public static readonly FieldSpec PositionEffect = new FieldSpec(FieldType.Char, "PositionEffect");
        public static readonly FieldSpec CoveredOrUncovered = new FieldSpec(FieldType.Int, "CoveredOrUncovered");
        public static readonly FieldSpec MaxShow = new FieldSpec(FieldType.Float, "MaxShow");
        // Begin PegInstructions
        public static readonly FieldSpec PegOffsetValue = new FieldSpec(FieldType.Float, "PegOffsetValue");
        public static readonly FieldSpec PegPriceType = new FieldSpec(FieldType.Int, "PegPriceType");
        public static readonly FieldSpec PegMoveType = new FieldSpec(FieldType.Int, "PegMoveType");
        public static readonly FieldSpec PegOffsetType = new FieldSpec(FieldType.Int, "PegOffsetType");
        public static readonly FieldSpec PegLimitType = new FieldSpec(FieldType.Int, "PegLimitType");
        public static readonly FieldSpec PegRoundDirection = new FieldSpec(FieldType.Int, "PegRoundDirection");
        public static readonly FieldSpec PegScope = new FieldSpec(FieldType.Int, "PegScope");
        public static readonly FieldSpec PegSecurityIDSource = new FieldSpec(FieldType.HashedSlice16, "PegSecurityIDSource");
        public static readonly FieldSpec PegSecurityID = new FieldSpec(FieldType.HashedSlice16, "PegSecurityID");
        public static readonly FieldSpec PegSymbol = new FieldSpec(FieldType.HashedSlice16, "PegSymbol");
        public static readonly FieldSpec PegSecurityDesc = new FieldSpec(FieldType.HashedSlice16, "PegSecurityDesc");
        // End PegInstructions
        // Begin DiscretionInstructions
        public static readonly FieldSpec DiscretionInst = new FieldSpec(FieldType.Char, "DiscretionInst");
        public static readonly FieldSpec DiscretionOffsetValue = new FieldSpec(FieldType.Float, "DiscretionOffsetValue");
        public static readonly FieldSpec DiscretionMoveType = new FieldSpec(FieldType.Int, "DiscretionMoveType");
        public static readonly FieldSpec DiscretionOffsetType = new FieldSpec(FieldType.Int, "DiscretionOffsetType");
        public static readonly FieldSpec DiscretionLimitType = new FieldSpec(FieldType.Int, "DiscretionLimitType");
        public static readonly FieldSpec DiscretionRoundDirection = new FieldSpec(FieldType.Int, "DiscretionRoundDirection");
        public static readonly FieldSpec DiscretionScope = new FieldSpec(FieldType.Int, "DiscretionScope");
        // End DiscretionInstructions
        public static readonly FieldSpec TargetStrategy = new FieldSpec(FieldType.Int, "TargetStrategy");
        // Begin StrategyParametersGrp
        public static readonly FieldSpec NoStrategyParameters = new FieldSpec(FieldType.Int, "NoStrategyParameters");
        public static readonly FieldSpec StrategyParameterName = new FieldSpec(FieldType.HashedSlice16, "StrategyParameterName");
        public static readonly FieldSpec StrategyParameterType = new FieldSpec(FieldType.Int, "StrategyParameterType");
        public static readonly FieldSpec StrategyParameterValue = new FieldSpec(FieldType.HashedSlice16, "StrategyParameterValue");
        // End StrategyParametersGrp
        public static readonly FieldSpec TargetStrategyParameters = new FieldSpec(FieldType.HashedSlice16, "TargetStrategyParameters");
        public static readonly FieldSpec ParticipationRate = new FieldSpec(FieldType.Float, "ParticipationRate");
        public static readonly FieldSpec Designation = new FieldSpec(FieldType.HashedSlice16, "Designation");
        // End ListOrdGrp
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
            NoRootPartyIDs,
            RootPartyID,
            RootPartyIDSource,
            RootPartyRole,
            NoRootPartySubIDs,
            RootPartySubID,
            RootPartySubIDType,
            NoOrders,
            ClOrdID,
            SecondaryClOrdID,
            ListSeqNo,
            ClOrdLinkID,
            SettlInstMode,
            NoPartyIDs,
            PartyID,
            PartyIDSource,
            PartyRole,
            NoPartySubIDs,
            PartySubID,
            PartySubIDType,
            TradeOriginationDate,
            TradeDate,
            Account,
            AcctIDSource,
            AccountType,
            DayBookingInst,
            BookingUnit,
            AllocID,
            PreallocMethod,
            NoAllocs,
            AllocAccount,
            AllocAcctIDSource,
            AllocSettlCurrency,
            IndividualAllocID,
            NoNestedPartyIDs,
            NestedPartyID,
            NestedPartyIDSource,
            NestedPartyRole,
            NoNestedPartySubIDs,
            NestedPartySubID,
            NestedPartySubIDType,
            AllocQty,
            SettlType,
            SettlDate,
            CashMargin,
            ClearingFeeIndicator,
            HandlInst,
            ExecInst,
            MinQty,
            MatchIncrement,
            MaxPriceLevels,
            DisplayQty,
            SecondaryDisplayQty,
            DisplayWhen,
            DisplayMethod,
            DisplayLowQty,
            DisplayHighQty,
            DisplayMinIncr,
            RefreshQty,
            MaxFloor,
            ExDestination,
            ExDestinationIDSource,
            NoTradingSessions,
            TradingSessionID,
            TradingSessionSubID,
            ProcessCode,
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
            PrevClosePx,
            Side,
            SideValueInd,
            LocateReqd,
            TransactTime,
            NoStipulations,
            StipulationType,
            StipulationValue,
            QtyType,
            OrderQty,
            CashOrderQty,
            OrderPercent,
            RoundingDirection,
            RoundingModulus,
            OrdType,
            PriceType,
            Price,
            PriceProtectionScope,
            StopPx,
            Spread,
            BenchmarkCurveCurrency,
            BenchmarkCurveName,
            BenchmarkCurvePoint,
            BenchmarkPrice,
            BenchmarkPriceType,
            BenchmarkSecurityID,
            BenchmarkSecurityIDSource,
            YieldType,
            Yield,
            YieldCalcDate,
            YieldRedemptionDate,
            YieldRedemptionPrice,
            YieldRedemptionPriceType,
            Currency,
            ComplianceID,
            SolicitedFlag,
            IOIID,
            QuoteID,
            RefOrderID,
            RefOrderIDSource,
            TimeInForce,
            EffectiveTime,
            ExpireDate,
            ExpireTime,
            GTBookingInst,
            Commission,
            CommType,
            CommCurrency,
            FundRenewWaiv,
            OrderCapacity,
            OrderRestrictions,
            PreTradeAnonymity,
            CustOrderCapacity,
            ForexReq,
            SettlCurrency,
            BookingType,
            Text,
            EncodedTextLen,
            EncodedText,
            SettlDate2,
            OrderQty2,
            Price2,
            PositionEffect,
            CoveredOrUncovered,
            MaxShow,
            PegOffsetValue,
            PegPriceType,
            PegMoveType,
            PegOffsetType,
            PegLimitType,
            PegRoundDirection,
            PegScope,
            PegSecurityIDSource,
            PegSecurityID,
            PegSymbol,
            PegSecurityDesc,
            DiscretionInst,
            DiscretionOffsetValue,
            DiscretionMoveType,
            DiscretionOffsetType,
            DiscretionLimitType,
            DiscretionRoundDirection,
            DiscretionScope,
            TargetStrategy,
            NoStrategyParameters,
            StrategyParameterName,
            StrategyParameterType,
            StrategyParameterValue,
            TargetStrategyParameters,
            ParticipationRate,
            Designation,
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
            { 66, ListID },
            { 390, BidID },
            { 391, ClientBidID },
            { 414, ProgRptReqs },
            { 394, BidType },
            { 415, ProgPeriodInterval },
            { 480, CancellationRights },
            { 481, MoneyLaunderingStatus },
            { 513, RegistID },
            { 433, ListExecInstType },
            { 69, ListExecInst },
            { 352, EncodedListExecInstLen },
            { 353, EncodedListExecInst },
            { 765, AllowableOneSidednessPct },
            { 766, AllowableOneSidednessValue },
            { 767, AllowableOneSidednessCurr },
            { 68, TotNoOrders },
            { 893, LastFragment },
            { 1116, NoRootPartyIDs },
            { 1117, RootPartyID },
            { 1118, RootPartyIDSource },
            { 1119, RootPartyRole },
            { 1120, NoRootPartySubIDs },
            { 1121, RootPartySubID },
            { 1122, RootPartySubIDType },
            { 73, NoOrders },
            { 11, ClOrdID },
            { 526, SecondaryClOrdID },
            { 67, ListSeqNo },
            { 583, ClOrdLinkID },
            { 160, SettlInstMode },
            { 453, NoPartyIDs },
            { 448, PartyID },
            { 447, PartyIDSource },
            { 452, PartyRole },
            { 802, NoPartySubIDs },
            { 523, PartySubID },
            { 803, PartySubIDType },
            { 229, TradeOriginationDate },
            { 75, TradeDate },
            { 1, Account },
            { 660, AcctIDSource },
            { 581, AccountType },
            { 589, DayBookingInst },
            { 590, BookingUnit },
            { 70, AllocID },
            { 591, PreallocMethod },
            { 78, NoAllocs },
            { 79, AllocAccount },
            { 661, AllocAcctIDSource },
            { 736, AllocSettlCurrency },
            { 467, IndividualAllocID },
            { 539, NoNestedPartyIDs },
            { 524, NestedPartyID },
            { 525, NestedPartyIDSource },
            { 538, NestedPartyRole },
            { 804, NoNestedPartySubIDs },
            { 545, NestedPartySubID },
            { 805, NestedPartySubIDType },
            { 80, AllocQty },
            { 63, SettlType },
            { 64, SettlDate },
            { 544, CashMargin },
            { 635, ClearingFeeIndicator },
            { 21, HandlInst },
            { 18, ExecInst },
            { 110, MinQty },
            { 1089, MatchIncrement },
            { 1090, MaxPriceLevels },
            { 1138, DisplayQty },
            { 1082, SecondaryDisplayQty },
            { 1083, DisplayWhen },
            { 1084, DisplayMethod },
            { 1085, DisplayLowQty },
            { 1086, DisplayHighQty },
            { 1087, DisplayMinIncr },
            { 1088, RefreshQty },
            { 111, MaxFloor },
            { 100, ExDestination },
            { 1133, ExDestinationIDSource },
            { 386, NoTradingSessions },
            { 336, TradingSessionID },
            { 625, TradingSessionSubID },
            { 81, ProcessCode },
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
            { 140, PrevClosePx },
            { 54, Side },
            { 401, SideValueInd },
            { 114, LocateReqd },
            { 60, TransactTime },
            { 232, NoStipulations },
            { 233, StipulationType },
            { 234, StipulationValue },
            { 854, QtyType },
            { 38, OrderQty },
            { 152, CashOrderQty },
            { 516, OrderPercent },
            { 468, RoundingDirection },
            { 469, RoundingModulus },
            { 40, OrdType },
            { 423, PriceType },
            { 44, Price },
            { 1092, PriceProtectionScope },
            { 99, StopPx },
            { 218, Spread },
            { 220, BenchmarkCurveCurrency },
            { 221, BenchmarkCurveName },
            { 222, BenchmarkCurvePoint },
            { 662, BenchmarkPrice },
            { 663, BenchmarkPriceType },
            { 699, BenchmarkSecurityID },
            { 761, BenchmarkSecurityIDSource },
            { 235, YieldType },
            { 236, Yield },
            { 701, YieldCalcDate },
            { 696, YieldRedemptionDate },
            { 697, YieldRedemptionPrice },
            { 698, YieldRedemptionPriceType },
            { 15, Currency },
            { 376, ComplianceID },
            { 377, SolicitedFlag },
            { 23, IOIID },
            { 117, QuoteID },
            { 1080, RefOrderID },
            { 1081, RefOrderIDSource },
            { 59, TimeInForce },
            { 168, EffectiveTime },
            { 432, ExpireDate },
            { 126, ExpireTime },
            { 427, GTBookingInst },
            { 12, Commission },
            { 13, CommType },
            { 479, CommCurrency },
            { 497, FundRenewWaiv },
            { 528, OrderCapacity },
            { 529, OrderRestrictions },
            { 1091, PreTradeAnonymity },
            { 582, CustOrderCapacity },
            { 121, ForexReq },
            { 120, SettlCurrency },
            { 775, BookingType },
            { 58, Text },
            { 354, EncodedTextLen },
            { 355, EncodedText },
            { 193, SettlDate2 },
            { 192, OrderQty2 },
            { 640, Price2 },
            { 77, PositionEffect },
            { 203, CoveredOrUncovered },
            { 210, MaxShow },
            { 211, PegOffsetValue },
            { 1094, PegPriceType },
            { 835, PegMoveType },
            { 836, PegOffsetType },
            { 837, PegLimitType },
            { 838, PegRoundDirection },
            { 840, PegScope },
            { 1096, PegSecurityIDSource },
            { 1097, PegSecurityID },
            { 1098, PegSymbol },
            { 1099, PegSecurityDesc },
            { 388, DiscretionInst },
            { 389, DiscretionOffsetValue },
            { 841, DiscretionMoveType },
            { 842, DiscretionOffsetType },
            { 843, DiscretionLimitType },
            { 844, DiscretionRoundDirection },
            { 846, DiscretionScope },
            { 847, TargetStrategy },
            { 957, NoStrategyParameters },
            { 958, StrategyParameterName },
            { 959, StrategyParameterType },
            { 960, StrategyParameterValue },
            { 848, TargetStrategyParameters },
            { 849, ParticipationRate },
            { 494, Designation },
            { 93, SignatureLength },
            { 89, Signature },
            { 10, CheckSum },
        };
        public static FieldSpec GetFieldSpec(int tag) => tagToFieldSpec[tag];
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class SecurityListUpdateReport
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
        public static readonly FieldSpec SecurityReportID = new FieldSpec(FieldType.Int, "SecurityReportID");
        public static readonly FieldSpec SecurityReqID = new FieldSpec(FieldType.HashedSlice16, "SecurityReqID");
        public static readonly FieldSpec SecurityResponseID = new FieldSpec(FieldType.HashedSlice16, "SecurityResponseID");
        public static readonly FieldSpec SecurityRequestResult = new FieldSpec(FieldType.Int, "SecurityRequestResult");
        public static readonly FieldSpec TotNoRelatedSym = new FieldSpec(FieldType.Int, "TotNoRelatedSym");
        public static readonly FieldSpec ClearingBusinessDate = new FieldSpec(FieldType.HashedSlice16, "ClearingBusinessDate");
        public static readonly FieldSpec SecurityUpdateAction = new FieldSpec(FieldType.Char, "SecurityUpdateAction");
        public static readonly FieldSpec CorporateAction = new FieldSpec(FieldType.HashedSlice16, "CorporateAction");
        public static readonly FieldSpec LastFragment = new FieldSpec(FieldType.Char, "LastFragment");
        // Begin SecLstUpdRelSymGrp
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
        public static readonly FieldSpec Currency = new FieldSpec(FieldType.HashedSlice16, "Currency");
        // Begin Stipulations
        public static readonly FieldSpec NoStipulations = new FieldSpec(FieldType.Int, "NoStipulations");
        public static readonly FieldSpec StipulationType = new FieldSpec(FieldType.HashedSlice16, "StipulationType");
        public static readonly FieldSpec StipulationValue = new FieldSpec(FieldType.HashedSlice16, "StipulationValue");
        // End Stipulations
        // Begin SecLstUpdRelSymsLegGrp
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
        public static readonly FieldSpec LegSwapType = new FieldSpec(FieldType.Int, "LegSwapType");
        public static readonly FieldSpec LegSettlType = new FieldSpec(FieldType.HashedSlice16, "LegSettlType");
        // Begin LegStipulations
        public static readonly FieldSpec NoLegStipulations = new FieldSpec(FieldType.Int, "NoLegStipulations");
        public static readonly FieldSpec LegStipulationType = new FieldSpec(FieldType.HashedSlice16, "LegStipulationType");
        public static readonly FieldSpec LegStipulationValue = new FieldSpec(FieldType.HashedSlice16, "LegStipulationValue");
        // End LegStipulations
        // Begin LegBenchmarkCurveData
        public static readonly FieldSpec LegBenchmarkCurveCurrency = new FieldSpec(FieldType.HashedSlice16, "LegBenchmarkCurveCurrency");
        public static readonly FieldSpec LegBenchmarkCurveName = new FieldSpec(FieldType.HashedSlice16, "LegBenchmarkCurveName");
        public static readonly FieldSpec LegBenchmarkCurvePoint = new FieldSpec(FieldType.HashedSlice16, "LegBenchmarkCurvePoint");
        public static readonly FieldSpec LegBenchmarkPrice = new FieldSpec(FieldType.Float, "LegBenchmarkPrice");
        public static readonly FieldSpec LegBenchmarkPriceType = new FieldSpec(FieldType.Int, "LegBenchmarkPriceType");
        // End LegBenchmarkCurveData
        // End SecLstUpdRelSymsLegGrp
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
        public static readonly FieldSpec Text = new FieldSpec(FieldType.HashedSlice16, "Text");
        public static readonly FieldSpec EncodedTextLen = new FieldSpec(FieldType.Int, "EncodedTextLen");
        public static readonly FieldSpec EncodedText = new FieldSpec(FieldType.HashedSlice16, "EncodedText");
        // End SecLstUpdRelSymGrp
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
            SecurityReportID,
            SecurityReqID,
            SecurityResponseID,
            SecurityRequestResult,
            TotNoRelatedSym,
            ClearingBusinessDate,
            SecurityUpdateAction,
            CorporateAction,
            LastFragment,
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
            Currency,
            NoStipulations,
            StipulationType,
            StipulationValue,
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
            LegSwapType,
            LegSettlType,
            NoLegStipulations,
            LegStipulationType,
            LegStipulationValue,
            LegBenchmarkCurveCurrency,
            LegBenchmarkCurveName,
            LegBenchmarkCurvePoint,
            LegBenchmarkPrice,
            LegBenchmarkPriceType,
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
            Text,
            EncodedTextLen,
            EncodedText,
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
            { 964, SecurityReportID },
            { 320, SecurityReqID },
            { 322, SecurityResponseID },
            { 560, SecurityRequestResult },
            { 393, TotNoRelatedSym },
            { 715, ClearingBusinessDate },
            { 980, SecurityUpdateAction },
            { 292, CorporateAction },
            { 893, LastFragment },
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
            { 15, Currency },
            { 232, NoStipulations },
            { 233, StipulationType },
            { 234, StipulationValue },
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
            { 690, LegSwapType },
            { 587, LegSettlType },
            { 683, NoLegStipulations },
            { 688, LegStipulationType },
            { 689, LegStipulationValue },
            { 676, LegBenchmarkCurveCurrency },
            { 677, LegBenchmarkCurveName },
            { 678, LegBenchmarkCurvePoint },
            { 679, LegBenchmarkPrice },
            { 680, LegBenchmarkPriceType },
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
            { 58, Text },
            { 354, EncodedTextLen },
            { 355, EncodedText },
            { 93, SignatureLength },
            { 89, Signature },
            { 10, CheckSum },
        };
        public static FieldSpec GetFieldSpec(int tag) => tagToFieldSpec[tag];
    }
}

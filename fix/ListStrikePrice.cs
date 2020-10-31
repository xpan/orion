using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class ListStrikePrice
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
        public static readonly FieldSpec TotNoStrikes = new FieldSpec(FieldType.Int, "TotNoStrikes");
        public static readonly FieldSpec LastFragment = new FieldSpec(FieldType.Char, "LastFragment");
        // Begin InstrmtStrkPxGrp
        public static readonly FieldSpec NoStrikes = new FieldSpec(FieldType.Int, "NoStrikes");
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
        // End InstrmtStrkPxGrp
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
            TotNoStrikes,
            LastFragment,
            NoStrikes,
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
            { 422, TotNoStrikes },
            { 893, LastFragment },
            { 428, NoStrikes },
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
            { 93, SignatureLength },
            { 89, Signature },
            { 10, CheckSum },
        };
        public static FieldSpec GetFieldSpec(int tag) => tagToFieldSpec[tag];
    }
}

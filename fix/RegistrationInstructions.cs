using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class RegistrationInstructions
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
        public static readonly FieldSpec RegistID = new FieldSpec(FieldType.HashedSlice16, "RegistID");
        public static readonly FieldSpec RegistTransType = new FieldSpec(FieldType.Char, "RegistTransType");
        public static readonly FieldSpec RegistRefID = new FieldSpec(FieldType.HashedSlice16, "RegistRefID");
        public static readonly FieldSpec ClOrdID = new FieldSpec(FieldType.HashedSlice16, "ClOrdID");
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
        public static readonly FieldSpec RegistAcctType = new FieldSpec(FieldType.HashedSlice16, "RegistAcctType");
        public static readonly FieldSpec TaxAdvantageType = new FieldSpec(FieldType.Int, "TaxAdvantageType");
        public static readonly FieldSpec OwnershipType = new FieldSpec(FieldType.Char, "OwnershipType");
        // Begin RgstDtlsGrp
        public static readonly FieldSpec NoRegistDtls = new FieldSpec(FieldType.Int, "NoRegistDtls");
        public static readonly FieldSpec RegistDtls = new FieldSpec(FieldType.HashedSlice16, "RegistDtls");
        public static readonly FieldSpec RegistEmail = new FieldSpec(FieldType.HashedSlice16, "RegistEmail");
        public static readonly FieldSpec MailingDtls = new FieldSpec(FieldType.HashedSlice16, "MailingDtls");
        public static readonly FieldSpec MailingInst = new FieldSpec(FieldType.HashedSlice16, "MailingInst");
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
        public static readonly FieldSpec OwnerType = new FieldSpec(FieldType.Int, "OwnerType");
        public static readonly FieldSpec DateOfBirth = new FieldSpec(FieldType.HashedSlice16, "DateOfBirth");
        public static readonly FieldSpec InvestorCountryOfResidence = new FieldSpec(FieldType.HashedSlice16, "InvestorCountryOfResidence");
        // End RgstDtlsGrp
        // Begin RgstDistInstGrp
        public static readonly FieldSpec NoDistribInsts = new FieldSpec(FieldType.Int, "NoDistribInsts");
        public static readonly FieldSpec DistribPaymentMethod = new FieldSpec(FieldType.Int, "DistribPaymentMethod");
        public static readonly FieldSpec DistribPercentage = new FieldSpec(FieldType.Float, "DistribPercentage");
        public static readonly FieldSpec CashDistribCurr = new FieldSpec(FieldType.HashedSlice16, "CashDistribCurr");
        public static readonly FieldSpec CashDistribAgentName = new FieldSpec(FieldType.HashedSlice16, "CashDistribAgentName");
        public static readonly FieldSpec CashDistribAgentCode = new FieldSpec(FieldType.HashedSlice16, "CashDistribAgentCode");
        public static readonly FieldSpec CashDistribAgentAcctNumber = new FieldSpec(FieldType.HashedSlice16, "CashDistribAgentAcctNumber");
        public static readonly FieldSpec CashDistribPayRef = new FieldSpec(FieldType.HashedSlice16, "CashDistribPayRef");
        public static readonly FieldSpec CashDistribAgentAcctName = new FieldSpec(FieldType.HashedSlice16, "CashDistribAgentAcctName");
        // End RgstDistInstGrp
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
            RegistID,
            RegistTransType,
            RegistRefID,
            ClOrdID,
            NoPartyIDs,
            PartyID,
            PartyIDSource,
            PartyRole,
            NoPartySubIDs,
            PartySubID,
            PartySubIDType,
            Account,
            AcctIDSource,
            RegistAcctType,
            TaxAdvantageType,
            OwnershipType,
            NoRegistDtls,
            RegistDtls,
            RegistEmail,
            MailingDtls,
            MailingInst,
            NoNestedPartyIDs,
            NestedPartyID,
            NestedPartyIDSource,
            NestedPartyRole,
            NoNestedPartySubIDs,
            NestedPartySubID,
            NestedPartySubIDType,
            OwnerType,
            DateOfBirth,
            InvestorCountryOfResidence,
            NoDistribInsts,
            DistribPaymentMethod,
            DistribPercentage,
            CashDistribCurr,
            CashDistribAgentName,
            CashDistribAgentCode,
            CashDistribAgentAcctNumber,
            CashDistribPayRef,
            CashDistribAgentAcctName,
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
            { 513, RegistID },
            { 514, RegistTransType },
            { 508, RegistRefID },
            { 11, ClOrdID },
            { 453, NoPartyIDs },
            { 448, PartyID },
            { 447, PartyIDSource },
            { 452, PartyRole },
            { 802, NoPartySubIDs },
            { 523, PartySubID },
            { 803, PartySubIDType },
            { 1, Account },
            { 660, AcctIDSource },
            { 493, RegistAcctType },
            { 495, TaxAdvantageType },
            { 517, OwnershipType },
            { 473, NoRegistDtls },
            { 509, RegistDtls },
            { 511, RegistEmail },
            { 474, MailingDtls },
            { 482, MailingInst },
            { 539, NoNestedPartyIDs },
            { 524, NestedPartyID },
            { 525, NestedPartyIDSource },
            { 538, NestedPartyRole },
            { 804, NoNestedPartySubIDs },
            { 545, NestedPartySubID },
            { 805, NestedPartySubIDType },
            { 522, OwnerType },
            { 486, DateOfBirth },
            { 475, InvestorCountryOfResidence },
            { 510, NoDistribInsts },
            { 477, DistribPaymentMethod },
            { 512, DistribPercentage },
            { 478, CashDistribCurr },
            { 498, CashDistribAgentName },
            { 499, CashDistribAgentCode },
            { 500, CashDistribAgentAcctNumber },
            { 501, CashDistribPayRef },
            { 502, CashDistribAgentAcctName },
            { 93, SignatureLength },
            { 89, Signature },
            { 10, CheckSum },
        };
        public static FieldSpec GetFieldSpec(int tag) => tagToFieldSpec[tag];
    }
}

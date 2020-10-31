using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class AllocationReportAck
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
        public static readonly FieldSpec AllocReportID = new FieldSpec(FieldType.HashedSlice16, "AllocReportID");
        public static readonly FieldSpec AllocID = new FieldSpec(FieldType.HashedSlice16, "AllocID");
        public static readonly FieldSpec ClearingBusinessDate = new FieldSpec(FieldType.HashedSlice16, "ClearingBusinessDate");
        public static readonly FieldSpec AvgPxIndicator = new FieldSpec(FieldType.Int, "AvgPxIndicator");
        public static readonly FieldSpec Quantity = new FieldSpec(FieldType.Float, "Quantity");
        public static readonly FieldSpec AllocTransType = new FieldSpec(FieldType.Char, "AllocTransType");
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
        public static readonly FieldSpec SecondaryAllocID = new FieldSpec(FieldType.HashedSlice16, "SecondaryAllocID");
        public static readonly FieldSpec TradeDate = new FieldSpec(FieldType.HashedSlice16, "TradeDate");
        public static readonly FieldSpec TransactTime = new FieldSpec(FieldType.HashedSlice16, "TransactTime");
        public static readonly FieldSpec AllocStatus = new FieldSpec(FieldType.Int, "AllocStatus");
        public static readonly FieldSpec AllocRejCode = new FieldSpec(FieldType.Int, "AllocRejCode");
        public static readonly FieldSpec AllocReportType = new FieldSpec(FieldType.Int, "AllocReportType");
        public static readonly FieldSpec AllocIntermedReqType = new FieldSpec(FieldType.Int, "AllocIntermedReqType");
        public static readonly FieldSpec MatchStatus = new FieldSpec(FieldType.Char, "MatchStatus");
        public static readonly FieldSpec Text = new FieldSpec(FieldType.HashedSlice16, "Text");
        public static readonly FieldSpec EncodedTextLen = new FieldSpec(FieldType.Int, "EncodedTextLen");
        public static readonly FieldSpec EncodedText = new FieldSpec(FieldType.HashedSlice16, "EncodedText");
        // Begin AllocAckGrp
        public static readonly FieldSpec NoAllocs = new FieldSpec(FieldType.Int, "NoAllocs");
        public static readonly FieldSpec AllocAccount = new FieldSpec(FieldType.HashedSlice16, "AllocAccount");
        public static readonly FieldSpec AllocAcctIDSource = new FieldSpec(FieldType.Int, "AllocAcctIDSource");
        public static readonly FieldSpec AllocPrice = new FieldSpec(FieldType.Float, "AllocPrice");
        public static readonly FieldSpec AllocPositionEffect = new FieldSpec(FieldType.Char, "AllocPositionEffect");
        public static readonly FieldSpec IndividualAllocID = new FieldSpec(FieldType.HashedSlice16, "IndividualAllocID");
        public static readonly FieldSpec IndividualAllocRejCode = new FieldSpec(FieldType.Int, "IndividualAllocRejCode");
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
        public static readonly FieldSpec AllocText = new FieldSpec(FieldType.HashedSlice16, "AllocText");
        public static readonly FieldSpec EncodedAllocTextLen = new FieldSpec(FieldType.Int, "EncodedAllocTextLen");
        public static readonly FieldSpec EncodedAllocText = new FieldSpec(FieldType.HashedSlice16, "EncodedAllocText");
        public static readonly FieldSpec SecondaryIndividualAllocID = new FieldSpec(FieldType.HashedSlice16, "SecondaryIndividualAllocID");
        public static readonly FieldSpec AllocCustomerCapacity = new FieldSpec(FieldType.HashedSlice16, "AllocCustomerCapacity");
        public static readonly FieldSpec IndividualAllocType = new FieldSpec(FieldType.Int, "IndividualAllocType");
        public static readonly FieldSpec AllocQty = new FieldSpec(FieldType.Float, "AllocQty");
        // End AllocAckGrp
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
            AllocReportID,
            AllocID,
            ClearingBusinessDate,
            AvgPxIndicator,
            Quantity,
            AllocTransType,
            NoPartyIDs,
            PartyID,
            PartyIDSource,
            PartyRole,
            NoPartySubIDs,
            PartySubID,
            PartySubIDType,
            SecondaryAllocID,
            TradeDate,
            TransactTime,
            AllocStatus,
            AllocRejCode,
            AllocReportType,
            AllocIntermedReqType,
            MatchStatus,
            Text,
            EncodedTextLen,
            EncodedText,
            NoAllocs,
            AllocAccount,
            AllocAcctIDSource,
            AllocPrice,
            AllocPositionEffect,
            IndividualAllocID,
            IndividualAllocRejCode,
            NoNestedPartyIDs,
            NestedPartyID,
            NestedPartyIDSource,
            NestedPartyRole,
            NoNestedPartySubIDs,
            NestedPartySubID,
            NestedPartySubIDType,
            AllocText,
            EncodedAllocTextLen,
            EncodedAllocText,
            SecondaryIndividualAllocID,
            AllocCustomerCapacity,
            IndividualAllocType,
            AllocQty,
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
            { 755, AllocReportID },
            { 70, AllocID },
            { 715, ClearingBusinessDate },
            { 819, AvgPxIndicator },
            { 53, Quantity },
            { 71, AllocTransType },
            { 453, NoPartyIDs },
            { 448, PartyID },
            { 447, PartyIDSource },
            { 452, PartyRole },
            { 802, NoPartySubIDs },
            { 523, PartySubID },
            { 803, PartySubIDType },
            { 793, SecondaryAllocID },
            { 75, TradeDate },
            { 60, TransactTime },
            { 87, AllocStatus },
            { 88, AllocRejCode },
            { 794, AllocReportType },
            { 808, AllocIntermedReqType },
            { 573, MatchStatus },
            { 58, Text },
            { 354, EncodedTextLen },
            { 355, EncodedText },
            { 78, NoAllocs },
            { 79, AllocAccount },
            { 661, AllocAcctIDSource },
            { 366, AllocPrice },
            { 1047, AllocPositionEffect },
            { 467, IndividualAllocID },
            { 776, IndividualAllocRejCode },
            { 539, NoNestedPartyIDs },
            { 524, NestedPartyID },
            { 525, NestedPartyIDSource },
            { 538, NestedPartyRole },
            { 804, NoNestedPartySubIDs },
            { 545, NestedPartySubID },
            { 805, NestedPartySubIDType },
            { 161, AllocText },
            { 360, EncodedAllocTextLen },
            { 361, EncodedAllocText },
            { 989, SecondaryIndividualAllocID },
            { 993, AllocCustomerCapacity },
            { 992, IndividualAllocType },
            { 80, AllocQty },
            { 93, SignatureLength },
            { 89, Signature },
            { 10, CheckSum },
        };
        public static FieldSpec GetFieldSpec(int tag) => tagToFieldSpec[tag];
    }
}

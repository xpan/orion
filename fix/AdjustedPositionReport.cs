using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class AdjustedPositionReport
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
        public static readonly FieldSpec PosMaintRptID = new FieldSpec(FieldType.HashedSlice16, "PosMaintRptID");
        public static readonly FieldSpec PosReqType = new FieldSpec(FieldType.Int, "PosReqType");
        public static readonly FieldSpec ClearingBusinessDate = new FieldSpec(FieldType.HashedSlice16, "ClearingBusinessDate");
        public static readonly FieldSpec SettlSessID = new FieldSpec(FieldType.HashedSlice16, "SettlSessID");
        public static readonly FieldSpec PosMaintRptRefID = new FieldSpec(FieldType.HashedSlice16, "PosMaintRptRefID");
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
        // Begin PositionQty
        public static readonly FieldSpec NoPositions = new FieldSpec(FieldType.Int, "NoPositions");
        public static readonly FieldSpec PosType = new FieldSpec(FieldType.HashedSlice16, "PosType");
        public static readonly FieldSpec LongQty = new FieldSpec(FieldType.Float, "LongQty");
        public static readonly FieldSpec ShortQty = new FieldSpec(FieldType.Float, "ShortQty");
        public static readonly FieldSpec PosQtyStatus = new FieldSpec(FieldType.Int, "PosQtyStatus");
        public static readonly FieldSpec QuantityDate = new FieldSpec(FieldType.HashedSlice16, "QuantityDate");
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
        // End PositionQty
        public static readonly FieldSpec SettlPrice = new FieldSpec(FieldType.Float, "SettlPrice");
        public static readonly FieldSpec PriorSettlPrice = new FieldSpec(FieldType.Float, "PriorSettlPrice");
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
            PosMaintRptID,
            PosReqType,
            ClearingBusinessDate,
            SettlSessID,
            PosMaintRptRefID,
            NoPartyIDs,
            PartyID,
            PartyIDSource,
            PartyRole,
            NoPartySubIDs,
            PartySubID,
            PartySubIDType,
            NoPositions,
            PosType,
            LongQty,
            ShortQty,
            PosQtyStatus,
            QuantityDate,
            NoNestedPartyIDs,
            NestedPartyID,
            NestedPartyIDSource,
            NestedPartyRole,
            NoNestedPartySubIDs,
            NestedPartySubID,
            NestedPartySubIDType,
            SettlPrice,
            PriorSettlPrice,
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
            { 721, PosMaintRptID },
            { 724, PosReqType },
            { 715, ClearingBusinessDate },
            { 716, SettlSessID },
            { 714, PosMaintRptRefID },
            { 453, NoPartyIDs },
            { 448, PartyID },
            { 447, PartyIDSource },
            { 452, PartyRole },
            { 802, NoPartySubIDs },
            { 523, PartySubID },
            { 803, PartySubIDType },
            { 702, NoPositions },
            { 703, PosType },
            { 704, LongQty },
            { 705, ShortQty },
            { 706, PosQtyStatus },
            { 976, QuantityDate },
            { 539, NoNestedPartyIDs },
            { 524, NestedPartyID },
            { 525, NestedPartyIDSource },
            { 538, NestedPartyRole },
            { 804, NoNestedPartySubIDs },
            { 545, NestedPartySubID },
            { 805, NestedPartySubIDType },
            { 730, SettlPrice },
            { 734, PriorSettlPrice },
            { 93, SignatureLength },
            { 89, Signature },
            { 10, CheckSum },
        };
        public static FieldSpec GetFieldSpec(int tag) => tagToFieldSpec[tag];
    }
}

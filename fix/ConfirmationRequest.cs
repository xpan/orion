using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class ConfirmationRequest
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
        public static readonly FieldSpec ConfirmReqID = new FieldSpec(FieldType.HashedSlice16, "ConfirmReqID");
        public static readonly FieldSpec ConfirmType = new FieldSpec(FieldType.Int, "ConfirmType");
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
        public static readonly FieldSpec AllocAccount = new FieldSpec(FieldType.HashedSlice16, "AllocAccount");
        public static readonly FieldSpec AllocAcctIDSource = new FieldSpec(FieldType.Int, "AllocAcctIDSource");
        public static readonly FieldSpec AllocAccountType = new FieldSpec(FieldType.Int, "AllocAccountType");
        public static readonly FieldSpec Text = new FieldSpec(FieldType.HashedSlice16, "Text");
        public static readonly FieldSpec EncodedTextLen = new FieldSpec(FieldType.Int, "EncodedTextLen");
        public static readonly FieldSpec EncodedText = new FieldSpec(FieldType.HashedSlice16, "EncodedText");
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
            ConfirmReqID,
            ConfirmType,
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
            AllocAccount,
            AllocAcctIDSource,
            AllocAccountType,
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
            { 859, ConfirmReqID },
            { 773, ConfirmType },
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
            { 79, AllocAccount },
            { 661, AllocAcctIDSource },
            { 798, AllocAccountType },
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

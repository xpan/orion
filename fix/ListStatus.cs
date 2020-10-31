using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class ListStatus
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
        public static readonly FieldSpec ListStatusType = new FieldSpec(FieldType.Int, "ListStatusType");
        public static readonly FieldSpec NoRpts = new FieldSpec(FieldType.Int, "NoRpts");
        public static readonly FieldSpec ListOrderStatus = new FieldSpec(FieldType.Int, "ListOrderStatus");
        public static readonly FieldSpec RptSeq = new FieldSpec(FieldType.Int, "RptSeq");
        public static readonly FieldSpec ListStatusText = new FieldSpec(FieldType.HashedSlice16, "ListStatusText");
        public static readonly FieldSpec EncodedListStatusTextLen = new FieldSpec(FieldType.Int, "EncodedListStatusTextLen");
        public static readonly FieldSpec EncodedListStatusText = new FieldSpec(FieldType.HashedSlice16, "EncodedListStatusText");
        public static readonly FieldSpec TransactTime = new FieldSpec(FieldType.HashedSlice16, "TransactTime");
        public static readonly FieldSpec TotNoOrders = new FieldSpec(FieldType.Int, "TotNoOrders");
        public static readonly FieldSpec LastFragment = new FieldSpec(FieldType.Char, "LastFragment");
        // Begin OrdListStatGrp
        public static readonly FieldSpec NoOrders = new FieldSpec(FieldType.Int, "NoOrders");
        public static readonly FieldSpec ClOrdID = new FieldSpec(FieldType.HashedSlice16, "ClOrdID");
        public static readonly FieldSpec SecondaryClOrdID = new FieldSpec(FieldType.HashedSlice16, "SecondaryClOrdID");
        public static readonly FieldSpec CumQty = new FieldSpec(FieldType.Float, "CumQty");
        public static readonly FieldSpec OrdStatus = new FieldSpec(FieldType.Char, "OrdStatus");
        public static readonly FieldSpec WorkingIndicator = new FieldSpec(FieldType.Char, "WorkingIndicator");
        public static readonly FieldSpec LeavesQty = new FieldSpec(FieldType.Float, "LeavesQty");
        public static readonly FieldSpec CxlQty = new FieldSpec(FieldType.Float, "CxlQty");
        public static readonly FieldSpec AvgPx = new FieldSpec(FieldType.Float, "AvgPx");
        public static readonly FieldSpec OrdRejReason = new FieldSpec(FieldType.Int, "OrdRejReason");
        public static readonly FieldSpec Text = new FieldSpec(FieldType.HashedSlice16, "Text");
        public static readonly FieldSpec EncodedTextLen = new FieldSpec(FieldType.Int, "EncodedTextLen");
        public static readonly FieldSpec EncodedText = new FieldSpec(FieldType.HashedSlice16, "EncodedText");
        // End OrdListStatGrp
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
            ListStatusType,
            NoRpts,
            ListOrderStatus,
            RptSeq,
            ListStatusText,
            EncodedListStatusTextLen,
            EncodedListStatusText,
            TransactTime,
            TotNoOrders,
            LastFragment,
            NoOrders,
            ClOrdID,
            SecondaryClOrdID,
            CumQty,
            OrdStatus,
            WorkingIndicator,
            LeavesQty,
            CxlQty,
            AvgPx,
            OrdRejReason,
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
            { 66, ListID },
            { 429, ListStatusType },
            { 82, NoRpts },
            { 431, ListOrderStatus },
            { 83, RptSeq },
            { 444, ListStatusText },
            { 445, EncodedListStatusTextLen },
            { 446, EncodedListStatusText },
            { 60, TransactTime },
            { 68, TotNoOrders },
            { 893, LastFragment },
            { 73, NoOrders },
            { 11, ClOrdID },
            { 526, SecondaryClOrdID },
            { 14, CumQty },
            { 39, OrdStatus },
            { 636, WorkingIndicator },
            { 151, LeavesQty },
            { 84, CxlQty },
            { 6, AvgPx },
            { 103, OrdRejReason },
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

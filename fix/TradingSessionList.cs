using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class TradingSessionList
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
        public static readonly FieldSpec TradSesReqID = new FieldSpec(FieldType.HashedSlice16, "TradSesReqID");
        // Begin TrdSessLstGrp
        public static readonly FieldSpec NoTradingSessions = new FieldSpec(FieldType.Int, "NoTradingSessions");
        public static readonly FieldSpec TradingSessionID = new FieldSpec(FieldType.HashedSlice16, "TradingSessionID");
        public static readonly FieldSpec TradingSessionSubID = new FieldSpec(FieldType.HashedSlice16, "TradingSessionSubID");
        public static readonly FieldSpec SecurityExchange = new FieldSpec(FieldType.HashedSlice16, "SecurityExchange");
        public static readonly FieldSpec TradSesMethod = new FieldSpec(FieldType.Int, "TradSesMethod");
        public static readonly FieldSpec TradSesMode = new FieldSpec(FieldType.Int, "TradSesMode");
        public static readonly FieldSpec UnsolicitedIndicator = new FieldSpec(FieldType.Char, "UnsolicitedIndicator");
        public static readonly FieldSpec TradSesStatus = new FieldSpec(FieldType.Int, "TradSesStatus");
        public static readonly FieldSpec TradSesStatusRejReason = new FieldSpec(FieldType.Int, "TradSesStatusRejReason");
        public static readonly FieldSpec TradSesStartTime = new FieldSpec(FieldType.HashedSlice16, "TradSesStartTime");
        public static readonly FieldSpec TradSesOpenTime = new FieldSpec(FieldType.HashedSlice16, "TradSesOpenTime");
        public static readonly FieldSpec TradSesPreCloseTime = new FieldSpec(FieldType.HashedSlice16, "TradSesPreCloseTime");
        public static readonly FieldSpec TradSesCloseTime = new FieldSpec(FieldType.HashedSlice16, "TradSesCloseTime");
        public static readonly FieldSpec TradSesEndTime = new FieldSpec(FieldType.HashedSlice16, "TradSesEndTime");
        public static readonly FieldSpec TotalVolumeTraded = new FieldSpec(FieldType.Float, "TotalVolumeTraded");
        public static readonly FieldSpec Text = new FieldSpec(FieldType.HashedSlice16, "Text");
        public static readonly FieldSpec EncodedTextLen = new FieldSpec(FieldType.Int, "EncodedTextLen");
        public static readonly FieldSpec EncodedText = new FieldSpec(FieldType.HashedSlice16, "EncodedText");
        // End TrdSessLstGrp
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
            TradSesReqID,
            NoTradingSessions,
            TradingSessionID,
            TradingSessionSubID,
            SecurityExchange,
            TradSesMethod,
            TradSesMode,
            UnsolicitedIndicator,
            TradSesStatus,
            TradSesStatusRejReason,
            TradSesStartTime,
            TradSesOpenTime,
            TradSesPreCloseTime,
            TradSesCloseTime,
            TradSesEndTime,
            TotalVolumeTraded,
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
            { 335, TradSesReqID },
            { 386, NoTradingSessions },
            { 336, TradingSessionID },
            { 625, TradingSessionSubID },
            { 207, SecurityExchange },
            { 338, TradSesMethod },
            { 339, TradSesMode },
            { 325, UnsolicitedIndicator },
            { 340, TradSesStatus },
            { 567, TradSesStatusRejReason },
            { 341, TradSesStartTime },
            { 342, TradSesOpenTime },
            { 343, TradSesPreCloseTime },
            { 344, TradSesCloseTime },
            { 345, TradSesEndTime },
            { 387, TotalVolumeTraded },
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

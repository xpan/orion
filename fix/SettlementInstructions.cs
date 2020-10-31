using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class SettlementInstructions
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
        public static readonly FieldSpec SettlInstMsgID = new FieldSpec(FieldType.HashedSlice16, "SettlInstMsgID");
        public static readonly FieldSpec SettlInstReqID = new FieldSpec(FieldType.HashedSlice16, "SettlInstReqID");
        public static readonly FieldSpec SettlInstMode = new FieldSpec(FieldType.Char, "SettlInstMode");
        public static readonly FieldSpec SettlInstReqRejCode = new FieldSpec(FieldType.Int, "SettlInstReqRejCode");
        public static readonly FieldSpec Text = new FieldSpec(FieldType.HashedSlice16, "Text");
        public static readonly FieldSpec EncodedTextLen = new FieldSpec(FieldType.Int, "EncodedTextLen");
        public static readonly FieldSpec EncodedText = new FieldSpec(FieldType.HashedSlice16, "EncodedText");
        public static readonly FieldSpec ClOrdID = new FieldSpec(FieldType.HashedSlice16, "ClOrdID");
        public static readonly FieldSpec TransactTime = new FieldSpec(FieldType.HashedSlice16, "TransactTime");
        // Begin SettlInstGrp
        public static readonly FieldSpec NoSettlInst = new FieldSpec(FieldType.Int, "NoSettlInst");
        public static readonly FieldSpec SettlInstID = new FieldSpec(FieldType.HashedSlice16, "SettlInstID");
        public static readonly FieldSpec SettlInstTransType = new FieldSpec(FieldType.Char, "SettlInstTransType");
        public static readonly FieldSpec SettlInstRefID = new FieldSpec(FieldType.HashedSlice16, "SettlInstRefID");
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
        public static readonly FieldSpec Side = new FieldSpec(FieldType.Char, "Side");
        public static readonly FieldSpec Product = new FieldSpec(FieldType.Int, "Product");
        public static readonly FieldSpec SecurityType = new FieldSpec(FieldType.HashedSlice16, "SecurityType");
        public static readonly FieldSpec CFICode = new FieldSpec(FieldType.HashedSlice16, "CFICode");
        public static readonly FieldSpec SettlCurrency = new FieldSpec(FieldType.HashedSlice16, "SettlCurrency");
        public static readonly FieldSpec EffectiveTime = new FieldSpec(FieldType.HashedSlice16, "EffectiveTime");
        public static readonly FieldSpec ExpireTime = new FieldSpec(FieldType.HashedSlice16, "ExpireTime");
        public static readonly FieldSpec LastUpdateTime = new FieldSpec(FieldType.HashedSlice16, "LastUpdateTime");
        // Begin SettlInstructionsData
        public static readonly FieldSpec SettlDeliveryType = new FieldSpec(FieldType.Int, "SettlDeliveryType");
        public static readonly FieldSpec StandInstDbType = new FieldSpec(FieldType.Int, "StandInstDbType");
        public static readonly FieldSpec StandInstDbName = new FieldSpec(FieldType.HashedSlice16, "StandInstDbName");
        public static readonly FieldSpec StandInstDbID = new FieldSpec(FieldType.HashedSlice16, "StandInstDbID");
        // Begin DlvyInstGrp
        public static readonly FieldSpec NoDlvyInst = new FieldSpec(FieldType.Int, "NoDlvyInst");
        public static readonly FieldSpec SettlInstSource = new FieldSpec(FieldType.Char, "SettlInstSource");
        public static readonly FieldSpec DlvyInstType = new FieldSpec(FieldType.Char, "DlvyInstType");
        // Begin SettlParties
        public static readonly FieldSpec NoSettlPartyIDs = new FieldSpec(FieldType.Int, "NoSettlPartyIDs");
        public static readonly FieldSpec SettlPartyID = new FieldSpec(FieldType.HashedSlice16, "SettlPartyID");
        public static readonly FieldSpec SettlPartyIDSource = new FieldSpec(FieldType.Char, "SettlPartyIDSource");
        public static readonly FieldSpec SettlPartyRole = new FieldSpec(FieldType.Int, "SettlPartyRole");
        // Begin SettlPtysSubGrp
        public static readonly FieldSpec NoSettlPartySubIDs = new FieldSpec(FieldType.Int, "NoSettlPartySubIDs");
        public static readonly FieldSpec SettlPartySubID = new FieldSpec(FieldType.HashedSlice16, "SettlPartySubID");
        public static readonly FieldSpec SettlPartySubIDType = new FieldSpec(FieldType.Int, "SettlPartySubIDType");
        // End SettlPtysSubGrp
        // End SettlParties
        // End DlvyInstGrp
        // End SettlInstructionsData
        public static readonly FieldSpec PaymentMethod = new FieldSpec(FieldType.Int, "PaymentMethod");
        public static readonly FieldSpec PaymentRef = new FieldSpec(FieldType.HashedSlice16, "PaymentRef");
        public static readonly FieldSpec CardHolderName = new FieldSpec(FieldType.HashedSlice16, "CardHolderName");
        public static readonly FieldSpec CardNumber = new FieldSpec(FieldType.HashedSlice16, "CardNumber");
        public static readonly FieldSpec CardStartDate = new FieldSpec(FieldType.HashedSlice16, "CardStartDate");
        public static readonly FieldSpec CardExpDate = new FieldSpec(FieldType.HashedSlice16, "CardExpDate");
        public static readonly FieldSpec CardIssNum = new FieldSpec(FieldType.HashedSlice16, "CardIssNum");
        public static readonly FieldSpec PaymentDate = new FieldSpec(FieldType.HashedSlice16, "PaymentDate");
        public static readonly FieldSpec PaymentRemitterID = new FieldSpec(FieldType.HashedSlice16, "PaymentRemitterID");
        // End SettlInstGrp
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
            SettlInstMsgID,
            SettlInstReqID,
            SettlInstMode,
            SettlInstReqRejCode,
            Text,
            EncodedTextLen,
            EncodedText,
            ClOrdID,
            TransactTime,
            NoSettlInst,
            SettlInstID,
            SettlInstTransType,
            SettlInstRefID,
            NoPartyIDs,
            PartyID,
            PartyIDSource,
            PartyRole,
            NoPartySubIDs,
            PartySubID,
            PartySubIDType,
            Side,
            Product,
            SecurityType,
            CFICode,
            SettlCurrency,
            EffectiveTime,
            ExpireTime,
            LastUpdateTime,
            SettlDeliveryType,
            StandInstDbType,
            StandInstDbName,
            StandInstDbID,
            NoDlvyInst,
            SettlInstSource,
            DlvyInstType,
            NoSettlPartyIDs,
            SettlPartyID,
            SettlPartyIDSource,
            SettlPartyRole,
            NoSettlPartySubIDs,
            SettlPartySubID,
            SettlPartySubIDType,
            PaymentMethod,
            PaymentRef,
            CardHolderName,
            CardNumber,
            CardStartDate,
            CardExpDate,
            CardIssNum,
            PaymentDate,
            PaymentRemitterID,
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
            { 777, SettlInstMsgID },
            { 791, SettlInstReqID },
            { 160, SettlInstMode },
            { 792, SettlInstReqRejCode },
            { 58, Text },
            { 354, EncodedTextLen },
            { 355, EncodedText },
            { 11, ClOrdID },
            { 60, TransactTime },
            { 778, NoSettlInst },
            { 162, SettlInstID },
            { 163, SettlInstTransType },
            { 214, SettlInstRefID },
            { 453, NoPartyIDs },
            { 448, PartyID },
            { 447, PartyIDSource },
            { 452, PartyRole },
            { 802, NoPartySubIDs },
            { 523, PartySubID },
            { 803, PartySubIDType },
            { 54, Side },
            { 460, Product },
            { 167, SecurityType },
            { 461, CFICode },
            { 120, SettlCurrency },
            { 168, EffectiveTime },
            { 126, ExpireTime },
            { 779, LastUpdateTime },
            { 172, SettlDeliveryType },
            { 169, StandInstDbType },
            { 170, StandInstDbName },
            { 171, StandInstDbID },
            { 85, NoDlvyInst },
            { 165, SettlInstSource },
            { 787, DlvyInstType },
            { 781, NoSettlPartyIDs },
            { 782, SettlPartyID },
            { 783, SettlPartyIDSource },
            { 784, SettlPartyRole },
            { 801, NoSettlPartySubIDs },
            { 785, SettlPartySubID },
            { 786, SettlPartySubIDType },
            { 492, PaymentMethod },
            { 476, PaymentRef },
            { 488, CardHolderName },
            { 489, CardNumber },
            { 503, CardStartDate },
            { 490, CardExpDate },
            { 491, CardIssNum },
            { 504, PaymentDate },
            { 505, PaymentRemitterID },
            { 93, SignatureLength },
            { 89, Signature },
            { 10, CheckSum },
        };
        public static FieldSpec GetFieldSpec(int tag) => tagToFieldSpec[tag];
    }
}

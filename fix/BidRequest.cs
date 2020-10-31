using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class BidRequest
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
        public static readonly FieldSpec BidID = new FieldSpec(FieldType.HashedSlice16, "BidID");
        public static readonly FieldSpec ClientBidID = new FieldSpec(FieldType.HashedSlice16, "ClientBidID");
        public static readonly FieldSpec BidRequestTransType = new FieldSpec(FieldType.Char, "BidRequestTransType");
        public static readonly FieldSpec ListName = new FieldSpec(FieldType.HashedSlice16, "ListName");
        public static readonly FieldSpec TotNoRelatedSym = new FieldSpec(FieldType.Int, "TotNoRelatedSym");
        public static readonly FieldSpec BidType = new FieldSpec(FieldType.Int, "BidType");
        public static readonly FieldSpec NumTickets = new FieldSpec(FieldType.Int, "NumTickets");
        public static readonly FieldSpec Currency = new FieldSpec(FieldType.HashedSlice16, "Currency");
        public static readonly FieldSpec SideValue1 = new FieldSpec(FieldType.Float, "SideValue1");
        public static readonly FieldSpec SideValue2 = new FieldSpec(FieldType.Float, "SideValue2");
        // Begin BidDescReqGrp
        public static readonly FieldSpec NoBidDescriptors = new FieldSpec(FieldType.Int, "NoBidDescriptors");
        public static readonly FieldSpec BidDescriptorType = new FieldSpec(FieldType.Int, "BidDescriptorType");
        public static readonly FieldSpec BidDescriptor = new FieldSpec(FieldType.HashedSlice16, "BidDescriptor");
        public static readonly FieldSpec SideValueInd = new FieldSpec(FieldType.Int, "SideValueInd");
        public static readonly FieldSpec LiquidityValue = new FieldSpec(FieldType.Float, "LiquidityValue");
        public static readonly FieldSpec LiquidityNumSecurities = new FieldSpec(FieldType.Int, "LiquidityNumSecurities");
        public static readonly FieldSpec LiquidityPctLow = new FieldSpec(FieldType.Float, "LiquidityPctLow");
        public static readonly FieldSpec LiquidityPctHigh = new FieldSpec(FieldType.Float, "LiquidityPctHigh");
        public static readonly FieldSpec EFPTrackingError = new FieldSpec(FieldType.Float, "EFPTrackingError");
        public static readonly FieldSpec FairValue = new FieldSpec(FieldType.Float, "FairValue");
        public static readonly FieldSpec OutsideIndexPct = new FieldSpec(FieldType.Float, "OutsideIndexPct");
        public static readonly FieldSpec ValueOfFutures = new FieldSpec(FieldType.Float, "ValueOfFutures");
        // End BidDescReqGrp
        // Begin BidCompReqGrp
        public static readonly FieldSpec NoBidComponents = new FieldSpec(FieldType.Int, "NoBidComponents");
        public static readonly FieldSpec ListID = new FieldSpec(FieldType.HashedSlice16, "ListID");
        public static readonly FieldSpec Side = new FieldSpec(FieldType.Char, "Side");
        public static readonly FieldSpec TradingSessionID = new FieldSpec(FieldType.HashedSlice16, "TradingSessionID");
        public static readonly FieldSpec TradingSessionSubID = new FieldSpec(FieldType.HashedSlice16, "TradingSessionSubID");
        public static readonly FieldSpec NetGrossInd = new FieldSpec(FieldType.Int, "NetGrossInd");
        public static readonly FieldSpec SettlType = new FieldSpec(FieldType.HashedSlice16, "SettlType");
        public static readonly FieldSpec SettlDate = new FieldSpec(FieldType.HashedSlice16, "SettlDate");
        public static readonly FieldSpec Account = new FieldSpec(FieldType.HashedSlice16, "Account");
        public static readonly FieldSpec AcctIDSource = new FieldSpec(FieldType.Int, "AcctIDSource");
        // End BidCompReqGrp
        public static readonly FieldSpec LiquidityIndType = new FieldSpec(FieldType.Int, "LiquidityIndType");
        public static readonly FieldSpec WtAverageLiquidity = new FieldSpec(FieldType.Float, "WtAverageLiquidity");
        public static readonly FieldSpec ExchangeForPhysical = new FieldSpec(FieldType.Char, "ExchangeForPhysical");
        public static readonly FieldSpec OutMainCntryUIndex = new FieldSpec(FieldType.Float, "OutMainCntryUIndex");
        public static readonly FieldSpec CrossPercent = new FieldSpec(FieldType.Float, "CrossPercent");
        public static readonly FieldSpec ProgRptReqs = new FieldSpec(FieldType.Int, "ProgRptReqs");
        public static readonly FieldSpec ProgPeriodInterval = new FieldSpec(FieldType.Int, "ProgPeriodInterval");
        public static readonly FieldSpec IncTaxInd = new FieldSpec(FieldType.Int, "IncTaxInd");
        public static readonly FieldSpec ForexReq = new FieldSpec(FieldType.Char, "ForexReq");
        public static readonly FieldSpec NumBidders = new FieldSpec(FieldType.Int, "NumBidders");
        public static readonly FieldSpec TradeDate = new FieldSpec(FieldType.HashedSlice16, "TradeDate");
        public static readonly FieldSpec BidTradeType = new FieldSpec(FieldType.Char, "BidTradeType");
        public static readonly FieldSpec BasisPxType = new FieldSpec(FieldType.Char, "BasisPxType");
        public static readonly FieldSpec StrikeTime = new FieldSpec(FieldType.HashedSlice16, "StrikeTime");
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
            BidID,
            ClientBidID,
            BidRequestTransType,
            ListName,
            TotNoRelatedSym,
            BidType,
            NumTickets,
            Currency,
            SideValue1,
            SideValue2,
            NoBidDescriptors,
            BidDescriptorType,
            BidDescriptor,
            SideValueInd,
            LiquidityValue,
            LiquidityNumSecurities,
            LiquidityPctLow,
            LiquidityPctHigh,
            EFPTrackingError,
            FairValue,
            OutsideIndexPct,
            ValueOfFutures,
            NoBidComponents,
            ListID,
            Side,
            TradingSessionID,
            TradingSessionSubID,
            NetGrossInd,
            SettlType,
            SettlDate,
            Account,
            AcctIDSource,
            LiquidityIndType,
            WtAverageLiquidity,
            ExchangeForPhysical,
            OutMainCntryUIndex,
            CrossPercent,
            ProgRptReqs,
            ProgPeriodInterval,
            IncTaxInd,
            ForexReq,
            NumBidders,
            TradeDate,
            BidTradeType,
            BasisPxType,
            StrikeTime,
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
            { 390, BidID },
            { 391, ClientBidID },
            { 374, BidRequestTransType },
            { 392, ListName },
            { 393, TotNoRelatedSym },
            { 394, BidType },
            { 395, NumTickets },
            { 15, Currency },
            { 396, SideValue1 },
            { 397, SideValue2 },
            { 398, NoBidDescriptors },
            { 399, BidDescriptorType },
            { 400, BidDescriptor },
            { 401, SideValueInd },
            { 404, LiquidityValue },
            { 441, LiquidityNumSecurities },
            { 402, LiquidityPctLow },
            { 403, LiquidityPctHigh },
            { 405, EFPTrackingError },
            { 406, FairValue },
            { 407, OutsideIndexPct },
            { 408, ValueOfFutures },
            { 420, NoBidComponents },
            { 66, ListID },
            { 54, Side },
            { 336, TradingSessionID },
            { 625, TradingSessionSubID },
            { 430, NetGrossInd },
            { 63, SettlType },
            { 64, SettlDate },
            { 1, Account },
            { 660, AcctIDSource },
            { 409, LiquidityIndType },
            { 410, WtAverageLiquidity },
            { 411, ExchangeForPhysical },
            { 412, OutMainCntryUIndex },
            { 413, CrossPercent },
            { 414, ProgRptReqs },
            { 415, ProgPeriodInterval },
            { 416, IncTaxInd },
            { 121, ForexReq },
            { 417, NumBidders },
            { 75, TradeDate },
            { 418, BidTradeType },
            { 419, BasisPxType },
            { 443, StrikeTime },
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

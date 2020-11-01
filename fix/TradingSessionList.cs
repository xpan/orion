using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class TradingSessionList
    {
        public static readonly FieldSpec[] Schema = new FieldSpec[]
        {
            FIXTags.BeginString,
            FIXTags.BodyLength,
            FIXTags.MsgType,
            FIXTags.ApplVerID,
            FIXTags.CstmApplVerID,
            FIXTags.SenderCompID,
            FIXTags.TargetCompID,
            FIXTags.OnBehalfOfCompID,
            FIXTags.DeliverToCompID,
            FIXTags.SecureDataLen,
            FIXTags.SecureData,
            FIXTags.MsgSeqNum,
            FIXTags.SenderSubID,
            FIXTags.SenderLocationID,
            FIXTags.TargetSubID,
            FIXTags.TargetLocationID,
            FIXTags.OnBehalfOfSubID,
            FIXTags.OnBehalfOfLocationID,
            FIXTags.DeliverToSubID,
            FIXTags.DeliverToLocationID,
            FIXTags.PossDupFlag,
            FIXTags.PossResend,
            FIXTags.SendingTime,
            FIXTags.OrigSendingTime,
            FIXTags.XmlDataLen,
            FIXTags.XmlData,
            FIXTags.MessageEncoding,
            FIXTags.LastMsgSeqNumProcessed,
            FIXTags.NoHops,
            FIXTags.HopCompID,
            FIXTags.HopSendingTime,
            FIXTags.HopRefID,
            FIXTags.TradSesReqID,
            FIXTags.NoTradingSessions,
            FIXTags.TradingSessionID,
            FIXTags.TradingSessionSubID,
            FIXTags.SecurityExchange,
            FIXTags.TradSesMethod,
            FIXTags.TradSesMode,
            FIXTags.UnsolicitedIndicator,
            FIXTags.TradSesStatus,
            FIXTags.TradSesStatusRejReason,
            FIXTags.TradSesStartTime,
            FIXTags.TradSesOpenTime,
            FIXTags.TradSesPreCloseTime,
            FIXTags.TradSesCloseTime,
            FIXTags.TradSesEndTime,
            FIXTags.TotalVolumeTraded,
            FIXTags.Text,
            FIXTags.EncodedTextLen,
            FIXTags.EncodedText,
            FIXTags.SignatureLength,
            FIXTags.Signature,
            FIXTags.CheckSum,
        };
    }
}

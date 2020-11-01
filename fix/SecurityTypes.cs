using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class SecurityTypes
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
            FIXTags.SecurityReqID,
            FIXTags.SecurityResponseID,
            FIXTags.SecurityResponseType,
            FIXTags.TotNoSecurityTypes,
            FIXTags.LastFragment,
            FIXTags.NoSecurityTypes,
            FIXTags.SecurityType,
            FIXTags.SecuritySubType,
            FIXTags.Product,
            FIXTags.CFICode,
            FIXTags.Text,
            FIXTags.EncodedTextLen,
            FIXTags.EncodedText,
            FIXTags.TradingSessionID,
            FIXTags.TradingSessionSubID,
            FIXTags.SubscriptionRequestType,
            FIXTags.SignatureLength,
            FIXTags.Signature,
            FIXTags.CheckSum,
        };
    }
}

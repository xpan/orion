using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class ListExecute
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
            FIXTags.ListID,
            FIXTags.ClientBidID,
            FIXTags.BidID,
            FIXTags.TransactTime,
            FIXTags.Text,
            FIXTags.EncodedTextLen,
            FIXTags.EncodedText,
            FIXTags.SignatureLength,
            FIXTags.Signature,
            FIXTags.CheckSum,
        };
    }
}

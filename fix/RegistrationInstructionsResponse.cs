using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class RegistrationInstructionsResponse
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
            FIXTags.RegistID,
            FIXTags.RegistTransType,
            FIXTags.RegistRefID,
            FIXTags.ClOrdID,
            FIXTags.NoPartyIDs,
            FIXTags.PartyID,
            FIXTags.PartyIDSource,
            FIXTags.PartyRole,
            FIXTags.NoPartySubIDs,
            FIXTags.PartySubID,
            FIXTags.PartySubIDType,
            FIXTags.Account,
            FIXTags.AcctIDSource,
            FIXTags.RegistStatus,
            FIXTags.RegistRejReasonCode,
            FIXTags.RegistRejReasonText,
            FIXTags.SignatureLength,
            FIXTags.Signature,
            FIXTags.CheckSum,
        };
    }
}

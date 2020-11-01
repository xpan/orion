using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class Logon
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
            FIXTags.EncryptMethod,
            FIXTags.HeartBtInt,
            FIXTags.RawDataLength,
            FIXTags.RawData,
            FIXTags.ResetSeqNumFlag,
            FIXTags.NextExpectedMsgSeqNum,
            FIXTags.MaxMessageSize,
            FIXTags.NoMsgTypes,
            FIXTags.RefMsgType,
            FIXTags.MsgDirection,
            FIXTags.RefApplVerID,
            FIXTags.RefCstmApplVerID,
            FIXTags.TestMessageIndicator,
            FIXTags.Username,
            FIXTags.Password,
            FIXTags.DefaultApplVerID,
            FIXTags.SignatureLength,
            FIXTags.Signature,
            FIXTags.CheckSum,
        };
    }
}

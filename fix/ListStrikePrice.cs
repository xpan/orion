using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class ListStrikePrice
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
            FIXTags.TotNoStrikes,
            FIXTags.LastFragment,
            FIXTags.NoStrikes,
            FIXTags.Symbol,
            FIXTags.SymbolSfx,
            FIXTags.SecurityID,
            FIXTags.SecurityIDSource,
            FIXTags.NoSecurityAltID,
            FIXTags.SecurityAltID,
            FIXTags.SecurityAltIDSource,
            FIXTags.Product,
            FIXTags.CFICode,
            FIXTags.SecurityType,
            FIXTags.SecuritySubType,
            FIXTags.MaturityMonthYear,
            FIXTags.MaturityDate,
            FIXTags.MaturityTime,
            FIXTags.SettleOnOpenFlag,
            FIXTags.InstrmtAssignmentMethod,
            FIXTags.SecurityStatus,
            FIXTags.CouponPaymentDate,
            FIXTags.IssueDate,
            FIXTags.RepoCollateralSecurityType,
            FIXTags.RepurchaseTerm,
            FIXTags.RepurchaseRate,
            FIXTags.Factor,
            FIXTags.CreditRating,
            FIXTags.InstrRegistry,
            FIXTags.CountryOfIssue,
            FIXTags.StateOrProvinceOfIssue,
            FIXTags.LocaleOfIssue,
            FIXTags.RedemptionDate,
            FIXTags.StrikePrice,
            FIXTags.StrikeCurrency,
            FIXTags.StrikeMultiplier,
            FIXTags.StrikeValue,
            FIXTags.OptAttribute,
            FIXTags.ContractMultiplier,
            FIXTags.MinPriceIncrement,
            FIXTags.UnitOfMeasure,
            FIXTags.PutOrCall,
            FIXTags.TimeUnit,
            FIXTags.CouponRate,
            FIXTags.SecurityExchange,
            FIXTags.PositionLimit,
            FIXTags.NTPositionLimit,
            FIXTags.Issuer,
            FIXTags.EncodedIssuerLen,
            FIXTags.EncodedIssuer,
            FIXTags.SecurityDesc,
            FIXTags.EncodedSecurityDescLen,
            FIXTags.EncodedSecurityDesc,
            FIXTags.Pool,
            FIXTags.ContractSettlMonth,
            FIXTags.CPProgram,
            FIXTags.CPRegType,
            FIXTags.NoEvents,
            FIXTags.EventType,
            FIXTags.EventDate,
            FIXTags.EventPx,
            FIXTags.EventText,
            FIXTags.DatedDate,
            FIXTags.InterestAccrualDate,
            FIXTags.NoInstrumentParties,
            FIXTags.InstrumentPartyID,
            FIXTags.InstrumentPartyIDSource,
            FIXTags.InstrumentPartyRole,
            FIXTags.NoInstrumentPartySubIDs,
            FIXTags.InstrumentPartySubID,
            FIXTags.InstrumentPartySubIDType,
            FIXTags.SignatureLength,
            FIXTags.Signature,
            FIXTags.CheckSum,
        };
    }
}

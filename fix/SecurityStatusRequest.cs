using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class SecurityStatusRequest
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
            FIXTags.SecurityStatusReqID,
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
            FIXTags.DeliveryForm,
            FIXTags.PctAtRisk,
            FIXTags.NoInstrAttrib,
            FIXTags.InstrAttribType,
            FIXTags.InstrAttribValue,
            FIXTags.NoUnderlyings,
            FIXTags.UnderlyingSymbol,
            FIXTags.UnderlyingSymbolSfx,
            FIXTags.UnderlyingSecurityID,
            FIXTags.UnderlyingSecurityIDSource,
            FIXTags.NoUnderlyingSecurityAltID,
            FIXTags.UnderlyingSecurityAltID,
            FIXTags.UnderlyingSecurityAltIDSource,
            FIXTags.UnderlyingProduct,
            FIXTags.UnderlyingCFICode,
            FIXTags.UnderlyingSecurityType,
            FIXTags.UnderlyingSecuritySubType,
            FIXTags.UnderlyingMaturityMonthYear,
            FIXTags.UnderlyingMaturityDate,
            FIXTags.UnderlyingCouponPaymentDate,
            FIXTags.UnderlyingIssueDate,
            FIXTags.UnderlyingRepoCollateralSecurityType,
            FIXTags.UnderlyingRepurchaseTerm,
            FIXTags.UnderlyingRepurchaseRate,
            FIXTags.UnderlyingFactor,
            FIXTags.UnderlyingCreditRating,
            FIXTags.UnderlyingInstrRegistry,
            FIXTags.UnderlyingCountryOfIssue,
            FIXTags.UnderlyingStateOrProvinceOfIssue,
            FIXTags.UnderlyingLocaleOfIssue,
            FIXTags.UnderlyingRedemptionDate,
            FIXTags.UnderlyingStrikePrice,
            FIXTags.UnderlyingStrikeCurrency,
            FIXTags.UnderlyingOptAttribute,
            FIXTags.UnderlyingContractMultiplier,
            FIXTags.UnderlyingUnitOfMeasure,
            FIXTags.UnderlyingTimeUnit,
            FIXTags.UnderlyingCouponRate,
            FIXTags.UnderlyingSecurityExchange,
            FIXTags.UnderlyingIssuer,
            FIXTags.EncodedUnderlyingIssuerLen,
            FIXTags.EncodedUnderlyingIssuer,
            FIXTags.UnderlyingSecurityDesc,
            FIXTags.EncodedUnderlyingSecurityDescLen,
            FIXTags.EncodedUnderlyingSecurityDesc,
            FIXTags.UnderlyingCPProgram,
            FIXTags.UnderlyingCPRegType,
            FIXTags.UnderlyingAllocationPercent,
            FIXTags.UnderlyingCurrency,
            FIXTags.UnderlyingQty,
            FIXTags.UnderlyingSettlementType,
            FIXTags.UnderlyingCashAmount,
            FIXTags.UnderlyingCashType,
            FIXTags.UnderlyingPx,
            FIXTags.UnderlyingDirtyPrice,
            FIXTags.UnderlyingEndPrice,
            FIXTags.UnderlyingStartValue,
            FIXTags.UnderlyingCurrentValue,
            FIXTags.UnderlyingEndValue,
            FIXTags.NoUnderlyingStips,
            FIXTags.UnderlyingStipType,
            FIXTags.UnderlyingStipValue,
            FIXTags.UnderlyingAdjustedQuantity,
            FIXTags.UnderlyingFXRate,
            FIXTags.UnderlyingFXRateCalc,
            FIXTags.UnderlyingCapValue,
            FIXTags.NoUndlyInstrumentParties,
            FIXTags.UnderlyingInstrumentPartyID,
            FIXTags.UnderlyingInstrumentPartyIDSource,
            FIXTags.UnderlyingInstrumentPartyRole,
            FIXTags.NoUndlyInstrumentPartySubIDs,
            FIXTags.UnderlyingInstrumentPartySubID,
            FIXTags.UnderlyingInstrumentPartySubIDType,
            FIXTags.UnderlyingSettlMethod,
            FIXTags.UnderlyingPutOrCall,
            FIXTags.NoLegs,
            FIXTags.LegSymbol,
            FIXTags.LegSymbolSfx,
            FIXTags.LegSecurityID,
            FIXTags.LegSecurityIDSource,
            FIXTags.NoLegSecurityAltID,
            FIXTags.LegSecurityAltID,
            FIXTags.LegSecurityAltIDSource,
            FIXTags.LegProduct,
            FIXTags.LegCFICode,
            FIXTags.LegSecurityType,
            FIXTags.LegSecuritySubType,
            FIXTags.LegMaturityMonthYear,
            FIXTags.LegMaturityDate,
            FIXTags.LegCouponPaymentDate,
            FIXTags.LegIssueDate,
            FIXTags.LegRepoCollateralSecurityType,
            FIXTags.LegRepurchaseTerm,
            FIXTags.LegRepurchaseRate,
            FIXTags.LegFactor,
            FIXTags.LegCreditRating,
            FIXTags.LegInstrRegistry,
            FIXTags.LegCountryOfIssue,
            FIXTags.LegStateOrProvinceOfIssue,
            FIXTags.LegLocaleOfIssue,
            FIXTags.LegRedemptionDate,
            FIXTags.LegStrikePrice,
            FIXTags.LegStrikeCurrency,
            FIXTags.LegOptAttribute,
            FIXTags.LegContractMultiplier,
            FIXTags.LegUnitOfMeasure,
            FIXTags.LegTimeUnit,
            FIXTags.LegCouponRate,
            FIXTags.LegSecurityExchange,
            FIXTags.LegIssuer,
            FIXTags.EncodedLegIssuerLen,
            FIXTags.EncodedLegIssuer,
            FIXTags.LegSecurityDesc,
            FIXTags.EncodedLegSecurityDescLen,
            FIXTags.EncodedLegSecurityDesc,
            FIXTags.LegRatioQty,
            FIXTags.LegSide,
            FIXTags.LegCurrency,
            FIXTags.LegPool,
            FIXTags.LegDatedDate,
            FIXTags.LegContractSettlMonth,
            FIXTags.LegInterestAccrualDate,
            FIXTags.LegOptionRatio,
            FIXTags.LegPrice,
            FIXTags.Currency,
            FIXTags.SubscriptionRequestType,
            FIXTags.TradingSessionID,
            FIXTags.TradingSessionSubID,
            FIXTags.SignatureLength,
            FIXTags.Signature,
            FIXTags.CheckSum,
        };
    }
}

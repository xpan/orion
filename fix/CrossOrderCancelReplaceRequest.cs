using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class CrossOrderCancelReplaceRequest
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
            FIXTags.OrderID,
            FIXTags.CrossID,
            FIXTags.OrigCrossID,
            FIXTags.HostCrossID,
            FIXTags.CrossType,
            FIXTags.CrossPrioritization,
            FIXTags.NoRootPartyIDs,
            FIXTags.RootPartyID,
            FIXTags.RootPartyIDSource,
            FIXTags.RootPartyRole,
            FIXTags.NoRootPartySubIDs,
            FIXTags.RootPartySubID,
            FIXTags.RootPartySubIDType,
            FIXTags.NoSides,
            FIXTags.Side,
            FIXTags.ClOrdID,
            FIXTags.SecondaryClOrdID,
            FIXTags.ClOrdLinkID,
            FIXTags.NoPartyIDs,
            FIXTags.PartyID,
            FIXTags.PartyIDSource,
            FIXTags.PartyRole,
            FIXTags.NoPartySubIDs,
            FIXTags.PartySubID,
            FIXTags.PartySubIDType,
            FIXTags.TradeOriginationDate,
            FIXTags.TradeDate,
            FIXTags.Account,
            FIXTags.AcctIDSource,
            FIXTags.AccountType,
            FIXTags.DayBookingInst,
            FIXTags.BookingUnit,
            FIXTags.PreallocMethod,
            FIXTags.AllocID,
            FIXTags.NoAllocs,
            FIXTags.AllocAccount,
            FIXTags.AllocAcctIDSource,
            FIXTags.AllocSettlCurrency,
            FIXTags.IndividualAllocID,
            FIXTags.NoNestedPartyIDs,
            FIXTags.NestedPartyID,
            FIXTags.NestedPartyIDSource,
            FIXTags.NestedPartyRole,
            FIXTags.NoNestedPartySubIDs,
            FIXTags.NestedPartySubID,
            FIXTags.NestedPartySubIDType,
            FIXTags.AllocQty,
            FIXTags.QtyType,
            FIXTags.OrderQty,
            FIXTags.CashOrderQty,
            FIXTags.OrderPercent,
            FIXTags.RoundingDirection,
            FIXTags.RoundingModulus,
            FIXTags.Commission,
            FIXTags.CommType,
            FIXTags.CommCurrency,
            FIXTags.FundRenewWaiv,
            FIXTags.OrderCapacity,
            FIXTags.OrderRestrictions,
            FIXTags.PreTradeAnonymity,
            FIXTags.CustOrderCapacity,
            FIXTags.ForexReq,
            FIXTags.SettlCurrency,
            FIXTags.BookingType,
            FIXTags.Text,
            FIXTags.EncodedTextLen,
            FIXTags.EncodedText,
            FIXTags.PositionEffect,
            FIXTags.CoveredOrUncovered,
            FIXTags.CashMargin,
            FIXTags.ClearingFeeIndicator,
            FIXTags.SolicitedFlag,
            FIXTags.SideComplianceID,
            FIXTags.SideTimeInForce,
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
            FIXTags.SettlType,
            FIXTags.SettlDate,
            FIXTags.HandlInst,
            FIXTags.ExecInst,
            FIXTags.MinQty,
            FIXTags.MatchIncrement,
            FIXTags.MaxPriceLevels,
            FIXTags.DisplayQty,
            FIXTags.SecondaryDisplayQty,
            FIXTags.DisplayWhen,
            FIXTags.DisplayMethod,
            FIXTags.DisplayLowQty,
            FIXTags.DisplayHighQty,
            FIXTags.DisplayMinIncr,
            FIXTags.RefreshQty,
            FIXTags.MaxFloor,
            FIXTags.ExDestination,
            FIXTags.ExDestinationIDSource,
            FIXTags.NoTradingSessions,
            FIXTags.TradingSessionID,
            FIXTags.TradingSessionSubID,
            FIXTags.ProcessCode,
            FIXTags.PrevClosePx,
            FIXTags.LocateReqd,
            FIXTags.TransactTime,
            FIXTags.TransBkdTime,
            FIXTags.NoStipulations,
            FIXTags.StipulationType,
            FIXTags.StipulationValue,
            FIXTags.OrdType,
            FIXTags.PriceType,
            FIXTags.Price,
            FIXTags.PriceProtectionScope,
            FIXTags.StopPx,
            FIXTags.Spread,
            FIXTags.BenchmarkCurveCurrency,
            FIXTags.BenchmarkCurveName,
            FIXTags.BenchmarkCurvePoint,
            FIXTags.BenchmarkPrice,
            FIXTags.BenchmarkPriceType,
            FIXTags.BenchmarkSecurityID,
            FIXTags.BenchmarkSecurityIDSource,
            FIXTags.YieldType,
            FIXTags.Yield,
            FIXTags.YieldCalcDate,
            FIXTags.YieldRedemptionDate,
            FIXTags.YieldRedemptionPrice,
            FIXTags.YieldRedemptionPriceType,
            FIXTags.Currency,
            FIXTags.ComplianceID,
            FIXTags.IOIID,
            FIXTags.QuoteID,
            FIXTags.TimeInForce,
            FIXTags.EffectiveTime,
            FIXTags.ExpireDate,
            FIXTags.ExpireTime,
            FIXTags.GTBookingInst,
            FIXTags.MaxShow,
            FIXTags.PegOffsetValue,
            FIXTags.PegPriceType,
            FIXTags.PegMoveType,
            FIXTags.PegOffsetType,
            FIXTags.PegLimitType,
            FIXTags.PegRoundDirection,
            FIXTags.PegScope,
            FIXTags.PegSecurityIDSource,
            FIXTags.PegSecurityID,
            FIXTags.PegSymbol,
            FIXTags.PegSecurityDesc,
            FIXTags.DiscretionInst,
            FIXTags.DiscretionOffsetValue,
            FIXTags.DiscretionMoveType,
            FIXTags.DiscretionOffsetType,
            FIXTags.DiscretionLimitType,
            FIXTags.DiscretionRoundDirection,
            FIXTags.DiscretionScope,
            FIXTags.TargetStrategy,
            FIXTags.NoStrategyParameters,
            FIXTags.StrategyParameterName,
            FIXTags.StrategyParameterType,
            FIXTags.StrategyParameterValue,
            FIXTags.TargetStrategyParameters,
            FIXTags.ParticipationRate,
            FIXTags.CancellationRights,
            FIXTags.MoneyLaunderingStatus,
            FIXTags.RegistID,
            FIXTags.Designation,
            FIXTags.SignatureLength,
            FIXTags.Signature,
            FIXTags.CheckSum,
        };
    }
}

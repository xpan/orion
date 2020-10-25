using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class Confirmation
    {
        public static readonly FieldSpec ConfirmID = new FieldSpec(FieldType.HashedSlice8, "ConfirmID");
        public static readonly FieldSpec ConfirmRefID = new FieldSpec(FieldType.HashedSlice8, "ConfirmRefID");
        public static readonly FieldSpec ConfirmReqID = new FieldSpec(FieldType.HashedSlice8, "ConfirmReqID");
        public static readonly FieldSpec ConfirmTransType = new FieldSpec(FieldType.Int, "ConfirmTransType");
        public static readonly FieldSpec ConfirmType = new FieldSpec(FieldType.Int, "ConfirmType");
        public static readonly FieldSpec CopyMsgIndicator = new FieldSpec(FieldType.Char, "CopyMsgIndicator");
        public static readonly FieldSpec LegalConfirm = new FieldSpec(FieldType.Char, "LegalConfirm");
        public static readonly FieldSpec ConfirmStatus = new FieldSpec(FieldType.Int, "ConfirmStatus");
        public static readonly FieldSpec AllocID = new FieldSpec(FieldType.HashedSlice8, "AllocID");
        public static readonly FieldSpec SecondaryAllocID = new FieldSpec(FieldType.HashedSlice8, "SecondaryAllocID");
        public static readonly FieldSpec IndividualAllocID = new FieldSpec(FieldType.HashedSlice8, "IndividualAllocID");
        public static readonly FieldSpec TransactTime = new FieldSpec(FieldType.HashedSlice8, "TransactTime");
        public static readonly FieldSpec TradeDate = new FieldSpec(FieldType.HashedSlice8, "TradeDate");
        public static readonly FieldSpec AllocQty = new FieldSpec(FieldType.Float, "AllocQty");
        public static readonly FieldSpec QtyType = new FieldSpec(FieldType.Int, "QtyType");
        public static readonly FieldSpec Side = new FieldSpec(FieldType.Char, "Side");
        public static readonly FieldSpec Currency = new FieldSpec(FieldType.HashedSlice8, "Currency");
        public static readonly FieldSpec LastMkt = new FieldSpec(FieldType.HashedSlice8, "LastMkt");
        public static readonly FieldSpec AllocAccount = new FieldSpec(FieldType.HashedSlice8, "AllocAccount");
        public static readonly FieldSpec AllocAcctIDSource = new FieldSpec(FieldType.Int, "AllocAcctIDSource");
        public static readonly FieldSpec AllocAccountType = new FieldSpec(FieldType.Int, "AllocAccountType");
        public static readonly FieldSpec AvgPx = new FieldSpec(FieldType.Float, "AvgPx");
        public static readonly FieldSpec AvgPxPrecision = new FieldSpec(FieldType.Int, "AvgPxPrecision");
        public static readonly FieldSpec PriceType = new FieldSpec(FieldType.Int, "PriceType");
        public static readonly FieldSpec AvgParPx = new FieldSpec(FieldType.Float, "AvgParPx");
        public static readonly FieldSpec ReportedPx = new FieldSpec(FieldType.Float, "ReportedPx");
        public static readonly FieldSpec Text = new FieldSpec(FieldType.HashedSlice8, "Text");
        public static readonly FieldSpec EncodedTextLen = new FieldSpec(FieldType.Int, "EncodedTextLen");
        public static readonly FieldSpec EncodedText = new FieldSpec(FieldType.HashedSlice8, "EncodedText");
        public static readonly FieldSpec ProcessCode = new FieldSpec(FieldType.Char, "ProcessCode");
        public static readonly FieldSpec GrossTradeAmt = new FieldSpec(FieldType.Float, "GrossTradeAmt");
        public static readonly FieldSpec NumDaysInterest = new FieldSpec(FieldType.Int, "NumDaysInterest");
        public static readonly FieldSpec ExDate = new FieldSpec(FieldType.HashedSlice8, "ExDate");
        public static readonly FieldSpec AccruedInterestRate = new FieldSpec(FieldType.Float, "AccruedInterestRate");
        public static readonly FieldSpec AccruedInterestAmt = new FieldSpec(FieldType.Float, "AccruedInterestAmt");
        public static readonly FieldSpec InterestAtMaturity = new FieldSpec(FieldType.Float, "InterestAtMaturity");
        public static readonly FieldSpec EndAccruedInterestAmt = new FieldSpec(FieldType.Float, "EndAccruedInterestAmt");
        public static readonly FieldSpec StartCash = new FieldSpec(FieldType.Float, "StartCash");
        public static readonly FieldSpec EndCash = new FieldSpec(FieldType.Float, "EndCash");
        public static readonly FieldSpec Concession = new FieldSpec(FieldType.Float, "Concession");
        public static readonly FieldSpec TotalTakedown = new FieldSpec(FieldType.Float, "TotalTakedown");
        public static readonly FieldSpec NetMoney = new FieldSpec(FieldType.Float, "NetMoney");
        public static readonly FieldSpec MaturityNetMoney = new FieldSpec(FieldType.Float, "MaturityNetMoney");
        public static readonly FieldSpec SettlCurrAmt = new FieldSpec(FieldType.Float, "SettlCurrAmt");
        public static readonly FieldSpec SettlCurrency = new FieldSpec(FieldType.HashedSlice8, "SettlCurrency");
        public static readonly FieldSpec SettlCurrFxRate = new FieldSpec(FieldType.Float, "SettlCurrFxRate");
        public static readonly FieldSpec SettlCurrFxRateCalc = new FieldSpec(FieldType.Char, "SettlCurrFxRateCalc");
        public static readonly FieldSpec SettlType = new FieldSpec(FieldType.HashedSlice8, "SettlType");
        public static readonly FieldSpec SettlDate = new FieldSpec(FieldType.HashedSlice8, "SettlDate");
        public static readonly FieldSpec SharedCommission = new FieldSpec(FieldType.Float, "SharedCommission");
        public static readonly FieldSpec AffirmStatus = new FieldSpec(FieldType.Int, "AffirmStatus");
        public static readonly FieldSpec TrdType = new FieldSpec(FieldType.Int, "TrdType");
        public static readonly FieldSpec TrdSubType = new FieldSpec(FieldType.Int, "TrdSubType");
        public static readonly FieldSpec SecondaryTrdType = new FieldSpec(FieldType.Int, "SecondaryTrdType");
        public static readonly FieldSpec MatchType = new FieldSpec(FieldType.HashedSlice8, "MatchType");
        public static readonly FieldSpec MatchStatus = new FieldSpec(FieldType.Char, "MatchStatus");
        public static readonly FieldSpec[] Schema = new FieldSpec[]
        {
            ConfirmID,
            ConfirmRefID,
            ConfirmReqID,
            ConfirmTransType,
            ConfirmType,
            CopyMsgIndicator,
            LegalConfirm,
            ConfirmStatus,
            AllocID,
            SecondaryAllocID,
            IndividualAllocID,
            TransactTime,
            TradeDate,
            AllocQty,
            QtyType,
            Side,
            Currency,
            LastMkt,
            AllocAccount,
            AllocAcctIDSource,
            AllocAccountType,
            AvgPx,
            AvgPxPrecision,
            PriceType,
            AvgParPx,
            ReportedPx,
            Text,
            EncodedTextLen,
            EncodedText,
            ProcessCode,
            GrossTradeAmt,
            NumDaysInterest,
            ExDate,
            AccruedInterestRate,
            AccruedInterestAmt,
            InterestAtMaturity,
            EndAccruedInterestAmt,
            StartCash,
            EndCash,
            Concession,
            TotalTakedown,
            NetMoney,
            MaturityNetMoney,
            SettlCurrAmt,
            SettlCurrency,
            SettlCurrFxRate,
            SettlCurrFxRateCalc,
            SettlType,
            SettlDate,
            SharedCommission,
            AffirmStatus,
            TrdType,
            TrdSubType,
            SecondaryTrdType,
            MatchType,
            MatchStatus,
        };
        public static FieldSpec GetFieldSpec(int tag)
        {
            return tag switch
            {
                664 => ConfirmID,
                772 => ConfirmRefID,
                859 => ConfirmReqID,
                666 => ConfirmTransType,
                773 => ConfirmType,
                797 => CopyMsgIndicator,
                650 => LegalConfirm,
                665 => ConfirmStatus,
                70 => AllocID,
                793 => SecondaryAllocID,
                467 => IndividualAllocID,
                60 => TransactTime,
                75 => TradeDate,
                80 => AllocQty,
                854 => QtyType,
                54 => Side,
                15 => Currency,
                30 => LastMkt,
                79 => AllocAccount,
                661 => AllocAcctIDSource,
                798 => AllocAccountType,
                6 => AvgPx,
                74 => AvgPxPrecision,
                423 => PriceType,
                860 => AvgParPx,
                861 => ReportedPx,
                58 => Text,
                354 => EncodedTextLen,
                355 => EncodedText,
                81 => ProcessCode,
                381 => GrossTradeAmt,
                157 => NumDaysInterest,
                230 => ExDate,
                158 => AccruedInterestRate,
                159 => AccruedInterestAmt,
                738 => InterestAtMaturity,
                920 => EndAccruedInterestAmt,
                921 => StartCash,
                922 => EndCash,
                238 => Concession,
                237 => TotalTakedown,
                118 => NetMoney,
                890 => MaturityNetMoney,
                119 => SettlCurrAmt,
                120 => SettlCurrency,
                155 => SettlCurrFxRate,
                156 => SettlCurrFxRateCalc,
                63 => SettlType,
                64 => SettlDate,
                858 => SharedCommission,
                940 => AffirmStatus,
                828 => TrdType,
                829 => TrdSubType,
                855 => SecondaryTrdType,
                574 => MatchType,
                573 => MatchStatus,
                _ => throw new ArgumentException($"Invalid tag value {tag}")
            };
        }
    }
}

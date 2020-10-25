using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class PositionMaintenanceReport
    {
        public static readonly FieldSpec PosMaintRptID = new FieldSpec(FieldType.HashedSlice8, "PosMaintRptID");
        public static readonly FieldSpec PosTransType = new FieldSpec(FieldType.Int, "PosTransType");
        public static readonly FieldSpec PosReqID = new FieldSpec(FieldType.HashedSlice8, "PosReqID");
        public static readonly FieldSpec PosMaintAction = new FieldSpec(FieldType.Int, "PosMaintAction");
        public static readonly FieldSpec OrigPosReqRefID = new FieldSpec(FieldType.HashedSlice8, "OrigPosReqRefID");
        public static readonly FieldSpec PosMaintStatus = new FieldSpec(FieldType.Int, "PosMaintStatus");
        public static readonly FieldSpec PosMaintResult = new FieldSpec(FieldType.Int, "PosMaintResult");
        public static readonly FieldSpec ClearingBusinessDate = new FieldSpec(FieldType.HashedSlice8, "ClearingBusinessDate");
        public static readonly FieldSpec SettlSessID = new FieldSpec(FieldType.HashedSlice8, "SettlSessID");
        public static readonly FieldSpec SettlSessSubID = new FieldSpec(FieldType.HashedSlice8, "SettlSessSubID");
        public static readonly FieldSpec Account = new FieldSpec(FieldType.HashedSlice8, "Account");
        public static readonly FieldSpec AcctIDSource = new FieldSpec(FieldType.Int, "AcctIDSource");
        public static readonly FieldSpec AccountType = new FieldSpec(FieldType.Int, "AccountType");
        public static readonly FieldSpec PosMaintRptRefID = new FieldSpec(FieldType.HashedSlice8, "PosMaintRptRefID");
        public static readonly FieldSpec Currency = new FieldSpec(FieldType.HashedSlice8, "Currency");
        public static readonly FieldSpec SettlCurrency = new FieldSpec(FieldType.HashedSlice8, "SettlCurrency");
        public static readonly FieldSpec ContraryInstructionIndicator = new FieldSpec(FieldType.Char, "ContraryInstructionIndicator");
        public static readonly FieldSpec PriorSpreadIndicator = new FieldSpec(FieldType.Char, "PriorSpreadIndicator");
        public static readonly FieldSpec TransactTime = new FieldSpec(FieldType.HashedSlice8, "TransactTime");
        public static readonly FieldSpec AdjustmentType = new FieldSpec(FieldType.Int, "AdjustmentType");
        public static readonly FieldSpec ThresholdAmount = new FieldSpec(FieldType.Float, "ThresholdAmount");
        public static readonly FieldSpec Text = new FieldSpec(FieldType.HashedSlice8, "Text");
        public static readonly FieldSpec EncodedTextLen = new FieldSpec(FieldType.Int, "EncodedTextLen");
        public static readonly FieldSpec EncodedText = new FieldSpec(FieldType.HashedSlice8, "EncodedText");
        public static readonly FieldSpec InputSource = new FieldSpec(FieldType.HashedSlice8, "InputSource");
        public static readonly FieldSpec SettlDate = new FieldSpec(FieldType.HashedSlice8, "SettlDate");
        public static readonly FieldSpec[] Schema = new FieldSpec[]
        {
            PosMaintRptID,
            PosTransType,
            PosReqID,
            PosMaintAction,
            OrigPosReqRefID,
            PosMaintStatus,
            PosMaintResult,
            ClearingBusinessDate,
            SettlSessID,
            SettlSessSubID,
            Account,
            AcctIDSource,
            AccountType,
            PosMaintRptRefID,
            Currency,
            SettlCurrency,
            ContraryInstructionIndicator,
            PriorSpreadIndicator,
            TransactTime,
            AdjustmentType,
            ThresholdAmount,
            Text,
            EncodedTextLen,
            EncodedText,
            InputSource,
            SettlDate,
        };
        public static FieldSpec GetFieldSpec(int tag)
        {
            return tag switch
            {
                721 => PosMaintRptID,
                709 => PosTransType,
                710 => PosReqID,
                712 => PosMaintAction,
                713 => OrigPosReqRefID,
                722 => PosMaintStatus,
                723 => PosMaintResult,
                715 => ClearingBusinessDate,
                716 => SettlSessID,
                717 => SettlSessSubID,
                1 => Account,
                660 => AcctIDSource,
                581 => AccountType,
                714 => PosMaintRptRefID,
                15 => Currency,
                120 => SettlCurrency,
                719 => ContraryInstructionIndicator,
                720 => PriorSpreadIndicator,
                60 => TransactTime,
                718 => AdjustmentType,
                834 => ThresholdAmount,
                58 => Text,
                354 => EncodedTextLen,
                355 => EncodedText,
                979 => InputSource,
                64 => SettlDate,
                _ => throw new ArgumentException($"Invalid tag value {tag}")
            };
        }
    }
}

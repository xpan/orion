using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class AssignmentReport
    {
        public static readonly FieldSpec AsgnRptID = new FieldSpec(FieldType.HashedSlice8, "AsgnRptID");
        public static readonly FieldSpec TotNumAssignmentReports = new FieldSpec(FieldType.Int, "TotNumAssignmentReports");
        public static readonly FieldSpec LastRptRequested = new FieldSpec(FieldType.Char, "LastRptRequested");
        public static readonly FieldSpec Account = new FieldSpec(FieldType.HashedSlice8, "Account");
        public static readonly FieldSpec AccountType = new FieldSpec(FieldType.Int, "AccountType");
        public static readonly FieldSpec Currency = new FieldSpec(FieldType.HashedSlice8, "Currency");
        public static readonly FieldSpec ThresholdAmount = new FieldSpec(FieldType.Float, "ThresholdAmount");
        public static readonly FieldSpec SettlPrice = new FieldSpec(FieldType.Float, "SettlPrice");
        public static readonly FieldSpec SettlPriceType = new FieldSpec(FieldType.Int, "SettlPriceType");
        public static readonly FieldSpec UnderlyingSettlPrice = new FieldSpec(FieldType.Float, "UnderlyingSettlPrice");
        public static readonly FieldSpec PriorSettlPrice = new FieldSpec(FieldType.Float, "PriorSettlPrice");
        public static readonly FieldSpec ExpireDate = new FieldSpec(FieldType.HashedSlice8, "ExpireDate");
        public static readonly FieldSpec AssignmentMethod = new FieldSpec(FieldType.Char, "AssignmentMethod");
        public static readonly FieldSpec AssignmentUnit = new FieldSpec(FieldType.Float, "AssignmentUnit");
        public static readonly FieldSpec OpenInterest = new FieldSpec(FieldType.Float, "OpenInterest");
        public static readonly FieldSpec ExerciseMethod = new FieldSpec(FieldType.Char, "ExerciseMethod");
        public static readonly FieldSpec SettlSessID = new FieldSpec(FieldType.HashedSlice8, "SettlSessID");
        public static readonly FieldSpec SettlSessSubID = new FieldSpec(FieldType.HashedSlice8, "SettlSessSubID");
        public static readonly FieldSpec ClearingBusinessDate = new FieldSpec(FieldType.HashedSlice8, "ClearingBusinessDate");
        public static readonly FieldSpec Text = new FieldSpec(FieldType.HashedSlice8, "Text");
        public static readonly FieldSpec EncodedTextLen = new FieldSpec(FieldType.Int, "EncodedTextLen");
        public static readonly FieldSpec EncodedText = new FieldSpec(FieldType.HashedSlice8, "EncodedText");
        public static readonly FieldSpec PosReqID = new FieldSpec(FieldType.HashedSlice8, "PosReqID");
        public static readonly FieldSpec[] Schema = new FieldSpec[]
        {
            AsgnRptID,
            TotNumAssignmentReports,
            LastRptRequested,
            Account,
            AccountType,
            Currency,
            ThresholdAmount,
            SettlPrice,
            SettlPriceType,
            UnderlyingSettlPrice,
            PriorSettlPrice,
            ExpireDate,
            AssignmentMethod,
            AssignmentUnit,
            OpenInterest,
            ExerciseMethod,
            SettlSessID,
            SettlSessSubID,
            ClearingBusinessDate,
            Text,
            EncodedTextLen,
            EncodedText,
            PosReqID,
        };
        public static FieldSpec GetFieldSpec(int tag)
        {
            return tag switch
            {
                833 => AsgnRptID,
                832 => TotNumAssignmentReports,
                912 => LastRptRequested,
                1 => Account,
                581 => AccountType,
                15 => Currency,
                834 => ThresholdAmount,
                730 => SettlPrice,
                731 => SettlPriceType,
                732 => UnderlyingSettlPrice,
                734 => PriorSettlPrice,
                432 => ExpireDate,
                744 => AssignmentMethod,
                745 => AssignmentUnit,
                746 => OpenInterest,
                747 => ExerciseMethod,
                716 => SettlSessID,
                717 => SettlSessSubID,
                715 => ClearingBusinessDate,
                58 => Text,
                354 => EncodedTextLen,
                355 => EncodedText,
                710 => PosReqID,
                _ => throw new ArgumentException($"Invalid tag value {tag}")
            };
        }
    }
}

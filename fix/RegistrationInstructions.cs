using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class RegistrationInstructions
    {
        public static readonly FieldSpec RegistID = new FieldSpec(FieldType.HashedSlice8, "RegistID");
        public static readonly FieldSpec RegistTransType = new FieldSpec(FieldType.Char, "RegistTransType");
        public static readonly FieldSpec RegistRefID = new FieldSpec(FieldType.HashedSlice8, "RegistRefID");
        public static readonly FieldSpec ClOrdID = new FieldSpec(FieldType.HashedSlice8, "ClOrdID");
        public static readonly FieldSpec Account = new FieldSpec(FieldType.HashedSlice8, "Account");
        public static readonly FieldSpec AcctIDSource = new FieldSpec(FieldType.Int, "AcctIDSource");
        public static readonly FieldSpec RegistAcctType = new FieldSpec(FieldType.HashedSlice8, "RegistAcctType");
        public static readonly FieldSpec TaxAdvantageType = new FieldSpec(FieldType.Int, "TaxAdvantageType");
        public static readonly FieldSpec OwnershipType = new FieldSpec(FieldType.Char, "OwnershipType");
        public static readonly FieldSpec ClearingBusinessDate = new FieldSpec(FieldType.HashedSlice8, "ClearingBusinessDate");
        public static readonly FieldSpec[] Schema = new FieldSpec[]
        {
            RegistID,
            RegistTransType,
            RegistRefID,
            ClOrdID,
            Account,
            AcctIDSource,
            RegistAcctType,
            TaxAdvantageType,
            OwnershipType,
            ClearingBusinessDate,
        };
        public static FieldSpec GetFieldSpec(int tag)
        {
            return tag switch
            {
                513 => RegistID,
                514 => RegistTransType,
                508 => RegistRefID,
                11 => ClOrdID,
                1 => Account,
                660 => AcctIDSource,
                493 => RegistAcctType,
                495 => TaxAdvantageType,
                517 => OwnershipType,
                715 => ClearingBusinessDate,
                _ => throw new ArgumentException($"Invalid tag value {tag}")
            };
        }
    }
}

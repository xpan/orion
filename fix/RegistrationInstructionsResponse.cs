using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class RegistrationInstructionsResponse
    {
        public static readonly FieldSpec RegistID = new FieldSpec(FieldType.HashedSlice8, "RegistID");
        public static readonly FieldSpec RegistTransType = new FieldSpec(FieldType.Char, "RegistTransType");
        public static readonly FieldSpec RegistRefID = new FieldSpec(FieldType.HashedSlice8, "RegistRefID");
        public static readonly FieldSpec ClOrdID = new FieldSpec(FieldType.HashedSlice8, "ClOrdID");
        public static readonly FieldSpec Account = new FieldSpec(FieldType.HashedSlice8, "Account");
        public static readonly FieldSpec AcctIDSource = new FieldSpec(FieldType.Int, "AcctIDSource");
        public static readonly FieldSpec RegistStatus = new FieldSpec(FieldType.Char, "RegistStatus");
        public static readonly FieldSpec RegistRejReasonCode = new FieldSpec(FieldType.Int, "RegistRejReasonCode");
        public static readonly FieldSpec RegistRejReasonText = new FieldSpec(FieldType.HashedSlice8, "RegistRejReasonText");
        public static readonly FieldSpec[] Schema = new FieldSpec[]
        {
            RegistID,
            RegistTransType,
            RegistRefID,
            ClOrdID,
            Account,
            AcctIDSource,
            RegistStatus,
            RegistRejReasonCode,
            RegistRejReasonText,
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
                506 => RegistStatus,
                507 => RegistRejReasonCode,
                496 => RegistRejReasonText,
                _ => throw new ArgumentException($"Invalid tag value {tag}")
            };
        }
    }
}

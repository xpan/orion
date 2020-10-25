using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class ConfirmationRequest
    {
        public static readonly FieldSpec ConfirmReqID = new FieldSpec(FieldType.HashedSlice8, "ConfirmReqID");
        public static readonly FieldSpec ConfirmType = new FieldSpec(FieldType.Int, "ConfirmType");
        public static readonly FieldSpec AllocID = new FieldSpec(FieldType.HashedSlice8, "AllocID");
        public static readonly FieldSpec SecondaryAllocID = new FieldSpec(FieldType.HashedSlice8, "SecondaryAllocID");
        public static readonly FieldSpec IndividualAllocID = new FieldSpec(FieldType.HashedSlice8, "IndividualAllocID");
        public static readonly FieldSpec TransactTime = new FieldSpec(FieldType.HashedSlice8, "TransactTime");
        public static readonly FieldSpec AllocAccount = new FieldSpec(FieldType.HashedSlice8, "AllocAccount");
        public static readonly FieldSpec AllocAcctIDSource = new FieldSpec(FieldType.Int, "AllocAcctIDSource");
        public static readonly FieldSpec AllocAccountType = new FieldSpec(FieldType.Int, "AllocAccountType");
        public static readonly FieldSpec Text = new FieldSpec(FieldType.HashedSlice8, "Text");
        public static readonly FieldSpec EncodedTextLen = new FieldSpec(FieldType.Int, "EncodedTextLen");
        public static readonly FieldSpec EncodedText = new FieldSpec(FieldType.HashedSlice8, "EncodedText");
        public static readonly FieldSpec[] Schema = new FieldSpec[]
        {
            ConfirmReqID,
            ConfirmType,
            AllocID,
            SecondaryAllocID,
            IndividualAllocID,
            TransactTime,
            AllocAccount,
            AllocAcctIDSource,
            AllocAccountType,
            Text,
            EncodedTextLen,
            EncodedText,
        };
        public static FieldSpec GetFieldSpec(int tag)
        {
            return tag switch
            {
                859 => ConfirmReqID,
                773 => ConfirmType,
                70 => AllocID,
                793 => SecondaryAllocID,
                467 => IndividualAllocID,
                60 => TransactTime,
                79 => AllocAccount,
                661 => AllocAcctIDSource,
                798 => AllocAccountType,
                58 => Text,
                354 => EncodedTextLen,
                355 => EncodedText,
                _ => throw new ArgumentException($"Invalid tag value {tag}")
            };
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class DerivativeSecurityListUpdateReport
    {
        public static readonly FieldSpec SecurityReqID = new FieldSpec(FieldType.HashedSlice8, "SecurityReqID");
        public static readonly FieldSpec SecurityResponseID = new FieldSpec(FieldType.HashedSlice8, "SecurityResponseID");
        public static readonly FieldSpec SecurityRequestResult = new FieldSpec(FieldType.Int, "SecurityRequestResult");
        public static readonly FieldSpec SecurityUpdateAction = new FieldSpec(FieldType.Char, "SecurityUpdateAction");
        public static readonly FieldSpec TotNoRelatedSym = new FieldSpec(FieldType.Int, "TotNoRelatedSym");
        public static readonly FieldSpec LastFragment = new FieldSpec(FieldType.Char, "LastFragment");
        public static readonly FieldSpec TransactTime = new FieldSpec(FieldType.HashedSlice8, "TransactTime");
        public static readonly FieldSpec LastUpdateTime = new FieldSpec(FieldType.HashedSlice8, "LastUpdateTime");
        public static readonly FieldSpec[] Schema = new FieldSpec[]
        {
            SecurityReqID,
            SecurityResponseID,
            SecurityRequestResult,
            SecurityUpdateAction,
            TotNoRelatedSym,
            LastFragment,
            TransactTime,
            LastUpdateTime,
        };
        public static FieldSpec GetFieldSpec(int tag)
        {
            return tag switch
            {
                320 => SecurityReqID,
                322 => SecurityResponseID,
                560 => SecurityRequestResult,
                980 => SecurityUpdateAction,
                393 => TotNoRelatedSym,
                893 => LastFragment,
                60 => TransactTime,
                779 => LastUpdateTime,
                _ => throw new ArgumentException($"Invalid tag value {tag}")
            };
        }
    }
}

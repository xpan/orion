using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class MassOrder
    {
        public static readonly FieldSpec Account = new FieldSpec(FieldType.HashedSlice8, "Account");
        public static readonly FieldSpec AcctIDSource = new FieldSpec(FieldType.Int, "AcctIDSource");
        public static readonly FieldSpec AccountType = new FieldSpec(FieldType.Int, "AccountType");
        public static readonly FieldSpec OrderCapacity = new FieldSpec(FieldType.Char, "OrderCapacity");
        public static readonly FieldSpec OrderRestrictions = new FieldSpec(FieldType.HashedSlice8, "OrderRestrictions");
        public static readonly FieldSpec CustOrderCapacity = new FieldSpec(FieldType.Int, "CustOrderCapacity");
        public static readonly FieldSpec ManualOrderIndicator = new FieldSpec(FieldType.Char, "ManualOrderIndicator");
        public static readonly FieldSpec CustOrderHandlingInst = new FieldSpec(FieldType.HashedSlice8, "CustOrderHandlingInst");
        public static readonly FieldSpec TransactTime = new FieldSpec(FieldType.HashedSlice8, "TransactTime");
        public static readonly FieldSpec Text = new FieldSpec(FieldType.HashedSlice8, "Text");
        public static readonly FieldSpec EncodedTextLen = new FieldSpec(FieldType.Int, "EncodedTextLen");
        public static readonly FieldSpec EncodedText = new FieldSpec(FieldType.HashedSlice8, "EncodedText");
        public static readonly FieldSpec LastFragment = new FieldSpec(FieldType.Char, "LastFragment");
        public static readonly FieldSpec[] Schema = new FieldSpec[]
        {
            Account,
            AcctIDSource,
            AccountType,
            OrderCapacity,
            OrderRestrictions,
            CustOrderCapacity,
            ManualOrderIndicator,
            CustOrderHandlingInst,
            TransactTime,
            Text,
            EncodedTextLen,
            EncodedText,
            LastFragment,
        };
        public static FieldSpec GetFieldSpec(int tag)
        {
            return tag switch
            {
                1 => Account,
                660 => AcctIDSource,
                581 => AccountType,
                528 => OrderCapacity,
                529 => OrderRestrictions,
                582 => CustOrderCapacity,
                1028 => ManualOrderIndicator,
                1031 => CustOrderHandlingInst,
                60 => TransactTime,
                58 => Text,
                354 => EncodedTextLen,
                355 => EncodedText,
                893 => LastFragment,
                _ => throw new ArgumentException($"Invalid tag value {tag}")
            };
        }
    }
}

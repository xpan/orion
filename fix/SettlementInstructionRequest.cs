using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class SettlementInstructionRequest
    {
        public static readonly FieldSpec SettlInstReqID = new FieldSpec(FieldType.HashedSlice8, "SettlInstReqID");
        public static readonly FieldSpec TransactTime = new FieldSpec(FieldType.HashedSlice8, "TransactTime");
        public static readonly FieldSpec AllocAccount = new FieldSpec(FieldType.HashedSlice8, "AllocAccount");
        public static readonly FieldSpec AllocAcctIDSource = new FieldSpec(FieldType.Int, "AllocAcctIDSource");
        public static readonly FieldSpec Side = new FieldSpec(FieldType.Char, "Side");
        public static readonly FieldSpec Product = new FieldSpec(FieldType.Int, "Product");
        public static readonly FieldSpec SecurityType = new FieldSpec(FieldType.HashedSlice8, "SecurityType");
        public static readonly FieldSpec CFICode = new FieldSpec(FieldType.HashedSlice8, "CFICode");
        public static readonly FieldSpec SettlCurrency = new FieldSpec(FieldType.HashedSlice8, "SettlCurrency");
        public static readonly FieldSpec EffectiveTime = new FieldSpec(FieldType.HashedSlice8, "EffectiveTime");
        public static readonly FieldSpec ExpireTime = new FieldSpec(FieldType.HashedSlice8, "ExpireTime");
        public static readonly FieldSpec LastUpdateTime = new FieldSpec(FieldType.HashedSlice8, "LastUpdateTime");
        public static readonly FieldSpec StandInstDbType = new FieldSpec(FieldType.Int, "StandInstDbType");
        public static readonly FieldSpec StandInstDbName = new FieldSpec(FieldType.HashedSlice8, "StandInstDbName");
        public static readonly FieldSpec StandInstDbID = new FieldSpec(FieldType.HashedSlice8, "StandInstDbID");
        public static readonly FieldSpec[] Schema = new FieldSpec[]
        {
            SettlInstReqID,
            TransactTime,
            AllocAccount,
            AllocAcctIDSource,
            Side,
            Product,
            SecurityType,
            CFICode,
            SettlCurrency,
            EffectiveTime,
            ExpireTime,
            LastUpdateTime,
            StandInstDbType,
            StandInstDbName,
            StandInstDbID,
        };
        public static FieldSpec GetFieldSpec(int tag)
        {
            return tag switch
            {
                791 => SettlInstReqID,
                60 => TransactTime,
                79 => AllocAccount,
                661 => AllocAcctIDSource,
                54 => Side,
                460 => Product,
                167 => SecurityType,
                461 => CFICode,
                120 => SettlCurrency,
                168 => EffectiveTime,
                126 => ExpireTime,
                779 => LastUpdateTime,
                169 => StandInstDbType,
                170 => StandInstDbName,
                171 => StandInstDbID,
                _ => throw new ArgumentException($"Invalid tag value {tag}")
            };
        }
    }
}

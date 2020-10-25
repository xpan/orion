using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class OrderMassStatusRequest
    {
        public static readonly FieldSpec MassStatusReqID = new FieldSpec(FieldType.HashedSlice8, "MassStatusReqID");
        public static readonly FieldSpec MassStatusReqType = new FieldSpec(FieldType.Int, "MassStatusReqType");
        public static readonly FieldSpec Account = new FieldSpec(FieldType.HashedSlice8, "Account");
        public static readonly FieldSpec AcctIDSource = new FieldSpec(FieldType.Int, "AcctIDSource");
        public static readonly FieldSpec TradingSessionID = new FieldSpec(FieldType.HashedSlice8, "TradingSessionID");
        public static readonly FieldSpec TradingSessionSubID = new FieldSpec(FieldType.HashedSlice8, "TradingSessionSubID");
        public static readonly FieldSpec Side = new FieldSpec(FieldType.Char, "Side");
        public static readonly FieldSpec[] Schema = new FieldSpec[]
        {
            MassStatusReqID,
            MassStatusReqType,
            Account,
            AcctIDSource,
            TradingSessionID,
            TradingSessionSubID,
            Side,
        };
        public static FieldSpec GetFieldSpec(int tag)
        {
            return tag switch
            {
                584 => MassStatusReqID,
                585 => MassStatusReqType,
                1 => Account,
                660 => AcctIDSource,
                336 => TradingSessionID,
                625 => TradingSessionSubID,
                54 => Side,
                _ => throw new ArgumentException($"Invalid tag value {tag}")
            };
        }
    }
}

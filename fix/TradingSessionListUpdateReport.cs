using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class TradingSessionListUpdateReport
    {
        public static readonly FieldSpec TradSesReqID = new FieldSpec(FieldType.HashedSlice8, "TradSesReqID");
        public static readonly FieldSpec[] Schema = new FieldSpec[]
        {
            TradSesReqID,
        };
        public static FieldSpec GetFieldSpec(int tag)
        {
            return tag switch
            {
                335 => TradSesReqID,
                _ => throw new ArgumentException($"Invalid tag value {tag}")
            };
        }
    }
}

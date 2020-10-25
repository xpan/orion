using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class RFQRequest
    {
        public static readonly FieldSpec RFQReqID = new FieldSpec(FieldType.HashedSlice8, "RFQReqID");
        public static readonly FieldSpec SubscriptionRequestType = new FieldSpec(FieldType.Char, "SubscriptionRequestType");
        public static readonly FieldSpec[] Schema = new FieldSpec[]
        {
            RFQReqID,
            SubscriptionRequestType,
        };
        public static FieldSpec GetFieldSpec(int tag)
        {
            return tag switch
            {
                644 => RFQReqID,
                263 => SubscriptionRequestType,
                _ => throw new ArgumentException($"Invalid tag value {tag}")
            };
        }
    }
}

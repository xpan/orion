using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class MarketDefinitionRequest
    {
        public static readonly FieldSpec SubscriptionRequestType = new FieldSpec(FieldType.Char, "SubscriptionRequestType");
        public static readonly FieldSpec[] Schema = new FieldSpec[]
        {
            SubscriptionRequestType,
        };
        public static FieldSpec GetFieldSpec(int tag)
        {
            return tag switch
            {
                263 => SubscriptionRequestType,
                _ => throw new ArgumentException($"Invalid tag value {tag}")
            };
        }
    }
}

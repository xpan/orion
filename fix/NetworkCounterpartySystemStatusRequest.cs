using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class NetworkCounterpartySystemStatusRequest
    {
        public static readonly FieldSpec NetworkRequestType = new FieldSpec(FieldType.Int, "NetworkRequestType");
        public static readonly FieldSpec NetworkRequestID = new FieldSpec(FieldType.HashedSlice8, "NetworkRequestID");
        public static readonly FieldSpec[] Schema = new FieldSpec[]
        {
            NetworkRequestType,
            NetworkRequestID,
        };
        public static FieldSpec GetFieldSpec(int tag)
        {
            return tag switch
            {
                935 => NetworkRequestType,
                933 => NetworkRequestID,
                _ => throw new ArgumentException($"Invalid tag value {tag}")
            };
        }
    }
}

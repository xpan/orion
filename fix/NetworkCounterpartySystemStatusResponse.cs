using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class NetworkCounterpartySystemStatusResponse
    {
        public static readonly FieldSpec NetworkStatusResponseType = new FieldSpec(FieldType.Int, "NetworkStatusResponseType");
        public static readonly FieldSpec NetworkRequestID = new FieldSpec(FieldType.HashedSlice8, "NetworkRequestID");
        public static readonly FieldSpec NetworkResponseID = new FieldSpec(FieldType.HashedSlice8, "NetworkResponseID");
        public static readonly FieldSpec LastNetworkResponseID = new FieldSpec(FieldType.HashedSlice8, "LastNetworkResponseID");
        public static readonly FieldSpec[] Schema = new FieldSpec[]
        {
            NetworkStatusResponseType,
            NetworkRequestID,
            NetworkResponseID,
            LastNetworkResponseID,
        };
        public static FieldSpec GetFieldSpec(int tag)
        {
            return tag switch
            {
                937 => NetworkStatusResponseType,
                933 => NetworkRequestID,
                932 => NetworkResponseID,
                934 => LastNetworkResponseID,
                _ => throw new ArgumentException($"Invalid tag value {tag}")
            };
        }
    }
}

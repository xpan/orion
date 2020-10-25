using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class BidResponse
    {
        public static readonly FieldSpec BidID = new FieldSpec(FieldType.HashedSlice8, "BidID");
        public static readonly FieldSpec ClientBidID = new FieldSpec(FieldType.HashedSlice8, "ClientBidID");
        public static readonly FieldSpec[] Schema = new FieldSpec[]
        {
            BidID,
            ClientBidID,
        };
        public static FieldSpec GetFieldSpec(int tag)
        {
            return tag switch
            {
                390 => BidID,
                391 => ClientBidID,
                _ => throw new ArgumentException($"Invalid tag value {tag}")
            };
        }
    }
}

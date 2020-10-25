using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class ListStrikePrice
    {
        public static readonly FieldSpec ListID = new FieldSpec(FieldType.HashedSlice8, "ListID");
        public static readonly FieldSpec TotNoStrikes = new FieldSpec(FieldType.Int, "TotNoStrikes");
        public static readonly FieldSpec LastFragment = new FieldSpec(FieldType.Char, "LastFragment");
        public static readonly FieldSpec[] Schema = new FieldSpec[]
        {
            ListID,
            TotNoStrikes,
            LastFragment,
        };
        public static FieldSpec GetFieldSpec(int tag)
        {
            return tag switch
            {
                66 => ListID,
                422 => TotNoStrikes,
                893 => LastFragment,
                _ => throw new ArgumentException($"Invalid tag value {tag}")
            };
        }
    }
}

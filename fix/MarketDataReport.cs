using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class MarketDataReport
    {
        public static readonly FieldSpec MDReportID = new FieldSpec(FieldType.Int, "MDReportID");
        public static readonly FieldSpec TransactTime = new FieldSpec(FieldType.HashedSlice8, "TransactTime");
        public static readonly FieldSpec TotNumReports = new FieldSpec(FieldType.Int, "TotNumReports");
        public static readonly FieldSpec[] Schema = new FieldSpec[]
        {
            MDReportID,
            TransactTime,
            TotNumReports,
        };
        public static FieldSpec GetFieldSpec(int tag)
        {
            return tag switch
            {
                963 => MDReportID,
                60 => TransactTime,
                911 => TotNumReports,
                _ => throw new ArgumentException($"Invalid tag value {tag}")
            };
        }
    }
}

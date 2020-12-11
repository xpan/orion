using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hydrogen
{
    public class Joined : ITable
    {
        private ITable l;
        private ITable r;

        public Joined(ITable l, ITable r)
        {
            this.l = l;
            this.r = r;
            Fields = l.Fields.Concat(r.Fields).ToArray();
        }

        public int Dim => l.Dim + r.Dim;

        public FieldSpec[] Fields { get; }

        public IField GetField(FieldSpec fieldSpec)
        {
            return l.GetField(fieldSpec) ?? r.GetField(fieldSpec);
        }

        public int GetOrdinal(ITable table)
        {
            var ord = l.GetOrdinal(table);
            if (ord >= 0)
                return ord;
            else
            {
                ord = r.GetOrdinal(table);
                if (ord >= 0)
                    return ord + l.Dim;
                else
                    return -1;
            }
        }

        public ITable GetOwnerTable(FieldSpec fieldSpec)
        {
            return l.GetOwnerTable(fieldSpec) ?? r.GetOwnerTable(fieldSpec);
        }
    }
}

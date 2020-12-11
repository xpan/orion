using Hydrogen.Arrays;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hydrogen
{
    public class TableStore : ITable
    {
        private Dictionary<FieldSpec, IField> s;
        private Hydrogen.Index.HashSet<int> rows = new Index.HashSet<int>(EqualityComparer<int>.Default, 1024);
        private List<TableListener> listeners = new List<TableListener>();
        private int current;
        protected TableStore(Dictionary<FieldSpec, IField> s)
        {
            this.s = s;
        }

        public int Dim => 1;

        public FieldSpec[] Fields => s.Keys.ToArray();

        public static TableStore Create(int chunkSize, params FieldSpec[] fieldSpecs)
        {
            IField Create(int capacity, FieldType type)
            {
                return type switch
                {
                    FieldType.Boolean => new Field.Boolean(capacity),
                    FieldType.Int8 => new Field.SByte(capacity),
                    FieldType.Int16 => new Field.Short(capacity),
                    FieldType.Int32 => new Field.Int(capacity),
                    FieldType.Char => new Field.Char(capacity),
                    _ => throw new NotSupportedException()
                };
            }
            return new TableStore(fieldSpecs.ToDictionary(f => f, f => Create(chunkSize, f.Type)));
        }

        public IField GetField(FieldSpec fieldSpec)
        {
            return s.ContainsKey(fieldSpec) ? s[fieldSpec] : null;
        }

        public int GetOrdinal(ITable table)
        {
            return table == this ? 0 : -1;
        }

        public ITable GetOwnerTable(FieldSpec fieldSpec)
        {
            return s.ContainsKey(fieldSpec) ? this : null;
        }

        public Joinable<Array1<int>> ToJoinable()
        {
            IEnumerable<Array1<int>> Test(ITable table, int index)
            {
                if (table != this || rows.GetEntry(index) < 0)
                    yield break;
                yield return new Array1<int> { d1 = index };
            }

            IEnumerable<Array1<int>> It()
            {
                foreach (var r in rows.It())
                    yield return new Array1<int> { d1 = r };
            }

            IEnumerable<(int ord, int index)> Facts(Array1<int> a)
            {
                yield return (0, a.d1);
            }
            return new Joinable<Array1<int>>(this, Test, It, Facts, (a, i) => i == 0? a.d1 : throw new IndexOutOfRangeException());
        }

        public void Subscribe(TableListener listner)
        {
            if (!listeners.Contains(listner))
                listeners.Add(listner);
        }

        public void CreateRow(Row row)
        {
            row.Initialize(current++, Op.Add);
        }

        public void ReleaseRow(Row row)
        {
            if (row.Op == Op.Add)
                rows.Insert(row.RowId);

            foreach (var listener in listeners)
                listener(this, row.Op, row.RowId, row.BitMask);
        }

        public void UpdateRow(int index, Row row)
        {
            row.Initialize(index, Op.Update);
        }

        public bool Contains(int index) => rows.GetEntry(index) >= 0;

        public int GetOrdinal(FieldSpec fieldSpec)
        {
            if (s.ContainsKey(fieldSpec))
                return 0;
            else
                return -1;
        }
    }
}

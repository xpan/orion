using Hydrogen.Arrays;
using Hydrogen.Enumerators;
using System;
using System.Collections;
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

        public struct Test : IEnumerator<Array1<int>>
        {
            public Func<ITable, int, bool> predicate;
            private Array1<int> v;
            public ITable table;
            public int index;
            public Array1<int> Current => v;

            object IEnumerator.Current => throw new NotImplementedException();

            public void Dispose()
            {
                throw new NotImplementedException();
            }

            public bool MoveNext()
            {
                if (predicate(table, index))
                {
                    v.d1 = index;
                    return true;
                }
                return false;
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }
        }

        public Joinable<Test, Array1<int>> ToJoinable()
        {
            void Test(ITable table, int index, ref Test it)
            {
                it.index = index;
                it.table = table;
                it.predicate = (t, i) => t == this && rows.GetEntry(i) >= 0;
            }

            return new Joinable<Test, Array1<int>>(this, Test, (a, i) => i == 0? a.d1 : throw new IndexOutOfRangeException());
        }

        public void Subscribe(TableListener listner)
        {
            if (!listeners.Contains(listner))
                listeners.Add(listner);
        }

        public void CreateRow(ref Row row)
        {
            row.store = this;
            row.index = current++;
            row.op = Op.Add;
        }

        public void ReleaseRow(Row row)
        {
            if (row.store == this)
            {
                rows.Insert(row.index);

                foreach (var listener in listeners)
                    listener(this, row.op, row.index, row.bitMask);
            }            
        }

        public void UpdateRow(int index, Row row)
        {
            row.store = this;
            row.index = current++;
            row.op = Op.Update;
            row.index = index;
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

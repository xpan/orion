using Hydrogen.Exprs.Serialization;
using Hydrogen.Index;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Hydrogen
{
    public class TableStore : ITable
    {
        private Dictionary<FieldSpec, FieldHolder> fieldSpecToFieldHolder;
        private Dictionary<IField, FieldHolder> fieldToFieldHolder;
        private List<TableStoreListener> listeners = new List<TableStoreListener>();
        private int current = 0;
        private BinarySearchTree<int> ns;
        public TableStore(Dictionary<FieldSpec, FieldHolder> fieldSpecToFieldHolder,
            Dictionary<IField, FieldHolder> fieldToFieldHolder,
            BinarySearchTree<int> rs)
        {
            this.fieldSpecToFieldHolder = fieldSpecToFieldHolder;
            this.fieldToFieldHolder = fieldToFieldHolder;
            this.ns = rs;

            FieldSpecs = fieldSpecToFieldHolder.Keys.ToArray();
        }

        public FieldSpec[] FieldSpecs { get; }

        public int Dimension => 1;

        public static TableStore Create(int capacity, params FieldSpec[] fieldSpecs)
        {
            static IField CreateField(int capacity, FieldType fieldType) => fieldType switch
            {
                FieldType.Boolean => new Field.Boolean(capacity),
                FieldType.SByte => new Field.SByte(capacity),
                FieldType.Short => new Field.Int16(capacity),
                FieldType.Int => new Field.Int32(capacity),
                FieldType.Long => new Field.Int64(capacity),
                FieldType.Byte => new Field.Byte(capacity),
                FieldType.UShort => new Field.UInt16(capacity),
                FieldType.UInt => new Field.UInt32(capacity),
                FieldType.ULong => new Field.UInt64(capacity),
                FieldType.Float => new Field.Float(capacity),
                FieldType.Double => new Field.Double(capacity),
                FieldType.HashedSlice8 => new Field.HashedSlice8(capacity),
                FieldType.HashedSlice16 => new Field.HashedSlice16(capacity),
                FieldType.Char => new Field.Char(capacity),
                _ => throw new NotSupportedException()
            };

            var fieldHolders = fieldSpecs.Select(fs => new FieldHolder(CreateField(capacity, fs.Type), fs)).ToArray();
            return new TableStore(fieldHolders.ToDictionary(fh => fh.FieldSpec, fh => fh),
                fieldHolders.ToDictionary(fh => fh.Field, fh => fh),
                new BinarySearchTree<int>((x, y) => x - y, capacity));
        }

        public IField GetField(FieldSpec fieldSpec) => fieldSpecToFieldHolder.ContainsKey(fieldSpec) ? fieldSpecToFieldHolder[fieldSpec].Field : null;

        public Joinable<T> ToJoinable<T>(Func<int, T> ctor) where T : IValueTypedArray<int>
        {
            static T ToArray(Func<int, T> ctor, int n)
            {
                var r = ctor(1);
                r[0] = n;
                return r;
            }
            return new Joinable<T>(this, (s, n) => s == this && ns.GetEntry(n) >= 0 ? new T[] { ToArray(ctor, n) } : new T[] { }, () => ns.Gt(-1).Select(i => ToArray(ctor, i)));
        }

        public void Notify(int rowNum, int bitMask, Op op)
        {
            static IEnumerable<int> GetFieldIds(int bitMask)
            {
                if (bitMask < 0)
                    yield break;

                var bit = 1;
                var index = 0;
                while (bit <= bitMask)
                {
                    if ((bit & bitMask) == bit)
                    {
                        yield return index;
                    }
                    bit <<= 1;
                    index++;
                }
            }

            var fields = GetFieldIds(bitMask)
                .Select(i => GetField(FieldSpecs[i]))
                .ToArray();
            foreach (var listener in listeners)
            {
                listener(this, op, rowNum, fields);
            }
                
        }

        public Row? this[int index]
        {
            get
            {
                if (ns.GetEntry(index) < 0)
                    return new Row?();
                else
                    return new Row(this, index, Op.Update);
            }
        }
        public Row NewRow()
        {
            return new Row(this, current++, Op.Add);
        }

        public void Add(Row r)
        {
            ns.Insert(r.RowNum);
            Notify(r.RowNum, r.BitMask, Op.Add);
        }

        public void Subscribe(TableStoreListener listener)
        {
            listeners.Add(listener);
        }

        public int GetOrdinal(TableStore table) => table == this? 0 : -1;

        public TableStore GetTableStore(IField field) => fieldToFieldHolder.ContainsKey(field) ? this : null;
    }
}

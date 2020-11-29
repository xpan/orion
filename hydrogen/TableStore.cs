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
        private (int fieldId, Variant v)[] currentStatus;
        public TableStore(Dictionary<FieldSpec, FieldHolder> fieldSpecToFieldHolder,
            Dictionary<IField, FieldHolder> fieldToFieldHolder,
            BinarySearchTree<int> ns)
        {
            this.fieldSpecToFieldHolder = fieldSpecToFieldHolder;
            this.fieldToFieldHolder = fieldToFieldHolder;
            this.ns = ns;

            Fields = fieldSpecToFieldHolder.Keys.ToArray();
            currentStatus = new (int fieldId, Variant v)[128];
        }

        public FieldSpec[] Fields { get; }

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
            var conv = Utils.ToArray(ctor);

            IEnumerable<T> Test(ITable table, int index)
            {
                if (table == this && ns.GetEntry(index) >= 0)
                    yield return conv(index);
                yield break;
            }

            IEnumerable<T> Snapshot()
            {
                foreach (var index in ns.Gt(-1))
                    yield return conv(index);
            }

            return new Joinable<T>(this, Test, Snapshot);
        }

        public void Notify(int rowNum, Op op, IEnumerable<(int fieldId, Variant v)> changes)
        {
            foreach (var listener in listeners)
            {
                listener(this, op, rowNum, changes);
            }                
        }

        public bool ContainsRow(int index)
        {
            return ns.GetEntry(index) >= 0;
        }

        public Row this[int index]
        {
            get
            {
                if (ns.GetEntry(index) < 0)
                    throw new ApplicationException();
                return new Row(this, index, Op.Update, currentStatus);
            }            
        }

        public Row NewRow()
        {
            return new Row(this, current++, Op.Add, currentStatus);
        }

        public void Add(Row r)
        {
            ns.Insert(r.RowNum);
            r.EndEdit();
        }

        public void Subscribe(TableStoreListener listener)
        {
            listeners.Add(listener);
        }

        public int GetOrdinal(ITable table) => table == this? 0 : -1;

        public TableStore GetTable(IField field) => fieldToFieldHolder.ContainsKey(field) ? this : null;
    }
}

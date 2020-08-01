using Hydrogen.Exprs.Serialization;
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
        private RowTracker rowTracker = new RowTracker();
        private List<TableStoreListener> listeners = new List<TableStoreListener>();
        private int current = 0;
        private int bitMask = 0;
        public TableStore(Dictionary<FieldSpec, FieldHolder> fieldSpecToFieldHolder,
            Dictionary<IField, FieldHolder> fieldToFieldHolder)
        {
            this.fieldSpecToFieldHolder = fieldSpecToFieldHolder;
            this.fieldToFieldHolder = fieldToFieldHolder;

            FieldSpecs = fieldSpecToFieldHolder.Keys.ToArray();
        }

        public FieldSpec[] FieldSpecs { get; }

        public int Dimension => 1;

        public static TableStore Create(params FieldSpec[] fieldSpecs)
        {
            static IField CreateField(FieldType fieldType) => fieldType switch
            {
                FieldType.Boolean => new Field<bool>(),
                FieldType.SByte => new Field<sbyte>(),
                FieldType.Short => new Field<short>(),
                FieldType.Int => new Field<int>(),
                FieldType.Long => new Field<long>(),
                FieldType.Byte => new Field<byte>(),
                FieldType.UShort => new Field<ushort>(),
                FieldType.UInt => new Field<uint>(),
                FieldType.ULong => new Field<ulong>(),
                FieldType.Float => new Field<float>(),
                FieldType.Double => new Field<double>(),
                _ => throw new NotSupportedException()
            };

            var fieldHolders = fieldSpecs.Select(fs => new FieldHolder(CreateField(fs.Type), fs)).ToArray();
            var fieldSpecToFieldHolder = fieldHolders.ToDictionary(fh => fh.FieldSpec, fh => fh);
            var fieldToFieldHolder = fieldHolders.ToDictionary(fh => fh.Field, fh => fh);
            return new TableStore(fieldSpecToFieldHolder, fieldToFieldHolder);
        }

        public IField GetField(FieldSpec fieldSpec) => fieldSpecToFieldHolder.ContainsKey(fieldSpec) ? fieldSpecToFieldHolder[fieldSpec].Field : null;

        public Joinable<T> ToJoinable<T>(Func<int, T> ctor) =>new Joinable<T>(this, (s, n) => s == this && rowTracker.Test(n) ? new T[] { ctor(n) } : new T[] { }, () => rowTracker.GetIndices().Select(i => ctor(i)));

        public void FireChanges()
        {
            IEnumerable<IField> GetFields()
            {
                var bit = 1;
                var index = 0;
                while (bit <= bitMask)
                {
                    if ((bit & bitMask) == bit)
                    {
                        var (field, _) = fieldSpecToFieldHolder[FieldSpecs[index]];
                        yield return field;
                    }
                    bit <<= 1;
                    index++;
                }
            }
            foreach (var listener in listeners)
            {
                listener(this, Op.Add, current - 1, GetFields().ToArray());
            }
        }

        public int BeginInsert()
        {
            bitMask = 0;
            var index = current++;
            rowTracker.Put(index);
            return index;
        }

        public void SetFieldValue(int index, FieldSpec fieldSpec, Variant value)
        {
            int a = Array.IndexOf(FieldSpecs, fieldSpec);
            bitMask  |= (1 << a);
            var (field, _) = fieldSpecToFieldHolder[fieldSpec];
            
        }
        public void Subscribe(TableStoreListener listener)
        {
            listeners.Add(listener);
        }

        public int GetOrdinal(TableStore table) => table == this? 0 : -1;

        public TableStore GetTableStore(IField field) => fieldToFieldHolder.ContainsKey(field) ? this : null;
    }
}

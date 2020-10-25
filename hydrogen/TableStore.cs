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
        private Dictionary<int, int> changes = new Dictionary<int, int>();
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
                FieldType.Boolean => new Field.Boolean(1024),
                FieldType.SByte => new Field.SByte(1024),
                FieldType.Short => new Field.Int16(1024),
                FieldType.Int => new Field.Int32(1024),
                FieldType.Long => new Field.Int64(1024),
                FieldType.Byte => new Field.Byte(1024),
                FieldType.UShort => new Field.UInt16(1024),
                FieldType.UInt => new Field.UInt32(1024),
                FieldType.ULong => new Field.UInt64(1024),
                FieldType.Float => new Field.Float(1024),
                FieldType.Double => new Field.Double(1024),
                FieldType.HashedSlice8 => new Field.HashedSlice8(1024),
                FieldType.HashedSlice16 => new Field.HashedSlice16(1024),
                _ => throw new NotSupportedException()
            };

            var fieldHolders = fieldSpecs.Select(fs => new FieldHolder(CreateField(fs.Type), fs)).ToArray();
            var fieldSpecToFieldHolder = fieldHolders.ToDictionary(fh => fh.FieldSpec, fh => fh);
            var fieldToFieldHolder = fieldHolders.ToDictionary(fh => fh.Field, fh => fh);
            return new TableStore(fieldSpecToFieldHolder, fieldToFieldHolder);
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
            return new Joinable<T>(this, (s, n) => s == this && rowTracker.Test(n) ? new T[] { ToArray(ctor, n) } : new T[] { }, () => rowTracker.GetIndices().Select(i => ToArray(ctor, i)));
        }

        public void Notify()
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
            
            foreach (var (index, bitMask) in changes)
            {
                foreach (var listener in listeners)
                {
                    var fields = GetFieldIds(bitMask).Select(i => GetField(FieldSpecs[i])).ToArray();
                    listener(this, bitMask == -2 ? Op.Add : Op.Update, index, fields);
                }
            }
            // Clear all the changes so far
            changes.Clear();
        }

        public Record CreateRecord(int rowNum)
        {
            if (rowNum < 0)
            {
                // Insert a new row
                var index = current++;
                rowTracker.Put(index);
                changes[index] = -1;
                return new Record(this, index, -2);
            }
            else
            {
                if (!changes.ContainsKey(rowNum))
                {
                    // mark this row as locked
                    changes[rowNum] = -1;
                    return new Record(this, rowNum, 0);
                }
                else
                {
                    if (changes[rowNum] != -1)
                    {
                        // mark this row as occupied
                        var bitMask = changes[rowNum];
                        changes[rowNum] = -1;
                        return new Record(this, rowNum, bitMask);
                    }
                    else
                    {
                        return null;
                    }
                }
                
            }
        }

        public void ReleaseRecord(Record record)
        {
            changes[record.Index] = record.BitMask;
        }

        public void Subscribe(TableStoreListener listener)
        {
            listeners.Add(listener);
        }

        public int GetOrdinal(TableStore table) => table == this? 0 : -1;

        public TableStore GetTableStore(IField field) => fieldToFieldHolder.ContainsKey(field) ? this : null;
    }
}

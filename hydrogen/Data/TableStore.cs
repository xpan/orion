using Hydrogen.Data.Indices;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.Data
{
    public class TableStore : ITable, IRowTracker
    {
        private object[] fields;
        private Dictionary<(Type, string), object> fieldSpecToField;
        private Dictionary<object, object> fieldToInvertedIndex;
        private RowTracker rowTracker = new RowTracker();
        private int current = 0;
        protected TableStore(object[] fields, Dictionary<(Type, string), object> fieldSpecToField, Dictionary<object, object> fieldToInvertedIndex)
        {
            this.fields = fields;
            this.fieldSpecToField = fieldSpecToField;
            this.fieldToInvertedIndex = fieldToInvertedIndex;
        }

        public IIndexable<T> GetField<T>(in FieldSpec<T> fieldSpec)
        {
            var key = (fieldSpec.Type, fieldSpec.Name);
            if (fieldSpecToField.ContainsKey(key))
            {
                return (IIndexable<T>)fieldSpecToField[key];
            }
            return null;
        }
        public InvertedIndex<T> GetInvertedIndex<T>(IIndexable<T> field)
        {
            if (fieldToInvertedIndex.ContainsKey(field))
            {
                return (InvertedIndex<T>)fieldToInvertedIndex[field];
            }
            return null;
        }

        public int GetFieldDimension<T>(IIndexable<T> field)
        {
            if (Array.IndexOf(fields, field) >= 0)
            {
                return 0;
            }
            return -1;
        }
        public IRowTracker GetRowTracker<T>(IIndexable<T> field)
        {
            if (Array.IndexOf(fields, field) >= 0)
            {
                return this;
            }
            return null;
        }

        public int Dimension => 1;

        public bool Contains(IRowTracker rowTracker)
        {
            return rowTracker == this;
        }

        public bool Test(int index)
        {
            return rowTracker.Test(index);
        }

        public IEnumerable<int> GetRows()
        {
            return rowTracker.Iter();
        }

        public Record Insert()
        {
            var index = current++;
            rowTracker.AddRow(index);
            return new Record(index, this);
        }

        public void SetRecord<T>(Record record, in FieldSpec<T> fieldSpec, T value)
        {
            var (index, _) = record;
            var field = GetField(fieldSpec);
            var invertedIndex = GetInvertedIndex(field);

            invertedIndex.Delete(value, index);
            field[index] = value;
            invertedIndex.Add(value, index);
        }

        public static TableStore Create<T1>(in FieldSpec<T1> fs1)
        {
            var f1 = new Field<T1>();
            var invertedIndex1 = new InvertedIndex<T1>(fs1.Comparer);

            var fields = new object[] { f1 };
            var fieldSpecToField = new Dictionary<(Type, string), object> { { (fs1.Type, fs1.Name), f1} };
            var fieldToInvertedIndex = new Dictionary<object, object> { { f1, invertedIndex1} };
            return new TableStore(fields, fieldSpecToField, fieldToInvertedIndex);
        }
        public static TableStore Create<T1, T2>(in FieldSpec<T1> fs1, in FieldSpec<T2> fs2)
        {
            var f1 = new Field<T1>();
            var invertedIndex1 = new InvertedIndex<T1>(fs1.Comparer);

            var f2 = new Field<T2>();
            var invertedIndex2 = new InvertedIndex<T2>(fs2.Comparer);

            var fields = new object[] { f1, f2 };
            var fieldSpecToField = new Dictionary<(Type, string), object> { { (fs1.Type, fs1.Name), f1 }, { (fs2.Type, fs2.Name), f2} };
            var fieldToInvertedIndex = new Dictionary<object, object> { { f1, invertedIndex1 }, { f2, invertedIndex2} };
            return new TableStore(fields, fieldSpecToField, fieldToInvertedIndex);
        }
        public static TableStore Create<T1, T2, T3>(in FieldSpec<T1> fs1, in FieldSpec<T2> fs2, in FieldSpec<T3> fs3)
        {
            var f1 = new Field<T1>();
            var invertedIndex1 = new InvertedIndex<T1>(fs1.Comparer);

            var f2 = new Field<T2>();
            var invertedIndex2 = new InvertedIndex<T2>(fs2.Comparer);

            var f3 = new Field<T3>();
            var invertedIndex3 = new InvertedIndex<T3>(fs3.Comparer);

            var fields = new object[] { f1, f2, f3 };
            var fieldSpecToField = new Dictionary<(Type, string), object> { { (fs1.Type, fs1.Name), f1 }, { (fs2.Type, fs2.Name), f2 }, { (fs3.Type, fs3.Name), f3 } };
            var fieldToInvertedIndex = new Dictionary<object, object> { { f1, invertedIndex1 }, { f2, invertedIndex2 }, { f3, invertedIndex3} };

            return new TableStore(fields, fieldSpecToField, fieldToInvertedIndex);
        }
    }
}

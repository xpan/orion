using Hydrogen.Arrays;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.Data
{
    public struct Record
    {
        private Array8 indices;
        private ITable table;
        public Record(Array8 indices, ITable table)
        {
            this.indices = indices;
            this.table = table;
        }

        internal void Deconstruct(out Array8 indices, out ITable table)
        {
            indices = this.indices;
            table = this.table;
        }

        public T GetValue<T>(IIndexable<T> field)
        {
            var dimension = table.GetFieldDimension(field);
            var index = indices[dimension];
            return field[index];
        }

        public void SetValue<T>(IIndexable<T> field, T value)
        {
            var dimension = table.GetFieldDimension(field);
            var index = indices[dimension];
            var current = field[index];
            field[index] = value;

            var invertedIndex = table.GetInvertedIndex(field);
            invertedIndex.Delete(current, index);
            invertedIndex.Add(value, index);
        }
    }
}

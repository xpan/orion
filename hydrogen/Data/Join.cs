using Hydrogen.Data.Indices;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.Data
{
    public class Join : ITable
    {
        private ITable outer;
        private ITable inner;
        public Join(ITable outer, ITable inner)
        {
            this.outer = outer;
            this.inner = inner;
        }
        public int Dimension => outer.Dimension + inner.Dimension;

        public bool Contains(ITable table)
        {
            return outer.Contains(table) || inner.Contains(table);
        }

        public IIndexable<T> GetField<T>(in FieldSpec<T> fieldSpec)
        {
            return outer.GetField(fieldSpec) ?? inner.GetField(fieldSpec);
        }

        public int GetFieldDimension<T>(IIndexable<T> field)
        {
            var dim = outer.GetFieldDimension(field);
            if (dim >= 0)
            {
                return dim;
            }
            return inner.GetFieldDimension(field) + outer.Dimension;
        }

        public InvertedIndex<T> GetInvertedIndex<T>(IIndexable<T> field)
        {
            return outer.GetInvertedIndex(field) ?? inner.GetInvertedIndex(field);
        }

        public ITable GetTable<T>(IIndexable<T> field)
        {
            return outer.GetTable(field) ?? inner.GetTable(field);
        }
    }
}

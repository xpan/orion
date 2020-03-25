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

        public bool Contains(IRowTracker rowTracker)
        {
            return outer.Contains(rowTracker) || inner.Contains(rowTracker);
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
            return inner.GetFieldDimension(field);
        }

        public InvertedIndex<T> GetInvertedIndex<T>(IIndexable<T> field)
        {
            return outer.GetInvertedIndex(field) ?? inner.GetInvertedIndex(field);
        }

        public IRowTracker GetRowTracker<T>(IIndexable<T> field)
        {
            return outer.GetRowTracker(field) ?? inner.GetRowTracker(field);
        }
    }
}

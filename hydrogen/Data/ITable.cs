using Hydrogen.Data.Indices;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.Data
{
    public interface ITable
    {
        IIndexable<T> GetField<T>(in FieldSpec<T> fieldSpec);
        InvertedIndex<T> GetInvertedIndex<T>(IIndexable<T> field);
        int GetFieldDimension<T>(IIndexable<T> field);
        IRowTracker GetRowTracker<T>(IIndexable<T> field);
        int Dimension { get; }
        bool Contains(IRowTracker rowTracker);
    }
}

using Hydrogen.Index;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hydrogen
{
    public class View<T> : IView
    {
        private List<Subscribe> callbacks = new List<Subscribe>();
        private Joinable<T> joinable;
        private InvertedIndex<T> invertedIndex;
        private Func<IEnumerable<T>, IEnumerable<T>, IEnumerable<(int, T)>> diff;
        public View(Joinable<T> jn)
        {
            Comparison<T> comparison = (x, y) =>
            {
                var dim = jn.Table.Dim;
                return dim switch
                {
                    1 => jn.Index(x, 0) - jn.Index(y, 0),
                    2 => (jn.Index(x, 0) - jn.Index(y, 0)) switch
                    {
                        > 0 => 1,
                        < 0 => -1,
                        0 => jn.Index(x, 1) - jn.Index(y, 1)
                    },
                    3 => (jn.Index(x, 0) - jn.Index(y, 0)) switch
                    {
                        > 0 => 1,
                        < 0 => -1,
                        0 => (jn.Index(x, 1) - jn.Index(y, 1)) switch
                        {
                            > 0 => 1,
                            < 0 => -1,
                            0 => jn.Index(x, 2) - jn.Index(y, 2)
                        }
                    },
                    4 => (jn.Index(x, 0) - jn.Index(y, 0)) switch
                    {
                        > 0 => 1,
                        < 0 => -1,
                        0 => (jn.Index(x, 1) - jn.Index(y, 1)) switch
                        {
                            > 0 => 1,
                            < 0 => -1,
                            0 => (jn.Index(x, 2) - jn.Index(y, 2)) switch
                            {
                                > 0 => 1,
                                < 0 => -1,
                                0 => jn.Index(x, 3) - jn.Index(y, 3)
                            }
                        }
                    },
                    _ => throw new NotSupportedException()
                };
            };
            joinable = jn;
            diff = Utils.SymmetricDiff(comparison);
            invertedIndex = new InvertedIndex<T>(comparison);
        }
        public void OnUpdate(ITable table, Op op, int index, ulong bitMask)
        {
            var ord = joinable.Table.GetOrdinal(table);
            var current = invertedIndex.GetPostings(ord, index);
            var hits = joinable.Test(table, index);
            var result = diff(current, hits).ToArray();

            foreach (var (a, b) in result)
            {
                foreach (var (factId, fact) in joinable.Facts(b))
                {
                    switch (a)
                    {
                        case 1:
                            invertedIndex.Delete(factId, fact, b);
                            break;
                        case -1:
                            invertedIndex.Add(factId, fact, b);
                            break;
                    }
                }
            }

            foreach (var (a, b) in result)
            {
                switch (a)
                {
                    case 1:
                        callbacks.ForEach(cb => cb(this, invertedIndex.Count(b) == 0 ? Op.Update : Op.Delete, invertedIndex.GetEntry(b)));
                        break;
                    case 0:
                        callbacks.ForEach(cb => cb(this, Op.Update, invertedIndex.GetEntry(b)));
                        break;
                    case -1:
                        callbacks.ForEach(cb => cb(this, invertedIndex.Count(b) == joinable.Table.Dim? Op.Add: Op.Update, invertedIndex.GetEntry(b)));
                        break;
                }
            }
        }

        public void Subscribe(Subscribe subscribe)
        {
            if (!callbacks.Contains(subscribe))
                callbacks.Add(subscribe);
        }

        public Variant GetValue(int index, int fieldId)
        {
            var fieldSpec = joinable.Table.Fields[fieldId];
            var field = joinable.Table.GetField(fieldSpec);
            var owner = joinable.Table.GetOwnerTable(fieldSpec);
            var ord = joinable.Table.GetOrdinal(owner);
            var b = invertedIndex.GetEntryValue(index);
            var rowId = joinable.Index(b, ord);
            return field[rowId];
        }
    }
}

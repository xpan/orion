using Hydrogen.Index;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hydrogen
{
    public class View<T, R> : IView where T : IEnumerator<R>
    {
        private List<Subscribe> callbacks = new List<Subscribe>();
        private Joinable<T, R> joinable;
        private InvertedIndex<R> invertedIndex;
        private Func<IEnumerable<R>, IEnumerable<R>, IEnumerable<(int, R)>> diff;
        public View(Joinable<T, R> jn)
        {
            Comparison<R> comparison = (x, y) =>
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
            invertedIndex = new InvertedIndex<R>(comparison);
        }
        public void OnUpdate(ITable table, Op op, int index, ulong bitMask)
        {
            var ord = joinable.Table.GetOrdinal(table);
            var current = invertedIndex.GetPostings(ord, index);

            T it = default;
            joinable.Test(table, index, ref it);
            while (it.MoveNext())
            {
                var v = it.Current;
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

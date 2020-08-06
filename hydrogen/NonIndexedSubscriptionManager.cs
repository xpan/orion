using Hydrogen.Arrays;
using Hydrogen.Exprs;
using Hydrogen.Exprs.Serialization;
using Hydrogen.Index;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Hydrogen
{
    public class NonIndexedSubscriptionManager<T> where T : IValueTypedArray<int>
    {
        private Dictionary<Joinable<T>, (ArrayInvertedIndex<T>, Subscribe<T>)> subscriptions = new Dictionary<Joinable<T>, (ArrayInvertedIndex<T>, Subscribe<T>)>();
        private Func<string, Joinable<T>> resolve;
        private Func<int, T> creator;
        private IComparer<T> comparer;

        public NonIndexedSubscriptionManager(Func<string, Joinable<T>> resolve, Func<int, T> creator, IComparer<T> comparer)
        {
            this.resolve = resolve;
            this.creator = creator;
            this.comparer = comparer;
        }

        public Joinable<T> Subscribe(string query, Subscribe<T> callback)
        {
            var tokens = Token.Tokenize(query).ToArray();
            var (succeed, expr, errorMessage) = Parsers.Sql()(tokens);

            Snapshot<T> EqSnapshot(Joinable<T> joinable, string name, Variant value)
            {
                var (table, _, snapshot) = joinable;

                var fieldSpec = Array.Find(table.FieldSpecs, fs => fs.Name == name);
                var field = table.GetField(fieldSpec);
                var store = table.GetTableStore(field);
                var position = table.GetOrdinal(store);

                return () => snapshot().Where(n => field[n[position]] == value);
            }

            Test<T> EqTest(Joinable<T> joinable, string name, Variant value)
            {
                var (table, test, _) = joinable;

                var fieldSpec = Array.Find(table.FieldSpecs, fs => fs.Name == name);
                var field = table.GetField(fieldSpec);
                var store = table.GetTableStore(field);
                var position = table.GetOrdinal(store);

                return (t, r) => test(t, r).Where(n => field[n[position]] == value);
            }

            Joinable<T> Join(Joinable<T> lJoinable, Joinable<T> rJoinable, FieldSpec lFieldSpec, FieldSpec rFieldSpec)
            {
                var (lTable, lTest, lSnapshot) = lJoinable;
                var (rTable, rTest, rSnapshot) = rJoinable;

                var lField = lTable.GetField(lFieldSpec);
                var lStore = lTable.GetTableStore(lField);
                var lOrdinal = lTable.GetOrdinal(lStore);

                var rField = rTable.GetField(rFieldSpec);
                var rStore = rTable.GetTableStore(rField);
                var rOrdinal = rTable.GetOrdinal(rStore);

                T JoinArray(in T l, in T r)
                {
                    var array = creator(l.Length + r.Length);
                    for (var i = 0; i < l.Length; i++)
                    {
                        array[i] = l[i];
                    }
                    for (var i = 0; i < r.Length; i++)
                    {
                        array[l.Length + i] = r[i];
                    }
                    return array;
                }

                IEnumerable<T> Snapshot()
                {
                    foreach (var l in lSnapshot())
                    {
                        foreach (var r in rSnapshot())
                        {
                            if (lField[l[lOrdinal]] == rField[r[rOrdinal]])
                            {
                                yield return JoinArray(l, r);
                            }
                        }
                    }
                }

                IEnumerable<T> Test(ITable table, int index)
                {
                    foreach (var r in rTest(table, index))
                    {
                        var va = rField[r[rOrdinal]];
                        foreach (var l in lSnapshot())
                        {
                            var vb = lField[l[lOrdinal]];
                            if (va == vb)
                            {
                                yield return JoinArray(l, r);
                            }
                        }
                    }
                    foreach (var l in lTest(table, index))
                    {
                        foreach (var r in rSnapshot())
                        {
                            if (lField[l[lOrdinal]] == rField[r[rOrdinal]])
                            {
                                yield return JoinArray(l, r);
                            }
                        }
                    }
                }
                return new Joinable<T>(new Join(lTable, rTable), Test, Snapshot);
            }

            if (!succeed)
            {
                throw new ApplicationException(errorMessage);
            }
            var visitor = new Visitor<T>(comparer, resolve, EqSnapshot, EqTest, Join);
            expr.Accept(visitor);
            var joinable = visitor.Ops.Pop();

            subscriptions[joinable] = (ArrayInvertedIndex<T>.Create(creator, comparer, joinable.Table.Dimension), callback);
            return joinable;
        }

        public TableStoreListener CreateTableStoreListener()
        {
            return (tableStore, op, index, fields) =>
            {
                foreach (var (joinable, (snapshot, callback)) in subscriptions)
                {
                    var (_, test, _) = joinable;
                    var hits = test(tableStore, index);
                    var position = joinable.Table.GetOrdinal(tableStore);
                    var current = snapshot.GetPostings(position, index);
                    var diff = current.SymmetricDiff(hits, comparer).ToArray();

                    // Update the inverted index
                    foreach (var (a, b) in diff)
                    {
                        switch (b)
                        {
                            case -1:
                                snapshot.Remove(a);
                                break;
                            case 1:
                                snapshot.Put(a);
                                break;
                        }
                    }

                    // Call back the subcribers
                    foreach (var (a, b) in diff)
                    {
                        switch (b)
                        {
                            case -1:
                                callback(joinable, Op.Delete, a, fields);
                                break;
                            case 0:
                                callback(joinable, Op.Update, a, fields);
                                break;
                            case 1:
                                callback(joinable, Op.Add, a, fields);
                                break;
                        }
                    }

                    
                }                
            };
        }
    }
}

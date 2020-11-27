using Hydrogen.Exprs.Serialization;
using Hydrogen.Index;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hydrogen
{
    public class IndexedSubscriptionManager<T> where T : IValueTypedArray<int>
    {
        private Dictionary<Joinable<T>, (ArrayInvertedIndex<T>, Subscribe<T>)> subscriptions = new Dictionary<Joinable<T>, (ArrayInvertedIndex<T>, Subscribe<T>)>();
        private Func<string, Joinable<T>> resolve;
        private Func<int, T> creator;
        private IComparer<T> comparer;
        private Func<FieldSpec, IIndex> index;

        public IndexedSubscriptionManager(Func<string, Joinable<T>> resolve, Func<int, T> creator, IComparer<T> comparer, Func<FieldSpec, IIndex> index)
        {
            this.resolve = resolve;
            this.creator = creator;
            this.comparer = comparer;
            this.index = index;
        }

        public Joinable<T> Subscribe(string query, Subscribe<T> callback)
        {
            var tokens = Token.Tokenize(query).ToArray();
            var (succeed, expr, errorMessage) = Parsers.Sql()(tokens);

            Snapshot<T> EqSnapshot(Joinable<T> joinable, string name, Variant value)
            {
                var (table, test, _) = joinable;
                var fs = Array.Find(table.Fields, f => f.Name == name);

                var field = table.GetField(fs);
                var t = table.GetTable(field);
                var invertedIndex = index(fs);

                return () => invertedIndex.GetPostings(value).SelectMany(i => test(t, i));
            }

            Test<T> EqTest(Joinable<T> joinable, string name, Variant value)
            {
                var (table, test, _) = joinable;
                var fs = Array.Find(table.Fields, f => f.Name == name);

                var field = table.GetField(fs);
                var t = table.GetTable(field);
                var ord = table.GetOrdinal(t);
                var invertedIndex = index(fs);

                return (t, n) =>
                {
                    var ord = table.GetOrdinal(t);
                    return test(t, n).Where(i => field[i[ord]] == value);
                };
            }

            Joinable<T> Join(Joinable<T> lJoinable, Joinable<T> rJoinable, FieldSpec lfs, FieldSpec rfs)
            {
                var (ltb, lt, _) = lJoinable;
                var (rtb, rt, _) = rJoinable;

                var lf = ltb.GetField(lfs);
                var rf = rtb.GetField(rfs);

                var ls = ltb.GetTable(lf);
                var rs = rtb.GetTable(rf);

                var lid = index(lfs);
                var rid = index(rfs);

                var jn = Utils.Join(creator);

                IEnumerable<T> Snapshot()
                {
                    if (lid.Count < rid.Count)
                    {
                        foreach (var v in lid.Values)
                        {
                            if (!rid.Contains(v))
                                continue;

                            foreach (var i in rid.GetPostings(v))
                                foreach (var b in rt(rs, i))
                                    foreach (var j in lid.GetPostings(v))
                                        foreach (var a in lt(ls, i))
                                            yield return jn(a, b);
                        }
                    }
                    else
                    {
                        foreach (var v in rid.Values)
                        {
                            if (!lid.Contains(v))
                                continue;

                            foreach (var i in lid.GetPostings(v))
                                foreach (var a in lt(ls, i))
                                    foreach (var j in rid.GetPostings(v))
                                        foreach (var b in rt(rs, j))
                                            yield return jn(a, b);
                        }
                    }
                }

                IEnumerable<T> Test(ITable table, int n)
                {
                    var lo = ltb.GetOrdinal(table);
                    var ro = rtb.GetOrdinal(table);

                    if (ro >= 0)
                    {
                        var v = rf[n];
                        if (!lid.Contains(v))
                            yield break;

                        foreach (var i in lid.GetPostings(v))
                            foreach (var a in lt(ls, i))
                                foreach (var b in rt(rs, n))
                                    yield return jn(a, b);
                    }
                    else
                    {
                        var v = lf[n];
                        if (!rid.Contains(v))
                            yield break;

                        foreach (var i in rid.GetPostings(v))
                            foreach (var b in rt(rs, i))
                                foreach (var a in lt(ls, n))
                                    yield return jn(a, b);
                    }
                }

                return new Joinable<T>(new Join(ltb, rtb), Test, Snapshot);
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

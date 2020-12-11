using Hydrogen.Arrays;
using Hydrogen.Exprs.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hydrogen
{
    public class IndexedSubscriptionManager
    {
        private Dictionary<IJoinable, IView> subs = new Dictionary<IJoinable, IView>();
        private Func<string, IJoinable> resolve;
        private Func<FieldSpec, IIndex> indexProvider;

        public IndexedSubscriptionManager(Func<string, IJoinable> resolve, Func<FieldSpec, IIndex> indexProvider)
        {
            this.resolve = resolve;
            this.indexProvider = indexProvider;
        }

        public IJoinable Subscribe(string txt, Subscribe subscribe)
        {
            Func<Joinable<T>, string, Variant, Joinable<T>> Eq<T>(Func<T, int, int> indexOf)
            {
                return (joinable, name, value) =>
                {
                    var fieldSpec = Array.Find(joinable.Table.Fields, f => f.Name == name);
                    var owner = joinable.Table.GetOwnerTable(fieldSpec);
                    var ordinal = joinable.Table.GetOrdinal(owner);
                    var field = joinable.Table.GetField(fieldSpec);

                    var fieldIndex = indexProvider(fieldSpec);

                    IEnumerable<T> Test(ITable table, int index)
                    {
                        foreach (var a in joinable.Test(table, index))
                            if (field[indexOf(a, ordinal)].Equals(value))
                                yield return a;
                    }
                    IEnumerable<T> It()
                    {
                        var entry = fieldIndex.GetEntry(value);
                        foreach (var i in fieldIndex.GetPostings(entry))
                            foreach (var a in joinable.Test(owner, i))
                                yield return a;
                    }
                    return new Joinable<T>(joinable.Table, Test, It, joinable.Facts, joinable.Index);
                };
            }

            Func<Joinable<T>, Joinable<U>, string, string, Joinable<R>> Join<T, U, R>(
                Func<T, U, R> join, 
                Func<R, int, int> ti,
                Func<R, T> lp,
                Func<R, U> rp)
            {
                return (l, r, ln, rn) =>
                {
                    var lfs = Array.Find(l.Table.Fields, f => f.Name == ln);
                    var rfs = Array.Find(r.Table.Fields, f => f.Name == rn);

                    var lo = l.Table.GetOwnerTable(lfs);
                    var ro = r.Table.GetOwnerTable(rfs);

                    var lord = l.Table.GetOrdinal(lo);
                    var rord = r.Table.GetOrdinal(ro);

                    var lf = l.Table.GetField(lfs);
                    var rf = r.Table.GetField(rfs);

                    var lfi = indexProvider(lfs);
                    var rfi = indexProvider(rfs);

                    IEnumerable<R> Test(ITable table, int index)
                    {
                        var lord = l.Table.GetOrdinal(table);
                        var rord = r.Table.GetOrdinal(table);

                        if (rord >= 0)
                        {
                            foreach (var b in r.Test(table, index))
                            {
                                var v = rf[r.Index(b, rord)];
                                var entry = lfi.GetEntry(v);
                                if (entry < 0)
                                    yield break;

                                foreach (var i in lfi.GetPostings(entry))
                                    foreach (var a in l.Test(lo, i))
                                            yield return join(a, b);
                            }
                        }
                        else
                        {
                            foreach (var a in l.Test(table, index))
                            {
                                var v = lf[l.Index(a, lord)];
                                var entry = rfi.GetEntry(v);
                                if (entry < 0)
                                    yield break;

                                foreach (var i in rfi.GetPostings(entry))
                                    foreach (var b in r.Test(ro, i))
                                        yield return join(a, b);
                            }                            
                        }
                    }

                    IEnumerable<R> It()
                    {
                        if (lfi.Count > rfi.Count)
                        {
                            foreach (var ri in rfi.GetEntries())
                            {
                                var v = rfi.GetEntryValue(ri);
                                var li = lfi.GetEntry(v);
                                if (li < 0)
                                    continue;

                                foreach (var a in lfi.GetPostings(li))
                                    foreach (var b in l.Test(lo, a))
                                        foreach (var c in rfi.GetPostings(ri))
                                            foreach (var d in r.Test(ro, c))
                                                yield return join(b, d);
                            }
                        }                            
                        else
                        {
                            foreach (var li in lfi.GetEntries())
                            {
                                var v = lfi.GetEntryValue(li);
                                var ri = rfi.GetEntry(v);
                                if (ri < 0)
                                    continue;

                                foreach (var a in rfi.GetPostings(ri))
                                    foreach (var b in r.Test(ro, a))
                                        foreach (var c in lfi.GetPostings(li))
                                            foreach (var d in l.Test(lo, c))
                                                yield return join(d, b);
                            }
                        }
                    }

                    IEnumerable<(int ord, int index)> Facts(R value)
                    {
                        foreach (var (ord, index) in l.Facts(lp(value)))
                            yield return (ord, index);
                        foreach (var (ord, index) in r.Facts(rp(value)))
                            yield return (ord + l.Table.Dim, index);
                    }
                    return new Joinable<R>(new Joined(l.Table, r.Table), Test, It, Facts, ti);
                };
            }

            var tokens = Token.Tokenize(txt).ToArray();
            var (succeed, expr, errorMessage) = Parsers.Sql()(tokens);

            if (!succeed)
            {
                throw new ApplicationException();
            }

            Func<Array1<int>, int, int> i1 = (a, i) => a[i];
            Func<Array2<int>, int, int> i2 = (a, i) => a[i];
            Func<Array3<int>, int, int> i3 = (a, i) => a[i];
            Func<Array4<int>, int, int> i4 = (a, i) => a[i];

            var eq1 = Eq(i1);
            var eq2 = Eq(i2);
            var eq3 = Eq(i3);
            var eq4 = Eq(i4);

            Func<IJoinable, string, Variant, IJoinable> Eqs(int dim) => dim switch
            {
                1 => (j, n, v) => eq1((Joinable<Array1<int>>)j, n, v),
                2 => (j, n, v) => eq2((Joinable<Array2<int>>)j, n, v),
                3 => (j, n, v) => eq3((Joinable<Array3<int>>)j, n, v),
                4 => (j, n, v) => eq4((Joinable<Array4<int>>)j, n, v),
                _ => throw new NotImplementedException()
            };

            Func<Array1<int>, Array1<int>, Array2<int>> j11 = (l, r) => new Array2<int> { d1 = l.d1, d2 = r.d1};
            Func<Array1<int>, Array2<int>, Array3<int>> j12 = (l, r) => new Array3<int> { d1 = l.d1, d2 = r.d1, d3 = r.d2 };
            Func<Array2<int>, Array1<int>, Array3<int>> j21 = (l, r) => new Array3<int> { d1 = l.d1, d2 = l.d2, d3 = r.d1 };
            Func<Array1<int>, Array3<int>, Array4<int>> j13 = (l, r) => new Array4<int> { d1 = l.d1, d2 = r.d1, d3 = r.d2, d4 = r.d3 };
            Func<Array2<int>, Array2<int>, Array4<int>> j22 = (l, r) => new Array4<int> { d1 = l.d1, d2 = l.d2, d3 = r.d1, d4 = r.d2 };
            Func<Array3<int>, Array1<int>, Array4<int>> j31 = (l, r) => new Array4<int> { d1 = l.d1, d2 = l.d2, d3 = l.d3, d4 = r.d1 };

            var join11 = Join(j11, i2, x => new Array1<int> { d1 = x.d1 }, x => new Array1<int> { d1 = x.d2 });
            var join12 = Join(j12, i3, x => new Array1<int> { d1 = x.d1 }, x => new Array2<int> { d1 = x.d2, d2 = x.d3 });
            var join21 = Join(j21, i3, x => new Array2<int> { d1 = x.d1, d2 = x.d2 }, x => new Array1<int> { d1 = x.d3 });
            var join13 = Join(j13, i4, x => new Array1<int> { d1 = x.d1 }, x => new Array3<int> { d1 = x.d2, d2 = x.d3, d3 = x.d4 });
            var join22 = Join(j22, i4, x => new Array2<int> { d1 = x.d1, d2 = x.d2 }, x => new Array2<int> { d1 = x.d3, d2 = x.d4 });
            var join31 = Join(j31, i4, x => new Array3<int> { d1 = x.d1, d2 = x.d2, d3 = x.d3 }, x => new Array1<int> { d1 = x.d4 });

            Func<IJoinable, IJoinable, string, string, IJoinable> Joins(int lDim, int rDim) => (lDim, rDim) switch
            {
                (1, 1) => (l, r, ln, rn) => join11((Joinable<Array1<int>>)l, (Joinable<Array1<int>>)r, ln, rn),
                (1, 2) => (l, r, ln, rn) => join12((Joinable<Array1<int>>)l, (Joinable<Array2<int>>)r, ln, rn),
                (2, 1) => (l, r, ln, rn) => join21((Joinable<Array2<int>>)l, (Joinable<Array1<int>>)r, ln, rn),
                (1, 3) => (l, r, ln, rn) => join13((Joinable<Array1<int>>)l, (Joinable<Array3<int>>)r, ln, rn),
                (2, 2) => (l, r, ln, rn) => join22((Joinable<Array2<int>>)l, (Joinable<Array2<int>>)r, ln, rn),
                (3, 1) => (l, r, ln, rn) => join31((Joinable<Array3<int>>)l, (Joinable<Array1<int>>)r, ln, rn),
                _ => throw new NotImplementedException()
            };

            var visitor = new Visitor(resolve, Eqs, Joins);
            expr.Accept(visitor);
            var joinable = visitor.Ops.Pop();
            if (!subs.ContainsKey(joinable))
            {
                subs[joinable] = joinable.View();
            }
            subs[joinable].Subscribe(subscribe);
            return joinable;
        }

        public TableListener CreateListener()
        {
            return (table, op, index, bitMask) =>
            {
                foreach (var (joinable, view) in subs)
                {
                    view.OnUpdate(table, op, index, bitMask);
                }
            };
        }
    }
}

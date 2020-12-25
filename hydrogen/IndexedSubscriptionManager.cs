using Hydrogen.Arrays;
using Hydrogen.Enumerators;
using Hydrogen.Exprs.Serialization;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hydrogen
{
    public class IndexedSubscriptionManager
    {
        public static readonly Func<Array1<int>, Array1<int>, Array2<int>> j11 = (l, r) => new Array2<int> { d1 = l.d1, d2 = r.d1 };
        public static readonly Func<Array1<int>, Array2<int>, Array3<int>> j12 = (l, r) => new Array3<int> { d1 = l.d1, d2 = r.d1, d3 = r.d2 };
        public static readonly Func<Array2<int>, Array1<int>, Array3<int>> j21 = (l, r) => new Array3<int> { d1 = l.d1, d2 = l.d2, d3 = r.d1 };
        public static readonly Func<Array1<int>, Array3<int>, Array4<int>> j13 = (l, r) => new Array4<int> { d1 = l.d1, d2 = r.d1, d3 = r.d2, d4 = r.d3 };
        public static readonly Func<Array2<int>, Array2<int>, Array4<int>> j22 = (l, r) => new Array4<int> { d1 = l.d1, d2 = l.d2, d3 = r.d1, d4 = r.d2 };
        public static readonly Func<Array3<int>, Array1<int>, Array4<int>> j31 = (l, r) => new Array4<int> { d1 = l.d1, d2 = l.d2, d3 = l.d3, d4 = r.d1 };

        public static readonly Func<Array2<int>, Array1<int>> l11 = j => new Array1<int> { d1 = j.d1 };
        public static readonly Func<Array3<int>, Array1<int>> l12 = j => new Array1<int> { d1 = j.d1 };
        public static readonly Func<Array3<int>, Array2<int>> l21 = j => new Array2<int> { d1 = j.d1, d2 = j.d2 };
        public static readonly Func<Array4<int>, Array1<int>> l13 = j => new Array1<int> { d1 = j.d1 };
        public static readonly Func<Array4<int>, Array2<int>> l22 = j => new Array2<int> { d1 = j.d1, d2 = j.d2 };
        public static readonly Func<Array4<int>, Array3<int>> l31 = j => new Array3<int> { d1 = j.d1, d2 = j.d2, d3 = j.d3 };

        public static readonly Func<Array2<int>, Array1<int>> r11 = j => new Array1<int> { d1 = j.d2 };
        public static readonly Func<Array3<int>, Array2<int>> r12 = j => new Array2<int> { d1 = j.d2, d2 = j.d3 };
        public static readonly Func<Array3<int>, Array1<int>> r21 = j => new Array1<int> { d1 = j.d3 };
        public static readonly Func<Array4<int>, Array3<int>> r13 = j => new Array3<int> { d1 = j.d2, d2 = j.d3, d3 = j.d4 };
        public static readonly Func<Array4<int>, Array2<int>> r22 = j => new Array2<int> { d1 = j.d3, d2 = j.d4 };
        public static readonly Func<Array4<int>, Array1<int>> r31 = j => new Array1<int> { d1 = j.d4 };

        private Dictionary<IJoinable, IView> subs = new Dictionary<IJoinable, IView>();
        private Func<string, IJoinable> resolve;
        private Func<FieldSpec, FieldIndex> indexProvider;

        public IndexedSubscriptionManager(Func<string, IJoinable> resolve, Func<FieldSpec, FieldIndex> indexProvider)
        {
            this.resolve = resolve;
            this.indexProvider = indexProvider;
        }

        public class JoinF<T, K> where T : IEnumerator<K>
        {
            public Joinable<T, K> joinable;
            public int ordinal;
            public ITable owner;
            public IField field;
            public FieldIndex index;
        }

        public struct Join<T, K, U, V, R> : IEnumerator<R> where T : IEnumerator<K> where U : IEnumerator<V>
        {
            public JoinF<T, K> lJoinF;
            public JoinF<U, V> rJoinF;
            internal int state;
            private R r;
            public ITable table;
            public int index;
            public T t;
            private U u;
            private FieldIndex.Values postings;
            public Func<K, V, R> join;
            
            public R Current => r;

            object IEnumerator.Current => throw new NotImplementedException();

            public void Dispose()
            {
                throw new NotImplementedException();
            }

            public bool MoveNext()
            {
                switch (state)
                {
                    case 0:
                        if (!t.MoveNext())
                            goto default;
                        var entry = rJoinF.index.GetEntry(lJoinF.field[lJoinF.joinable.Index(t.Current, lJoinF.ordinal)]);
                        if (entry < 0)
                            goto case 0;
                        rJoinF.index.GetPostings(entry, ref postings);
                        goto case 1;
                    case 1:
                        if (!postings.MoveNext())
                            goto case 0;
                        rJoinF.joinable.Test(rJoinF.owner, postings.Current, ref u);
                        goto case 2;
                    case 2:
                        if (!u.MoveNext())
                            goto case 1;
                        r = join(t.Current, u.Current);
                        state = 2;
                        return true;
                    default:
                        return false;
                }
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }
        }

        public IJoinable Subscribe(string txt, Subscribe subscribe)
        {
            Joinable<Where<T, K>, K> Eq<T, K>(Joinable<T, K> joinable, string name, Variant value) where T : IEnumerator<K>
            {
                var fieldSpec = Array.Find(joinable.Table.Fields, f => f.Name == name);
                var owner = joinable.Table.GetOwnerTable(fieldSpec);
                var field = joinable.Table.GetField(fieldSpec);
                var ord = joinable.Table.GetOrdinal(owner);

                void Test(ITable table, int index, ref Where<T, K> it)
                {
                    it.predicate = i => field[joinable.Index(i, ord)].Equals(value);
                    joinable.Test(table, index, ref it.s);
                }
                return new Joinable<Where<T, K>, K>(joinable.Table, Test, joinable.Index);
            }

            JoinF<T, K> Create<T, K>(Joinable<T, K> joinable, string name) where T : IEnumerator<K>
            {
                var fieldSpec = Array.Find(joinable.Table.Fields, f => f.Name == name);
                var owner = joinable.Table.GetOwnerTable(fieldSpec);
                var field = joinable.Table.GetField(fieldSpec);
                var ord = joinable.Table.GetOrdinal(owner);
                var index = indexProvider(fieldSpec);
                return new JoinF<T, K> { joinable = joinable, field = field, ordinal = ord, owner = owner, index = index };
            }

            Func<Joinable<T, K>, Joinable<U, V>, string, string, Joinable<Join<T, K, U, V, R>, R>> Join<T, K, U, V, R>(
                Func<K, V, R> join, 
                Func<R, K> lp,
                Func<R, V> rp) where T : IEnumerator<K> where U : IEnumerator<V>
            {
                return (l, r, ln, rn) =>
                {                    
                    var lJoinF = Create(l, ln);
                    var rJoinF = Create(r, rn);

                    void Test(ITable table, int index, ref Join<T, K, U, V, R> it)
                    {
                        it.lJoinF = lJoinF;
                        it.rJoinF = rJoinF;
                        it.table = table;
                        it.index = index;
                        it.join = join;
                        it.state = 0;
                    }

                    return new Joinable<Join<T, K, U, V, R>, R>(new Joined(l.Table, r.Table), Test, null);
                };
            }

            Func<Joinable<IEnumerator<int>, int>, string, Variant, Joinable<Where<IEnumerator<int>, int>, int>> eq = Eq;
            Func<Func<int, int, int>, Func<int, int>, Func<int, int>, Func<Joinable<IEnumerator<int>, int>, Joinable<IEnumerator<int>, int>, string, string, Joinable<Join<IEnumerator<int>, int, IEnumerator<int>, int, int>, int>>> jn = Join<IEnumerator<int>, int, IEnumerator<int>, int, int>;

            IJoinable EqDynamicInvoke(IJoinable joinable, string name, Variant value)
            {
                return (IJoinable)eq.Method
                    .GetGenericMethodDefinition()
                    .MakeGenericMethod(joinable.GetType().GetGenericArguments())
                    .Invoke(eq.Target, new object[] { joinable, name, value});
            }

            IJoinable JoinDynamicInvoke(IJoinable lJoinable, IJoinable rJoinable, string ln, string rn)
            {
                var lts = lJoinable.GetType().GetGenericArguments();
                var rts = rJoinable.GetType().GetGenericArguments();

                IJoinable DynamicInvokeHelper<K, V, R>(Func<K, V, R> j, Func<R, K> l, Func<R, V> r)
                {
                    var method = jn.Method.GetGenericMethodDefinition().MakeGenericMethod(lts.Concat(rts).Concat(new Type[] { typeof(R) }).ToArray());
                    var fn = (Delegate)method.Invoke(jn.Target, new object[] { j, l, r});
                    return (IJoinable)fn.DynamicInvoke(lJoinable, rJoinable, ln, rn);
                }

                return (lJoinable.Table.Dim, rJoinable.Table.Dim) switch
                {
                    (1, 1) => DynamicInvokeHelper(j11, l11, r11),
                    (1, 2) => DynamicInvokeHelper(j12, l12, r12),
                    (2, 1) => DynamicInvokeHelper(j21, l21, r21),
                    (1, 3) => DynamicInvokeHelper(j13, l13, r13),
                    (2, 2) => DynamicInvokeHelper(j22, l22, r22),
                    (3, 1) => DynamicInvokeHelper(j31, l31, r31),
                    _ => throw new NotSupportedException()
                };
            }

            var tokens = Token.Tokenize(txt).ToArray();
            var (succeed, expr, errorMessage) = Parsers.Sql()(tokens);

            if (!succeed)
            {
                throw new ApplicationException();
            }

            var visitor = new Visitor(resolve, EqDynamicInvoke, JoinDynamicInvoke);
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

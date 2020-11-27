using Hydrogen;
using Hydrogen.Arrays;
using Hydrogen.Index;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace HydrogenTests
{
    public class IndexedSubscriptionManagerTests
    {
        public class A
        {
            public static readonly FieldSpec a = new FieldSpec(FieldType.Int, "a");
            public static readonly FieldSpec b = new FieldSpec(FieldType.HashedSlice8, "b");
            public static readonly FieldSpec c = new FieldSpec(FieldType.Int, "c");
        }

        public class B
        {
            public static readonly FieldSpec d = new FieldSpec(FieldType.Int, "d");
            public static readonly FieldSpec e = new FieldSpec(FieldType.HashedSlice8, "e");
            public static readonly FieldSpec f = new FieldSpec(FieldType.Int, "f");
        }

        [Fact]
        public void Test_select_from_j_where_c_eq_10()
        {
            Func<int, Array4<int>> ctor = l => new Array4<int>(l);

            var s = TableStore.Create(4, A.a, A.b, A.c);
            var j = s.ToJoinable(ctor);

            Joinable<Array4<int>> Resolve(string name) => name switch
            {
                "j" => j,
                _ => throw new ApplicationException()
            };

            var ia = new FieldIndex(4);
            var ib = new FieldIndex(4);
            var ic = new FieldIndex(4);

            IIndex GetIndex(FieldSpec fs)
            {
                if (fs == A.a)
                    return ia;
                else if (fs == A.b)
                    return ib;
                else if (fs == A.c)
                    return ic;
                else
                    throw new ApplicationException();
            }

            var indexedSubscriptionManager = new IndexedSubscriptionManager<Array4<int>>(Resolve, ctor, new ArrayComparer<Array4<int>>(), GetIndex);
            var result = new List<(Op op, Array4<int> index, IEnumerable<(int fieldId, Variant v)> fields)>();
            indexedSubscriptionManager.Subscribe("select * from j where c = 10", (joinable, op, index, fields) =>
            {
                result.Add((op, index, fields.ToArray()));
            });

            void UpdateInvertedIndex(TableStore s, Op op, int index, IEnumerable<(int fieldId, Variant v)> fields)
            {
                switch (op)
                {
                    case Op.Add:
                        foreach (var (a, b) in fields)
                        {
                            switch (a)
                            {
                                case 0:
                                    ia.Put(index, b);
                                    break;
                                case 1:
                                    ib.Put(index, b);
                                    break;
                                case 2:
                                    ic.Put(index, b);
                                    break;
                            }
                        }
                        break;
                    case Op.Update:
                        break;
                    case Op.Delete:
                        break;
                }
            }

            s.Subscribe(UpdateInvertedIndex);
            s.Subscribe(indexedSubscriptionManager.CreateTableStoreListener());

            ArraySegment<byte> b = Encoding.UTF8.GetBytes("abc");
            var r = s.NewRow();
            r[A.a] = Variant.Int(1);
            r[A.b] = Variant.ByteSlice(new ByteSlice(b));
            r[A.c] = Variant.Int(10);
            s.Add(r);

            Assert.Single(result);
            Assert.Equal(Op.Add, result[0].op);
            Assert.Equal(new Array4<int>(1) { [0] = 0 }, result[0].index);
        }

        [Fact]
        public void Test_select_from_j_join_k_on_c_eq_d()
        {
            Func<int, Array4<int>> ctor = l => new Array4<int>(l);

            var s = TableStore.Create(4, A.a, A.b, A.c);
            var c = TableStore.Create(4, B.d, B.e, B.f);
            var j = s.ToJoinable(ctor);
            var k = c.ToJoinable(ctor);

            Joinable<Array4<int>> Resolve(string name) => name switch
            {
                "j" => j,
                "k" => k,
                _ => throw new ApplicationException()
            };

            var ia = new FieldIndex(4);
            var ib = new FieldIndex(4);
            var ic = new FieldIndex(4);

            var id = new FieldIndex(4);
            var ie = new FieldIndex(4);
            var ig = new FieldIndex(4);
            
            IIndex GetIndex(FieldSpec fs)
            {
                if (fs == A.a)
                    return ia;
                else if (fs == A.b)
                    return ib;
                else if (fs == A.c)
                    return ic;
                else if (fs == B.d)
                    return id;
                else if (fs == B.e)
                    return ie;
                else if (fs == B.f)
                    return ig;
                else
                    throw new ApplicationException();
            }

            var indexedSubscriptionManager = new IndexedSubscriptionManager<Array4<int>>(Resolve, ctor, new ArrayComparer<Array4<int>>(), GetIndex);

            var result = new List<(Op op, Array4<int> index, IEnumerable<(int fieldId, Variant v)> fields)>();

            void Sub(Joinable<Array4<int>> jn, Op op, Array4<int> index, IEnumerable<(int, Variant)> fields)
            {
                result.Add((op, index, fields));
            }
            
            void UpdateInvertedIndex(TableStore store, Op op, int index, IEnumerable<(int fieldId, Variant v)> fields)
            {
                switch (op)
                {
                    case Op.Add:
                        if (store == s)
                        {
                            foreach (var (a, b) in fields)
                            {
                                switch (a)
                                {
                                    case 0:
                                        ia.Put(index, b);
                                        break;
                                    case 1:
                                        ib.Put(index, b);
                                        break;
                                    case 2:
                                        ic.Put(index, b);
                                        break;
                                }
                            }
                        }
                        else if (store == c)
                        {
                            foreach (var (a, b) in fields)
                            {
                                switch (a)
                                {
                                    case 0:
                                        id.Put(index, b);
                                        break;
                                    case 1:
                                        ie.Put(index, b);
                                        break;
                                    case 2:
                                        ig.Put(index, b);
                                        break;
                                }
                            }
                        }
                        break;
                    case Op.Update:
                        break;
                    case Op.Delete:
                        break;
                }
            }

            var l = indexedSubscriptionManager.CreateTableStoreListener();

            s.Subscribe(UpdateInvertedIndex);
            c.Subscribe(UpdateInvertedIndex);
            s.Subscribe(l);
            c.Subscribe(l);

            ArraySegment<byte> b = Encoding.UTF8.GetBytes("abc");

            var r = s.NewRow();
            r[A.a] = Variant.Int(1);
            r[A.b] = Variant.ByteSlice(new ByteSlice(b));
            r[A.c] = Variant.Int(11);
            s.Add(r);

            var h = c.NewRow();
            h[B.d] = Variant.Int(11);
            h[B.e] = Variant.ByteSlice(new ByteSlice(b));
            h[B.f] = Variant.Int(9);
            c.Add(h);

            var jn = indexedSubscriptionManager.Subscribe("select* from j join k on c = d", Sub);

            foreach (var a in jn.Snapshot())
            {
                Sub(jn, Op.Add, a, null);
            }

            Assert.Single(result);
            Assert.Equal(Op.Add, result[0].op);
            Assert.Equal(new Array4<int>(2) { [0] = 0, [1] = 0 }, result[0].index);
        }
    }
}

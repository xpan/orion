using System;
using Xunit;
using Hydrogen;
using System.Collections.Generic;
using System.Linq;
using Hydrogen.Arrays;
using Hydrogen.Exprs.Serialization;
using Hydrogen.Exprs;
using Hydrogen.Index;
using System.Text;

namespace HydrogenTests
{
    public class NonIndexedSubscriptionManagerTests
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
        public void Test_select_from_j_Insert_1_row_then_notify()
        {
            Func<int, Array4<int>> ctor = l => new Array4<int>(l);

            var s = TableStore.Create(4, A.a, A.b, A.c);
            var j = s.ToJoinable(ctor);
            
            Joinable<Array4<int>> Resolve(string name) => name switch
            {
                "j" => j,
                _ => throw new ApplicationException()
            };

            var nonIndexedSubscriptionManager = new NonIndexedSubscriptionManager<Array4<int>>(Resolve, ctor, new ArrayComparer<Array4<int>>());

            var result = new List<(Op op, Array4<int> index, IEnumerable<(int fieldId, Variant v)> fields)>();

            nonIndexedSubscriptionManager.Subscribe("select* from j", (joinable, op, index, fields) =>
            {
                result.Add((op, index, fields));
            });

            s.Subscribe(nonIndexedSubscriptionManager.CreateTableStoreListener());

            ArraySegment<byte> b = Encoding.UTF8.GetBytes("abc");
            
            var r = s.NewRow();
            r[A.a] = Variant.Int(1);
            r[A.b] = Variant.ByteSlice(new ByteSlice(b));
            r[A.c] = Variant.Int(1);
            s.Add(r);

            Assert.Single(result);
            Assert.Equal(Op.Add, result[0].op);
            Assert.Equal(new Array4<int>(1) { [0] = 0 }, result[0].index);
            Assert.Equal(new [] { (0, Variant.Int(1)), (1, Variant.ByteSlice(new ByteSlice(b))), (2, Variant.Int(1)) }, result[0].fields);
        }

        [Fact]
        public void Test_select_from_students_Insert_2_rows()
        {
            Func<int, Array4<int>> ctor = l => new Array4<int>(l);

            var s = TableStore.Create(4, A.a, A.b, A.c);
            var j = s.ToJoinable(ctor);

            Joinable<Array4<int>> Resolve(string name) => name switch
            {
                "j" => j,
                _ => throw new ApplicationException()
            };

            var nonIndexedSubscriptionManager = new NonIndexedSubscriptionManager<Array4<int>>(Resolve, ctor, new ArrayComparer<Array4<int>>());

            var result = new List<(Op op, Array4<int> index, IEnumerable<(int fieldId, Variant v)> fields)>();

            nonIndexedSubscriptionManager.Subscribe("select* from j", (joinable, op, index, fields) =>
            {
                result.Add((op, index, fields.ToArray()));
            });
            s.Subscribe(nonIndexedSubscriptionManager.CreateTableStoreListener());

            ArraySegment<byte> b = Encoding.UTF8.GetBytes("abc");
            byte count = 1;

            void Insert()
            {
                var r = s.NewRow();
                r[A.a] = Variant.Int(count);
                r[A.b] = Variant.ByteSlice(new ByteSlice(b));
                r[A.c] = Variant.Int(count);
                s.Add(r);
                count++;
            }

            Insert();
            Insert();

            Assert.Equal(2, result.Count);

            Assert.Equal(Op.Add, result[0].op);
            Assert.Equal(new Array4<int>(1) { [0] = 0 }, result[0].index);
            Assert.Equal(new [] { (0, Variant.Int(1)), (1, Variant.ByteSlice(new ByteSlice(b))), (2, Variant.Int(1)) }, result[0].fields);

            Assert.Equal(Op.Add, result[1].op);
            Assert.Equal(new Array4<int>(1) { [0] = 1 }, result[1].index);
            Assert.Equal(new[] { (0, Variant.Int(2)), (1, Variant.ByteSlice(new ByteSlice(b))), (2, Variant.Int(2)) }, result[1].fields);
        }

        [Fact]
        public void Test_select_from_students_Insert_1_row_then_update()
        {
            Func<int, Array4<int>> ctor = l => new Array4<int>(l);

            var s = TableStore.Create(4, A.a, A.b, A.c);
            var j = s.ToJoinable(ctor);

            Joinable<Array4<int>> Resolve(string name) => name switch
            {
                "j" => j,
                _ => throw new ApplicationException()
            };

            var nonIndexedSubscriptionManager = new NonIndexedSubscriptionManager<Array4<int>>(Resolve, ctor, new ArrayComparer<Array4<int>>());

            var result = new List<(Op op, Array4<int> index, IEnumerable<(int fieldId, Variant v)> fields)>();

            nonIndexedSubscriptionManager.Subscribe("select* from j", (joinable, op, index, fields) =>
            {
                result.Add((op, index, fields.ToArray()));
            });
            s.Subscribe(nonIndexedSubscriptionManager.CreateTableStoreListener());

            ArraySegment<byte> b = Encoding.UTF8.GetBytes("abc");

            var r = s.NewRow();
            r[A.a] = Variant.Int(1);
            r[A.b] = Variant.ByteSlice(new ByteSlice(b));
            r[A.c] = Variant.Int(1);
            s.Add(r);

            r = s[0];
            r.BeginEdit();
            r[A.c] = Variant.Int(2);
            r.EndEdit();

            Assert.Equal(2, result.Count);
            Assert.Equal(Op.Add, result[0].op);
            Assert.Equal(new Array4<int>(1) { [0] = 0 }, result[0].index);
            Assert.Equal(new[] { (0, Variant.Int(1)), (1, Variant.ByteSlice(new ByteSlice(b))), (2, Variant.Int(1)) }, result[0].fields);

            Assert.Equal(Op.Update, result[1].op);
            Assert.Equal(new Array4<int>(1) { [0] = 0 }, result[1].index);
            Assert.Equal(new [] { (2, Variant.Int(1)) }, result[1].fields);
        }



        [Fact]
        public void Test_select_from_students_where_age_eq_10_then_add_age_eq_11_then_add_age_eq_10()
        {
            Func<int, Array4<int>> ctor = l => new Array4<int>(l);

            var s = TableStore.Create(4, A.a, A.b, A.c);
            var j = s.ToJoinable(ctor);

            Joinable<Array4<int>> Resolve(string name) => name switch
            {
                "j" => j,
                _ => throw new ApplicationException()
            };

            var nonIndexedSubscriptionManager = new NonIndexedSubscriptionManager<Array4<int>>(Resolve, ctor, new ArrayComparer<Array4<int>>());

            var result = new List<(Op op, Array4<int> index, IEnumerable<(int fieldId, Variant v)> fields)>();

            nonIndexedSubscriptionManager.Subscribe("select* from j where c = 10", (joinable, op, index, fields) =>
            {
                result.Add((op, index, fields.ToArray()));
            });
            s.Subscribe(nonIndexedSubscriptionManager.CreateTableStoreListener());

            ArraySegment<byte> b = Encoding.UTF8.GetBytes("abc");

            var r = s.NewRow();
            r[A.a] = Variant.Int(1);
            r[A.b] = Variant.ByteSlice(new ByteSlice(b));
            r[A.c] = Variant.Int(11);
            s.Add(r);

            Assert.Empty(result);

            r = s.NewRow();
            r[A.a] = Variant.Int(2);
            r[A.b] = Variant.ByteSlice(new ByteSlice(b));
            r[A.c] = Variant.Int(10);
            s.Add(r);

            Assert.Single(result);
            Assert.Equal(Op.Add, result[0].op);
            Assert.Equal(new Array4<int>(1) { [0] = 1 }, result[0].index);
            Assert.Equal(new[] { (0, Variant.Int(2)), (1, Variant.ByteSlice(new ByteSlice(b))), (2, Variant.Int(10)) }, result[0].fields);
        }

        [Fact]
        public void Test_select_from_students_where_age_eq_10_then_add_age_eq_10_then_add_age_eq_10()
        {
            Func<int, Array4<int>> ctor = l => new Array4<int>(l);

            var s = TableStore.Create(4, A.a, A.b, A.c);
            var j = s.ToJoinable(ctor);

            Joinable<Array4<int>> Resolve(string name) => name switch
            {
                "j" => j,
                _ => throw new ApplicationException()
            };

            var nonIndexedSubscriptionManager = new NonIndexedSubscriptionManager<Array4<int>>(Resolve, ctor, new ArrayComparer<Array4<int>>());

            var result = new List<(Op op, Array4<int> index, IEnumerable<(int fieldId, Variant v)> fields)>();

            nonIndexedSubscriptionManager.Subscribe("select* from j where c = 10", (joinable, op, index, fields) =>
            {
                result.Add((op, index, fields.ToArray()));
            });
            s.Subscribe(nonIndexedSubscriptionManager.CreateTableStoreListener());

            ArraySegment<byte> b = Encoding.UTF8.GetBytes("abc");

            var r = s.NewRow();
            r[A.a] = Variant.Int(1);
            r[A.b] = Variant.ByteSlice(new ByteSlice(b));
            r[A.c] = Variant.Int(10);
            s.Add(r);

            Assert.Single(result);
            Assert.Equal(Op.Add, result[0].op);
            Assert.Equal(new Array4<int>(1) { [0] = 0 }, result[0].index);
            Assert.Equal(new[] { (0, Variant.Int(1)), (1, Variant.ByteSlice(new ByteSlice(b))), (2, Variant.Int(10)) }, result[0].fields);

            r = s.NewRow();
            r[A.a] = Variant.Int(2);
            r[A.b] = Variant.ByteSlice(new ByteSlice(b));
            r[A.c] = Variant.Int(10);
            s.Add(r);

            Assert.Equal(2, result.Count);
            Assert.Equal(Op.Add, result[1].op);
            Assert.Equal(new Array4<int>(1) { [0] = 1 }, result[1].index);
            Assert.Equal(new[] { (0, Variant.Int(2)), (1, Variant.ByteSlice(new ByteSlice(b))), (2, Variant.Int(10)) }, result[1].fields);
        }

        [Fact]
        public void Test_select_from_students_where_age_eq_11_then_add_age_eq_11_then_add_age_eq_10()
        {
            Func<int, Array4<int>> ctor = l => new Array4<int>(l);

            var s = TableStore.Create(4, A.a, A.b, A.c);
            var j = s.ToJoinable(ctor);

            Joinable<Array4<int>> Resolve(string name) => name switch
            {
                "j" => j,
                _ => throw new ApplicationException()
            };

            var nonIndexedSubscriptionManager = new NonIndexedSubscriptionManager<Array4<int>>(Resolve, ctor, new ArrayComparer<Array4<int>>());

            var result = new List<(Op op, Array4<int> index, IEnumerable<(int fieldId, Variant v)> fields)>();

            nonIndexedSubscriptionManager.Subscribe("select* from j where c = 11", (joinable, op, index, fields) =>
            {
                result.Add((op, index, fields.ToArray()));
            });
            s.Subscribe(nonIndexedSubscriptionManager.CreateTableStoreListener());

            ArraySegment<byte> b = Encoding.UTF8.GetBytes("abc");

            var r = s.NewRow();
            r[A.a] = Variant.Int(1);
            r[A.b] = Variant.ByteSlice(new ByteSlice(b));
            r[A.c] = Variant.Int(11);
            s.Add(r);

            Assert.Single(result);
            Assert.Equal(Op.Add, result[0].op);
            Assert.Equal(new Array4<int>(1) { [0] = 0 }, result[0].index);
            Assert.Equal(new[] { (0, Variant.Int(1)), (1, Variant.ByteSlice(new ByteSlice(b))), (2, Variant.Int(11)) }, result[0].fields);

            r = s.NewRow();
            r[A.a] = Variant.Int(2);
            r[A.b] = Variant.ByteSlice(new ByteSlice(b));
            r[A.c] = Variant.Int(10);
            s.Add(r);

            Assert.Single(result);
        }

        [Fact]
        public void Test_select_from_students_where_age_eq_9_then_add_age_eq_11_then_add_age_eq_10()
        {
            Func<int, Array4<int>> ctor = l => new Array4<int>(l);

            var s = TableStore.Create(4, A.a, A.b, A.c);
            var j = s.ToJoinable(ctor);

            Joinable<Array4<int>> Resolve(string name) => name switch
            {
                "j" => j,
                _ => throw new ApplicationException()
            };

            var nonIndexedSubscriptionManager = new NonIndexedSubscriptionManager<Array4<int>>(Resolve, ctor, new ArrayComparer<Array4<int>>());

            var result = new List<(Op op, Array4<int> index, IEnumerable<(int fieldId, Variant v)> fields)>();

            nonIndexedSubscriptionManager.Subscribe("select* from j where c = 9", (joinable, op, index, fields) =>
            {
                result.Add((op, index, fields.ToArray()));
            });
            s.Subscribe(nonIndexedSubscriptionManager.CreateTableStoreListener());

            ArraySegment<byte> b = Encoding.UTF8.GetBytes("abc");

            var r = s.NewRow();
            r[A.a] = Variant.Int(1);
            r[A.b] = Variant.ByteSlice(new ByteSlice(b));
            r[A.c] = Variant.Int(11);
            s.Add(r);

            Assert.Empty(result);

            r = s.NewRow();
            r[A.a] = Variant.Int(2);
            r[A.b] = Variant.ByteSlice(new ByteSlice(b));
            r[A.c] = Variant.Int(10);
            s.Add(r);

            Assert.Empty(result);
        }

        [Fact]
        public void Test_select_from_students_join_courses_on_courseId_eq_id()
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

            var nonIndexedSubscriptionManager = new NonIndexedSubscriptionManager<Array4<int>>(Resolve, ctor, new ArrayComparer<Array4<int>>());

            var result = new List<(Op op, Array4<int> index, IEnumerable<(int fieldId, Variant v)> fields)>();

            nonIndexedSubscriptionManager.Subscribe("select* from j join k on c = d", (joinable, op, index, fields) =>
            {
                result.Add((op, index, fields.ToArray()));
            });

            var listener = nonIndexedSubscriptionManager.CreateTableStoreListener();
            s.Subscribe(listener);
            c.Subscribe(listener);

            ArraySegment<byte> b = Encoding.UTF8.GetBytes("abc");

            var r = s.NewRow();
            r[A.a] = Variant.Int(1);
            r[A.b] = Variant.ByteSlice(new ByteSlice(b));
            r[A.c] = Variant.Int(11);
            s.Add(r);

            Assert.Empty(result);

            r = c.NewRow();
            r[B.d] = Variant.Int(11);
            r[B.e] = Variant.ByteSlice(new ByteSlice(b));
            r[B.f] = Variant.Int(1);
            c.Add(r);

            Assert.Single(result);
            Assert.Equal(Op.Add, result[0].op);
            Assert.Equal(new Array4<int>(2) { [0] = 0, [1] = 0 }, result[0].index);
        }

        [Fact]
        public void Test_select_from_students_join_courses_on_courseId_eq_id_where_age_eq_11_then_add_age_eq_11()
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

            var nonIndexedSubscriptionManager = new NonIndexedSubscriptionManager<Array4<int>>(Resolve, ctor, new ArrayComparer<Array4<int>>());

            var result = new List<(Op op, Array4<int> index, IEnumerable<(int fieldId, Variant v)> fields)>();

            nonIndexedSubscriptionManager.Subscribe("select* from j join k on c = d where a = 1", (joinable, op, index, fields) =>
            {
                result.Add((op, index, fields.ToArray()));
            });

            var listener = nonIndexedSubscriptionManager.CreateTableStoreListener();
            s.Subscribe(listener);
            c.Subscribe(listener);

            ArraySegment<byte> b = Encoding.UTF8.GetBytes("abc");

            var r = s.NewRow();
            r[A.a] = Variant.Int(1);
            r[A.b] = Variant.ByteSlice(new ByteSlice(b));
            r[A.c] = Variant.Int(11);
            s.Add(r);

            Assert.Empty(result);

            r = c.NewRow();
            r[B.d] = Variant.Int(11);
            r[B.e] = Variant.ByteSlice(new ByteSlice(b));
            r[B.f] = Variant.Int(1);
            c.Add(r);

            Assert.Single(result);
            Assert.Equal(Op.Add, result[0].op);
            Assert.Equal(new Array4<int>(2) { [0] = 0, [1] = 0 }, result[0].index);
        }

        [Fact]
        public void Test_select_from_students_join_courses_on_courseId_eq_id_where_age_eq_10_then_add_age_eq_11()
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

            var nonIndexedSubscriptionManager = new NonIndexedSubscriptionManager<Array4<int>>(Resolve, ctor, new ArrayComparer<Array4<int>>());

            var result = new List<(Op op, Array4<int> index, IEnumerable<(int fieldId, Variant v)> fields)>();

            nonIndexedSubscriptionManager.Subscribe("select* from j join k on c = d where a = 2", (joinable, op, index, fields) =>
            {
                result.Add((op, index, fields.ToArray()));
            });

            var listener = nonIndexedSubscriptionManager.CreateTableStoreListener();
            s.Subscribe(listener);
            c.Subscribe(listener);

            ArraySegment<byte> b = Encoding.UTF8.GetBytes("abc");

            var r = s.NewRow();
            r[A.a] = Variant.Int(1);
            r[A.b] = Variant.ByteSlice(new ByteSlice(b));
            r[A.c] = Variant.Int(11);
            s.Add(r);

            Assert.Empty(result);

            r = c.NewRow();
            r[B.d] = Variant.Int(11);
            r[B.e] = Variant.ByteSlice(new ByteSlice(b));
            r[B.f] = Variant.Int(1);
            c.Add(r);

            Assert.Empty(result);
        }

        [Fact]
        public void Test_select_from_students_join_lb_select_from_courses_where_score_eq_5_rb()
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

            var nonIndexedSubscriptionManager = new NonIndexedSubscriptionManager<Array4<int>>(Resolve, ctor, new ArrayComparer<Array4<int>>());

            var result = new List<(Op op, Array4<int> index, IEnumerable<(int fieldId, Variant v)> fields)>();

            nonIndexedSubscriptionManager.Subscribe("select* from j join (select * from k where f = 1) on c = d", (joinable, op, index, fields) =>
            {
                result.Add((op, index, fields.ToArray()));
            });

            var listener = nonIndexedSubscriptionManager.CreateTableStoreListener();
            s.Subscribe(listener);
            c.Subscribe(listener);

            ArraySegment<byte> b = Encoding.UTF8.GetBytes("abc");

            var r = s.NewRow();
            r[A.a] = Variant.Int(1);
            r[A.b] = Variant.ByteSlice(new ByteSlice(b));
            r[A.c] = Variant.Int(11);
            s.Add(r);

            Assert.Empty(result);

            r = c.NewRow();
            r[B.d] = Variant.Int(11);
            r[B.e] = Variant.ByteSlice(new ByteSlice(b));
            r[B.f] = Variant.Int(1);
            c.Add(r);

            Assert.Single(result);
            Assert.Equal(Op.Add, result[0].op);
            Assert.Equal(new Array4<int>(2) { [0] = 0, [1] = 0 }, result[0].index);
        }

        [Fact]
        public void Test_select_from_students_join_lb_select_from_courses_where_score_eq_4_rb()
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

            var nonIndexedSubscriptionManager = new NonIndexedSubscriptionManager<Array4<int>>(Resolve, ctor, new ArrayComparer<Array4<int>>());

            var result = new List<(Op op, Array4<int> index, IEnumerable<(int fieldId, Variant v)> fields)>();

            nonIndexedSubscriptionManager.Subscribe("select* from j join (select * from k where f = 2) on c = d", (joinable, op, index, fields) =>
            {
                result.Add((op, index, fields.ToArray()));
            });

            var listener = nonIndexedSubscriptionManager.CreateTableStoreListener();
            s.Subscribe(listener);
            c.Subscribe(listener);

            ArraySegment<byte> b = Encoding.UTF8.GetBytes("abc");

            var r = s.NewRow();
            r[A.a] = Variant.Int(1);
            r[A.b] = Variant.ByteSlice(new ByteSlice(b));
            r[A.c] = Variant.Int(11);
            s.Add(r);

            Assert.Empty(result);

            r = c.NewRow();
            r[B.d] = Variant.Int(11);
            r[B.e] = Variant.ByteSlice(new ByteSlice(b));
            r[B.f] = Variant.Int(1);
            c.Add(r);

            Assert.Empty(result);
        }
    }
}

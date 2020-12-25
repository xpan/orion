using Hydrogen;
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
        public static class A
        {
            public static readonly FieldSpec a = new FieldSpec(FieldType.Int32, "a");
            public static readonly FieldSpec b = new FieldSpec(FieldType.Int32, "b");
            public static readonly FieldSpec c = new FieldSpec(FieldType.Int32, "c");
        }

        public static class B
        {
            public static readonly FieldSpec d = new FieldSpec(FieldType.Int32, "d");
            public static readonly FieldSpec e = new FieldSpec(FieldType.Int32, "e");
            public static readonly FieldSpec f = new FieldSpec(FieldType.Int32, "f");
        }

        [Fact]
        public void Test()
        {
            var t = TableStore.Create(4, A.a, A.b, A.c);
            var j = t.ToJoinable();

            IJoinable Resolve(string name) => name switch
            {
                "j" => j,
                _ => throw new NotSupportedException()
            };

            var fia = new FieldIndex(16);
            var fib = new FieldIndex(16);
            var fic = new FieldIndex(16);

            FieldIndex Index(FieldSpec f)
            {
                if (f == A.a)
                    return fia;
                else if (f == A.b)
                    return fib;
                else if (f == A.c)
                    return fic;
                else
                    throw new NotSupportedException();
            }
            var sub = new IndexedSubscriptionManager(Resolve, Index);
            var joinable = sub.Subscribe("select*from j", (t, op, index) =>
            {
                Console.WriteLine("hello");
            });

            void UpdateIndex(ITable table, Op op, int index, ulong bitMask)
            {
                static IEnumerable<int> GetFieldId(ulong bits)
                {
                    var n = 1ul;
                    var i = 0;
                    while (bits >= n)
                    {
                        var hit = bits & n;
                        if (hit == n)
                            yield return i;
                        n <<= 1;
                        i++;
                    }
                }

                foreach (var i in GetFieldId(bitMask))
                {
                    var fieldSpec = table.Fields[i];
                    var field = table.GetField(fieldSpec);
                    var v = field[index];
                    var fid = Index(fieldSpec);
                    switch (op)
                    {
                        case Op.Add:
                            fid.Add(index, v);
                            break;
                        case Op.Update:
                            fid.Update(index, v);
                            break;
                        case Op.Delete:
                            fid.Delete(index);
                            break;
                    }
                }
            }

            t.Subscribe((t, op, index, bitMask) => UpdateIndex(t, op, index, bitMask));
            t.Subscribe(sub.CreateListener());

            Row r = default;

            t.CreateRow(ref r);
            r[0] = Variant.Int32(1);
            r[1] = Variant.Int32(2);
            r[2] = Variant.Int32(3);
            t.ReleaseRow(r);

            t.CreateRow(ref r);
            r[0] = Variant.Int32(2);
            r[1] = Variant.Int32(4);
            r[2] = Variant.Int32(3);
            t.ReleaseRow(r);
        }
    }
}

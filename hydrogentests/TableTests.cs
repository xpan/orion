using Hydrogen.Arrays;
using Hydrogen.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace hydrogentests
{
    public class TableTests
    {
        [Fact]
        public void Test_gt5_notify()
        {
            var fsa = new FieldSpec<int>("a");
            var fsb = new FieldSpec<int>("b");

            var store = TableStore.Create(fsa, fsb);
            
            var students = Table.Create(store);
            var (_, snapshot, test) = Table.Gt(students, fsb, 5);

            var r1 = store.Insert();
            store.SetRecord(r1, fsa, 0);
            store.SetRecord(r1, fsb, 5);

            Assert.Empty(test(store, 0));
        }

        [Fact]
        public void Test_gt4_notify()
        {
            var fsa = new FieldSpec<int>("a");
            var fsb = new FieldSpec<int>("b");

            var store = TableStore.Create(fsa, fsb);

            var students = Table.Create(store);
            var (_, snapshot, test) = Table.Gt(students, fsb, 4);

            var r1 = store.Insert();
            store.SetRecord(r1, fsa, 0);
            store.SetRecord(r1, fsb, 5);

            Assert.Equal(new Array8[] { new Array8(1) { [0] = 0 } }, test(store, 0));
        }

        [Fact]
        public void Test_gt5_snapshot()
        {
            var fsa = new FieldSpec<int>("a");
            var fsb = new FieldSpec<int>("b");

            var store = TableStore.Create(fsa, fsb);

            var students = Table.Create(store);
            var (_, snapshot, test) = Table.Gt(students, fsb, 5);

            var r1 = store.Insert();
            store.SetRecord(r1, fsa, 0);
            store.SetRecord(r1, fsb, 5);

            Assert.Empty(snapshot());
        }

        [Fact]
        public void Test_gt4_snapshot()
        {
            var fsa = new FieldSpec<int>("a");
            var fsb = new FieldSpec<int>("b");

            var store = TableStore.Create(fsa, fsb);

            var students = Table.Create(store);
            var (_, snapshot, test) = Table.Gt(students, fsb, 4);

            var r1 = store.Insert();
            store.SetRecord(r1, fsa, 0);
            store.SetRecord(r1, fsb, 5);

            Assert.Equal(new Array8[] { new Array8(1) { [0] = 0 } }, snapshot());
        }

        [Fact]
        public void Test_gt4_notify_2()
        {
            var fsa = new FieldSpec<int>("a");
            var fsb = new FieldSpec<int>("b");

            var store = TableStore.Create(fsa, fsb);

            var students = Table.Create(store);
            var (_, snapshot, test) = Table.Gt(students, fsb, 4);

            var r1 = store.Insert();
            store.SetRecord(r1, fsa, 0);
            store.SetRecord(r1, fsb, 5);

            var r2 = store.Insert();
            store.SetRecord(r2, fsa, 1);
            store.SetRecord(r2, fsb, 6);

            var r3 = store.Insert();
            store.SetRecord(r3, fsa, 2);
            store.SetRecord(r3, fsb, 4);

            Assert.Equal(new Array8[] { new Array8(1) { [0] = 0 } }, test(store, 0));
            Assert.Equal(new Array8[] { new Array8(1) { [0] = 1 } }, test(store, 1));
            Assert.Empty(test(store, 2));
        }

        [Fact]
        public void Test_gt4_snapshot_2()
        {
            var fsa = new FieldSpec<int>("a");
            var fsb = new FieldSpec<int>("b");

            var store = TableStore.Create(fsa, fsb);

            var students = Table.Create(store);
            var (_, snapshot, test) = Table.Gt(students, fsb, 4);

            var r1 = store.Insert();
            store.SetRecord(r1, fsa, 0);
            store.SetRecord(r1, fsb, 5);

            var r2 = store.Insert();
            store.SetRecord(r2, fsa, 1);
            store.SetRecord(r2, fsb, 6);

            var r3 = store.Insert();
            store.SetRecord(r3, fsa, 2);
            store.SetRecord(r3, fsb, 4);

            Assert.Equal(new Array8[] { new Array8(1) { [0] = 0 }, new Array8(1) { [0] = 1 } }, snapshot());
        }

        [Fact]
        public void Test_gt4_snapshot_3()
        {
            var fsa = new FieldSpec<int>("a");
            var fsb = new FieldSpec<int>("b");

            var store1 = TableStore.Create(fsa, fsb);

            var students = Table.Create(store1);
            
            var r1 = store1.Insert();
            store1.SetRecord(r1, fsa, 0);
            store1.SetRecord(r1, fsb, 5);

            var r2 = store1.Insert();
            store1.SetRecord(r2, fsa, 1);
            store1.SetRecord(r2, fsb, 6);

            var r3 = store1.Insert();
            store1.SetRecord(r3, fsa, 2);
            store1.SetRecord(r3, fsb, 5);

            var fsc = new FieldSpec<int>("c");
            var fsd = new FieldSpec<int>("d");

            var store2 = TableStore.Create(fsc, fsd);

            var r4 = store2.Insert();
            store2.SetRecord(r4, fsc, 5);
            store2.SetRecord(r4, fsd, 2);

            var r5 = store2.Insert();
            store2.SetRecord(r5, fsc, 7);
            store2.SetRecord(r5, fsd, 3);

            var (_, snapshot, test) = Table.Join(Table.Create(store1), Table.Create(store2), fsb, fsc);

            Assert.Equal(new Array8[] { new Array8(2) { [0] = 0, [1] = 0 }, new Array8(2) { [0] = 2, [1] = 0 } }, snapshot());
        }

        [Fact]
        public void Test_gt4_test_2()
        {
            var fsa = new FieldSpec<int>("a");
            var fsb = new FieldSpec<int>("b");

            var store1 = TableStore.Create(fsa, fsb);

            var students = Table.Create(store1);

            var r1 = store1.Insert();
            store1.SetRecord(r1, fsa, 0);
            store1.SetRecord(r1, fsb, 5);

            var r2 = store1.Insert();
            store1.SetRecord(r2, fsa, 1);
            store1.SetRecord(r2, fsb, 6);

            var r3 = store1.Insert();
            store1.SetRecord(r3, fsa, 2);
            store1.SetRecord(r3, fsb, 5);

            var fsc = new FieldSpec<int>("c");
            var fsd = new FieldSpec<int>("d");

            var store2 = TableStore.Create(fsc, fsd);

            var r4 = store2.Insert();
            store2.SetRecord(r4, fsc, 5);
            store2.SetRecord(r4, fsd, 2);

            var r5 = store2.Insert();
            store2.SetRecord(r5, fsc, 7);
            store2.SetRecord(r5, fsd, 3);

            var (_, snapshot, test) = Table.Join(Table.Create(store1), Table.Create(store2), fsb, fsc);

            Assert.Equal(new Array8[] { new Array8(2) { [0] = 0, [1] = 0 }, new Array8(2) { [0] = 2, [1] = 0 } }, test(store2, 0));
        }

        [Fact]
        public void Test_gt4_test_3()
        {
            var fsa = new FieldSpec<int>("a");
            var fsb = new FieldSpec<int>("b");

            var store1 = TableStore.Create(fsa, fsb);

            var students = Table.Create(store1);

            var r1 = store1.Insert();
            store1.SetRecord(r1, fsa, 0);
            store1.SetRecord(r1, fsb, 5);

            var r2 = store1.Insert();
            store1.SetRecord(r2, fsa, 1);
            store1.SetRecord(r2, fsb, 6);

            var r3 = store1.Insert();
            store1.SetRecord(r3, fsa, 2);
            store1.SetRecord(r3, fsb, 5);

            var fsc = new FieldSpec<int>("c");
            var fsd = new FieldSpec<int>("d");

            var store2 = TableStore.Create(fsc, fsd);

            var r4 = store2.Insert();
            store2.SetRecord(r4, fsc, 5);
            store2.SetRecord(r4, fsd, 2);

            var r5 = store2.Insert();
            store2.SetRecord(r5, fsc, 7);
            store2.SetRecord(r5, fsd, 3);

            var (_, snapshot, test) = Table.Join(Table.Create(store1), Table.Create(store2), fsb, fsc);

            Assert.Empty(test(store2, 1));
        }

        [Fact]
        public void Test_gt4_test_4()
        {
            var fsa = new FieldSpec<int>("a");
            var fsb = new FieldSpec<int>("b");

            var store1 = TableStore.Create(fsa, fsb);

            var students = Table.Create(store1);

            var r1 = store1.Insert();
            store1.SetRecord(r1, fsa, 0);
            store1.SetRecord(r1, fsb, 5);

            var r2 = store1.Insert();
            store1.SetRecord(r2, fsa, 1);
            store1.SetRecord(r2, fsb, 6);

            var r3 = store1.Insert();
            store1.SetRecord(r3, fsa, 2);
            store1.SetRecord(r3, fsb, 5);

            var fsc = new FieldSpec<int>("c");
            var fsd = new FieldSpec<int>("d");

            var store2 = TableStore.Create(fsc, fsd);

            var r4 = store2.Insert();
            store2.SetRecord(r4, fsc, 5);
            store2.SetRecord(r4, fsd, 2);

            var r5 = store2.Insert();
            store2.SetRecord(r5, fsc, 7);
            store2.SetRecord(r5, fsd, 3);

            var (_, snapshot, test) = Table.Join(Table.Gt(Table.Create(store1), fsb, 5), Table.Create(store2), fsb, fsc);

            Assert.Empty(test(store2, 0));
        }
    }
}

using Hydrogen.Arrays;
using Hydrogen.Data;
using Hydrogen.Data.Exprs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace Hydrogen
{
    public class TableTests
    {
        [Fact]
        public void Test_gt5_notify()
        {
            var fsa = new FieldSpec<int>("a");
            var fsb = new FieldSpec<int>("b");

            var store = TableStore.Create(fsa, fsb);

            var fa = store.GetField(fsa);
            var fb = store.GetField(fsb);
            
            var students = Table.Create(store);
            var (_, snapshot, test) = Table.Gt(students, fsb, 5);

            var r1 = store.Insert();
            r1.SetValue(fa, 0);
            r1.SetValue(fb, 5);
            
            Assert.Empty(test(store[0]));
        }

        [Fact]
        public void Test_gt4_notify()
        {
            var fsa = new FieldSpec<int>("a");
            var fsb = new FieldSpec<int>("b");

            var store = TableStore.Create(fsa, fsb);

            var fa = store.GetField(fsa);
            var fb = store.GetField(fsb);

            var students = Table.Create(store);
            var (_, snapshot, test) = Table.Gt(students, fsb, 4);

            var r1 = store.Insert();
            r1.SetValue(fa, 0);
            r1.SetValue(fb, 5);

            Assert.Equal(new Array8[] { new Array8(1) { [0] = 0 } }, test(store[0]));
        }

        [Fact]
        public void Test_gt5_snapshot()
        {
            var fsa = new FieldSpec<int>("a");
            var fsb = new FieldSpec<int>("b");

            var store = TableStore.Create(fsa, fsb);

            var fa = store.GetField(fsa);
            var fb = store.GetField(fsb);

            var students = Table.Create(store);
            var (_, snapshot, test) = Table.Gt(students, fsb, 5);

            var r1 = store.Insert();
            r1.SetValue(fa, 0);
            r1.SetValue(fb, 5);

            Assert.Empty(snapshot());
        }

        [Fact]
        public void Test_gt4_snapshot()
        {
            var fsa = new FieldSpec<int>("a");
            var fsb = new FieldSpec<int>("b");

            var store = TableStore.Create(fsa, fsb);

            var fa = store.GetField(fsa);
            var fb = store.GetField(fsb);

            var students = Table.Create(store);
            var (_, snapshot, test) = Table.Gt(students, fsb, 4);

            var r1 = store.Insert();
            r1.SetValue(fa, 0);
            r1.SetValue(fb, 5);

            Assert.Equal(new Array8[] { new Array8(1) { [0] = 0 } }, snapshot());
        }

        [Fact]
        public void Test_gt4_notify_2()
        {
            var fsa = new FieldSpec<int>("a");
            var fsb = new FieldSpec<int>("b");

            var store = TableStore.Create(fsa, fsb);

            var fa = store.GetField(fsa);
            var fb = store.GetField(fsb);

            var students = Table.Create(store);
            var (_, snapshot, test) = Table.Gt(students, fsb, 4);

            var r1 = store.Insert();
            r1.SetValue(fa, 0);
            r1.SetValue(fb, 5);

            var r2 = store.Insert();
            r2.SetValue(fa, 1);
            r2.SetValue(fb, 6);

            var r3 = store.Insert();
            r3.SetValue(fa, 2);
            r3.SetValue(fb, 4);

            Assert.Equal(new Array8[] { new Array8(1) { [0] = 0 } }, test(store[0]));
            Assert.Equal(new Array8[] { new Array8(1) { [0] = 1 } }, test(store[1]));
            Assert.Empty(test(store[2]));
        }

        [Fact]
        public void Test_gt4_snapshot_2()
        {
            var fsa = new FieldSpec<int>("a");
            var fsb = new FieldSpec<int>("b");

            var store = TableStore.Create(fsa, fsb);

            var fa = store.GetField(fsa);
            var fb = store.GetField(fsb);

            var students = Table.Create(store);
            var (_, snapshot, test) = Table.Gt(students, fsb, 4);

            var r1 = store.Insert();
            r1.SetValue(fa, 0);
            r1.SetValue(fb, 5);

            var r2 = store.Insert();
            r2.SetValue(fa, 1);
            r2.SetValue(fb, 6);

            var r3 = store.Insert();
            r3.SetValue(fa, 2);
            r3.SetValue(fb, 4);

            Assert.Equal(new Array8[] { new Array8(1) { [0] = 0 }, new Array8(1) { [0] = 1 } }, snapshot());
        }

        [Fact]
        public void Test_gt4_snapshot_3()
        {
            var fsa = new FieldSpec<int>("a");
            var fsb = new FieldSpec<int>("b");

            var store1 = TableStore.Create(fsa, fsb);

            var students = Table.Create(store1);

            var fa = store1.GetField(fsa);
            var fb = store1.GetField(fsb);

            var r1 = store1.Insert();
            r1.SetValue(fa, 0);
            r1.SetValue(fb, 5);

            var r2 = store1.Insert();
            r2.SetValue(fa, 1);
            r2.SetValue(fb, 6);

            var r3 = store1.Insert();
            r3.SetValue(fa, 2);
            r3.SetValue(fb, 5);

            var fsc = new FieldSpec<int>("c");
            var fsd = new FieldSpec<int>("d");

            var store2 = TableStore.Create(fsc, fsd);

            var r4 = store2.Insert();

            var fc = store2.GetField(fsc);
            var fd = store2.GetField(fsd);

            r4.SetValue(fc, 5);
            r4.SetValue(fd, 2);

            var r5 = store2.Insert();
            r5.SetValue(fc, 7);
            r5.SetValue(fd, 3);

            var (_, snapshot, test) = Table.Join(Table.Create(store1), Table.Create(store2), fsb, fsc);

            Assert.Equal(new Array8[] { new Array8(2) { [0] = 0, [1] = 0 }, new Array8(2) { [0] = 2, [1] = 0 } }, snapshot());
        }

        [Fact]
        public void Test_gt4_test_2()
        {
            var fsa = new FieldSpec<int>("a");
            var fsb = new FieldSpec<int>("b");

            var store1 = TableStore.Create(fsa, fsb);

            var fa = store1.GetField(fsa);
            var fb = store1.GetField(fsb);

            var r1 = store1.Insert();
            r1.SetValue(fa, 0);
            r1.SetValue(fb, 5);

            var r2 = store1.Insert();
            r2.SetValue(fa, 1);
            r2.SetValue(fb, 6);

            var r3 = store1.Insert();
            r3.SetValue(fa, 2);
            r3.SetValue(fb, 5);

            var fsc = new FieldSpec<int>("c");
            var fsd = new FieldSpec<int>("d");

            var store2 = TableStore.Create(fsc, fsd);

            var fc = store2.GetField(fsc);
            var fd = store2.GetField(fsd);

            var r4 = store2.Insert();
            r4.SetValue(fc, 5);
            r4.SetValue(fd, 2);

            var r5 = store2.Insert();
            r5.SetValue(fc, 7);
            r5.SetValue(fd, 3);

            var (_, snapshot, test) = Table.Join(Table.Create(store1), Table.Create(store2), fsb, fsc);

            Assert.Equal(new Array8[] { new Array8(2) { [0] = 0, [1] = 0 }, new Array8(2) { [0] = 2, [1] = 0 } }, test(store2[0]));
        }

        [Fact]
        public void Test_gt4_test_3()
        {
            var fsa = new FieldSpec<int>("a");
            var fsb = new FieldSpec<int>("b");

            var store1 = TableStore.Create(fsa, fsb);

            var fa = store1.GetField(fsa);
            var fb = store1.GetField(fsb);


            var r1 = store1.Insert();
            r1.SetValue(fa, 0);
            r1.SetValue(fb, 5);

            var r2 = store1.Insert();
            r2.SetValue(fa, 1);
            r2.SetValue(fb, 6);

            var r3 = store1.Insert();
            r3.SetValue(fa, 2);
            r3.SetValue(fb, 5);

            var fsc = new FieldSpec<int>("c");
            var fsd = new FieldSpec<int>("d");

            var store2 = TableStore.Create(fsc, fsd);

            var fc = store2.GetField(fsc);
            var fd = store2.GetField(fsd);

            var r4 = store2.Insert();
            r4.SetValue(fc, 5);
            r4.SetValue(fd, 2);

            var r5 = store2.Insert();
            r5.SetValue(fc, 7);
            r5.SetValue(fd, 3);

            var (_, snapshot, test) = Table.Join(Table.Create(store1), Table.Create(store2), fsb, fsc);

            Assert.Empty(test(store2[1]));
        }

        [Fact]
        public void Test_gt4_test_4()
        {
            var fsa = new FieldSpec<int>("a");
            var fsb = new FieldSpec<int>("b");

            var store1 = TableStore.Create(fsa, fsb);

            var fa = store1.GetField(fsa);
            var fb = store1.GetField(fsb);

            var r1 = store1.Insert();
            r1.SetValue(fa, 0);
            r1.SetValue(fb, 5);

            var r2 = store1.Insert();
            r2.SetValue(fa, 1);
            r2.SetValue(fb, 6);

            var r3 = store1.Insert();
            r3.SetValue(fa, 2);
            r3.SetValue(fb, 5);

            var fsc = new FieldSpec<int>("c");
            var fsd = new FieldSpec<int>("d");

            var store2 = TableStore.Create(fsc, fsd);

            var fc = store2.GetField(fsc);
            var fd = store2.GetField(fsd);

            var r4 = store2.Insert();
            r4.SetValue(fc, 5);
            r4.SetValue(fd, 2);

            var r5 = store2.Insert();
            r5.SetValue(fc, 7);
            r5.SetValue(fd, 3);

            var (_, snapshot, test) = Table.Join(Table.Gt(Table.Create(store1), fsb, 5), Table.Create(store2), fsb, fsc);

            Assert.Empty(test(store2[0]));
        }

        [Fact]
        public void Test_b_gt_5()
        {
            var fsa = new FieldSpec<int>("a");
            var fsb = new FieldSpec<int>("b");

            var store1 = TableStore.Create(fsa, fsb);

            var fa = store1.GetField(fsa);
            var fb = store1.GetField(fsb);

            var expr = new Gt<int>(fsb, 5);
            var (_, snapshot, test) = Table.Filter(Table.Create(store1), expr);

            var r1 = store1.Insert();
            r1.SetValue(fa, 0);
            r1.SetValue(fb, 5);

            var r2 = store1.Insert();
            r2.SetValue(fa, 1);
            r2.SetValue(fb, 6);

            var r3 = store1.Insert();
            r3.SetValue(fa, 2);
            r3.SetValue(fb, 7);

            Assert.Equal(new Array8[] { new Array8(1) { [0] = 1 }, new Array8(1) { [0] = 2 } }, snapshot());
            Assert.Empty(test(store1[0]));
            Assert.Equal(new Array8[] { new Array8(1) { [0] = 1 } }, test(store1[1]));
            Assert.Equal(new Array8[] { new Array8(1) { [0] = 2 } }, test(store1[2]));
        }

        [Fact]
        public void Test_b_gt_5_and_a_lt_2()
        {
            var fsa = new FieldSpec<int>("a");
            var fsb = new FieldSpec<int>("b");

            var store1 = TableStore.Create(fsa, fsb);

            var fa = store1.GetField(fsa);
            var fb = store1.GetField(fsb);

            var expr = new And(new Gt<int>(fsb, 5), new Lt<int>(fsa, 2));
            var (_, snapshot, test) = Table.Filter(Table.Create(store1), expr);

            var r1 = store1.Insert();
            r1.SetValue(fa, 0);
            r1.SetValue(fb, 5);

            var r2 = store1.Insert();
            r2.SetValue(fa, 1);
            r2.SetValue(fb, 6);

            var r3 = store1.Insert();
            r3.SetValue(fa, 2);
            r3.SetValue(fb, 7);

            Assert.Equal(new Array8[] { new Array8(1) { [0] = 1 } }, snapshot());
            Assert.Empty(test(store1[0]));
            Assert.Equal(new Array8[] { new Array8(1) { [0] = 1 } }, test(store1[1]));
            Assert.Empty(test(store1[2]));
        }
    }
}

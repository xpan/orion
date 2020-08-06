using System;
using Xunit;
using Hydrogen;
using System.Collections.Generic;
using System.Linq;
using Hydrogen.Arrays;
using Hydrogen.Exprs.Serialization;
using Hydrogen.Exprs;
using Hydrogen.Index;

namespace HydrogenTests
{
    public class SubscriptionTests
    {
        [Fact]
        public void Test_select_from_students_Insert_1_row_then_notify()
        {
            Func<int, Array4<int>> ctor = l => new Array4<int>(l);

            var studentStore = TableStore.Create(StudentSchema.schema);
            var students = studentStore.ToJoinable(ctor);
            var courseStore = TableStore.Create(CourseSchema.schema);
            var courses = courseStore.ToJoinable(ctor);

            Joinable<Array4<int>> Resolve(string name) => name switch
            {
                "students" => students,
                "courses" => courses,
                _ => throw new ApplicationException()
            };

            var nonIndexedSubscriptionManager = new NonIndexedSubscriptionManager<Array4<int>>(Resolve, ctor, new ArrayComparer<Array4<int>>());

            var result = new List<(Op, Array4<int>, IEnumerable<IField>)>();

            nonIndexedSubscriptionManager.Subscribe("select* from students", (joinable, op, index, fields) =>
            {
                result.Add((op, index, fields));
            });

            studentStore.Subscribe(nonIndexedSubscriptionManager.CreateTableStoreListener());
            
            
            var r1 = studentStore.CreateRecord(-1);
            r1.SetValue(StudentSchema.id, Variant.Int(0));
            r1.SetValue(StudentSchema.age, Variant.Int(26));
            r1.SetValue(StudentSchema.courseId, Variant.Int(0));
            studentStore.ReleaseRecord(r1);

            studentStore.Notify();

            Assert.Single(result);
            var (op, index, fields) = result[0];
            Assert.Equal(Op.Add, op);
            Assert.Equal(new Array4<int>(1) { [0] = 0 }, index);
            Assert.Empty(fields);
        }

        [Fact]
        public void Test_select_from_students_Insert_2_rows_then_notify()
        {
            Func<int, Array4<int>> ctor = l => new Array4<int>(l);

            var studentStore = TableStore.Create(StudentSchema.schema);
            var students = studentStore.ToJoinable(ctor);
            var courseStore = TableStore.Create(CourseSchema.schema);
            var courses = courseStore.ToJoinable(ctor);

            Joinable<Array4<int>> Resolve(string name) => name switch
            {
                "students" => students,
                "courses" => courses,
                _ => throw new ApplicationException()
            };

            var nonIndexedSubscriptionManager = new NonIndexedSubscriptionManager<Array4<int>>(Resolve, ctor, new ArrayComparer<Array4<int>>());

            var result = new List<(Op, Array4<int>, IEnumerable<IField>)>();

            nonIndexedSubscriptionManager.Subscribe("select* from students", (joinable, op, index, fields) =>
            {
                result.Add((op, index, fields));
            });

            studentStore.Subscribe(nonIndexedSubscriptionManager.CreateTableStoreListener());


            var r1 = studentStore.CreateRecord(-1);
            r1.SetValue(StudentSchema.id, Variant.Int(0));
            r1.SetValue(StudentSchema.age, Variant.Int(26));
            r1.SetValue(StudentSchema.courseId, Variant.Int(0));
            studentStore.ReleaseRecord(r1);

            var r2 = studentStore.CreateRecord(-1);
            r2.SetValue(StudentSchema.id, Variant.Int(1));
            r2.SetValue(StudentSchema.age, Variant.Int(27));
            r2.SetValue(StudentSchema.courseId, Variant.Int(0));
            studentStore.ReleaseRecord(r2);

            studentStore.Notify();

            Assert.Equal(2, result.Count);

            var (op, index, fields) = result[0];
            Assert.Equal(Op.Add, op);
            Assert.Equal(new Array4<int>(1) { [0] = 0 }, index);
            Assert.Empty(fields);

            var (op2, index2, fields2) = result[1];
            Assert.Equal(Op.Add, op2);
            Assert.Equal(new Array4<int>(1) { [0] = 1 }, index2);
            Assert.Empty(fields2);
        }

        [Fact]
        public void Test_select_from_students_Insert_1_row_then_update_then_notify()
        {
            Func<int, Array4<int>> ctor = l => new Array4<int>(l);

            var studentStore = TableStore.Create(StudentSchema.schema);
            var students = studentStore.ToJoinable(ctor);
            var courseStore = TableStore.Create(CourseSchema.schema);
            var courses = courseStore.ToJoinable(ctor);

            Joinable<Array4<int>> Resolve(string name) => name switch
            {
                "students" => students,
                "courses" => courses,
                _ => throw new ApplicationException()
            };

            var nonIndexedSubscriptionManager = new NonIndexedSubscriptionManager<Array4<int>>(Resolve, ctor, new ArrayComparer<Array4<int>>());

            var result = new List<(Op, Array4<int>, IEnumerable<IField>)>();

            nonIndexedSubscriptionManager.Subscribe("select* from students", (joinable, op, index, fields) =>
            {
                result.Add((op, index, fields));
            });

            studentStore.Subscribe(nonIndexedSubscriptionManager.CreateTableStoreListener());


            var r1 = studentStore.CreateRecord(-1);
            r1.SetValue(StudentSchema.id, Variant.Int(0));
            r1.SetValue(StudentSchema.age, Variant.Int(26));
            r1.SetValue(StudentSchema.courseId, Variant.Int(0));
            studentStore.ReleaseRecord(r1);

            var r2 = studentStore.CreateRecord(0);
            r2.SetValue(StudentSchema.age, Variant.Int(27));
            r2.SetValue(StudentSchema.courseId, Variant.Int(1));
            studentStore.ReleaseRecord(r2);

            studentStore.Notify();

            Assert.Single(result);

            var (op, index, fields) = result[0];
            Assert.Equal(Op.Add, op);
            Assert.Equal(new Array4<int>(1) { [0] = 0 }, index);
            Assert.Empty(fields);
        }

        [Fact]
        public void Test_select_from_students_Insert_1_row_then_notify_then_update_then_notify()
        {
            Func<int, Array4<int>> ctor = l => new Array4<int>(l);

            var studentStore = TableStore.Create(StudentSchema.schema);
            var students = studentStore.ToJoinable(ctor);
            var courseStore = TableStore.Create(CourseSchema.schema);
            var courses = courseStore.ToJoinable(ctor);

            Joinable<Array4<int>> Resolve(string name) => name switch
            {
                "students" => students,
                "courses" => courses,
                _ => throw new ApplicationException()
            };

            var nonIndexedSubscriptionManager = new NonIndexedSubscriptionManager<Array4<int>>(Resolve, ctor, new ArrayComparer<Array4<int>>());

            var result = new List<(Op, Array4<int>, IEnumerable<IField>)>();

            nonIndexedSubscriptionManager.Subscribe("select* from students", (joinable, op, index, fields) =>
            {
                result.Add((op, index, fields));
            });

            studentStore.Subscribe(nonIndexedSubscriptionManager.CreateTableStoreListener());


            var r1 = studentStore.CreateRecord(-1);
            r1.SetValue(StudentSchema.id, Variant.Int(0));
            r1.SetValue(StudentSchema.age, Variant.Int(26));
            r1.SetValue(StudentSchema.courseId, Variant.Int(0));
            studentStore.ReleaseRecord(r1);

            studentStore.Notify();

            Assert.Single(result);

            var (op, index, fields) = result[0];
            Assert.Equal(Op.Add, op);
            Assert.Equal(new Array4<int>(1) { [0] = 0 }, index);
            Assert.Empty(fields);

            result.Clear();

            var r2 = studentStore.CreateRecord(0);
            r2.SetValue(StudentSchema.age, Variant.Int(27));
            r2.SetValue(StudentSchema.courseId, Variant.Int(1));
            studentStore.ReleaseRecord(r2);

            studentStore.Notify();

            Assert.Single(result);

            var (op2, index2, fields2) = result[0];
            Assert.Equal(Op.Update, op2);
            Assert.Equal(new Array4<int>(1) { [0] = 0 }, index2);
            Assert.Equal(new IField[] { studentStore.GetField(StudentSchema.age), studentStore.GetField(StudentSchema.courseId) }, fields2);
        }
    }
}

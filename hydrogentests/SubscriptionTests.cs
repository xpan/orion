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

            var result = new List<(Op op, Array4<int> index, IEnumerable<IField> fields)>();

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
            Assert.Equal(Op.Add, result[0].op);
            Assert.Equal(new Array4<int>(1) { [0] = 0 }, result[0].index);
            Assert.Empty(result[0].fields);
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

            var result = new List<(Op op, Array4<int> index, IEnumerable<IField> fields)>();

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

            Assert.Equal(Op.Add, result[0].op);
            Assert.Equal(new Array4<int>(1) { [0] = 0 }, result[0].index);
            Assert.Empty(result[0].fields);

            Assert.Equal(Op.Add, result[1].op);
            Assert.Equal(new Array4<int>(1) { [0] = 1 }, result[1].index);
            Assert.Empty(result[1].fields);
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

            var result = new List<(Op op, Array4<int> index, IEnumerable<IField> fields)>();

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
            Assert.Equal(Op.Add, result[0].op);
            Assert.Equal(new Array4<int>(1) { [0] = 0 }, result[0].index);
            Assert.Empty(result[0].fields);
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

            var result = new List<(Op op, Array4<int> index, IEnumerable<IField> fields)>();

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

            Assert.Equal(Op.Add, result[0].op);
            Assert.Equal(new Array4<int>(1) { [0] = 0 }, result[0].index);
            Assert.Empty(result[0].fields);

            result.Clear();

            var r2 = studentStore.CreateRecord(0);
            r2.SetValue(StudentSchema.age, Variant.Int(27));
            r2.SetValue(StudentSchema.courseId, Variant.Int(1));
            studentStore.ReleaseRecord(r2);

            studentStore.Notify();

            Assert.Single(result);

            Assert.Equal(Op.Update, result[0].op);
            Assert.Equal(new Array4<int>(1) { [0] = 0 }, result[0].index);
            Assert.Equal(new IField[] { studentStore.GetField(StudentSchema.age), studentStore.GetField(StudentSchema.courseId) }, result[0].fields);
        }

        [Fact]
        public void Test_select_from_students_where_age_eq_10_then_add_age_eq_11_then_add_age_eq_10()
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

            var result = new List<(Op op, Array4<int> index, IEnumerable<IField> fields)>();

            nonIndexedSubscriptionManager.Subscribe("select* from students where age = 10", (joinable, op, index, fields) =>
            {
                result.Add((op, index, fields));
            });

            studentStore.Subscribe(nonIndexedSubscriptionManager.CreateTableStoreListener());

            var r1 = studentStore.CreateRecord(-1);
            r1.SetValue(StudentSchema.id, Variant.Int(0));
            r1.SetValue(StudentSchema.age, Variant.Int(11));
            r1.SetValue(StudentSchema.courseId, Variant.Int(0));
            studentStore.ReleaseRecord(r1);

            var r2 = studentStore.CreateRecord(-1);
            r2.SetValue(StudentSchema.id, Variant.Int(1));
            r2.SetValue(StudentSchema.age, Variant.Int(10));
            r2.SetValue(StudentSchema.courseId, Variant.Int(0));
            studentStore.ReleaseRecord(r2);

            studentStore.Notify();

            Assert.Single(result);
            Assert.Equal(Op.Add, result[0].op);
            Assert.Equal(new Array4<int>(1) { [0] = 1 }, result[0].index);
            Assert.Empty(result[0].fields);
        }

        [Fact]
        public void Test_select_from_students_where_age_eq_10_then_add_age_eq_10_then_add_age_eq_10()
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

            var result = new List<(Op op, Array4<int> index, IEnumerable<IField> fields)>();

            nonIndexedSubscriptionManager.Subscribe("select* from students where age = 10", (joinable, op, index, fields) =>
            {
                result.Add((op, index, fields));
            });

            studentStore.Subscribe(nonIndexedSubscriptionManager.CreateTableStoreListener());

            var r1 = studentStore.CreateRecord(-1);
            r1.SetValue(StudentSchema.id, Variant.Int(0));
            r1.SetValue(StudentSchema.age, Variant.Int(10));
            r1.SetValue(StudentSchema.courseId, Variant.Int(0));
            studentStore.ReleaseRecord(r1);

            var r2 = studentStore.CreateRecord(-1);
            r2.SetValue(StudentSchema.id, Variant.Int(1));
            r2.SetValue(StudentSchema.age, Variant.Int(10));
            r2.SetValue(StudentSchema.courseId, Variant.Int(0));
            studentStore.ReleaseRecord(r2);

            studentStore.Notify();

            Assert.Equal(2, result.Count);
            Assert.Equal(Op.Add, result[0].op);
            Assert.Equal(new Array4<int>(1) { [0] = 0 }, result[0].index);
            Assert.Empty(result[0].fields);
            Assert.Equal(Op.Add, result[1].op);
            Assert.Equal(new Array4<int>(1) { [0] = 1 }, result[1].index);
            Assert.Empty(result[1].fields);
        }

        [Fact]
        public void Test_select_from_students_where_age_eq_11_then_add_age_eq_11_then_add_age_eq_10()
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

            var result = new List<(Op op, Array4<int> index, IEnumerable<IField> fields)>();

            nonIndexedSubscriptionManager.Subscribe("select* from students where age = 11", (joinable, op, index, fields) =>
            {
                result.Add((op, index, fields));
            });

            studentStore.Subscribe(nonIndexedSubscriptionManager.CreateTableStoreListener());

            var r1 = studentStore.CreateRecord(-1);
            r1.SetValue(StudentSchema.id, Variant.Int(0));
            r1.SetValue(StudentSchema.age, Variant.Int(11));
            r1.SetValue(StudentSchema.courseId, Variant.Int(0));
            studentStore.ReleaseRecord(r1);

            var r2 = studentStore.CreateRecord(-1);
            r2.SetValue(StudentSchema.id, Variant.Int(1));
            r2.SetValue(StudentSchema.age, Variant.Int(10));
            r2.SetValue(StudentSchema.courseId, Variant.Int(0));
            studentStore.ReleaseRecord(r2);

            studentStore.Notify();

            Assert.Single(result);
            Assert.Equal(Op.Add, result[0].op);
            Assert.Equal(new Array4<int>(1) { [0] = 0 }, result[0].index);
            Assert.Empty(result[0].fields);
        }

        [Fact]
        public void Test_select_from_students_where_age_eq_9_then_add_age_eq_11_then_add_age_eq_10()
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

            var result = new List<(Op op, Array4<int> index, IEnumerable<IField> fields)>();

            nonIndexedSubscriptionManager.Subscribe("select* from students where age = 9", (joinable, op, index, fields) =>
            {
                result.Add((op, index, fields));
            });

            studentStore.Subscribe(nonIndexedSubscriptionManager.CreateTableStoreListener());

            var r1 = studentStore.CreateRecord(-1);
            r1.SetValue(StudentSchema.id, Variant.Int(0));
            r1.SetValue(StudentSchema.age, Variant.Int(11));
            r1.SetValue(StudentSchema.courseId, Variant.Int(0));
            studentStore.ReleaseRecord(r1);

            var r2 = studentStore.CreateRecord(-1);
            r2.SetValue(StudentSchema.id, Variant.Int(1));
            r2.SetValue(StudentSchema.age, Variant.Int(10));
            r2.SetValue(StudentSchema.courseId, Variant.Int(0));
            studentStore.ReleaseRecord(r2);

            studentStore.Notify();

            Assert.Empty(result);
        }

        [Fact]
        public void Test_select_from_students_join_courses_on_courseId_eq_id()
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

            var result = new List<(Op op, Array4<int> index, IEnumerable<IField> fields)>();

            nonIndexedSubscriptionManager.Subscribe("select* from students join courses on courseId = id", (joinable, op, index, fields) =>
            {
                result.Add((op, index, fields));
            });

            var listener = nonIndexedSubscriptionManager.CreateTableStoreListener();
            studentStore.Subscribe(listener);
            courseStore.Subscribe(listener);

            var r1 = studentStore.CreateRecord(-1);
            r1.SetValue(StudentSchema.id, Variant.Int(0));
            r1.SetValue(StudentSchema.age, Variant.Int(11));
            r1.SetValue(StudentSchema.courseId, Variant.Int(0));
            studentStore.ReleaseRecord(r1);

            studentStore.Notify();

            Assert.Empty(result);

            var r2 = courseStore.CreateRecord(-1);
            r2.SetValue(CourseSchema.id, Variant.Int(0));
            r2.SetValue(CourseSchema.score, Variant.Int(5));
            courseStore.ReleaseRecord(r2);

            courseStore.Notify();

            Assert.Single(result);
            Assert.Equal(Op.Add, result[0].op);
            Assert.Equal(new Array4<int>(2) { [0] = 0, [1] = 0 }, result[0].index);
            Assert.Empty(result[0].fields);
        }

        [Fact]
        public void Test_select_from_students_join_courses_on_courseId_eq_id_where_age_eq_11_then_add_age_eq_11()
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

            var result = new List<(Op op, Array4<int> index, IEnumerable<IField> fields)>();

            nonIndexedSubscriptionManager.Subscribe("select* from students join courses on courseId = id where age = 11", (joinable, op, index, fields) =>
            {
                result.Add((op, index, fields));
            });

            var listener = nonIndexedSubscriptionManager.CreateTableStoreListener();
            studentStore.Subscribe(listener);
            courseStore.Subscribe(listener);

            var r1 = studentStore.CreateRecord(-1);
            r1.SetValue(StudentSchema.id, Variant.Int(0));
            r1.SetValue(StudentSchema.age, Variant.Int(11));
            r1.SetValue(StudentSchema.courseId, Variant.Int(0));
            studentStore.ReleaseRecord(r1);

            studentStore.Notify();

            Assert.Empty(result);

            var r2 = courseStore.CreateRecord(-1);
            r2.SetValue(CourseSchema.id, Variant.Int(0));
            r2.SetValue(CourseSchema.score, Variant.Int(5));
            courseStore.ReleaseRecord(r2);

            courseStore.Notify();

            Assert.Single(result);
            Assert.Equal(Op.Add, result[0].op);
            Assert.Equal(new Array4<int>(2) { [0] = 0, [1] = 0 }, result[0].index);
            Assert.Empty(result[0].fields);
        }

        [Fact]
        public void Test_select_from_students_join_courses_on_courseId_eq_id_where_age_eq_10_then_add_age_eq_11()
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

            var result = new List<(Op op, Array4<int> index, IEnumerable<IField> fields)>();

            nonIndexedSubscriptionManager.Subscribe("select* from students join courses on courseId = id where age = 11", (joinable, op, index, fields) =>
            {
                result.Add((op, index, fields));
            });

            var listener = nonIndexedSubscriptionManager.CreateTableStoreListener();
            studentStore.Subscribe(listener);
            courseStore.Subscribe(listener);

            var r1 = studentStore.CreateRecord(-1);
            r1.SetValue(StudentSchema.id, Variant.Int(0));
            r1.SetValue(StudentSchema.age, Variant.Int(10));
            r1.SetValue(StudentSchema.courseId, Variant.Int(0));
            studentStore.ReleaseRecord(r1);

            studentStore.Notify();

            Assert.Empty(result);

            var r2 = courseStore.CreateRecord(-1);
            r2.SetValue(CourseSchema.id, Variant.Int(0));
            r2.SetValue(CourseSchema.score, Variant.Int(5));
            courseStore.ReleaseRecord(r2);

            courseStore.Notify();

            Assert.Empty(result);
        }

        [Fact]
        public void Test_select_from_students_join_lb_select_from_courses_where_score_eq_5_rb()
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

            var result = new List<(Op op, Array4<int> index, IEnumerable<IField> fields)>();

            nonIndexedSubscriptionManager.Subscribe("select* from students join (select* from courses where score = 5) on courseId = id", (joinable, op, index, fields) =>
            {
                result.Add((op, index, fields));
            });

            var listener = nonIndexedSubscriptionManager.CreateTableStoreListener();
            studentStore.Subscribe(listener);
            courseStore.Subscribe(listener);

            var r1 = studentStore.CreateRecord(-1);
            r1.SetValue(StudentSchema.id, Variant.Int(0));
            r1.SetValue(StudentSchema.age, Variant.Int(10));
            r1.SetValue(StudentSchema.courseId, Variant.Int(0));
            studentStore.ReleaseRecord(r1);

            studentStore.Notify();

            Assert.Empty(result);

            var r2 = courseStore.CreateRecord(-1);
            r2.SetValue(CourseSchema.id, Variant.Int(0));
            r2.SetValue(CourseSchema.score, Variant.Int(5));
            courseStore.ReleaseRecord(r2);

            courseStore.Notify();

            Assert.Single(result);
            Assert.Equal(Op.Add, result[0].op);
            Assert.Equal(new Array4<int>(2) { [0] = 0, [1] = 0 }, result[0].index);
            Assert.Empty(result[0].fields);
        }

        [Fact]
        public void Test_select_from_students_join_lb_select_from_courses_where_score_eq_4_rb()
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

            var result = new List<(Op op, Array4<int> index, IEnumerable<IField> fields)>();

            nonIndexedSubscriptionManager.Subscribe("select* from students join (select* from courses where score = 4) on courseId = id", (joinable, op, index, fields) =>
            {
                result.Add((op, index, fields));
            });

            var listener = nonIndexedSubscriptionManager.CreateTableStoreListener();
            studentStore.Subscribe(listener);
            courseStore.Subscribe(listener);

            var r1 = studentStore.CreateRecord(-1);
            r1.SetValue(StudentSchema.id, Variant.Int(0));
            r1.SetValue(StudentSchema.age, Variant.Int(10));
            r1.SetValue(StudentSchema.courseId, Variant.Int(0));
            studentStore.ReleaseRecord(r1);

            studentStore.Notify();

            Assert.Empty(result);

            var r2 = courseStore.CreateRecord(-1);
            r2.SetValue(CourseSchema.id, Variant.Int(0));
            r2.SetValue(CourseSchema.score, Variant.Int(5));
            courseStore.ReleaseRecord(r2);

            courseStore.Notify();

            Assert.Empty(result);
        }
    }
}

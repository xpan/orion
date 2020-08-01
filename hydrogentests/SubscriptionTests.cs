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
        public void Test()
        {
            var studentStore = TableStore.Create(StudentSchema.schema);
            var students = studentStore.ToJoinable(n => new Array4<int>(1) { [0] = n });
            var courseStore = TableStore.Create(CourseSchema.schema);
            var courses = courseStore.ToJoinable(n => new Array4<int>(1) { [0] = n });

            Joinable<Array4<int>> Resolve(string name) => name switch
            {
                "students" => students,
                "courses" => courses,
                _ => throw new ApplicationException()
            };

            var nonIndexedSubscriptionManager = new NonIndexedSubscriptionManager<Array4<int>>(Resolve, n => new Array4<int>(n), new ArrayComparer<Array4<int>>());
            var details = nonIndexedSubscriptionManager.Subscribe("select* from students join courses on courseId = id", (joinable, op, index, fields) =>
            {
                Console.WriteLine("hello");
            });

            studentStore.Subscribe(nonIndexedSubscriptionManager.CreateTableStoreListener());
            var index = studentStore.BeginInsert();
            studentStore.SetFieldValue(index, StudentSchema.id, Variant.Int(0));
            studentStore.SetFieldValue(index, StudentSchema.age, Variant.Int(26));
            studentStore.SetFieldValue(index, StudentSchema.courseId, Variant.Int(0));
            studentStore.FireChanges();
            
        }
    }
}

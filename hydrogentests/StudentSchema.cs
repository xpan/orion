using Hydrogen;
using System;
using System.Collections.Generic;
using System.Text;

namespace HydrogenTests
{
    public static class StudentSchema
    {
        public static readonly FieldSpec id = new FieldSpec(FieldType.Int, "id");
        public static readonly FieldSpec age = new FieldSpec(FieldType.Int, "age");
        public static readonly FieldSpec courseId = new FieldSpec(FieldType.Int, "courseId");
        public static readonly FieldSpec[] schema = new FieldSpec[] { id, age, courseId };
    }
}

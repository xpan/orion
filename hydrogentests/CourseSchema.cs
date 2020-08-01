using Hydrogen;
using System;
using System.Collections.Generic;
using System.Text;

namespace HydrogenTests
{
    public static class CourseSchema
    {
        public static readonly FieldSpec id = new FieldSpec(FieldType.Int, "id");
        public static readonly FieldSpec score = new FieldSpec(FieldType.Int, "score");
        public static readonly FieldSpec[] schema = new FieldSpec[] { id, score };
    }
}

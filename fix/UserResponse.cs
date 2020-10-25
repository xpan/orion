using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class UserResponse
    {
        public static readonly FieldSpec UserRequestID = new FieldSpec(FieldType.HashedSlice8, "UserRequestID");
        public static readonly FieldSpec Username = new FieldSpec(FieldType.HashedSlice8, "Username");
        public static readonly FieldSpec UserStatus = new FieldSpec(FieldType.Int, "UserStatus");
        public static readonly FieldSpec UserStatusText = new FieldSpec(FieldType.HashedSlice8, "UserStatusText");
        public static readonly FieldSpec[] Schema = new FieldSpec[]
        {
            UserRequestID,
            Username,
            UserStatus,
            UserStatusText,
        };
        public static FieldSpec GetFieldSpec(int tag)
        {
            return tag switch
            {
                923 => UserRequestID,
                553 => Username,
                926 => UserStatus,
                927 => UserStatusText,
                _ => throw new ArgumentException($"Invalid tag value {tag}")
            };
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.FIX
{
    public class UserRequest
    {
        public static readonly FieldSpec UserRequestID = new FieldSpec(FieldType.HashedSlice8, "UserRequestID");
        public static readonly FieldSpec UserRequestType = new FieldSpec(FieldType.Int, "UserRequestType");
        public static readonly FieldSpec Username = new FieldSpec(FieldType.HashedSlice8, "Username");
        public static readonly FieldSpec Password = new FieldSpec(FieldType.HashedSlice8, "Password");
        public static readonly FieldSpec NewPassword = new FieldSpec(FieldType.HashedSlice8, "NewPassword");
        public static readonly FieldSpec RawDataLength = new FieldSpec(FieldType.Int, "RawDataLength");
        public static readonly FieldSpec RawData = new FieldSpec(FieldType.HashedSlice8, "RawData");
        public static readonly FieldSpec[] Schema = new FieldSpec[]
        {
            UserRequestID,
            UserRequestType,
            Username,
            Password,
            NewPassword,
            RawDataLength,
            RawData,
        };
        public static FieldSpec GetFieldSpec(int tag)
        {
            return tag switch
            {
                923 => UserRequestID,
                924 => UserRequestType,
                553 => Username,
                554 => Password,
                925 => NewPassword,
                95 => RawDataLength,
                96 => RawData,
                _ => throw new ArgumentException($"Invalid tag value {tag}")
            };
        }
    }
}

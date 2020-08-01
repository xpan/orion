using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.Exprs.Serialization
{
    public class ParseResult<T>
    {
        public ParseResult(T result, ArraySegment<Token> remaining)
        {
            Succeed = true;
            Result = result;
            Remaining = remaining;
        }
        public ParseResult(string errorMessage)
        {
            Succeed = false;
            ErrorMessage = errorMessage;
        }
        public T Result { get; }
        public bool Succeed { get; }
        public ArraySegment<Token> Remaining { get; }
        public string ErrorMessage { get; }

        public void Deconstruct(out bool succeed, out T value, out string errorMessage)
        {
            succeed = Succeed;
            value = Result;
            errorMessage = ErrorMessage;
        }
    }
}

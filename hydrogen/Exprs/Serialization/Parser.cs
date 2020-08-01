using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.Exprs.Serialization
{
    public static class Parser
    {
        public static Parse<T> Where<T>(this Parse<T> p, Func<T, bool> test)
        {
            return input =>
            {
                var parseResult = p(input);
                if (parseResult.Succeed && test(parseResult.Result))
                    return parseResult;
                else
                    return new ParseResult<T>(parseResult.ErrorMessage);
            };
        }

        public static Parse<R> Select<T, R>(this Parse<T> p, Func<T, R> select)
        {
            return input =>
            {
                var parseResult = p(input);
                if (parseResult.Succeed)
                    return new ParseResult<R>(select(parseResult.Result), parseResult.Remaining);
                else
                    return new ParseResult<R>(parseResult.ErrorMessage);
            };
        }

        public static Parse<U> SelectMany<T, R, U>(this Parse<T> p,
            Func<T, Parse<R>> map,
            Func<T, R, U> project)
        {
            return input =>
            {
                var pr1 = p(input);
                if (pr1.Succeed)
                {
                    var p2 = map(pr1.Result);
                    var pr2 = p2(pr1.Remaining);
                    if (pr2.Succeed)
                    {
                        return new ParseResult<U>(project(pr1.Result, pr2.Result), pr2.Remaining);
                    }
                    return new ParseResult<U>(pr2.ErrorMessage);
                }
                return new ParseResult<U>(pr1.ErrorMessage);
            };
        }

        public static Parse<T[]> Many<T>(this Parse<T> p)
        {
            return input =>
            {
                var list = new List<T>();
                var remaining = input;
                while (true)
                {
                    var pr = p(remaining);
                    if (!pr.Succeed)
                        break;
                    remaining = pr.Remaining;
                    list.Add(pr.Result);
                }          
                return new ParseResult<T[]>(list.ToArray(), remaining);              
            };
        }

        public static Parse<T> Or<T>(this Parse<T> p1, Parse<T> p2)
        {
            return input =>
            {
                var pr1 = p1(input);
                if (pr1.Succeed)
                    return pr1;
                else
                    return p2(input);
            };
        }

        public static Parse<T[]> Optional<T>(this Parse<T> p)
        {
            return input =>
            {
                var list = new List<T>();
                var remaining = input;
                var pr = p(remaining);
                if (!pr.Succeed)
                    return new ParseResult<T[]>(new T[] { }, input);
                else
                    return new ParseResult<T[]>(new T[] { pr.Result }, pr.Remaining);
            };
        }
    }
}

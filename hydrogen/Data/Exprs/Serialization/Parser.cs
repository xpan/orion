using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.Data.Exprs.Serialization
{
    public static class Parser
    {
        public static Parse<T> Where<T>(this Parse<T> p, Func<T, bool> test)
        {
            return input =>
            {
                var parseResult = p(input);
                if (parseResult.succeeded && test(parseResult.result))
                    return parseResult;
                else
                    return (parseResult.result, false, input);
            };
        }

        public static Parse<R> Select<T, R>(this Parse<T> p, Func<T, R> select)
        {
            return input =>
            {
                var parseResult = p(input);
                if (parseResult.succeeded)
                    return (select(parseResult.result), true, parseResult.remaining);
                else
                    return (default, false, input);
            };
        }

        public static Parse<U> SelectMany<T, R, U>(this Parse<T> p,
            Func<T, Parse<R>> map,
            Func<T, R, U> project)
        {
            return input =>
            {
                var pr1 = p(input);
                if (pr1.succeeded)
                {
                    var p2 = map(pr1.result);
                    var pr2 = p2(pr1.remaining);
                    if (pr2.succeeded)
                    {
                        return (project(pr1.result, pr2.result), true, pr2.remaining);
                    }
                }
                return (default, false, input);
            };
        }

        public static Parse<R> Bind<T, R>(this Parse<T> p, Func<T, Parse<R>> map)
        {
            return input =>
            {
                var pr1 = p(input);
                if (pr1.succeeded)
                {
                    return map(pr1.result)(pr1.remaining);
                }
                return (default, false, input);
            };
        }

        public static Parse<T> Unit<T>(T value) => input => (value, true, input);

        public static Parse<T> Or<T>(this Parse<T> p1, Parse<T> p2)
        {
            return input =>
            {
                var pr1 = p1(input);
                if (pr1.succeeded)
                    return pr1;
                else
                    return p2(input);
            };
        }

        public static Parse<T[]> Many<T>(this Parse<T> p)
        {
            return input =>
            {
                var lst = new List<T>();
                var remaining = input;
                while (true)
                {
                    var pr = p(input);
                    if (!pr.succeeded)
                        break;
                    remaining = pr.remaining;
                    lst.Add(pr.result);
                }
                return (lst.ToArray(), true, remaining);
            };
        }
    }
}

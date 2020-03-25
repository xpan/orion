using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Hydrogen.Data.Indices;

namespace Hydrogen.Data.Exprs.Serialization
{
    public class Parsers
    {
        public static readonly Parse<Token> OneToken = input => input.Count > 0 ? (input[0], true, input.Slice(1)) : (default, false, input);
        public static readonly Parse<TokenType> co = from t in OneToken
                                                 where t.tokenType == TokenType.Comma
                                                 select TokenType.Comma;
        public static readonly Parse<string> symbol = from t in OneToken
                                                      select t.ToString();
        public static readonly Parse<TokenType> lb = from t in OneToken
                                                 where t.tokenType == TokenType.Lb
                                                 select TokenType.Lb;
        public static readonly Parse<TokenType> rb = from t in OneToken
                                                 where t.tokenType == TokenType.Rb
                                                 select TokenType.Rb;
        public static readonly Parse<Token> ap = from t in OneToken
                                                 where t.length == 1 && t.s[t.start] == '`'
                                                 select t;
        public static readonly Parse<TokenType> lt = from t in OneToken
                                                   where t.tokenType == TokenType.Lt
                                                   select TokenType.Lt;
        public static readonly Parse<TokenType> gt = from t in OneToken
                                                  where t.tokenType == TokenType.Gt
                                                   select TokenType.Gt;
        public static readonly Parse<TokenType> eq = from t in OneToken
                                                   where t.tokenType == TokenType.Eq
                                                   select TokenType.Eq;
        public static readonly Parse<Token> sc = from t in OneToken
                                                 where t.length == 1 && t.s[t.start] == ';'
                                                 select t;
        public static readonly Parse<TokenType> and = from t in OneToken
                                                    where t.tokenType == TokenType.And
                                                    select TokenType.And;
        public static readonly Parse<TokenType> or = from t in OneToken
                                                   where t.tokenType == TokenType.Or
                                                   select TokenType.Or;
        public static readonly Parse<Expr> bn = from op in gt.Or(eq).Or(lt)
                                                 from _1 in co
                                                 from fn in symbol
                                                 from _2 in co
                                                 from v in OneToken
                                                 select CreateBinary(op, fn, v);
        public static readonly Parse<Expr> log = from op in and.Or(or)
                                                 from _1 in lb
                                                 from l in expr
                                                 from _2 in rb
                                                 from _3 in lb
                                                 from r in expr
                                                 from _4 in rb
                                                 select Binary(op, l, r);
        public static readonly Parse<Expr> expr = log.Or(bn);
        public static Expr CreateBinary(TokenType op, string n, Token stringnified)
        {
            ArraySegment<char> s = stringnified;
            
            return (op, stringnified.tokenType) switch
            {
                (TokenType.Eq, TokenType.Boolean) => new Eq<bool>(new FieldSpec<bool>(n), s[0] =='1'? true: false),
                (TokenType.Eq, TokenType.Integer) => new Eq<int>(new FieldSpec<int>(n), int.Parse(s[0..^1])),
                (TokenType.Eq, TokenType.Dt) => new Eq<DateTime>(new FieldSpec<DateTime>(n), DateTime.Parse(s)),
                (TokenType.Gt, TokenType.Boolean) => new Gt<bool>(new FieldSpec<bool>(n), s[0] == '1' ? true : false),
                (TokenType.Gt, TokenType.Integer) => new Gt<int>(new FieldSpec<int>(n), int.Parse(s[0..^1])),
                (TokenType.Gt, TokenType.Dt) => new Gt<DateTime>(new FieldSpec<DateTime>(n), DateTime.Parse(s)),
                (TokenType.Lt, TokenType.Boolean) => new Lt<bool>(new FieldSpec<bool>(n), s[0] == '1' ? true : false),
                (TokenType.Lt, TokenType.Integer) => new Lt<int>(new FieldSpec<int>(n), int.Parse(s[0..^1])),
                (TokenType.Lt, TokenType.Dt) => new Lt<DateTime>(new FieldSpec<DateTime>(n), DateTime.Parse(s)),
                _ => throw new ApplicationException()
            };
        }

        public static Expr Binary(TokenType op, Expr l, Expr r)
        {
            return op switch
            {
                TokenType.And => new And(l, r),
                TokenType.Or => new Or(l, r),
                _ => throw new ApplicationException()
            };
        }

        public static (Expr, bool) Parse(string s)
        {
            var ts = Token.Tokenize(s).ToArray();
            var (result, succeeded, _) = Parsers.expr(ts);
            return (result, succeeded);
        }

        public static (Expr, bool) Parse(char[] input)
        {
            var ts = Token.Tokenize(input).ToArray();
            var (result, succeeded, _) = Parsers.expr(ts);
            return (result, succeeded);
        }
    }
}

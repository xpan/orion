using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;

namespace Hydrogen.Exprs.Serialization
{
    public struct Token
    {
        public TokenType type;
        public ArraySegment<char> s;
        public override string ToString() => type switch
        {
            TokenType.And => "kw:and",
            TokenType.Or => "kw:or",
            TokenType.Symbol => $"s:{new string(s)}",
            TokenType.Eq => "kw:=",
            TokenType.Join => "kw:join",
            TokenType.On => "kw:on",
            TokenType.Select => "kw:select",
            TokenType.From => "kw:from",
            TokenType.Wildcard => "kw:*",
            TokenType.Where => "kw:where",
            TokenType.Number => $"num:{int.Parse(s)}",
            TokenType.Comma => "kw:,",
            TokenType.Lb => "kw:(",
            TokenType.Rb => "kw:)",
            TokenType.Lt => "kw:<",
            TokenType.Gt => "kw:>",
            TokenType.Boolean => $"b:{bool.Parse(s)}",
            _ => base.ToString()
        };

        public static Func<TokenType, Func<char[], Match, Token>> tokenlizer = t => (s, m) => new Token { type = t, s = new ArraySegment<char>(s, m.Index, m.Length) };

        public static readonly Func<char[], Match, Token> num = tokenlizer(TokenType.Number);
        public static readonly Func<char[], Match, Token> symbol = tokenlizer(TokenType.Symbol);
        public static readonly Func<char[], Match, Token> select = tokenlizer(TokenType.Select);
        public static readonly Func<char[], Match, Token> where = tokenlizer(TokenType.Where);
        public static readonly Func<char[], Match, Token> from = tokenlizer(TokenType.From);
        public static readonly Func<char[], Match, Token> comma = tokenlizer(TokenType.Comma);
        public static readonly Func<char[], Match, Token> eq = tokenlizer(TokenType.Eq);
        public static readonly Func<char[], Match, Token> gt = tokenlizer(TokenType.Gt);
        public static readonly Func<char[], Match, Token> lt = tokenlizer(TokenType.Lt);
        public static readonly Func<char[], Match, Token> wildcard = tokenlizer(TokenType.Wildcard);
        public static readonly Func<char[], Match, Token> boolean = tokenlizer(TokenType.Boolean);
        public static readonly Func<char[], Match, Token> join = tokenlizer(TokenType.Join);
        public static readonly Func<char[], Match, Token> on = tokenlizer(TokenType.On);
        public static readonly Func<char[], Match, Token> lb = tokenlizer(TokenType.Lb);
        public static readonly Func<char[], Match, Token> rb = tokenlizer(TokenType.Rb);
        public static readonly Func<char[], Match, Token> and = tokenlizer(TokenType.And);
        public static readonly Func<char[], Match, Token> or = tokenlizer(TokenType.Or);
        public static IEnumerable<Token> Tokenize(string s)
        {
            var input = s.ToCharArray();

            var reg = new Regex(@"(?<datetime>\d{4}\.\d{2}\.\d{2}T\d{2}:\d{2}:\d{2})|(?<lb>\()|(?<rb>\))|(?<comma>,)|(?<boolean>true|false)|(?<on>on)|(?<select>select)|(?<from>from)|(?<where>where)|(?<join>join)|(?<integer>\d+)|(?<lt><)|(?<gt>>)|(?<eq>=)|(?<and>and)|(?<or>or)|(?<wildcard>\*)|(?<symbol>\w+)");
            var matches = reg.Matches(s);
            for (var i = 0; i < matches.Count; i++)
            {
                var match = matches[i];
                if (match.Groups["integer"].Success)
                    yield return num(input, match);
                else if (match.Groups["symbol"].Success)
                    yield return symbol(input, match);
                else if (match.Groups["select"].Success)
                    yield return select(input, match);
                else if (match.Groups["where"].Success)
                    yield return where(input, match);
                else if (match.Groups["from"].Success)
                    yield return from(input, match);
                else if (match.Groups["comma"].Success)
                    yield return comma(input, match);
                else if (match.Groups["eq"].Success)
                    yield return eq(input, match);
                else if (match.Groups["gt"].Success)
                    yield return gt(input, match);
                else if (match.Groups["lt"].Success)
                    yield return lt(input, match);
                else if (match.Groups["wildcard"].Success)
                    yield return wildcard(input, match);
                else if (match.Groups["boolean"].Success)
                    yield return boolean(input, match);
                else if (match.Groups["join"].Success)
                    yield return join(input, match);
                else if (match.Groups["on"].Success)
                    yield return on(input, match);
                else if (match.Groups["lb"].Success)
                    yield return lb(input, match);
                else if (match.Groups["rb"].Success)
                    yield return rb(input, match);
                else if (match.Groups["and"].Success)
                    yield return and(input, match);
                else if (match.Groups["or"].Success)
                    yield return or(input, match);
            }
        }

    }
}

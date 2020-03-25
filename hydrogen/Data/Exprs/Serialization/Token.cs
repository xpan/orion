using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Hydrogen.Data.Exprs.Serialization
{
    public struct Token
    {
        public char[] s;
        public int start;
        public int length;
        public TokenType tokenType;
        public Token(char[] s, int start, int length, TokenType tokenType)
        {
            this.s = s;
            this.start = start;
            this.length = length;
            this.tokenType = tokenType;
        }

        public static implicit operator ArraySegment<char>(Token t)
        {
            return new ArraySegment<char>(t.s, t.start, t.length);
        }

        public override string ToString()
        {
            return string.Create(length, this, (buf, t) => new Span<char>(t.s, t.start, t.length).CopyTo(buf));
        }

        public static readonly Func<TokenType, Func<char[], int, int, Token>> tokenizer = type => (s, start, length) => new Token(s, start, length, type);

        public static readonly Func<char[], int, int, Token> dt = tokenizer(TokenType.Dt);
        public static readonly Func<char[], int, int, Token> lb = tokenizer(TokenType.Lb);
        public static readonly Func<char[], int, int, Token> rb = tokenizer(TokenType.Rb);
        public static readonly Func<char[], int, int, Token> comma = tokenizer(TokenType.Comma);
        public static readonly Func<char[], int, int, Token> boolean = tokenizer(TokenType.Boolean);
        public static readonly Func<char[], int, int, Token> integer = tokenizer(TokenType.Integer);
        public static readonly Func<char[], int, int, Token> symbol = tokenizer(TokenType.Symbol);
        public static readonly Func<char[], int, int, Token> lt = tokenizer(TokenType.Lt);
        public static readonly Func<char[], int, int, Token> gt = tokenizer(TokenType.Gt);
        public static readonly Func<char[], int, int, Token> eq = tokenizer(TokenType.Eq);
        public static readonly Func<char[], int, int, Token> and = tokenizer(TokenType.And);
        public static readonly Func<char[], int, int, Token> or = tokenizer(TokenType.Or);
        public static IEnumerable<Token> Tokenize(string s)
        {
            char[] chars = s.ToCharArray();
            var reg = new Regex(@"(?<datetime>\d{4}\.\d{2}\.\d{2}T\d{2}:\d{2}:\d{2})|(?<lb>\()|(?<rb>\))|(?<comma>,)|(?<boolean>[01]b)|(?<integer>\d+i)|(?<symbol>\w+)|(?<lt><)|(?<gt>>)|(?<eq>=)|(?<and>&)|(?<or>\|)");
            var matches = reg.Matches(s);
            for (var i = 0; i < matches.Count; i++)
            {
                var match = matches[i];
                if (match.Groups["datetime"].Success)
                    yield return dt(chars, match.Index, match.Length);
                else if (match.Groups["lb"].Success)
                    yield return lb(chars, match.Index, match.Length);
                else if (match.Groups["rb"].Success)
                    yield return rb(chars, match.Index, match.Length);
                else if (match.Groups["comma"].Success)
                    yield return comma(chars, match.Index, match.Length);
                else if (match.Groups["boolean"].Success)
                    yield return boolean(chars, match.Index, match.Length);
                else if (match.Groups["integer"].Success)
                    yield return integer(chars, match.Index, match.Length);
                else if (match.Groups["symbol"].Success)
                    yield return symbol(chars, match.Index, match.Length);
                else if (match.Groups["lt"].Success)
                    yield return lt(chars, match.Index, match.Length);
                else if (match.Groups["gt"].Success)
                    yield return gt(chars, match.Index, match.Length);
                else if (match.Groups["eq"].Success)
                    yield return eq(chars, match.Index, match.Length);
                else if (match.Groups["and"].Success)
                    yield return and(chars, match.Index, match.Length);
                else if (match.Groups["or"].Success)
                    yield return or(chars, match.Index, match.Length);
                
            }
        }

        public static IEnumerable<Token> Tokenize(char[] chars)
        {
            var s = new string(chars);
            var reg = new Regex(@"(?<datetime>\d{4}\.\d{2}\.\d{2}T\d{2}:\d{2}:\d{2})|(?<lb>\()|(?<rb>\))|(?<comma>,)|(?<boolean>[01]b)|(?<integer>\d+i)|(?<symbol>\w+)|(?<lt><)|(?<gt>>)|(?<eq>=)|(?<and>&)|(?<or>\|)");
            var matches = reg.Matches(s);
            for (var i = 0; i < matches.Count; i++)
            {
                var match = matches[i];
                if (match.Groups["datetime"].Success)
                    yield return dt(chars, match.Index, match.Length);
                else if (match.Groups["lb"].Success)
                    yield return lb(chars, match.Index, match.Length);
                else if (match.Groups["rb"].Success)
                    yield return rb(chars, match.Index, match.Length);
                else if (match.Groups["comma"].Success)
                    yield return comma(chars, match.Index, match.Length);
                else if (match.Groups["boolean"].Success)
                    yield return boolean(chars, match.Index, match.Length);
                else if (match.Groups["integer"].Success)
                    yield return integer(chars, match.Index, match.Length);
                else if (match.Groups["symbol"].Success)
                    yield return symbol(chars, match.Index, match.Length);
                else if (match.Groups["lt"].Success)
                    yield return lt(chars, match.Index, match.Length);
                else if (match.Groups["gt"].Success)
                    yield return gt(chars, match.Index, match.Length);
                else if (match.Groups["eq"].Success)
                    yield return eq(chars, match.Index, match.Length);
                else if (match.Groups["and"].Success)
                    yield return and(chars, match.Index, match.Length);
                else if (match.Groups["or"].Success)
                    yield return or(chars, match.Index, match.Length);

            }
        }


    }
}

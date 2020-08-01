using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hydrogen.Exprs.Serialization
{
    public static class Parsers
    {
        public static readonly Parse<Token> consume = input => input.Count > 0 ? new ParseResult<Token>(input[0], input.Slice(1)) : new ParseResult<Token>("EOF");

        public static Parse<TokenType> Sat(TokenType type) =>
            from t in consume
            where t.type == type
            select type;

        public static readonly Parse<TokenType> s = Sat(TokenType.Select);
        public static readonly Parse<TokenType> a = Sat(TokenType.Wildcard);
        public static readonly Parse<TokenType> f = Sat(TokenType.From);
        public static readonly Parse<TokenType> w = Sat(TokenType.Where);
        public static readonly Parse<TokenType> j = Sat(TokenType.Join);
        public static readonly Parse<TokenType> o = Sat(TokenType.On);
        public static readonly Parse<TokenType> l = Sat(TokenType.Lb);
        public static readonly Parse<TokenType> r = Sat(TokenType.Rb);
        public static readonly Parse<TokenType> c = Sat(TokenType.Comma);
        public static readonly Parse<TokenType> n = Sat(TokenType.And);
        public static readonly Parse<TokenType> h = Sat(TokenType.Or);
        public static readonly Parse<TokenType> e = Sat(TokenType.Eq);

        public static readonly Parse<int> num =
            from t in consume
            where t.type == TokenType.Number
            select int.Parse(t.s);

        public static readonly Parse<string> literal =
            from t in consume
            where t.type == TokenType.Literal
            select new string(t.s[1..^1]);

        public static readonly Parse<string> symbol =
            from t in consume
            where t.type == TokenType.Symbol
            select new string(t.s);

        public static readonly Parse<string[]> symbols =
            from a in symbol
            from b in (from _ in c from s in symbol select s).Many()
            select new string[] { a }.Concat(b).ToArray();

        public static readonly Parse<EqExpr> eqNum =
            from a in symbol
            from b in e
            from c in num
            select new EqExpr(a, Variant.Int(c));

        public static Parse<Expr> Term() => (from a in eqNum select a as Expr).Or(from a in l from b in OrExpr() from c in r select b);

        public static Parse<Expr> AndExpr() =>
            from a in Term()
            from b in (from _ in n from d in Term() select d).Many()
            select AndHelper(new Expr[] { a }.Concat(b).ToArray());

        public static Parse<Expr> OrExpr() =>
            from a in AndExpr()
            from b in (from _ in h from d in AndExpr() select d).Many()
            select OrHelper(new Expr[] { a }.Concat(b).ToArray());

        public static Parse<Expr> T() =>(from a in symbol select new ConstExpr(a) as Expr).Or(from b in l /* ( */ from a in Sql() /* query */ from c in r /* ) */ select a as Expr);

        public static Parse<Expr> Join() =>
            from a in T() /* table */
            from b in (from x in j /* join */ from y in T() /* table */from z in o /* on */ from u in symbol /* field*/ from w in e /* = */ from v in symbol /* field*/ select (y, u, v)).Many()
            select JoinHelper(a, b);

        public static Parse<Expr> Sql() =>
            from b in s
            from c in (from h in a select new string[] { }).Or(symbols)
            from d in f
            from e in Join()
            from g in (from j in w from k in OrExpr() select k).Optional()
            select g.Length == 0? c.Length == 0? e: new SelectExpr(c, e): c.Length == 0? new WhereExpr(e, g[0]) as Expr: new SelectExpr(c, new WhereExpr(e, g[0]));
        
        public static Expr AndHelper(ArraySegment<Expr> s) => s.Count == 1 ? s[0] : new AndExpr(s[0], AndHelper(s[1..]));

        public static Expr OrHelper(ArraySegment<Expr> s) => s.Count == 1 ? s[0] : new OrExpr(s[0], OrHelper(s[1..]));

        public static Expr JoinHelper(Expr a, ArraySegment<(Expr rJoinable, string lField, string rField)> tails) => tails.Count == 0 ? a : JoinHelper(new JoinExpr(a, tails[0].rJoinable, tails[0].lField, tails[0].rField), tails[1..]);

    }
}

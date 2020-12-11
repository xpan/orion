using Hydrogen;
using Hydrogen.Exprs;
using Hydrogen.Exprs.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace HydrogenTests
{
    public class ParserTests
    {
        [Fact]
        public void Test_a_eq_5()
        {
            var tokens = Token.Tokenize("a=5").ToArray();
            var (succeed, result, _) = Parsers.OrExpr()(tokens);
            Assert.True(succeed);
            switch (result)
            {
                case EqExpr (string field, Variant v):
                    Assert.Equal("a", field);
                    Assert.Equal(Variant.Int32(5), v);
                    break;
                default:
                    Assert.True(false);
                    break;
            }
        }

        [Fact]
        public void Test_a_eq_5_and_b_eq_6()
        {
            var tokens = Token.Tokenize("a=5 and b=6").ToArray();
            var (succeed, result, _) = Parsers.OrExpr()(tokens);
            Assert.True(succeed);
            switch (result)
            {
                case AndExpr(EqExpr(string a, Variant b), EqExpr(string c, Variant d)):
                    Assert.Equal("a", a);
                    Assert.Equal(Variant.Int32(5), b);
                    Assert.Equal("b", c);
                    Assert.Equal(Variant.Int32(6), d);
                    break;
                default:
                    Assert.True(false);
                    break;
            }
        }

        [Fact]
        public void Test_a_eq_5_or_b_eq_6()
        {
            var tokens = Token.Tokenize("a=5 or b=6").ToArray();
            var (succeed, result, _) = Parsers.OrExpr()(tokens);
            Assert.True(succeed);
            switch (result)
            {
                case OrExpr(EqExpr(string a, Variant b), EqExpr(string c, Variant d)):
                    Assert.Equal("a", a);
                    Assert.Equal(Variant.Int32(5), b);
                    Assert.Equal("b", c);
                    Assert.Equal(Variant.Int32(6), d);
                    break;
                default:
                    Assert.True(false);
                    break;
            }
        }

        [Fact]
        public void Testa_eq_5_and_b_eq_6_or_c_eq_10()
        {
            var tokens = Token.Tokenize("a=5 and b=6 or c=10").ToArray();
            var (succeed, result, _) = Parsers.OrExpr()(tokens);
            Assert.True(succeed);
            switch (result)
            {
                case OrExpr(AndExpr(EqExpr(string a, Variant b), EqExpr(string c, Variant d)), EqExpr(string e, Variant f)):
                    Assert.Equal("a", a);
                    Assert.Equal(Variant.Int32(5), b);
                    Assert.Equal("b", c);
                    Assert.Equal(Variant.Int32(6), d);
                    Assert.Equal("c", e);
                    Assert.Equal(Variant.Int32(10), f);
                    break;
                default:
                    Assert.True(false);
                    break;
            }
        }

        [Fact]
        public void Testa_eq_5_and_lb_b_eq_6_or_c_eq_10_rb()
        {
            var tokens = Token.Tokenize("a=5 and ( b=6 or c=10)").ToArray();
            var (succeed, result, _) = Parsers.OrExpr()(tokens);
            Assert.True(succeed);
            switch (result)
            {
                case AndExpr(EqExpr(string a, Variant b), OrExpr(EqExpr(string c, Variant d), EqExpr(string e, Variant f))):
                    Assert.Equal("a", a);
                    Assert.Equal(Variant.Int32(5), b);
                    Assert.Equal("b", c);
                    Assert.Equal(Variant.Int32(6), d);
                    Assert.Equal("c", e);
                    Assert.Equal(Variant.Int32(10), f);
                    break;
                default:
                    Assert.True(false);
                    break;
            }
        }

        [Fact]
        public void Test_a()
        {
            var tokens = Token.Tokenize("a").ToArray();
            var (succeed, result, _) = Parsers.Join()(tokens);
            Assert.True(succeed);
            switch (result)
            {
                case ConstExpr (var a):
                    Assert.Equal("a", a);
                    break;
                default:
                    Assert.True(false);
                    break;
            }
        }

        [Fact]
        public void Test_a_join_b_on_c_eq_d()
        {
            var tokens = Token.Tokenize("a join b on c = d").ToArray();
            var (succeed, result, _) = Parsers.Join()(tokens);
            Assert.True(succeed);
            switch (result)
            {
                case JoinExpr(ConstExpr(var a), ConstExpr(var b), var c, var d):
                    Assert.Equal("a", a);
                    Assert.Equal("b", b);
                    Assert.Equal("c", c);
                    Assert.Equal("d", d);
                    break;
                default:
                    Assert.True(false);
                    break;
            }
        }

        [Fact]
        public void Test_a_join_b_on_c_eq_d_join_e_on_h_eq_g()
        {
            var tokens = Token.Tokenize("a join b on c = d join e on h = g").ToArray();
            var (succeed, result, _) = Parsers.Join()(tokens);
            Assert.True(succeed);
            switch (result)
            {
                case JoinExpr(JoinExpr(ConstExpr(var a), ConstExpr(var b), var c, var d), ConstExpr(var e), var f, var g):
                    Assert.Equal("a", a);
                    Assert.Equal("b", b);
                    Assert.Equal("c", c);
                    Assert.Equal("d", d);
                    Assert.Equal("e", e);
                    Assert.Equal("h", f);
                    Assert.Equal("g", g);
                    break;
                default:
                    Assert.True(false);
                    break;
            }
        }

        [Fact]
        public void Test_select_from_a()
        {
            var tokens = Token.Tokenize("select*from a").ToArray();
            var (succeed, result, _) = Parsers.Sql()(tokens);
            Assert.True(succeed);
            switch (result)
            {
                case ConstExpr(var b):
                    Assert.Equal("a", b);
                    break;
                default:
                    Assert.True(false);
                    break;
            }
        }

        [Fact]
        public void Test_a_com_b()
        {
            var tokens = Token.Tokenize("a,b").ToArray();
            var (succeed, result, _) = Parsers.symbols(tokens);
            Assert.True(succeed);
            Assert.Equal(new string[] { "a", "b" }, result);
        }

        [Fact]
        public void Test_select_a_from_b()
        {
            var tokens = Token.Tokenize("select a from b").ToArray();
            var (succeed, result, _) = Parsers.Sql()(tokens);
            Assert.True(succeed);
            switch (result)
            {
                case SelectExpr(var a, ConstExpr(var b)):
                    Assert.Equal(new string[] { "a" }, a);
                    Assert.Equal("b", b);
                    break;
                default:
                    Assert.True(false);
                    break;
            }
        }

        [Fact]
        public void Test_select_from_a_where_b_eq_10()
        {
            var tokens = Token.Tokenize("select*from a where b = 10").ToArray();
            var (succeed, result, _) = Parsers.Sql()(tokens);
            Assert.True(succeed);
            switch (result)
            {
                case WhereExpr(ConstExpr(var b), EqExpr(var c, var d)):
                    Assert.Equal("a", b);
                    Assert.Equal("b", c);
                    Assert.Equal(Variant.Int32(10), d);
                    break;
                default:
                    Assert.True(false);
                    break;
            }
        }

        [Fact]
        public void Test_select_from_a_join_c_on_d_eq_e_where_b_eq_10()
        {
            var tokens = Token.Tokenize("select*from a join c on d = e where b = 10").ToArray();
            var (succeed, result, _) = Parsers.Sql()(tokens);
            Assert.True(succeed);
            switch (result)
            {
                case WhereExpr(JoinExpr(ConstExpr(var g), ConstExpr(var b), string e, string f), EqExpr(var c, var d)):
                    Assert.Equal("a", g);
                    Assert.Equal("c", b);
                    Assert.Equal("d", e);
                    Assert.Equal("e", f);
                    Assert.Equal("b", c);
                    Assert.Equal(Variant.Int32(10), d);
                    break;
                default:
                    Assert.True(false);
                    break;
            }
        }

        [Fact]
        public void Test_a_join_lb_select_from_b_rb_on_c_eq_d()
        {
            var tokens = Token.Tokenize("a join (select*from b) on c = d").ToArray();
            var (succeed, result, _) = Parsers.Join()(tokens);
            Assert.True(succeed);
            switch (result)
            {
                case JoinExpr(ConstExpr(var a), ConstExpr(var c), string d, string e):
                    Assert.Equal("a", a);
                    Assert.Equal("b", c);
                    Assert.Equal("c", d);
                    Assert.Equal("d", e);
                    break;
                default:
                    Assert.True(false);
                    break;
            }
        }

        [Fact]
        public void Test_a_join_lb_select_from_b_where_e_eq_10_rb_on_c_eq_d()
        {
            var tokens = Token.Tokenize("a join (select*from b where e = 10) on c = d").ToArray();
            var (succeed, result, _) = Parsers.Join()(tokens);
            Assert.True(succeed);
            switch (result)
            {
                case JoinExpr(ConstExpr(var a), WhereExpr(ConstExpr(var c), EqExpr(string f, Variant g)), string d, string e):
                    Assert.Equal("a", a);
                    Assert.Equal("b", c);
                    Assert.Equal("c", d);
                    Assert.Equal("d", e);
                    Assert.Equal("e", f);
                    Assert.Equal(Variant.Int32(10), g);
                    break;
                default:
                    Assert.True(false);
                    break;
            }
        }
    }
}

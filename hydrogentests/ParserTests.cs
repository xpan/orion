using Hydrogen.Data.Exprs;
using Hydrogen.Data.Exprs.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace Hydrogen
{
    public class ParserTests
    {
        [Fact]
        public void TestLt()
        {
            var chs = new char[] {'<' };      
            var r = Token.Tokenize(chs).ToArray();
            Assert.Equal(new Token[] { new Token(chs, 0, 1, TokenType.Lt) }, r);
        }
        [Fact]
        public void TestGt()
        {
            var chs = new char[] { '>' };
            var r = Token.Tokenize(chs).ToArray();
            Assert.Equal(new Token[] { new Token(chs, 0, 1, TokenType.Gt) }, r);
        }
        [Fact]
        public void TestEq()
        {
            var chs = new char[] { '=' };
            var r = Token.Tokenize(chs).ToArray();
            Assert.Equal(new Token[] { new Token(chs, 0, 1, TokenType.Eq) }, r);
        }
        [Fact]
        public void TestCo()
        {
            var chs = new char[] { ',' };
            var r = Token.Tokenize(chs).ToArray();
            Assert.Equal(new Token[] { new Token(chs, 0, 1, TokenType.Comma) }, r);
        }
        [Fact]
        public void TestLb()
        {
            var chs = new char[] { '(' };
            var r = Token.Tokenize(chs).ToArray();
            Assert.Equal(new Token[] { new Token(chs, 0, 1, TokenType.Lb) }, r);
        }
        [Fact]
        public void TestRb()
        {
            var chs = new char[] { ')' };
            var r = Token.Tokenize(chs).ToArray();
            Assert.Equal(new Token[] { new Token(chs, 0, 1, TokenType.Rb) }, r);
        }
        [Fact]
        public void TestAnd()
        {
            var chs = new char[] { '&' };
            var r = Token.Tokenize(chs).ToArray();
            Assert.Equal(new Token[] { new Token(chs, 0, 1, TokenType.And) }, r);
        }
        [Fact]
        public void TestOr()
        {
            var chs = new char[] { '|' };
            var r = Token.Tokenize(chs).ToArray();
            Assert.Equal(new Token[] { new Token(chs, 0, 1, TokenType.Or) }, r);
        }
        [Fact]
        public void TestSym()
        {
            var chs = new char[] { 'a' };
            var r = Token.Tokenize(chs).ToArray();
            Assert.Equal(new Token[] { new Token(chs, 0, 1, TokenType.Symbol) }, r);
        }
        [Fact]
        public void TestFalse()
        {
            var chs = new char[] { '0','b' };
            var r = Token.Tokenize(chs).ToArray();
            Assert.Equal(new Token[] { new Token(chs, 0, 2, TokenType.Boolean) }, r);
        }
        [Fact]
        public void TestTrue()
        {
            var chs = new char[] { '1', 'b' };
            var r = Token.Tokenize(chs).ToArray();
            Assert.Equal(new Token[] { new Token(chs, 0, 2, TokenType.Boolean) }, r);
        }
        [Fact]
        public void Test1()
        {
            var chs = new char[] { '1', 'i' };
            var r = Token.Tokenize(chs).ToArray();
            Assert.Equal(new Token[] { new Token(chs, 0, 2, TokenType.Integer) }, r);
        }
        
        [Fact]
        public void Test12()
        {
            var chs = new char[] { '1','2', 'i' };
            var r = Token.Tokenize(chs).ToArray();
            Assert.Equal(new Token[] { new Token(chs, 0, 3, TokenType.Integer) }, r);
        }

        [Fact]
        public void TestDt()
        {
            var chs = new char[] { '2', '0', '2','0','.','0','6','.','0','4','T','0','0',':','0','0',':','0','0'};
            var r = Token.Tokenize(chs).ToArray();
            Assert.Equal(new Token[] { new Token(chs, 0, chs.Length, TokenType.Dt) }, r);
        }
        [Fact]
        public void TestLtInt32Expr()
        {
            var chs = new char[] { '<', ',', 'a','g','e',',','2','5','i' };
            var (r, s) = Parsers.Parse(chs);
            Assert.True(s);
            Assert.IsType<Lt<int>>(r);
        }
        [Fact]
        public void TestEqInt32Expr()
        {
            var chs = new char[] { '=', ',', 'a', 'g', 'e', ',', '2', 'i' };
            var (r, s) = Parsers.Parse(chs);
            Assert.True(s);
            Assert.IsType<Eq<int>>(r);
        }
        [Fact]
        public void TestGtInt32Expr()
        {
            var chs = new char[] { '>', ',', 'a', 'g', 'e', ',', '1', 'i' };
            var (r, s) = Parsers.Parse(chs);
            Assert.True(s);
            Assert.IsType<Gt<int>>(r);
        }
        [Fact]
        public void TestEqBooleanExpr()
        {
            var chs = new char[] { '=', ',', 'a', ',', '1', 'b' };
            var (r, s) = Parsers.Parse(chs);
            Assert.True(s);
            Assert.IsType<Eq<bool>>(r);
        }
        [Fact]
        public void TestEqDtExpr()
        {
            var chs = new char[] { '=', ',', 'a', ',', '2', '0', '2', '0', '.', '0', '6', '.', '0', '4', 'T', '0', '0', ':', '0', '0', ':', '0', '0' };
            var (r, s) = Parsers.Parse(chs);
            Assert.True(s);
            Assert.IsType<Eq<DateTime>>(r);
        }
        [Fact]
        public void TestAndExpr()
        {
            var chs = new char[] { '&', '(', '=', ',', 'a', ',', '2', '0', '2', '0', '.', '0', '6', '.', '0', '4', 'T', '0', '0', ':', '0', '0', ':', '0', '0',')','(','>',',','b',',','1','b', ')' };
            var (r, s) = Parsers.Parse(chs);
            Assert.True(s);
            Assert.IsType<And>(r);
            Assert.IsType<Eq<DateTime>>(((And)r).Left);
            Assert.IsType<Gt<bool>>(((And)r).Right);
        }
        [Fact]
        public void TestOrExpr()
        {
            var chs = new char[] { '|', '(', '=', ',', 'a', ',', '2', '0', '2', '0', '.', '0', '6', '.', '0', '4', 'T', '0', '0', ':', '0', '0', ':', '0', '0', ')', '(', '>', ',', 'b', ',', '1', 'b', ')' };
            var (r, s) = Parsers.Parse(chs);
            Assert.True(s);
            Assert.IsType<Or>(r);
            Assert.IsType<Eq<DateTime>>(((Or)r).Left);
            Assert.IsType<Gt<bool>>(((Or)r).Right);
        }
    }
}

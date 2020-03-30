using Hydrogen.Arrays;
using Hydrogen.Data.Exprs;
using Hydrogen.Data.Indices;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.Data
{
    public class Visitor : ExprVisitor
    {
        private ITable table;
        private Stack<(Func<IEnumerable<Array8>, IEnumerable<Array8>>, Func<Array8, bool>)> fs = new Stack<(Func<IEnumerable<Array8>, IEnumerable<Array8>>, Func<Array8, bool>)>();
        public Visitor(ITable table)
        {
            this.table = table;
        }

        public (Func<IEnumerable<Array8>, IEnumerable<Array8>>, Func<Array8, bool>) Result()
        {
            return fs.Pop();
        }
        
        public override void VisitGt<T>(Gt<T> node)
        {
            var fieldOuter = table.GetField(node.FieldSpec);
            var outerInvertedIndex = table.GetInvertedIndex(fieldOuter);
            var fieldDimensionOuter = table.GetFieldDimension(fieldOuter);

            bool Test(Array8 a)
            {
                return Comparer<T>.Default.Compare(fieldOuter[a[fieldDimensionOuter]], node.Value) > 0;
            }

            IEnumerable<Array8> Filter(IEnumerable<Array8> indices)
            {
                var s = outerInvertedIndex.GreaterThan(node.Value);
                var t = new BinaryTree<int>(1024, Comparer<int>.Default);
                foreach (var i in s)
                {
                    t.Insert(i);
                }
                foreach (var a in indices)
                {
                    if (t.Search(a[fieldDimensionOuter]).Item2 == 0)
                    {
                        yield return a;
                    }
                }
            }
            
            fs.Push((Filter, Test));
            
        }

        public override void VisitLt<T>(Lt<T> node)
        {
            var fieldOuter = table.GetField(node.FieldSpec);
            var outerInvertedIndex = table.GetInvertedIndex(fieldOuter);
            var fieldDimensionOuter = table.GetFieldDimension(fieldOuter);

            bool Test(Array8 a)
            {
                return Comparer<T>.Default.Compare(fieldOuter[a[fieldDimensionOuter]], node.Value) < 0;
            }


            IEnumerable<Array8> Filter(IEnumerable<Array8> indices)
            {
                var s = outerInvertedIndex.LessThan(node.Value);
                var t = new BinaryTree<int>(1024, Comparer<int>.Default);
                foreach (var i in s)
                {
                    t.Insert(i);
                }
                foreach (var a in indices)
                {
                    if (t.Search(a[fieldDimensionOuter]).compare == 0)
                    {
                        yield return a;
                    }
                }
            }
            
            fs.Push((Filter, Test));
            
        }

        public override void VisitAnd(And node)
        {
            base.VisitAnd(node);

            var (f1, t1) = fs.Pop();
            var (f2, t2) = fs.Pop();

            fs.Push((indices => f1(f2(indices)), a => t2(a) && t1(a)));
        }

        public override void VisitOr(Or node)
        {
            base.VisitOr(node);

            var (f1, t1) = fs.Pop();
            var (f2, t2) = fs.Pop();

            fs.Push((a => Utils.Or(f1(a), f2(a)), a => t2(a) || t1(a)));
        }
    }
}

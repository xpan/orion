using Hydrogen.Data.Indices;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.Data
{
    public static class Utils
    {
        public static IEnumerable<(T, ChangeType)> SymmetricDiff<T>(IEnumerable<T> left, IEnumerable<T> right)
        {
            var e1 = left.GetEnumerator();
            var e2 = right.GetEnumerator();

            var b1 = e1.MoveNext();
            var b2 = e2.MoveNext();
            while (b1 && b2)
            {
                var v1 = e1.Current;
                var v2 = e2.Current;
                var r = Comparer<T>.Default.Compare(v1, v2);
                if (r < 0)
                {
                    yield return (v1, ChangeType.Delete);
                    b1 = e1.MoveNext();
                }
                else if (r == 0)
                {
                    yield return (v1, ChangeType.Update);
                    b1 = e1.MoveNext();
                    b2 = e2.MoveNext();
                }
                else
                {
                    yield return (v2, ChangeType.Add);
                    b2 = e2.MoveNext();
                }
            }

            while (b1)
            {
                yield return (e1.Current, ChangeType.Delete);
                b1 = e1.MoveNext();
            }

            while (b2)
            {
                yield return (e2.Current, ChangeType.Add);
                b2 = e2.MoveNext();
            }
        }

        public static IEnumerable<T> Or<T>(IEnumerable<T> l, IEnumerable<T> r)
        {
            var s = new BinaryTree<T>(1024, Comparer<T>.Default);

            foreach (var a in l)
            {
                s.Insert(a);
            }               
            foreach (var a in r)
            {
                s.Insert(a);
            }               
            return s.Iter();
        }

        public static IEnumerable<T> Intersect<T>(IEnumerable<T> l, IEnumerable<T> r)
        {
            var le = l.GetEnumerator();
            var re = r.GetEnumerator();
            var f = le.MoveNext() && re.MoveNext();
            while (f)
            {
                var lv = le.Current;
                var rv = re.Current;
                var b = Comparer<T>.Default.Compare(lv, rv);
                if (b < 0)
                {
                    f = le.MoveNext();
                }
                else if (b > 0)
                {
                    f = re.MoveNext();
                }
                else
                {
                    yield return lv;
                    f = le.MoveNext() && re.MoveNext();
                }
            }
        }
    }
}

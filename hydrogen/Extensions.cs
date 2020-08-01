using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen
{
    public static class Extensions
    {
        public static IEnumerable<T> Intersect<T>(IEnumerable<T> l, IEnumerable<T> r, IComparer<T> comparer)
        {
            var le = l.GetEnumerator();
            var re = r.GetEnumerator();

            var lf = le.MoveNext();
            var rf = re.MoveNext();
            while (lf && rf)
            {
                var lv = le.Current;
                var rv = re.Current;

                var b = comparer.Compare(lv, rv);
                if (b < 0)
                {
                    lf = le.MoveNext();
                }
                else if (b > 0)
                {
                    rf = re.MoveNext();
                }
                else
                {
                    yield return lv;
                    lf = le.MoveNext();
                    rf = re.MoveNext();
                }
            }
        }

        public static IEnumerable<T> Union<T>(IEnumerable<T> l, IEnumerable<T> r, IComparer<T> comparer)
        {
            var le = l.GetEnumerator();
            var re = r.GetEnumerator();

            var lf = le.MoveNext();
            var rf = re.MoveNext();
            while (lf && rf)
            {
                var lv = le.Current;
                var rv = re.Current;

                var b = comparer.Compare(lv, rv);
                if (b < 0)
                {
                    yield return lv;
                    lf = le.MoveNext();
                }
                else if (b > 0)
                {
                    yield return rv;
                    rf = re.MoveNext();
                }
                else
                {
                    yield return lv;
                    lf = le.MoveNext();
                    rf = re.MoveNext();
                }
            }

            while (lf)
            {
                yield return le.Current;
                lf = le.MoveNext();
            }

            while (rf)
            {
                yield return re.Current;
                rf = re.MoveNext();
            }
        }

        public static IEnumerable<(T, int)> SymmetricDiff<T>(this IEnumerable<T> l, IEnumerable<T> r, IComparer<T> comparer)
        {
            var le = l.GetEnumerator();
            var re = r.GetEnumerator();

            var lf = le.MoveNext();
            var rf = re.MoveNext();
            while (lf && rf)
            {
                var lv = le.Current;
                var rv = re.Current;

                var b = comparer.Compare(lv, rv);
                if (b < 0)
                {
                    yield return (lv, -1);
                    lf = le.MoveNext();
                }
                else if (b > 0)
                {
                    yield return (rv, 1);
                    rf = re.MoveNext();
                }
                else
                {
                    yield return (lv, 0);
                    lf = le.MoveNext();
                    rf = re.MoveNext();
                }
            }

            while (lf)
            {
                yield return (le.Current, -1);
                lf = le.MoveNext();
            }

            while (rf)
            {
                yield return (re.Current, 1);
                rf = re.MoveNext();
            }
        }
    }
}

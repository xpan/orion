using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hydrogen
{
    public class Utils
    {
        public static Func<T, T, T> Join<T>(Func<int, T> ctor) where T : IValueTypedArray<int>
        {
            return (a, b) =>
            {
                var l = a.Length + b.Length;
                var r = ctor(l);
                for (var i = 0; i < a.Length; i++)
                    r[i] = a[i];
                for (var i = 0; i < b.Length; i++)
                    r[a.Length + i] = b[i];
                return r;
            };
        }

        public static Func<int, T> ToArray<T>(Func<int, T> ctor) where T: IValueTypedArray<int>
        {
            return index =>
            {
                var r = ctor(1);
                r[0] = index;
                return r;
            };
        }

        public static Func<IEnumerable<T>, IEnumerable<T>, IEnumerable<T>> Union<T>(IComparer<T> comparer)
        {
            IEnumerable<T> Calc(IEnumerable<T> l, IEnumerable<T> r, IComparer<T> comparer)
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

            return (x, y) => Calc(x, y, comparer);
        }
    }
}

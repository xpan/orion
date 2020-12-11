using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hydrogen
{
    public static class Utils
    {
        public static Func<IEnumerable<T>, IEnumerable<T>, IEnumerable<(int, T)>> SymmetricDiff<T>(Comparison<T> comparison)
        {
            return (l, r) =>
            {
                IEnumerable<(int, T)> Diff()
                {
                    var le = l.GetEnumerator();
                    var re = r.GetEnumerator();

                    var lb = le.MoveNext();
                    var rb = re.MoveNext();

                    while (lb && rb)
                    {
                        var lv = le.Current;
                        var rv = re.Current;

                        var r = comparison(lv, rv);
                        if (r < 0)
                        {
                            yield return (1, lv);
                            lb = le.MoveNext();
                        }
                        else if (r == 0)
                        {
                            yield return (0, lv);
                            lb = le.MoveNext();
                            rb = re.MoveNext();
                        }
                        else
                        {
                            yield return (-1, rv);
                            rb = re.MoveNext();
                        }
                    }

                    while (lb)
                    {
                        var lv = le.Current;
                        yield return (1, lv);
                        lb = le.MoveNext();
                    }

                    while (rb)
                    {
                        var rv = re.Current;
                        yield return (-1, rv);
                        rb = re.MoveNext();
                    }
                }
                return Diff();
            };
        }
    }
}

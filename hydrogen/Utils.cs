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
    }
}

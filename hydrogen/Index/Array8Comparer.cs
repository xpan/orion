using Hydrogen.Arrays;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Hydrogen.Index
{
    public class Array8Comparer<T> : IComparer<Array8<T>>
    {
        private Comparison<T> comparison;
        public Array8Comparer(Comparison<T> comparison)
        {
            this.comparison = comparison;
        }
        public int Compare([AllowNull] Array8<T> x, [AllowNull] Array8<T> y)
        {
            return (x.Length, y.Length) switch
            {
                (0, 0) => 0,
                (1, 1) => comparison(x.d1, y.d1),
                (2, 2) => comparison(x.d1, y.d1) switch
                {
                    var a when a != 0 => a,
                    _ => comparison(x.d2, y.d2)
                },
                (3, 3) => comparison(x.d1, y.d1) switch
                {
                    var a when a != 0 => a,
                    _ => comparison(x.d2, y.d2) switch
                    {
                        var a when a != 0 => a,
                        _ => comparison(x.d3, y.d3)
                    }
                },
                (4, 4) => comparison(x.d1, y.d1) switch
                {
                    var a when a != 0 => a,
                    _ => comparison(x.d2, y.d2) switch
                    {
                        var a when a != 0 => a,
                        _ => comparison(x.d3, y.d3) switch
                        {
                            var a when a != 0 => a,
                            _ => comparison(x.d4, y.d4)
                        }
                    }
                },
                (5, 5) => comparison(x.d1, y.d1) switch
                {
                    var a when a != 0 => a,
                    _ => comparison(x.d2, y.d2) switch
                    {
                        var a when a != 0 => a,
                        _ => comparison(x.d3, y.d3) switch
                        {
                            var a when a != 0 => a,
                            _ => comparison(x.d4, y.d4) switch
                            {
                                var a when a != 0 => a,
                                _ => comparison(x.d5, y.d5)
                            }
                        }
                    }
                },
                (6, 6) => comparison(x.d1, y.d1) switch
                {
                    var a when a != 0 => a,
                    _ => comparison(x.d2, y.d2) switch
                    {
                        var a when a != 0 => a,
                        _ => comparison(x.d3, y.d3) switch
                        {
                            var a when a != 0 => a,
                            _ => comparison(x.d4, y.d4) switch
                            {
                                var a when a != 0 => a,
                                _ => comparison(x.d5, y.d5) switch
                                {
                                    var a when a != 0 => a,
                                    _ => comparison(x.d6, y.d6)
                                }
                            }
                        }
                    }
                },
                (7, 7) => comparison(x.d1, y.d1) switch
                {
                    var a when a != 0 => a,
                    _ => comparison(x.d2, y.d2) switch
                    {
                        var a when a != 0 => a,
                        _ => comparison(x.d3, y.d3) switch
                        {
                            var a when a != 0 => a,
                            _ => comparison(x.d4, y.d4) switch
                            {
                                var a when a != 0 => a,
                                _ => comparison(x.d5, y.d5) switch
                                {
                                    var a when a != 0 => a,
                                    _ => comparison(x.d6, y.d6) switch
                                    {
                                        var a when a != 0 => a,
                                        _ => comparison(x.d7, y.d7)
                                    }
                                }
                            }
                        }
                    }
                },
                (8, 8) => comparison(x.d1, y.d1) switch
                {
                    var a when a != 0 => a,
                    _ => comparison(x.d2, y.d2) switch
                    {
                        var a when a != 0 => a,
                        _ => comparison(x.d3, y.d3) switch
                        {
                            var a when a != 0 => a,
                            _ => comparison(x.d4, y.d4) switch
                            {
                                var a when a != 0 => a,
                                _ => comparison(x.d5, y.d5) switch
                                {
                                    var a when a != 0 => a,
                                    _ => comparison(x.d6, y.d6) switch
                                    {
                                        var a when a != 0 => a,
                                        _ => comparison(x.d7, y.d7) switch
                                        {
                                            var a when a != 0 => a,
                                            _ => comparison(x.d8, y.d8)
                                        }
                                    }
                                }
                            }
                        }
                    }
                },
                _ => throw new ApplicationException()
            };
        }
    }
}

using Hydrogen.Arrays;
using Hydrogen.Data.Indices;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.Data
{
    public struct Table
    {
        public Table(ITable tab, Snapshot snapshot, Test test)
        {
            Snapshot = snapshot;
            Tab = tab;
            Test = test;
        }

        public Snapshot Snapshot { get; }
        public ITable Tab { get; }
        public Test Test { get; }
        public void Deconstruct(out ITable tab, out Snapshot snapshot, out Test test)
        {
            tab = Tab;
            snapshot = Snapshot;
            test = Test;
        }

        public static Table Create(TableStore store)
        {
            IEnumerable<Array8> Snapshot()
            {
                foreach (var index in store.GetRows())
                {
                    Array8 r = new Array8(1);
                    r[0] = index;
                    yield return r;
                }
            }

            IEnumerable<Array8> Test(IRowTracker rowTracker, int index)
            {
                if (store == rowTracker && store.Test(index))
                {
                    Array8 r = new Array8(1);
                    r[0] = index;
                    yield return r;
                }
            }

            return new Table(store, Snapshot, Test);
        }

        public static Table Join<T>(in Table outer, in Table inner, in FieldSpec<T> fieldSpecOuter, in FieldSpec<T> fieldSpecInner)
        {
            var (outerTab, outerSnapshot, outerTest) = outer;
            var (innerTab, innerSnapshot, innerTest) = inner;

            var fieldOuter = outerTab.GetField(fieldSpecOuter);
            var outerInvertedIndex = outerTab.GetInvertedIndex(fieldOuter);
            var fieldDimensionOuter = outerTab.GetFieldDimension(fieldOuter);
            var outerRowTracker = outerTab.GetRowTracker(fieldOuter);

            var fieldInner = innerTab.GetField(fieldSpecInner);
            var innerInvertedIndex = innerTab.GetInvertedIndex(fieldInner);
            var fieldDimensionInner = innerTab.GetFieldDimension(fieldInner);
            var innerRowTracker = innerTab.GetRowTracker(fieldInner);

            
            IEnumerable<Array8> Snapshot()
            {
                IEnumerable<(int, int)> Intersect(IEnumerable<T> l, IEnumerable<T> r)
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
                            foreach (var a in outerInvertedIndex.GetPostings(lv))
                            {
                                foreach (var c in innerInvertedIndex.GetPostings(rv))
                                {
                                    yield return (a, c);
                                }
                            }
                            f = le.MoveNext() && re.MoveNext();
                        }
                    }
                }

                var snapshotOuter = outerSnapshot();
                var snapshotInner = innerSnapshot();

                foreach (var (no, ni) in Intersect(outerInvertedIndex.Keys, innerInvertedIndex.Keys))
                {
                    foreach (var a in snapshotOuter)
                    {
                        if (a[fieldDimensionOuter] == no)
                        {
                            foreach (var b in snapshotInner)
                            {
                                if (b[fieldDimensionInner] == ni)
                                {
                                    yield return Array8.Join(a, b);
                                }
                            }
                        }
                    }
                }
            }

            IEnumerable<Array8> Test(IRowTracker rowTracker, int index)
            {
                if (innerTab.Contains(rowTracker))
                {
                    foreach (var a in innerTest(rowTracker, index))
                    {
                        var i = a[fieldDimensionInner];
                        var v = fieldInner[i];
                        foreach (var b in outerInvertedIndex.GetPostings(v))
                        {
                            foreach (var c in outerTest(outerRowTracker, b))
                            {
                                yield return Array8.Join(c, a);
                            }
                        }
                    }
                }
                else if (outerTab.Contains(rowTracker))
                {
                    foreach (var a in outerTest(rowTracker, index))
                    {
                        var i = a[fieldDimensionOuter];
                        var v = fieldOuter[i];
                        foreach (var b in innerInvertedIndex.GetPostings(v))
                        {
                            foreach (var c in innerTest(innerRowTracker, b))
                            {
                                yield return Array8.Join(a, c);
                            }
                        }
                    }
                }
            }

            
            return new Table(new Join(outerTab, innerTab), Snapshot, Test);
        }

        public static Table Gt<T>(Table outer, in FieldSpec<T> fieldSpec, T value)
        {
            var (outerTab, outerSnapshot, outerTest) = outer;
            var fieldOuter = outerTab.GetField(fieldSpec);
            var outerInvertedIndex = outerTab.GetInvertedIndex(fieldOuter);
            var fieldDimensionOuter = outerTab.GetFieldDimension(fieldOuter);
            var outerRowTracker = outerTab.GetRowTracker(fieldOuter);

            IEnumerable<Array8> Snapshot()
            {
                var indices = outerInvertedIndex.GreaterThanIter(value);
                var s = new BinaryTree<int>(1024, Comparer<int>.Default);
                foreach (var index in indices)
                {
                    s.Insert(index);
                }
                foreach (var a in outerSnapshot())
                {
                    var (_, b) = s.Search(a[fieldDimensionOuter]);
                    if (b == 0)
                    {
                        yield return a;
                    }
                }
            }

            IEnumerable<Array8> Test(IRowTracker rowTracker, int index)
            {
                foreach (var arr in outerTest(rowTracker, index))
                {
                    var n = arr[fieldDimensionOuter];
                    var test = Comparer<T>.Default.Compare(fieldOuter[n], value);
                    if (test > 0)
                    {
                        yield return arr;
                    }
                }
            }

            return new Table(outerTab, Snapshot, Test);
        }
    }
}

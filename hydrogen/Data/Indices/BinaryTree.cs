using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

[assembly: InternalsVisibleTo("hydrogentests")]

namespace Hydrogen.Data.Indices
{
    public class BinaryTree<T>
    {
        internal BinaryTreeNode<Guarder<T>>[] nodes;
        private int head = 1;
        private IComparer<Guarder<T>> guarderComparer;

        public BinaryTree(int capacity, IComparer<T> comparer)
        {
            nodes = new BinaryTreeNode<Guarder<T>>[capacity];

            ref var n = ref nodes[0];
            n.val.minimum = true;
            n.val.value = default;
            n.h = -1;
            n.l = -1;
            n.r = -1;
            n.p = 0;
            n.n = 0;

            guarderComparer = new GuarderComparer<T>(comparer);
        }
        public void Insert(T value)
        {
            Guarder<T> v;
            v.minimum = false;
            v.value = value;

            Span<int> indices = stackalloc int[64];
            var (c, b) = Locate(0, in v, indices);
            var n = indices[c - 1];
            ref var node = ref nodes[n];
            if (b > 0)
            {
                ref var nn = ref nodes[head];
                nn.l = -1;
                nn.r = -1;
                nn.h = 1;
                nn.n = n;
                nn.p = node.p;
                nn.val = v;

                node.l = head;
                ref var prev = ref nodes[nn.p];
                prev.n = head;
                node.p = head;
                head++;
                Rebalance(indices.Slice(0, c));
            }
            else if (b < 0)
            {
                ref var nn = ref nodes[head];
                nn.l = -1;
                nn.r = -1;
                nn.h = 1;
                nn.p = n;
                nn.n = node.n;
                nn.val = v;

                node.r = head;
                ref var next = ref nodes[nn.n];
                next.p = head;
                node.n = head;
                head++;
                Rebalance(indices.Slice(0, c));
            }
            else
            {
                // Value exists, skip
            }



        }

        public void Remove(T value)
        {
            Guarder<T> v;
            v.minimum = false;
            v.value = value;

            Span<int> indices = stackalloc int[64];
            var (c, b) = Locate(0, in v, indices);
            if (b == 0)
            {
                var n = indices[c - 1];
                var p = indices[c - 2];
                ref var nn = ref nodes[n];
                ref var pn = ref nodes[p];

                if (nn.l == -1)
                {
                    if (pn.l == n)
                    {
                        pn.l = nn.r;
                    }
                    else
                    {
                        pn.r = nn.r;
                    }

                    ref var prev = ref nodes[nn.p];
                    ref var next = ref nodes[nn.n];
                    prev.n = nn.n;
                    next.p = nn.p;
                }
                else
                {
                    ref var prev = ref nodes[nn.p];
                    ref var next = ref nodes[nn.n];

                    var (l, _) = Locate(nn.l, prev.val, indices.Slice(c));
                    c += l;
                    var q = indices[c - 2];
                    ref var qn = ref nodes[q];
                    if (qn.l == nn.p)
                    {
                        qn.l = prev.l;
                    }
                    else
                    {
                        qn.r = prev.l;
                    }
                    ref var ppn = ref nodes[prev.p];
                    ppn.n = n;
                    nn.p = prev.p;
                    nn.val = prev.val;
                }

                Rebalance(indices.Slice(0, c - 1));

            }
        }

        private int Height(int n)
        {
            return n == -1 ? 0 : nodes[n].h;
        }

        private bool AdjustNode(ref int n)
        {
            void UpdateHeight(ref BinaryTreeNode<Guarder<T>> node)
            {
                node.h = Math.Max(Height(node.l), Height(node.r)) + 1;
            }

            void LR(ref int n)
            {
                ref var node = ref nodes[n];
                var r = node.r;
                ref var right = ref nodes[r];
                node.r = right.l;
                UpdateHeight(ref node);
                right.l = n;
                UpdateHeight(ref right);
                n = r;
            }

            void RR(ref int n)
            {
                ref var node = ref nodes[n];
                var l = node.l;
                ref var left = ref nodes[l];
                node.l = left.r;
                UpdateHeight(ref node);
                left.r = n;
                UpdateHeight(ref left);
                n = l;
            }

            ref var node = ref nodes[n];
            var lh = Height(node.l);
            var rh = Height(node.r);
            var h = node.h;

            if (rh - lh == 2)
            {
                ref var r = ref nodes[node.r];
                var rlh = Height(r.l);
                if (rlh == lh)
                {
                    LR(ref n);
                }
                else if (rlh - lh == 1)
                {
                    RR(ref node.r);
                    LR(ref n);
                }
            }
            else if (lh - rh == 2)
            {
                ref var l = ref nodes[node.l];
                var lrh = Height(l.r);
                if (lrh == rh)
                {
                    RR(ref n);
                }
                else if (lrh - rh == 1)
                {
                    LR(ref node.l);
                    RR(ref n);
                }
            }
            else
            {
                UpdateHeight(ref node);

            }

            return node.h != h;
        }
        private void Rebalance(Span<int> indices)
        {
            for (var i = indices.Length - 1; i >= 1; i--)
            {
                var pi = indices[i - 1];
                var ni = indices[i];
                ref var p = ref nodes[pi];

                if (p.l == ni)
                {
                    if (!AdjustNode(ref p.l))
                    {
                        break;
                    }
                }
                else if (p.r == ni)
                {
                    if (!AdjustNode(ref p.r))
                    {
                        break;
                    }
                }
                else
                {
                    // Should NEVER go here
                    throw new InvalidOperationException();
                }
            }

        }

        private (int, int) Locate(int r, in Guarder<T> value, Span<int> indices)
        {
            var n = r;
            var count = 0;
            var b = 0;
            while (n >= 0)
            {
                indices[count++] = n;
                ref var node = ref nodes[n];
                b = guarderComparer.Compare(node.val, value);
                if (b == 0)
                {
                    break;
                }
                else if (b > 0)
                {
                    n = node.l;
                }
                else
                {
                    n = node.r;
                }
            }
            return (count, b);
        }

        public (T, int) Search(T value)
        {
            Guarder<T> val;
            val.value = value;
            val.minimum = false;

            Span<int> indices = stackalloc int[64];
            var (c, b) = Locate(0, in val, indices);
            var n = indices[c - 1];
            return (nodes[n].val.value, b);
        }



        public IEnumerable<T> Iter()
        {
            var n = nodes[0].n;
            while (n > 0)
            {
                yield return nodes[n].val.value;
                n = nodes[n].n;
            }
        }

        public IEnumerable<T> GreaterThan(T value)
        {
            Guarder<T> val;
            val.value = value;
            val.minimum = false;

            Span<int> indices = stackalloc int[64];
            var (a, b) = Locate(0, in val, indices);
            var n = indices[a - 1];

            if (b <= 0)
            {
                n = nodes[indices[a - 1]].n;
            }

            while (n > 0)
            {
                yield return nodes[n].val.value;
                n = nodes[n].n;
            }
        }


        public IEnumerable<T> GreaterThan(T value, Func<T, bool> testCondition)
        {
            Guarder<T> val;
            val.value = value;
            val.minimum = false;

            Span<int> indices = stackalloc int[64];
            var (a, b) = Locate(0, in val, indices);
            var n = indices[a - 1];

            if (b <= 0)
            {
                n = nodes[indices[a - 1]].n;
            }

            while (n > 0)
            {
                var v = nodes[n].val.value;
                if (testCondition(v))
                    yield return nodes[n].val.value;
                else
                    yield break;
                n = nodes[n].n;
            }
        }
        public IEnumerable<T> LessThan(T value)
        {
            Guarder<T> val;
            val.value = value;
            val.minimum = false;

            Span<int> indices = stackalloc int[64];
            var (nn, b) = Locate(0, in val, indices);
            var n = nodes[indices[nn - 1]].p;

            while (n > 0)
            {
                yield return nodes[n].val.value;
                n = nodes[n].p;
            };
        }

        public IEnumerable<T> ReverseIter()
        {
            var n = nodes[0].p;
            while (n > 0)
            {
                yield return nodes[n].val.value;
                n = nodes[n].p;
            }
        }
    }
}

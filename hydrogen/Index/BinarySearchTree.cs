using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

[assembly: InternalsVisibleTo("hydrogentests")]

namespace Hydrogen.Index
{
    public class BinarySearchTree<T>
    {
        internal BinarySearchTreeNode<Guarder<T>>[] nodes;
        private int head = 1;
        private Comparison<Guarder<T>> cp;

        public BinarySearchTree(Comparison<T> comparison, int capacity = 1024)
        {
            nodes = new BinarySearchTreeNode<Guarder<T>>[capacity];
            cp = (x, y) => x.minimum ? -1 : comparison(x.value, y.value);

            ref var n = ref nodes[0];
            n.val.minimum = true;
            n.val.value = default;
            n.h = -1;
            n.l = -1;
            n.r = -1;
            n.parent = -1;
            n.p = 0;
            n.n = 0;
        }
        public void Insert(T value)
        {
            Guarder<T> v;
            v.minimum = false;
            v.value = value;

            var n = Locate(v);
            ref var node = ref nodes[n];
            var b = cp(node.val, v);
            if (b > 0)
            {
                ref var nn = ref nodes[head];
                nn.l = -1;
                nn.r = -1;
                nn.h = 1;
                nn.n = n;
                nn.parent = n;
                nn.p = node.p;
                nn.val = v;

                node.l = head;
                ref var prev = ref nodes[nn.p];
                prev.n = head;
                node.p = head;
                head++;
                Rebalance(n);
            }
            else if (b < 0)
            {
                ref var nn = ref nodes[head];
                nn.l = -1;
                nn.r = -1;
                nn.h = 1;
                nn.p = n;
                nn.parent = n;
                nn.n = node.n;
                nn.val = v;

                node.r = head;
                ref var next = ref nodes[nn.n];
                next.p = head;
                node.n = head;
                head++;
                Rebalance(n);
            }
        }

        public void Remove(T value)
        {
            Guarder<T> v;
            v.minimum = false;
            v.value = value;

            var n = Locate(v);
            ref var nn = ref nodes[n];
            var b = cp(nn.val, v);
            if (b == 0)
            {
                var p = nn.parent;
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

                    if (nn.r >= 0)
                    {
                        nodes[nn.r].parent = p;
                    }                        

                    ref var prev = ref nodes[nn.p];
                    ref var next = ref nodes[nn.n];
                    prev.n = nn.n;
                    next.p = nn.p;

                    Rebalance(p);
                }
                else
                {
                    ref var prev = ref nodes[nn.p];
                    ref var next = ref nodes[nn.n];

                    var q = prev.parent;
                    ref var qn = ref nodes[q];
                    if (qn.l == nn.p)
                    {
                        qn.l = prev.l;
                    }
                    else
                    {
                        qn.r = prev.l;
                    }

                    if (prev.l >= 0)
                    {
                        nodes[prev.l].parent = q;
                    }
                    ref var ppn = ref nodes[prev.p];
                    ppn.n = n;
                    nn.p = prev.p;
                    nn.val = prev.val;

                    Rebalance(q);
                }
            }
        }

        private int Height(int n)
        {
            return n == -1 ? 0 : nodes[n].h;
        }

        private void AdjustNode(ref int n)
        {            
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
        }

        private void UpdateHeight(ref BinarySearchTreeNode<Guarder<T>> node)
        {
            node.h = Math.Max(Height(node.l), Height(node.r)) + 1;
        }

        private void LR(ref int n)
        {
            ref var node = ref nodes[n];
            var r = node.r;
            ref var right = ref nodes[r];
            node.r = right.l;
            if (right.l >= 0)
                nodes[right.l].parent = n;
            UpdateHeight(ref node);
            right.l = n;
            var p = node.parent;
            node.parent = r;
            UpdateHeight(ref right);
            n = r;
            right.parent = p;
        }

        private void RR(ref int n)
        {
            ref var node = ref nodes[n];
            var l = node.l;
            ref var left = ref nodes[l];
            node.l = left.r;
            if (left.r >= 0)
                nodes[left.r].parent = n;
            UpdateHeight(ref node);
            left.r = n;
            var p = node.parent;
            node.parent = l;
            UpdateHeight(ref left);
            n = l;
            left.parent = p;
        }

        private void Rebalance(int index)
        {
            var n = index;
            var pi = nodes[n].parent;
            while (pi >= 0)
            {
                ref var p = ref nodes[pi];
                if (p.l == n)
                {
                    AdjustNode(ref p.l);
                }
                else if (p.r == n)
                {
                    AdjustNode(ref p.r);
                }
                n = pi;
                pi = nodes[n].parent;
            }
        }

        private int Locate(in Guarder<T> value)
        {
            var n = 0;
            var b = 0;
            while (n >= 0)
            {
                ref var node = ref nodes[n];
                b = cp(node.val, value);
                if (b == 0)
                {
                    break;
                }
                else if (b > 0)
                {
                    if (node.l < 0)
                    {
                        break;
                    }                        
                    n = node.l;
                }
                else
                {
                    if (node.r < 0)
                    {
                        break;
                    }                        
                    n = node.r;
                }
            }
            return n;
        }

        public int GetEntry(T value)
        {
            Guarder<T> val;
            val.value = value;
            val.minimum = false;

            var n = Locate(in val);
            var b = cp(nodes[n].val, val);
            if (b == 0)
                return n;
            else
                return -1;
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

        public IEnumerable<T> Gt(T value)
        {
            Guarder<T> val;
            val.value = value;
            val.minimum = false;

            var n = Locate(in val);
            var b = cp(nodes[n].val, val);
            if (b <= 0)
            {
                n = nodes[n].n;
            }

            while (n > 0)
            {
                yield return nodes[n].val.value;
                n = nodes[n].n;
            }
        }
    }
}

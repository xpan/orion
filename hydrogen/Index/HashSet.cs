using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.Index
{
    public class HashSet<T>
    {
        private HashSetNode<T>[] nodes;
        private IEqualityComparer<T> eq;
        public HashSet(IEqualityComparer<T> comparer, int capacity = 1024)
        {
            // Allocate one more node than the capacity since we are using
            // the first node (index 0) as the head, this will simply how to
            // allocate a node
            nodes = new HashSetNode<T>[capacity + 1];
            eq = comparer;

            nodes[0].p = capacity;
            nodes[capacity].n = 0;

            for (var i = 0; i < capacity; i++)
            {
                nodes[i].n = i + 1;
                nodes[i + 1].p = i;
            }
        }
        public void Insert(T value)
        {
            var hashCode = eq.GetHashCode(value);
            var capacity = nodes.Length - 1;
            var slot = hashCode % capacity;
            if (slot < 0)
                slot += capacity;

            slot++; // valid slots range from 1 to capacity (included)

            ref var n = ref nodes[slot];
            if (!n.occupied)
            {
                n.occupied = true;
                var prev = n.p;
                var next = n.n;
                nodes[prev].n = next;
                nodes[next].p = prev;

                n.val = value;
                n.p = -1;
                n.n = -1;
            }
            else
            {
                var b = eq.Equals(n.val, value);
                while (!b)
                {
                    slot = n.n;
                    if (slot < 0)
                        break;

                    n = ref nodes[slot];
                    b = eq.Equals(n.val, value);
                }

                if (!b)
                {
                    var a = nodes[0].n;
                    if (a == 0)
                        throw new NonSlotRemainingException();

                    ref var an = ref nodes[a];
                    an.occupied = true;
                    var prev = an.p;
                    var next = an.n;
                    nodes[prev].n = next;
                    nodes[next].p = prev;

                    an.p = -1;
                    an.n = n.n;
                    n.n = a;
                }
            }
        }

        public int GetEntry(T value)
        {
            var hashCode = eq.GetHashCode(value);
            var capacity = nodes.Length - 1;
            var slot = hashCode % capacity;
            if (slot < 0)
                slot += capacity;

            slot++; // valid slots range from 1 to capacity (included)

            ref var n = ref nodes[slot];
            if (!n.occupied)
                return -1;

            var b = eq.Equals(n.val, value);
            while (!b)
            {
                slot = n.n;
                if (slot < 0)
                    break;
                
                n = ref nodes[slot];
                b = eq.Equals(n.val, value);
            }

            if (!b)
                return -1;
            else
                return slot - 1;
        }
    }
}

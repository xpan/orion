using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.Index
{
    public class HashSet<T>
    {
        private HashSetNode<T>[] nodes;
        private IEqualityComparer<T> eq;
        private int count;
        public HashSet(IEqualityComparer<T> comparer, int capacity = 1024)
        {
            // Allocate one more node than the capacity since we are using
            // the first node (index 0) as the head, this will simply how to
            // allocate a node
            nodes = new HashSetNode<T>[capacity + 2];
            eq = comparer;
            
            for (var i = 0; i < capacity + 1; i++)
            {
                nodes[i].n = i + 1;
                nodes[i + 1].p = i;
            }

            nodes[0].p = capacity + 1;
            nodes[0].n = 2;
            nodes[1].p = 1;
            nodes[1].n = 1;
            nodes[1].hash = -1;
            nodes[2].p = 0;
            nodes[capacity + 1].n = 0;
        }

        public void Insert(T value)
        {
            var hashCode = eq.GetHashCode(value);
            var capacity = nodes.Length - 2;
            var slot = hashCode % capacity;
            if (slot < 0)
                slot += capacity;

            slot += 2; // valid slots range from 1 to capacity (included)

            ref var n = ref nodes[slot];
            if (!n.occupied)
            {
                n.occupied = true;
                var prev = n.p;
                var next = n.n;
                nodes[prev].n = next;
                nodes[next].p = prev;

                var h = nodes[1].n;
                n.val = value;
                n.p = 1;
                n.n = h;
                n.hash = slot;
                nodes[h].p = slot;
                nodes[1].n = slot;
                count++;
            }
            else
            {
                var b = eq.Equals(n.val, value);
                var hash = slot;
                while (!b)
                {
                    if (n.n == 1 || n.hash != hash)
                        break;

                    slot = n.n;
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

                    var h = n.n;
                    an.p = slot;
                    an.n = h;
                    an.val = value;
                    an.hash = hash;
                    n.n = a;
                    nodes[h].p = a;
                    count++;
                }
            }
        }

        public int GetEntry(T value)
        {
            var hashCode = eq.GetHashCode(value);
            var capacity = nodes.Length - 2;
            var slot = hashCode % capacity;
            if (slot < 0)
                slot += capacity;

            slot += 2; // valid slots range from 1 to capacity (included)

            ref var n = ref nodes[slot];
            if (!n.occupied)
                return -1;

            var b = eq.Equals(n.val, value);
            var hash = slot;
            while (!b)
            {
                if (n.n == 1 || n.hash != hash)
                    break;

                slot = n.n;
                n = ref nodes[slot];
                b = eq.Equals(n.val, value);
            }

            if (!b)
                return -1;
            else
                return slot - 2;
        }

        public T GetEntryValue(int entry)
        {
            return nodes[entry + 2].val;
        }

        public void Remove(int entry)
        {
            void DropAdd(int index)
            {
                ref var n = ref nodes[index];
                var next = n.n;
                var prev = n.p;
                nodes[next].p = prev;
                nodes[prev].n = next;
                n.occupied = false;

                var nn = nodes[0].n;
                n.n = nn;
                n.p = 0;
                nodes[0].n = index;
                nodes[nn].p = index;
                count--;
            }

            var slot = entry + 2;
            ref var n = ref nodes[slot];
            if (n.occupied)
            {
                if (nodes[n.n].hash == slot)
                {
                    n.val = nodes[n.n].val;
                    DropAdd(n.n);               
                }
                else
                {
                    DropAdd(slot);
                }
            }
        }

        public IEnumerable<T> It()
        {
            var n = nodes[1].n;
            while (n != 1)
            {
                yield return nodes[n].val;
                n = nodes[n].n;
            }
        }

        public int Count => count;
    }
}

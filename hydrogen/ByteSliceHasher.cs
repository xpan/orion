using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen
{
    public class ByteSliceHasher
    {
        private byte[] bytes = new byte[1024];
        private int offset;
        private ByteSliceChunk[] chunks;
        private int freeChunkHead;
        private IEqualityComparer<ByteSlice> comparer;

        public ByteSliceHasher()
            : this(new ByteSliceEqualityComparer())
        {
        }

        public ByteSliceHasher(IEqualityComparer<ByteSlice> comparer)
        {
            this.comparer = comparer;

            chunks = new ByteSliceChunk[256];
            for (var i = 0; i < 255; i++)
            {
                chunks[i].n = i + 1;
                chunks[i + 1].p = i;
            }
            chunks[255].n = -1;
            chunks[0].p = -1;
        }

        public int GetEntry(in ByteSlice byteSlice)
        {
            var (bucket, exist) = ComputeBucket(byteSlice);

            if (bucket < 0)
            {
                throw new InvalidOperationException("all buckets all occupied");
            }

            if (!exist)
            {
                Array.Copy(byteSlice.Bytes, byteSlice.Offset, bytes, offset, byteSlice.Count);            
                ref var chunk = ref chunks[bucket];
                chunk.offset = offset;
                chunk.count = byteSlice.Count;
                offset += byteSlice.Count;
            }
            return bucket;
        }

        public ByteSlice GetEntryValue(int bucket)
        {
            ref var chunk = ref chunks[bucket];
            return new ByteSlice(bytes, chunk.offset, chunk.count);
        }

        private (int bucket, bool exist) ComputeBucket(in ByteSlice byteSlice)
        {
            var hashCode = comparer.GetHashCode(byteSlice);
            var bucket = hashCode % 256;
            if (bucket < 0)
            {
                bucket += 256;
            }
            ref var chunk = ref chunks[bucket];
            if (!chunk.occupied)
            {
                chunk.occupied = true;
                var p = chunk.p;
                var n = chunk.n;
                if (p >= 0)
                {
                    chunks[p].n = n;
                }
                else
                {
                    freeChunkHead = chunk.n;
                    chunks[chunk.n].p = -1;
                }
                    
                if (n >= 0)
                {
                    chunks[n].p = p;
                }
                chunk.n = -1;
                return (bucket, false);
            }

            while (bucket >= 0)
            {
                chunk = ref chunks[bucket];
                if (comparer.Equals(new ByteSlice(bytes, chunk.offset, chunk.count), byteSlice))
                    return (bucket, true);
                bucket = chunk.n;
            }

            if (freeChunkHead < 0)
            {
                return (freeChunkHead, false);
            }                

            bucket = freeChunkHead;
            chunk.n = bucket;
            chunk = ref chunks[bucket];
            freeChunkHead = chunk.n;
            chunk.occupied = true;
            chunk.n = -1;
            return (bucket, false);
        }
        
    }
}

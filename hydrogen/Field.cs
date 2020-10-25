using Hydrogen.Index;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen
{
    public abstract class Field : IField
    {
        public Field(FieldType type) => Type = type;
        public abstract Variant this[int index] { get; set; }

        public FieldType Type { get; }

        public class Boolean : Field
        {
            private bool[] buf;

            public Boolean(int capacity) : base(FieldType.Boolean)
            {
                buf = new bool[capacity];
            }

            public override Variant this[int index]
            {
                get { return Variant.Boolean(buf[index]); }
                set
                {
                    if (value.bitMask != 256)
                        throw new ArgumentException();
                    buf[index] = value.d9;
                }
            }
        }

        public class Byte : Field
        {
            private byte[] buf;

            public Byte(int capacity) : base(FieldType.Byte)
            {
                buf = new byte[capacity];
            }

            public override Variant this[int index]
            {
                get { return Variant.Byte(buf[index]); }
                set
                {
                    if (value.bitMask != 16)
                        throw new ArgumentException();
                    buf[index] = value.d5;
                }
            }
        }

        public class SByte : Field
        {
            private sbyte[] buf;

            public SByte(int capacity) : base(FieldType.SByte)
            {
                buf = new sbyte[capacity];
            }

            public override Variant this[int index]
            {
                get { return Variant.SByte(buf[index]); }
                set
                {
                    if (value.bitMask != 1)
                        throw new ArgumentException();
                    buf[index] = value.d1;
                }
            }
        }


        public class Int16 : Field
        {
            private short[] buf;

            public Int16(int capacity) : base(FieldType.Short)
            {
                buf = new short[capacity];
            }

            public override Variant this[int index]
            {
                get { return Variant.Short(buf[index]); }
                set
                {
                    if (value.bitMask != 2)
                        throw new ArgumentException();
                    buf[index] = value.d2;
                }
            }
        }

        public class Int32 : Field
        {
            private int[] buf;

            public Int32(int capacity) : base(FieldType.Int)
            {
                buf = new int[capacity];
            }

            public override Variant this[int index]
            {
                get { return Variant.Int(buf[index]); }
                set
                {
                    if (value.bitMask != 4)
                        throw new ArgumentException();
                    buf[index] = value.d3;
                }
            }
        }

        public class Int64 : Field
        {
            private long[] buf;

            public Int64(int capacity) : base(FieldType.Long)
            {
                buf = new long[capacity];
            }

            public override Variant this[int index]
            {
                get { return Variant.Long(buf[index]); }
                set
                {
                    if (value.bitMask != 8)
                        throw new ArgumentException();
                    buf[index] = value.d4;
                }
            }
        }

        public class HashedSlice8 : Field
        {
            private byte[] bytes = new byte[32768];
            private int offset = 0;
            private Hydrogen.Index.HashSet<ByteSlice> s = new Index.HashSet<ByteSlice>(new ByteSliceEqualityComparer(), 256);
            private byte[] buf;

            public HashedSlice8(int capacity) : base(FieldType.HashedSlice8)
            {
                buf = new byte[capacity];
            }

            public override Variant this[int index]
            {
                get 
                {
                    var entry = buf[index];
                    var bs = s.GetEntryValue(entry);
                    return Variant.ByteSlice(bs);
                }
                set
                {
                    if (value.bitMask != 2048)
                        throw new ArgumentException();
                    var entry = s.GetEntry(value.d12);
                    if (entry >= 0)
                    {
                        buf[index] = (byte)entry;
                    }                        
                    else
                    {
                        Buffer.BlockCopy(value.d12.Bytes, value.d12.Offset, bytes, offset, value.d12.Count);
                        var bs = new ByteSlice(bytes, offset, value.d12.Count);
                        s.Insert(bs);
                        entry = s.GetEntry(bs);
                        buf[index] = (byte)entry;
                        offset += value.d12.Count;
                    }
                }
            }
        }

        public class HashedSlice16 : Field
        {
            private byte[] bytes = new byte[32768];
            private int offset = 0;
            private Hydrogen.Index.HashSet<ByteSlice> s = new Index.HashSet<ByteSlice>(new ByteSliceEqualityComparer(), 65536);
            private byte[] buf;

            public HashedSlice16(int capacity) : base(FieldType.HashedSlice8)
            {
                buf = new byte[capacity];
            }

            public override Variant this[int index]
            {
                get
                {
                    var entry = buf[index];
                    var bs = s.GetEntryValue(entry);
                    return Variant.ByteSlice(bs);
                }
                set
                {
                    if (value.bitMask != 2048)
                        throw new ArgumentException();
                    var entry = s.GetEntry(value.d12);
                    if (entry >= 0)
                    {
                        buf[index] = (byte)entry;
                    }
                    else
                    {
                        Buffer.BlockCopy(value.d12.Bytes, value.d12.Offset, bytes, offset, value.d12.Count);
                        var bs = new ByteSlice(bytes, offset, value.d12.Count);
                        s.Insert(bs);
                        entry = s.GetEntry(bs);
                        buf[index] = (byte)entry;
                        offset += value.d12.Count;
                    }
                }
            }
        }

        public class UInt64 : Field
        {
            private ulong[] buf;

            public UInt64(int capacity) : base(FieldType.ULong)
            {
                buf = new ulong[capacity];
            }

            public override Variant this[int index]
            {
                get { return Variant.ULong(buf[index]); }
                set
                {
                    if (value.bitMask != 128)
                        throw new ArgumentException();
                    buf[index] = value.d8;
                }
            }
        }

        public class UInt32 : Field
        {
            private uint[] buf;

            public UInt32(int capacity) : base(FieldType.UInt)
            {
                buf = new uint[capacity];
            }

            public override Variant this[int index]
            {
                get { return Variant.UInt(buf[index]); }
                set
                {
                    if (value.bitMask != 64)
                        throw new ArgumentException();
                    buf[index] = value.d7;
                }
            }
        }

        public class UInt16 : Field
        {
            private ushort[] buf;

            public UInt16(int capacity) : base(FieldType.UShort)
            {
                buf = new ushort[capacity];
            }

            public override Variant this[int index]
            {
                get { return Variant.UShort(buf[index]); }
                set
                {
                    if (value.bitMask != 32)
                        throw new ArgumentException();
                    buf[index] = value.d6;
                }
            }
        }

        public class Float : Field
        {
            private float[] buf;

            public Float(int capacity) : base(FieldType.Float)
            {
                buf = new float[capacity];
            }

            public override Variant this[int index]
            {
                get { return Variant.Float(buf[index]); }
                set
                {
                    if (value.bitMask != 512)
                        throw new ArgumentException();
                    buf[index] = value.d10;
                }
            }
        }

        public class Double : Field
        {
            private double[] buf;

            public Double(int capacity) : base(FieldType.Double)
            {
                buf = new double[capacity];
            }

            public override Variant this[int index]
            {
                get { return Variant.Double(buf[index]); }
                set
                {
                    if (value.bitMask != 1024)
                        throw new ArgumentException();
                    buf[index] = value.d11;
                }
            }
        }
    }
}

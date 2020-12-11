using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hydrogen
{
    public abstract class Field : IField
    {
        protected Field(FieldType type)
        {
            Type = type;
        }

        public FieldType Type { get; }
        public abstract Variant this[int index] { get; set; }

        public class Boolean : Field
        {
            private bool[] buf;
            public Boolean(int capacity)
                : base(FieldType.Boolean)
            {
                buf = new bool[capacity];
            }

            public override Variant this[int index]
            {
                get { return Variant.Boolean(buf[index]); }
                set 
                {
                    if (value.bitMask != 1)
                        throw new ArgumentException();
                    buf[index] = value.d1;
                }
            }
        }

        public class SByte : Field
        {
            private sbyte[] buf;
            public SByte(int capacity)
                : base(FieldType.Int8)
            {
                buf = new sbyte[capacity];
            }

            public override Variant this[int index]
            {
                get { return Variant.Int8(buf[index]); }
                set
                {
                    if (value.bitMask != 2)
                        throw new ArgumentException();
                    buf[index] = value.d2;
                }
            }
        }

        public class Short : Field
        {
            private short[] buf;
            public Short(int capacity)
                : base(FieldType.Int16)
            {
                buf = new short[capacity];
            }

            public override Variant this[int index]
            {
                get { return Variant.Int16(buf[index]); }
                set
                {
                    if (value.bitMask != 4)
                        throw new ArgumentException();
                    buf[index] = value.d3;
                }
            }
        }

        public class Int : Field
        {
            private int[] buf;
            public Int(int capacity)
                : base(FieldType.Int32)
            {
                buf = new int[capacity];
            }

            public override Variant this[int index]
            {
                get { return Variant.Int32(buf[index]); }
                set
                {
                    if (value.bitMask != 8)
                        throw new ArgumentException();
                    buf[index] = value.d4;
                }
            }
        }

        public class Long : Field
        {
            private long[] buf;
            public Long(int capacity)
                : base(FieldType.Int64)
            {
                buf = new long[capacity];
            }

            public override Variant this[int index]
            {
                get { return Variant.Int64(buf[index]); }
                set
                {
                    if (value.bitMask != 16)
                        throw new ArgumentException();
                    buf[index] = value.d5;
                }
            }
        }

        public class Byte : Field
        {
            private byte[] buf;
            public Byte(int capacity)
                : base(FieldType.UInt8)
            {
                buf = new byte[capacity];
            }

            public override Variant this[int index]
            {
                get { return Variant.UInt8(buf[index]); }
                set
                {
                    if (value.bitMask != 32)
                        throw new ArgumentException();
                    buf[index] = value.d6;
                }
            }
        }

        public class UShort : Field
        {
            private ushort[] buf;
            public UShort(int capacity)
                : base(FieldType.UInt16)
            {
                buf = new ushort[capacity];
            }

            public override Variant this[int index]
            {
                get { return Variant.UInt16(buf[index]); }
                set
                {
                    if (value.bitMask != 64)
                        throw new ArgumentException();
                    buf[index] = value.d7;
                }
            }
        }

        public class UInt : Field
        {
            private uint[] buf;
            public UInt(int capacity)
                : base(FieldType.UInt32)
            {
                buf = new uint[capacity];
            }

            public override Variant this[int index]
            {
                get { return Variant.UInt32(buf[index]); }
                set
                {
                    if (value.bitMask != 128)
                        throw new ArgumentException();
                    buf[index] = value.d8;
                }
            }
        }

        public class ULong : Field
        {
            private ulong[] buf;
            public ULong(int capacity)
                : base(FieldType.UInt64)
            {
                buf = new ulong[capacity];
            }

            public override Variant this[int index]
            {
                get { return Variant.UInt64(buf[index]); }
                set
                {
                    if (value.bitMask != 256)
                        throw new ArgumentException();
                    buf[index] = value.d9;
                }
            }
        }

        public class Float : Field
        {
            private float[] buf;
            public Float(int capacity)
                : base(FieldType.Float)
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
            public Double(int capacity)
                : base(FieldType.Double)
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

        public class Char : Field
        {
            private char[] buf;
            public Char(int capacity)
                : base(FieldType.Char)
            {
                buf = new char[capacity];
            }

            public override Variant this[int index]
            {
                get { return Variant.Char(buf[index]); }
                set
                {
                    if (value.bitMask != 2048)
                        throw new ArgumentException();
                    buf[index] = value.d12;
                }
            }
        }
    }
}

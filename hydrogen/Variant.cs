using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Hydrogen
{
    [StructLayout(LayoutKind.Explicit)]
    public struct Variant : IEquatable<Variant>
    {
        [FieldOffset(0)]
        public int bitMask;
        [FieldOffset(4)]
        public bool d1;
        [FieldOffset(4)]
        public sbyte d2;
        [FieldOffset(4)]
        public short d3;
        [FieldOffset(4)]
        public int d4;
        [FieldOffset(4)]
        public long d5;
        [FieldOffset(4)]
        public byte d6;
        [FieldOffset(4)]
        public ushort d7;
        [FieldOffset(4)]
        public uint d8;
        [FieldOffset(4)]
        public ulong d9;
        [FieldOffset(4)]
        public float d10;
        [FieldOffset(4)]
        public double d11;
        [FieldOffset(4)]
        public char d12;

        public bool Equals(Variant other)
        {
            return (bitMask, other.bitMask) switch
            { 
                (1, 1) => d1 == other.d1,
                (2, 2) => d2 == other.d2,
                (4, 4) => d3 == other.d3,
                (8, 8) => d4 == other.d4,
                (16, 16) => d5 == other.d5,
                (32, 32) => d6 == other.d6,
                (64, 64) => d7 == other.d7,
                (128, 128) => d8 == other.d8,
                (256, 256) => d9 == other.d9,
                (512, 512) => d10 == other.d10,
                (1024, 1024) => d11 == other.d11,
                (2048, 2048) => d12 == other.d12,
                _ => false
            };
        }

        public static Variant Boolean(bool value)
        {
            return new Variant { bitMask = 1, d1 = value };
        }

        public static Variant Int8(sbyte value)
        {
            return new Variant { bitMask = 2, d2 = value };
        }

        public static Variant Int16(short value)
        {
            return new Variant { bitMask = 4, d3 = value };
        }

        public static Variant Int32(int value)
        {
            return new Variant { bitMask = 8, d4 = value };
        }

        public static Variant Int64(long value)
        {
            return new Variant { bitMask = 16, d5 = value };
        }

        public static Variant UInt8(byte value)
        {
            return new Variant { bitMask = 32, d6 = value };
        }

        public static Variant UInt16(ushort value)
        {
            return new Variant { bitMask = 64, d7 = value };
        }

        public static Variant UInt32(uint value)
        {
            return new Variant { bitMask = 128, d8 = value };
        }

        public static Variant UInt64(ulong value)
        {
            return new Variant { bitMask = 256, d9 = value };
        }

        public static Variant Float(float value)
        {
            return new Variant { bitMask = 512, d10 = value };
        }

        public static Variant Double(double value)
        {
            return new Variant { bitMask = 1024, d11 = value };
        }

        public static Variant Char(char value)
        {
            return new Variant { bitMask = 2048, d12 = value };
        }
    }
}

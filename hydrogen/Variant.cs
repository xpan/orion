using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Text;

namespace Hydrogen
{
    [StructLayout(LayoutKind.Explicit)]
    public struct Variant : IEquatable<Variant>
    {
        [FieldOffset(0)] public int bitMask;
        [FieldOffset(4)] public sbyte d1;
        [FieldOffset(4)] public short d2;
        [FieldOffset(4)] public int d3;
        [FieldOffset(4)] public long d4;
        [FieldOffset(4)] public byte d5;
        [FieldOffset(4)] public ushort d6;
        [FieldOffset(4)] public uint d7;
        [FieldOffset(4)] public ulong d8;
        [FieldOffset(4)] public bool d9;
        [FieldOffset(4)] public float d10;
        [FieldOffset(4)] public double d11;

        public bool Equals([AllowNull] Variant other) => (bitMask, other.bitMask) switch
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
            _ => false
        };

        public override string ToString() => bitMask switch
        {
            1 => $"{d1}",
            2 => $"{d2}",
            4 => $"{d3}",
            8 => $"{d4}",
            16 => $"{d5}",
            32 => $"{d6}",
            64 => $"{d7}",
            128 => $"{d8}",
            256 => $"{d9}",
            512 => $"{d10}",
            1024 => $"{d11}",
            _ => throw new NotSupportedException()
        };

        public static bool operator ==(Variant l, Variant r) => l.Equals(r);
        public static bool operator !=(Variant l, Variant r) => !l.Equals(r);
        public static Variant SByte(sbyte value) => new Variant { bitMask = 1, d1 = value };

        public static Variant Short(short value) => new Variant { bitMask = 2, d2 = value };

        public static Variant Int(int value) => new Variant { bitMask = 4, d3 = value };

        public static Variant Long(long value) => new Variant { bitMask = 8, d4 = value };

        public static Variant Byte(byte value) => new Variant { bitMask = 16, d5 = value };

        public static Variant UShort(ushort value) => new Variant { bitMask = 32, d6 = value };

        public static Variant UInt(uint value) => new Variant { bitMask = 64, d7 = value };

        public static Variant ULong(ulong value) => new Variant { bitMask = 128, d8 = value };

        public static Variant Boolean(bool value) => new Variant { bitMask = 256, d9 = value };

        public static Variant Float(float value) => new Variant { bitMask = 512, d10 = value };

        public static Variant Double(double value) => new Variant { bitMask = 1024, d11 = value };
        public static Variant String(string value) => new Variant { bitMask = 2048 };

        public static Variant Create<T>(T value) => value switch
        {
            sbyte b => SByte(b),
            short b => Short(b),
            int b => Int(b),
            long b => Long(b),
            byte b => Byte(b),
            ushort b => UShort(b),
            uint b => UInt(b),
            ulong b => ULong(b),
            bool b => Boolean(b),
            float b => Float(b),
            double b => Double(b),
            _ => throw new ApplicationException()
        };
    }
}

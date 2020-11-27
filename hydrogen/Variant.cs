using Hydrogen.Index;
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
        [FieldOffset(8)] public sbyte d1;
        [FieldOffset(8)] public short d2;
        [FieldOffset(8)] public int d3;
        [FieldOffset(8)] public long d4;
        [FieldOffset(8)] public byte d5;
        [FieldOffset(8)] public ushort d6;
        [FieldOffset(8)] public uint d7;
        [FieldOffset(8)] public ulong d8;
        [FieldOffset(8)] public bool d9;
        [FieldOffset(8)] public float d10;
        [FieldOffset(8)] public double d11;
        [FieldOffset(8)] public ByteSlice d12;
        [FieldOffset(8)] public char d13;

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
            (2048, 2048) => d12 == other.d12,
            (4096, 4096) => d13 == other.d13,
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
            2048 => $"{d12}",
            4096 => $"{d13}",
            _ => "INVALID"
        };

        public override bool Equals(object obj)
        {
            return Equals((Variant)obj);
        }

        public override int GetHashCode()
        {
            return bitMask.GetHashCode() * 17 + d8.GetHashCode();
        }

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

        public static Variant ByteSlice(in ByteSlice value) => new Variant { bitMask = 2048, d12 = value };

        public static Variant Char(char value) => new Variant { bitMask = 4096, d13 = value };
    }
}

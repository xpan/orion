using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen
{
    public class Record
    {
        private ITable table;
        internal Record(ITable table, int index, int bitMask)
        {
            this.table = table;
            Index = index;
            BitMask = bitMask;
        }

        public int Index { get; }
        public int BitMask { get; private set; }
        public void SetValue(FieldSpec fieldSpec, in Variant value)
        {
            if (BitMask >= 0)
            {
                var i = Array.IndexOf(table.FieldSpecs, fieldSpec);
                BitMask |= (1 << i);
            }

            var field = table.GetField(fieldSpec);
            switch (field, fieldSpec.Type, value.bitMask)
            {
                case (Field<bool> f, FieldType.Boolean, 256):
                    f[Index] = value.d9;
                    break;
                case (Field<byte> f, FieldType.Byte, 16):
                    f[Index] = value.d5;
                    break;
                case (Field<ushort> f, FieldType.UShort, 32):
                    f[Index] = value.d6;
                    break;
                case (Field<uint> f, FieldType.UInt, 64):
                    f[Index] = value.d7;
                    break;
                case (Field<ulong> f, FieldType.ULong, 128):
                    f[Index] = value.d8;
                    break;
                case (Field<sbyte> f, FieldType.SByte, 1):
                    f[Index] = value.d1;
                    break;
                case (Field<short> f, FieldType.Short, 2):
                    f[Index] = value.d2;
                    break;
                case (Field<int> f, FieldType.Int, 4):
                    f[Index] = value.d3;
                    break;
                case (Field<long> f, FieldType.Long, 8):
                    f[Index] = value.d4;
                    break;
                case (Field<float> f, FieldType.Float, 512):
                    f[Index] = value.d10;
                    break;
                case (Field<double> f, FieldType.Double, 1024):
                    f[Index] = value.d11;
                    break;
            }            
        }
    }
}

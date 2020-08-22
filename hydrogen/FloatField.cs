using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen
{
    public class FloatField : IField
    {
        private float[] buf;
        public FloatField(int capacity)
        {
            buf = new float[capacity];
        }
        public Variant this[int index]
        {
            get { return Variant.Float(buf[index]); }
            set
            {
                if (value.bitMask != 512)
                    throw new ArgumentException();
                buf[index] = value.d10;
            }
        }

        public FieldType Type => FieldType.Float;
    }
}

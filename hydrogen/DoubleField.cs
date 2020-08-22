using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen
{
    public class DoubleField : IField
    {
        private double[] buf;
        public DoubleField(int capacity)
        {
            buf = new double[capacity];
        }
        public Variant this[int index]
        {
            get { return Variant.Double(buf[index]); }
            set
            {
                if (value.bitMask != 1024)
                    throw new ArgumentException();
                buf[index] = value.d11;
            }
        }

        public FieldType Type => FieldType.Double;
    }
}

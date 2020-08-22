﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen
{
    public class IntField : IField
    {
        private int[] buf;
        public IntField(int capacity)
        {
            buf = new int[capacity];
        }
        public Variant this[int index]
        {
            get { return Variant.Int(buf[index]); }
            set
            {
                if (value.bitMask != 4)
                    throw new ArgumentException();
                buf[index] = value.d3;
            }
        }

        public FieldType Type => FieldType.Int;
    }
}

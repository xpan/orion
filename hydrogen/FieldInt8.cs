﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen
{
    public class FieldInt8 : IField
    {
        private byte[] buf;
        public FieldInt8(int capacity)
        {
            buf = new byte[capacity];
        }
        public Variant this[int index]
        {
            get { return Variant.Byte(buf[index]); }
            set
            {
                if (value.bitMask != 16)
                    throw new ArgumentException();
                buf[index] = value.d5;
            }
        }

        public FieldType Type => FieldType.Byte;
    }
}
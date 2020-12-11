﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.Arrays
{
    public struct Array1<T>
    {
        public T d1;
        public int Length => 1;
        public T this[int index] => index switch
        {
            0 => d1,
            _ => throw new IndexOutOfRangeException()
        };

        public override string ToString()
        {
            return $"[{d1}]";
        }
    }
}

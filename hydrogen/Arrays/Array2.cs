﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen.Arrays
{
    public struct Array2<T>
    {
        public T d1;
        public T d2;
        public int Length => 2;
        public T this[int index] => index switch
        {
            0 => d1,
            1 => d2,
            _ => throw new IndexOutOfRangeException()
        };

        public override string ToString()
        {
            return $"[{d1},{d2}]";
        }
    }
}

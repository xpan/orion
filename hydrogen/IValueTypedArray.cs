using System;
using System.Collections.Generic;
using System.Text;

namespace Hydrogen
{
    public interface IValueTypedArray<T>
    {
        public int Length { get; }
        public T this[int index] { get;set; }
    }
}

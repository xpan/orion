﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hydrogen
{
    public interface IField
    {
        Variant this[int index] { get;set; }
        FieldType Type { get; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlineArray
{
    [System.Runtime.CompilerServices.InlineArray(10)]
    public struct InlineBuffer
    {
        private int _element;
    }
}

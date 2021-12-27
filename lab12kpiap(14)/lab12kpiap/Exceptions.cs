using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12kpiap
{
    class ZeroException : Exception
    {
        public ZeroException(string message) : base(message)
        { }
    }
    class RangeException : Exception
    {
        public RangeException(string message) : base(message)
        { }
    }
    class Exceptions
    {
    }
}

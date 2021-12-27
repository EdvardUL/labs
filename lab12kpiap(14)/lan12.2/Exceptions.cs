using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lan12._2
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

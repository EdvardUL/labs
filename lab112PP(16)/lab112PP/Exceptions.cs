using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab112PP
{
    class ZeroException : Exception
    {
        public ZeroException(string message) : base(message)
        { }
    }
    class MaxLvlException : Exception
    {
        public MaxLvlException(string message) : base(message)
        { }
    }
    class PersonException : Exception
    {
        public PersonException(string message) : base(message)
        { }
    }
}

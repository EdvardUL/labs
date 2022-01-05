using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab131PP
{
    class ZeroException:Exception
    {
        public ZeroException(string message) : base(message)
        { }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab112PP
{
    public class MyClassEventArgs
    {
        public string message;
        public MyClassEventArgs(string s)
        {
            message = s;
        }
        public override string ToString()
        {
            return $"{message}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab131PP
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        static double FirstY(int x)
        {
            if (x < 0) throw new ZeroException("x cant be zero");
            return (Math.Exp(2 * x) + Math.Sqrt(x)) / Math.Abs(Math.Pow(x, 2) + 6 * x - 27);
        }
        static double Secondy(int x)
        {
            if (x < 0) throw new ZeroException("x cant be zero");
            return (Math.Exp(2 * x) + Math.Sqrt(x)) / Math.Abs(Math.Pow(x, 2) + 6 * x - 27);
        }
    }
}

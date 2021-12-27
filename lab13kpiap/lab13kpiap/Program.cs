using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace lab13kpiap
{
    class Program
    {
        public delegate double Function(double a);
        static void Main(string[] args)
        {
            CountFunc(-1, 1, 0.04, Math.Tan);
            Console.WriteLine("~~~~~~~~~~~~~~~~");
            CountCotFunc(-1, 1, 0.04, Math.Tan);
        }
        public static void CountFunc(double a, double b,double c, Function F)
        {
            for (double i = a; i <= b; i += c)
            {
                Console.WriteLine(F(i));
            }
        }
        public static void CountCotFunc(double a, double b, double c, Function F)
        {
            for (double i = a; i <= b; i += c)
            {
                Console.WriteLine(1/F(i));
            }
        }
    }
}

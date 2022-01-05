using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12PP
{
    class Program
    {
        static void Main(string[] args)
        {
            Pyramid pyr = new Pyramid();
            Console.WriteLine(((Foundation)pyr).Square());
            Console.WriteLine(((Foundation)pyr).Perimeter());
            Console.WriteLine(((SquareSide)pyr).SideSquare());
            Console.WriteLine(((Capacity)pyr).Capacity());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab13PP
{
    class Program
    {
        static void Main(string[] args)
        {
            Restaurant test = new Restaurant("sto rengen", "Bday", 100, 8, 15, true);
            Console.WriteLine(test.AveragePrice());
            test.Dishes = 21;
        }
    }
}

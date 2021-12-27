using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lan12._2
{
    class Program
    {

        static void Main(string[] args)
        {
            Employee John = new Employee("Smith John Barnett", 423512,730, 15);
            Console.WriteLine(John.MonthSalary());
            John.Promotion(100);
            John.HourlyRate = 100;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Laba19._2_KPIAP
{
    class Program
    {
        static void Main(string[] args)
        {
            Tovar[] arr = new Tovar[4];
            arr[0] = new Tovar(12, 11, "a", "abc");
            arr[1] = new Tovar(12, 11, "a", "abc");
            arr[2] = new Tovar(13, 10, "b", "qwe");
            arr[3] = new Tovar(14, 19, "c", "zxc");
            var zxc = arr.DistinctBy(x => x.Name).ToList();
            foreach (var item in zxc)

            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
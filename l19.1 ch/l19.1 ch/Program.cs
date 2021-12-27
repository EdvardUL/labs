using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace l19._1_ch
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            double[] mas = new double[n];
            fillArray(mas);
            Sort(mas);
            Console.ReadKey();
        }
        static void Sort(double[] arr)
        {
            var zxc = arr.Where(X => X < 0).Count();
            var abc = arr.OrderBy(s => s);
            foreach (var item in abc)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(zxc);
        }
        static void fillArray(double[] arr)
        {
            Random rand = new Random();
            for (int x = 0; x < arr.Length; x++)
            {
                arr[x] = rand.Next(-20,20) ;
                Console.WriteLine(arr[x]);
            }
        }
    }
}

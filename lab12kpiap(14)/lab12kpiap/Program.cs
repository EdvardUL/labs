using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab12kpiap
{
    class Program
    {
        static double Square(int r)
        {
            if (r <= 0) throw new ZeroException("cant be 0 or less");
            return Math.PI * Math.Pow(r, 2);
        }
        static double Perimeter(int r)
        {
            if (r <= 0) throw new ZeroException("cant be 0 or less");
            return Math.PI * 2 *r;
        }

        static string InsertElements(string[] arr,int K,int M)
        {
            try
            {
                string temp = "";
                for (int i = 0; i < M; i++)
                {
                    temp = temp.Insert(0, "0");
                }
                string str = string.Join("", arr);
                str = str.Insert(K - 1, temp);
                return str;
            }
            catch
            {
                if (K <= 0) throw new ZeroException("cant be 0 or less");
                if (M <= 0) throw new ZeroException("cant be 0 or less");
                if (arr.Length <= K) throw new RangeException($"cant be more than {arr.Length}");
                if (M >= 10) throw new RangeException("cant be more than 10");
            }
            return "";
        }
        static void Main(string[] args)
        {
           //Console.WriteLine(Square(0));
            //Console.WriteLine(Perimeter(5));
            //Console.WriteLine(InsertElements(new string[] {"r","r","r","5","5"},0,5));
        }
    }
}

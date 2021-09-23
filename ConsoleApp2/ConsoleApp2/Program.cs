using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void lab2(double R)
        {
            Console.WriteLine("Площадь равна " + Math.PI * (R * R));
            Console.WriteLine("Длинна окружности равна " + 2*Math.PI * R);
        }
        
        static void lab31(int x)
        {
            double h = 0.09, xk = 1, xn = 0.1, Res;
            for(int i = 0;i<x && xn<xk;xn=+h,i++)
            {
                Res = Math.Exp(i * Math.Cos(Math.PI / 4.0)) * Math.Cos(i * Math.Cos(Math.PI / 4.0));
                Console.WriteLine(Res);
            }
        }

        static double lab32_1(int n)
        {
            double R=0;
            for(int i = 1;i<=n;i++)
            {
                R +=1.0/i;
            }
            return R;
        }
        
        static int lab32_2(int n)
        {
            int Res = 0;
            while (n > 0)
            {
                Res = Res*10 +(n % 10);
                n /= 10;
            }
            return Res;
        }
        static void DisplayArray(string[] arr) => Console.WriteLine(string.Join(" ", arr));

        static double lab4_1_Neg(int[] arr)
        {
            double Neg =1;
            for(int i = 0;i<arr.Length;i++)
            {
                if(arr[i]<0)
                {
                    Neg *= arr[i];
                }
            }
            return Neg;
        }

        static double lab4_1_Pos(int[] arr)
        {
            double Pos = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    Pos *= arr[i];
                }
            }
            return Pos;
        }
        static int lab4_2(int[] arr)
        {
            int ElementNum=0,Sum=0;
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i]>0)
                {
                    ElementNum = i;
                }
            }
            for (int i = 0; i <= ElementNum; i++)
            {
                Sum += arr[i];
            }
            return Sum;
        }

        static void Main(string[] args)
        {
            int[] arr = { 1, -3, 2, 5, -6 };
            Console.WriteLine(lab4_2(arr));
        }
    }
}

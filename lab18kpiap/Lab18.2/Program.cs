using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab18._2
{
    struct Passanger : IComparable
    {
        public string FIO;
        public int amountOfThings;
        public int weight;
        public double AverageWeight
        {
            get
            {
                return (double)weight / amountOfThings;
            }
        }
        public int CompareTo(object obj)
        {
            return amountOfThings.CompareTo(((Passanger)obj).amountOfThings);
        }
        public override string ToString()
        {
            return FIO + " " + amountOfThings + " " + weight + "\n";
        }
    }
    class Program
    {
        
        
            static void Main(string[] args)
            {
                Console.Write("Введите вес багажа: ");
                double given = Convert.ToDouble(Console.ReadLine());
                ArrayList arrayList = new ArrayList();
                string[] text = File.ReadAllLines("input.txt");
                foreach (string i in text)
                {
                    int n1 = i.IndexOf('#');
                    int n2 = i.IndexOf('#', n1 + 1);
                    Passanger passanger = new Passanger()
                    {
                        FIO = i.Substring(0, n1 - 1),
                        amountOfThings = Convert.ToInt32(i.Substring(n1 + 1, n2 - n1 - 1)),
                        weight = Convert.ToInt32(i.Substring(n2 + 1))
                    };
                    arrayList.Add(passanger);
                }
                arrayList.Sort();
                string str = " ";
                Passanger p;
                foreach (var i in arrayList)
                {
                    p = (Passanger)i;
                    if (p.AverageWeight > given)
                        str += p;
                }
                File.WriteAllText("output.txt", str);

                Disk disk1 = new Disk("Blinding Lights", "Weeknd");
                Disk disk2 = new Disk("Sort of blood", "KINO");
                List<Disk> list = new List<Disk>();
                Catalog catalog = new Catalog(list);
                catalog.AddDisk(disk1);
                catalog.AddDisk(disk2);
                catalog.AddDisk();
                catalog.Show();
                Console.WriteLine("zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz");
                catalog.DeleteDisk(disk2);
                catalog.Show();
                Console.WriteLine("zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz");

                Console.ReadKey();
            }
        
    }
}

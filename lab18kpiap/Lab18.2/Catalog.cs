using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab18._2
{
    class Catalog
    {
        public Hashtable ht = new Hashtable();
        public List<Disk> Disk;
        private int count;
        public Catalog(List<Disk> disk)
        {
            Disk = disk;
        }
        public void AddDisk()
        {
            Console.WriteLine("Enter name, and Singer");
            string name = Console.ReadLine();
            string sinker = Console.ReadLine();
            Disk newD = new Disk(name, sinker);
            Disk.Add(newD);
            ht.Add(newD.Name, newD.Sinker);
            Console.WriteLine("Произошло успешное добавление");
        }
        public void AddDisk(string name, string sinker)
        {
            Disk newD = new Disk(name, sinker);
            Disk.Add(newD);
            ht.Add(newD.Name, newD.Sinker);
            Console.WriteLine("Произошло успешное добавление");
        }
        public void AddDisk(Disk disk)
        {
            Disk.Add(disk);
            ht.Add(disk.Name, disk.Sinker);
            Console.WriteLine("Произошло успешное добавление");
        }
        public void DeleteDisk()
        {
            Console.WriteLine("Enter name, and Sinker");
            string name = Console.ReadLine();
            string sinker = Console.ReadLine();
            Disk newD = new Disk(name, sinker);
            if (Disk.Contains(newD))
            {
                Disk.Remove(newD);
                ht.Remove(newD);
            }
            else Console.WriteLine("Error");
        }
        public void DeleteDisk(Disk newD)
        {
            if (Disk.Contains(newD))
            {
                Disk.Remove(newD);
                ht.Remove(newD.Name);
            }
            else Console.WriteLine("Error");
        }
        public void DeleteSing()
        {
            Console.WriteLine("Enter name of song and Singer");
            string song = Console.ReadLine();
            string sinker = Console.ReadLine();
            Disk disk = new Disk(song, sinker);
            if (Disk.Contains(disk))
            {
                disk.Name = "Empty" + count;
                count++;
            }
        }
        public void Show()
        {
            Console.WriteLine("Enter Key what you want to watch ( 1 or 2 ) ");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:
                    ICollection keys = ht.Keys;
                    foreach (string s in keys)
                        Console.WriteLine(s + ": " + ht[s]);
                    break;
                case 2:
                    Console.WriteLine("Error");
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }
        }
    }
}

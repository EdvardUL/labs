using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Soap;
using System.IO;



namespace lab10kpiap
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Pet dog = new Pet("doglike", 4, 6, "Booze");
            Console.WriteLine(dog.ToString());
            dog.ChangeDescendants(7);
            Console.WriteLine(dog.ToString());
            Pet[] doggies = new Pet[4];
            doggies[0] = new Pet("doglike", 4, 6, "Booze");
            doggies[1] = new Pet("doglike", 4, 8, "Baxter");
            doggies[2] = new Pet("doglike", 4, 2, "Leo");
            doggies[3] = new Pet("doglike", 4, 0, "Zeus");
            dog.ShortestNickname(doggies);
            dog.InputData();
            Console.WriteLine(doggies[0].CompareTo(doggies[1]));
            Pet[] D = { doggies[0], doggies[1], doggies[2] };
            Array.Sort(D);
            foreach (var obj in D)
            {
                Console.WriteLine(obj);//сортировка по возрастанию
            }
            Pet X = (Pet)dog.Clone();
            Console.WriteLine(X);*/
            Pet dog = new Pet("doglike", 4, 6, "Booze");
            Animal lizard = new Animal("lizard", 5, 5);
            BinaryFormatter formatter = new BinaryFormatter();
            // получаем поток, куда будем записывать сериализованный объект
            using (FileStream fs = new FileStream("animals.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, dog);
                formatter.Serialize(fs, lizard);
                Console.WriteLine("Объекты сериализован(Bin)");
            }
            SoapFormatter formatter2 = new SoapFormatter();
            // получаем поток, куда будем записывать сериализованный объект
            using (FileStream fs = new FileStream("animals.soap", FileMode.OpenOrCreate))
            {
                formatter2.Serialize(fs, dog);
                formatter2.Serialize(fs, dog);

                Console.WriteLine("Объекты сериализован(Soap)");
            }
            XmlSerializer formatter3 = new XmlSerializer(typeof(Pet));

            // получаем поток, куда будем записывать сериализованный объект
            using (FileStream fs = new FileStream("animals.xml", FileMode.OpenOrCreate))
            {
                formatter3.Serialize(fs,dog);
                Console.WriteLine("Объект сериализован(XML)");
            }
        }
    }
}

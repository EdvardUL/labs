using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace lab112PP
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassPaladin Flint = new ClassPaladin(44, "Flint", "Dwarf", "Male", "Eelastree", "lawful", 3);
            ClassRogue Jennet = new ClassRogue(21, "Jennet", "Elf", "Female", "freedom", "chaotic");
            ClassWarlock Teray = new ClassWarlock(25, "Teray", "Tiefling", "male", "Llos", "evil");
            /*Console.WriteLine(Flint.ShowYourself());
            Console.WriteLine(Flint.DivineSmite(3));
            Console.WriteLine(Flint.LayOnHands(5));
            Console.WriteLine("~~~~~~~~~~");
            Console.WriteLine(Jennet.ShowYourself());
            Console.WriteLine(Jennet.Expertise(new string[] {"Charisma","Agility","Intellect"}));
            Console.WriteLine(Jennet.SneakAttack(7));
            Console.WriteLine("~~~~~~~~~~");
            Console.WriteLine(Teray.ShowYourself());
            Console.WriteLine(Teray.Prais("human"));
            Console.WriteLine(Teray.EldritchInvocations(new string[] { "Thief of the 5 fates","Eyes of runes keeper"}));*/
            OathOfRevenge Kaylett = new OathOfRevenge(29, "Kaylett", "Drou", "female", "Eelastree", "neutral", 5);
            SacredOath Tallion = new SacredOath(31, "Tallion", "human", "male", "-", "chaotic", 6);
            Thief Balasar = new Thief(22, "Balasar", "Dragonborn", "male", "greed", "neutral", "Strenght");
            MagicTrickster Tahm = new MagicTrickster(25, "Tahm", "Half-orc", "male", "family", "neutral", "Wisdom");
            PatronFiend Cade = new PatronFiend(55, "Cade", "Halfling", "male", "Llos", "evil");
            PatronElder Shava = new PatronElder(27, "Shava", "Elf", "female", "Llos", "evil");
            /*Console.WriteLine(Kaylett.ShowYourself());
            Console.WriteLine(Kaylett.DivineSmite(3));
            Console.WriteLine(Kaylett.LayOnHands(5));
            Console.WriteLine(Kaylett.ShowDogmats());
            Console.WriteLine("~~~~~~~~~~");
            Console.WriteLine(Tallion.ShowYourself());
            Console.WriteLine(Tallion.DivineSmite(3));
            Console.WriteLine(Tallion.LayOnHands(5));
            Console.WriteLine(Tallion.ShowDogmats());
            Console.WriteLine("~~~~~~~~~~");
            Console.WriteLine(Balasar.ShowYourself());
            Console.WriteLine(Balasar.Expertise(new string[] { "Charisma", "Agility", "Intellect" }));
            Console.WriteLine(Balasar.SneakAttack(7));
            Console.WriteLine(Balasar.WhatCanI());
            Console.WriteLine("~~~~~~~~~~");
            Console.WriteLine(Tahm.ShowYourself());
            Console.WriteLine(Tahm.Expertise(new string[] { "Charisma", "Agility", "Intellect" }));
            Console.WriteLine(Tahm.SneakAttack(7));
            Console.WriteLine(Tahm.WhatCanI()); 
            Console.WriteLine("~~~~~~~~~~");
            Console.WriteLine(Cade.ShowYourself());
            Console.WriteLine(Cade.Prais("human"));
            Console.WriteLine(Cade.EldritchInvocations(new string[] { "Thief of the 5 fates", "Eyes of runes keeper" }));
            Console.WriteLine(Cade.WhatCanI());
            Console.WriteLine("~~~~~~~~~~");
            Console.WriteLine(Shava.ShowYourself());
            Console.WriteLine(Shava.Prais("human"));
            Console.WriteLine(Shava.EldritchInvocations(new string[] { "Thief of the 5 fates", "Eyes of runes keeper" }));
            Console.WriteLine(Shava.WhatCanI());
            Console.WriteLine("~~~~~~~~~~");*/
            var test = new AdventureArray();
            test.Add(Flint);
            test.Add(Jennet);
            test.Add(Teray);
            test.Add(Kaylett);
            test.Add(Tallion);
            test.Add(Balasar);
            test.Add(Tahm);
            test.PrintContents();
            test.Remove(Tahm);
            test.PrintContents();
            test.Add(Flint);
            test.PrintContents();
            test.Remove(Tahm);
            test.Insert(1, Jennet);
            test.PrintContents();
            Console.WriteLine(test.IndexOf(Flint));
            AdventureArray test2 = (AdventureArray)test.Clone();
            ClassPaladin[] order = new ClassPaladin[3];
            order[0] = new ClassPaladin(44, "Flint", "Dwarf", "Male", "Eelastree", "lawful", 3);
            order[1] = new OathOfRevenge(29, "Kaylett", "Drou", "female", "Eelastree", "neutral", 5);
            order[2] = new SacredOath(31, "Tallion", "human", "male", "-", "chaotic", 6);
            Array.Sort(order);
            Console.WriteLine(order[0]);
            Console.WriteLine(order[1]);
            Console.WriteLine(order[2]);
            ClassPaladin dopler = (ClassPaladin)order[2].Clone();
            Console.WriteLine(dopler);
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("Adventurers.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, Flint);
                formatter.Serialize(fs, Jennet);
                formatter.Serialize(fs, Teray);
                formatter.Serialize(fs, Kaylett);
                formatter.Serialize(fs, Tallion);
                formatter.Serialize(fs, Balasar);
                formatter.Serialize(fs, dopler);
                Console.WriteLine("Объекты сериализованы");
            }
            XmlSerializer formatter3 = new XmlSerializer(typeof(ClassPaladin));

            // получаем поток, куда будем записывать сериализованный объект
            using (FileStream fs = new FileStream("order.xml", FileMode.OpenOrCreate))
            {
                formatter3.Serialize(fs, order[0]);
                formatter3.Serialize(fs, order[1]);
                formatter3.Serialize(fs, order[2]);
                Console.WriteLine("Объект сериализован");
            }
        }
    }
}

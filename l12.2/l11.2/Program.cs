using System;
using System.Linq;

namespace l11._2
{
    class Program
    {
        static void Main(string[] args)
        {
            MG obj1 = new MG(120, "Kord", 61, "Female", 110, "none", 5, "None", 40);
            Kansen obj2 = new Kansen(110, "Tirpitz", 71, "Female", 12, "Iron blood", "BC", "empty", 5);
            TDoll obj3 = new TDoll(80, "AR-10", 55, "Female", 120, "none", 5);
            Operator obj4 = new Operator(90, "Chen", 63, "Female", "none", "Caster", 4);
            MG obj5 =new MG(91, "MG 42", 61, "Female", 120, "none", 5, "None", 40);
            HG obj6 = new HG(92, "Grizzly", 59, "Female", 80, "none", 5, "None", 78);
            Caster obj7 = new Caster(93, "none", 0, "unlnown", "none", "Caster", 4, 12, 3);
            BattleCruiser obj8 = new BattleCruiser(94, "New jersey", 68, "Female", 12, "Eagle union", "BB", "none", 6, 460, 8000);
            var test = new CreaturesArray();
            test.Add(obj1);
            test.Add(obj2);
            test.Add(obj3);
            test.Add(obj4);
            test.Add(obj5);
            test.Add(obj6);
            test.Add(obj7);
            test.PrintContents();
            test.Remove(obj7);
            test.PrintContents();
            test.Add(obj1);
            test.PrintContents();
            test.Remove(obj7);
            test.Insert(1, obj2);
            test.PrintContents();
            Console.WriteLine(test.IndexOf(obj1));
            //test.CompareTo(obj5);
            CreaturesArray test2 = (CreaturesArray)test.Clone();
            TDoll[] arrDoll = new TDoll[3];
            arrDoll[0] = new TDoll(80, "AR-10", 55, "Female", 110, "none", 5);
            arrDoll[1] = new MG(91, "MG 42", 61, "Female", 120, "none", 5, "None", 40);
            arrDoll[2] = new HG(92, "Grizzly", 59, "Female", 80, "none", 5, "None", 78);
            Array.Sort(arrDoll);
            Console.WriteLine(arrDoll[0]);
            Console.WriteLine(arrDoll[1]);
            Console.WriteLine(arrDoll[2]);
            TDoll obj66 = (TDoll)arrDoll[2].Clone();
            Console.WriteLine(obj66);
        }
    }
}

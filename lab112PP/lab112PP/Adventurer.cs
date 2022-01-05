using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab112PP
{
    abstract class Adventurer
    {
        int age;
        string name,race,gender;
        public int Age { get; set; }
        public string Name { get; set; }
        public string Race { get; set; }
        public string Gender { get; set; }
        public abstract string ShowYourself();
        public void RollDice()
        {
            Random rnd = new Random();
            int dice = rnd.Next(1, 20);
            Console.WriteLine($"Dice is rolling!");
            if (dice < 2)
            {
                Console.WriteLine($"you rolled {dice}");
                Console.WriteLine("Critical miss!");
            }
            if (2 < dice && dice < 5)
            {
                Console.WriteLine($"you rolled {dice}");

                Console.WriteLine("unfortunetly,you loss this roll");
            }
            if (5 < dice && dice < 10)
            {
                Console.WriteLine($"you rolled {dice}");
                Console.WriteLine("Yes! tou got this roll!");
            }
            if (10 < dice && dice < 19)
            {
                Console.WriteLine($"you rolled {dice}");
                Console.WriteLine("Holy crap,that almost critical!");
            }
            if (19 < dice && dice <= 20)
            {
                Console.WriteLine($"you rolled {dice}");
                Console.WriteLine("CRITICAL STRIKE");
            }
        }
    }
}

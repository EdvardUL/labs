using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab112PP
{
    class ClassRogue:Adventurer
    {
        string heroClass = "Rogue", creed, ideology;
        public string Creed { get; set; }
        public string Ideology { get; set; }
        public ClassRogue(int _age, string _name, string _race, string _gender, string _creed, string _ideology)
        {
            Age = _age;
            Name = _name;
            Race = _race;
            Gender = _gender;
            Creed = _creed;
            Ideology = _ideology;
        }
        public override string ShowYourself()
        {
            return $"My name is {Name},im a {Race}, im {Age} years old and im a {heroClass},and {Creed} is my creed and my ideology is {Ideology}";
        }
        virtual public string Expertise(string[] mastery)
        {
            return "i have mastery at skills: "+String.Join(",",mastery);
        }
        public int SneakAttack(int _damage)
        {
            Console.WriteLine("You stab a knife in back of your opponent!");
            Random rnd = new Random();
            int dice = rnd.Next(1,6);
            Console.WriteLine($"your total damage is {_damage+dice}");
            return _damage + dice;
        }
    }
}

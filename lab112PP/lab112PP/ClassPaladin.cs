using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab112PP
{
    class ClassPaladin : Adventurer
    {
        string heroClass = "paladin", idol, ideology;
        int lvl,hitpoints;
        public int Lvl
        {
            get { return lvl; }
            set { if(value < 20) { lvl = value; } }
        }

        public string Idol { get; set; }
        public string Ideology { get; set; }
        public ClassPaladin(int _age,string _name,string _race,string _gender,string _idol,string _ideology,int _lvl)
        {
            Age = _age;
            Name = _name;
            Race = _race;
            Gender = _gender;
            Idol = _idol;
            Ideology = _ideology;
            Lvl = _lvl;
        }
        public override string ShowYourself()
        {
            return $"My name is {Name},im a {Race}, im {Age} years old and im a {heroClass},i believe in {Idol} and my ideologt is {Ideology}";
        }
        public virtual int DivineSmite(int spellslot)
        {
            Random rnd = new Random();
            int dice = 0;
            for(int i = 0;i < spellslot;i++)
            {
                dice += rnd.Next(1, 8);
            }
            return dice;
        }
        public int LayOnHands(int spend)
        {
            hitpoints = lvl * 5;
            if(hitpoints < spend)
            {
                Console.WriteLine("you cant spend more than you have");
                return 0;
            }
            hitpoints -= spend;
            return hitpoints;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;


namespace lab112PP
{
    [Serializable]
    public class ClassRogue:Adventurer
    {
        public delegate void AdventurerHandler(object o, MyClassEventArgs s);
        public event AdventurerHandler Changing;
        public event AdventurerHandler Creating;
        string heroClass = "Rogue", creed, ideology;
        int lvl;
        public int Lvl
        {
            get { return lvl; }
            set 
            {
                if (value > 20) throw new MaxLvlException("more than max level");
                else 
                {
                    Changing = abc;
                    lvl = value;
                    Changing(this, new MyClassEventArgs("Обьект изменен"));
                }
            }
        }
        public string Creed
        {
            get { return creed; }
            set {
                Changing = abc;
                creed = value;
                Changing(this, new MyClassEventArgs("Обьект изменен"));
                }
        }
        public string Ideology 
        {
            get { return ideology; }
            set
            {
                Changing = abc;
                ideology = value;
                Changing(this, new MyClassEventArgs("Обьект изменен"));
            }
        }
        public ClassRogue(int _age, string _name, string _race, string _gender, string _creed, string _ideology)
        {
            Creating = abc;
            Age = _age;
            Name = _name;
            Race = _race;
            Gender = _gender;
            Creed = _creed;
            Ideology = _ideology;
            Creating(this, new MyClassEventArgs("Обьект создан"));
        }
        public ClassRogue()
        {
            Creating = abc;
            Age = 20;
            Name = "Lissandra";
            Race = "Drou";
            Gender = "Female";
            Creed = "Self";
            Ideology = "Chaotic";
            Creating(this, new MyClassEventArgs("Обьект создан"));
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
        public void abc(object o, MyClassEventArgs m)
        {
            Console.WriteLine($"{m}");
        }
    }
    
}

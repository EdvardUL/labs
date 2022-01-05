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
    public class ClassPaladin : Adventurer,ICloneable, IComparable
    {
        public delegate void AdventurerHandler(object o, MyClassEventArgs s);
        public event AdventurerHandler Changing;
        public event AdventurerHandler Creating;
        string heroClass = "paladin",idol,ideology;
        int lvl,hitpoints;
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

        public string Idol
        {
            get { return idol; }
            set
            {
                Changing = abc;
                idol = value;
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
        public ClassPaladin(int _age,string _name,string _race,string _gender,string _idol,string _ideology,int _lvl)
        {
            Creating = abc;
            Age = _age;
            Name = _name;
            Race = _race;
            Gender = _gender;
            Idol = _idol;
            Ideology = _ideology;
            Lvl = _lvl;
            Creating(this, new MyClassEventArgs("Обьект был создан"));
        }
        public ClassPaladin()
        {
            Creating = abc;
            Age = 20;
            Name = "John";
            Race = "Human";
            Gender = "Male";
            Idol = "Truth";
            Ideology = "Lawful";
            Lvl = 10;
            Creating(this, new MyClassEventArgs("Обьект был создан"));
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
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        public int CompareTo(object o)
        {
            ClassPaladin p = o as ClassPaladin;
            if (p != null)
                return this.Lvl.CompareTo(p.Lvl);
            else
                throw new Exception("Невозможно сравнить два объекта");
        }
        public void abc(object o, MyClassEventArgs m)
        {
            Console.WriteLine($"{m}");
        }
    }
}

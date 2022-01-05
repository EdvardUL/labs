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
    public class ClassWarlock:Adventurer
    {
        public delegate void AdventurerHandler(object o, MyClassEventArgs s);
        public event AdventurerHandler Changing;
        public event AdventurerHandler Creating;
        string heroClass = "warlock", demonLord, ideology;
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
        public string DemonLord 
        {
            get { return demonLord; }
            set
            {
                {
                    Changing = abc;
                    demonLord = value;
                    Changing(this, new MyClassEventArgs("Обьект изменен"));
                }
            }
        }
        public string Ideology
        {
            get { return ideology; }
            set
            {
                {
                    Changing = abc;
                    ideology = value;
                    Changing(this, new MyClassEventArgs("Обьект изменен"));
                }
            }
        }
        public ClassWarlock(int _age, string _name, string _race, string _gender, string _demonLord, string _ideology)
        {
            Creating = abc;
            Age = _age;
            Name = _name;
            Race = _race;
            Gender = _gender;
            DemonLord = _demonLord;
            Ideology = _ideology;
            Creating(this, new MyClassEventArgs("Обьект создан"));
        }
        public ClassWarlock()
        {
            Creating = abc;
            Age = 20;
            Name = "Mark";
            Race = "Tiefling";
            Gender = "Male";
            DemonLord = "Belzeebub";
            Ideology = "Evil";
            Creating(this, new MyClassEventArgs("Обьект создан"));
        }
        public override string ShowYourself()
        {
            return $"My name is {Name},im a {Race}, im {Age} years old and im a {heroClass},i pray to {DemonLord} and my ideologt is {Ideology}";
        }
        virtual public string EldritchInvocations(string[] spells)
        {
            return $"i know some invocations:"+ string.Join(",",spells);
        }
        public string Prais(string sacrifice)
        {
            return $"you praice your {DemonLord} and sacrifice {sacrifice} in bless of it";
        }
        public void abc(object o, MyClassEventArgs m)
        {
            Console.WriteLine($"{m}");
        }
    }
    
}

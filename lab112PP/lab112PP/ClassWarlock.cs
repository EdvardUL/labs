using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab112PP
{
    class ClassWarlock:Adventurer
    {
        string heroClass = "warlock", demonLord, ideology;
        public string DemonLord { get; set; }
        public string Ideology { get; set; }
        public ClassWarlock(int _age, string _name, string _race, string _gender, string _demonLord, string _ideology)
        {
            Age = _age;
            Name = _name;
            Race = _race;
            Gender = _gender;
            DemonLord = _demonLord;
            Ideology = _ideology;
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
    }
}

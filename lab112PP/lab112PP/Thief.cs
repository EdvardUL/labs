using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab112PP
{
    class Thief:ClassRogue
    {
        string newmastery;
        public string Newmastery{ get; set; }
        public Thief(int _age, string _name, string _race, string _gender, string _creed, string _ideology,string _newmastery):base(_age,_name,_race,_gender,_creed,_ideology)
        {
            newmastery = _newmastery;
        }
        public override string Expertise(string[] mastery)
        {
            return base.Expertise(mastery)+$"i found a new mastery:{Newmastery}";
        }
        public override string ShowYourself()
        {
            return base.ShowYourself()+" and now im a Thief";
        }
        public string WhatCanI()
        {
            return "Because im a Thief i can unnoticed steal from your pocket,make silent step,crowl into windows";
        }
    }
}

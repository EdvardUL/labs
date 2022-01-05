using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab112PP
{
    class PatronFiend:ClassWarlock
    {
        string newspell;
        public string Newspell { get; set; }
        public PatronFiend(int _age, string _name, string _race, string _gender, string _demonLord, string _ideology):base(_age, _name, _race, _gender, _demonLord, _ideology)
        {}
        public override string ShowYourself()
        {
            return base.ShowYourself()+"and im praice to Fiend";
        }
        public override string EldritchInvocations(string[] spells)
        {
            return base.EldritchInvocations(spells)+newspell;
        }
        public string WhatCanI()
        {
            return "Because my patron is Fiend i can use power of the hell to reach my aims";
        }
    }
}

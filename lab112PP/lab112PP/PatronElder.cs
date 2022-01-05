using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab112PP
{
    class PatronElder:ClassWarlock
    {
        string newspell;
        public string Newspell { get; set; }
        public PatronElder(int _age, string _name, string _race, string _gender, string _demonLord, string _ideology) : base(_age, _name, _race, _gender, _demonLord, _ideology)
        { }
        public override string ShowYourself()
        {
            return base.ShowYourself() + "and im praice to Fiend";
        }
        public override string EldritchInvocations(string[] spells)
        {
            return base.EldritchInvocations(spells) + newspell;
        }
        public string WhatCanI()
        {
            return "Because my patron is Greater Elder i can use power of darkests realites to manipulate the minds of my enemies";
        }
    }
}

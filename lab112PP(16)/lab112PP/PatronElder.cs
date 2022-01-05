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
    public class PatronElder:ClassWarlock
    {
        public delegate void AdventurerHandler(object o, MyClassEventArgs s);
        public event AdventurerHandler Changing;
        public event AdventurerHandler Creating;
        string newspell;
        public string Newspell 
        {
            get { return newspell; }
            set
            {
                Changing = abc;
                newspell = value;
                Changing(this, new MyClassEventArgs("Обьект изменен"));
            }
        }
        public PatronElder(int _age, string _name, string _race, string _gender, string _demonLord, string _ideology) : base(_age, _name, _race, _gender, _demonLord, _ideology)
        {
            Creating = abc;
            Creating(this, new MyClassEventArgs("Обьект создан"));
        }
        public PatronElder() : base()
        {
            Creating = abc;
            Creating(this, new MyClassEventArgs("Обьект создан"));
        }
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
        public void abc(object o, MyClassEventArgs m)
        {
            Console.WriteLine($"{m}");
        }
    }
}

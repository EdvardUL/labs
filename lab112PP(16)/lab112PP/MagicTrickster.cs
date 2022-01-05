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
    public class MagicTrickster:ClassRogue
    {
        public delegate void AdventurerHandler(object o, MyClassEventArgs s);
        public event AdventurerHandler Changing;
        public event AdventurerHandler Creating;
        string newmastery;
        public string Newmastery {
            get { return newmastery; }
            set
            {
                Changing = abc;
                newmastery = value;
                Changing(this, new MyClassEventArgs("Обьект изменен"));
            }
        }
        public MagicTrickster(int _age, string _name, string _race, string _gender, string _creed, string _ideology, string _newmastery) : base(_age, _name, _race, _gender, _creed, _ideology)
        {
            Creating = abc;
            newmastery = _newmastery;
            Creating(this, new MyClassEventArgs("Обьект создан"));
        }
        public MagicTrickster() : base()
        {
            Creating = abc;
            newmastery = "Athletic";
            Creating(this, new MyClassEventArgs("Обьект создан"));
        }

        public override string Expertise(string[] mastery)
        {
            return base.Expertise(mastery) + $"i found a new mastery:{Newmastery}";
        }
        public override string ShowYourself()
        {
            return base.ShowYourself() + " and now im a Magic Trickster";
        }
        public string WhatCanI()
        {
            return "Because im a Magic Tricster i can use magic to make myself invisible,help my teammates in fight with magic.";
        }
        public void abc(object o, MyClassEventArgs m)
        {
            Console.WriteLine($"{m}");
        }
    }
}

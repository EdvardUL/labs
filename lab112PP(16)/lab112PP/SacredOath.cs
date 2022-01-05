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
    class SacredOath:ClassPaladin
    {
        public delegate void AdventurerHandler(object o, MyClassEventArgs s);
        public event AdventurerHandler Creating;
        public SacredOath(int _age, string _name, string _race, string _gender, string _idol, string _ideology, int _lvl) : base(_age, _name, _race, _gender, _idol, _ideology, _lvl)
        {
            Creating = abc;
            Creating(this, new MyClassEventArgs("Обьект создан"));
        }
        public SacredOath() : base()
        {
            Creating = abc;
            Creating(this, new MyClassEventArgs("Обьект создан"));
        }
        public override int DivineSmite(int spellslot)
        {
            Random rnd = new Random();
            return base.DivineSmite(spellslot) + rnd.Next(1, 8) + rnd.Next(1, 8);
        }
        public override string ShowYourself()
        {
            return base.ShowYourself()+"and i brake my Oath,im a SacredOath,Praice the darknes!";
        }
        public string ShowDogmats()
        {
            return "i have no dogmats,darkness is my destiny!";
        }
        public void abc(object o, MyClassEventArgs m)
        {
            Console.WriteLine($"{m}");
        }

    }
}

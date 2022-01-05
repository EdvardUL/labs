using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab112PP
{
    class SacredOath:ClassPaladin
    {
        public SacredOath(int _age, string _name, string _race, string _gender, string _idol, string _ideology, int _lvl) : base(_age, _name, _race, _gender, _idol, _ideology, _lvl)
        {
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

    }
}

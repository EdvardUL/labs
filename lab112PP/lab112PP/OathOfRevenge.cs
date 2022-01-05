using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab112PP
{
    class OathOfRevenge:ClassPaladin
    {
        string[] dogmatsOfRevenge = new string[4]{ "Fight great evil", "Do not spare evil", "At any cost.", "Reimbursement." };
        public OathOfRevenge(int _age, string _name, string _race, string _gender, string _idol, string _ideology, int _lvl):base(_age,_name,_race,_gender,_idol,_ideology,_lvl)
        {
        }
        public override int DivineSmite(int spellslot)
        {
            Random rnd = new Random();
            return base.DivineSmite(spellslot)+rnd.Next(1,8)+ rnd.Next(1, 8);
        }
        public override string ShowYourself()
        {
            return base.ShowYourself() + "and my oath is revenge!";
        }
        public string ShowDogmats()
        {
            return "My dogmats of revenge is:" + string.Join(",", dogmatsOfRevenge);
        }
    }
}

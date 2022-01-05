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
    public class OathOfRevenge:ClassPaladin
    {
        public delegate void AdventurerHandler(object o, MyClassEventArgs s);
        public event AdventurerHandler Changing;
        public event AdventurerHandler Creating;
        public string[] dogmatsOfRevenge;
        public OathOfRevenge(int _age, string _name, string _race, string _gender, string _idol, string _ideology, int _lvl) : base(_age, _name, _race, _gender, _idol, _ideology, _lvl)
        {
            Creating = abc;
            Creating(this, new MyClassEventArgs("Обьект создан"));
        }
        public OathOfRevenge():base()
        {
                Creating = abc;
                dogmatsOfRevenge = new string[4] { "Fight great evil", "Do not spare evil", "At any cost.", "Reimbursement." };
                Creating(this, new MyClassEventArgs("Обьект создан"));
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
        public void abc(object o, MyClassEventArgs m)
        {
            Console.WriteLine($"{m}");
        }
    }
}

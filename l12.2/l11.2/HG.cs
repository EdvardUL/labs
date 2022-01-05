using System;
using System.Collections.Generic;
using System.Text;

namespace l11._2
{
    class HG:TDoll
    {
        public string typesWhichBuffed = "All Types";
        string buffDescription;
        int buffStat;
        public int BuffStat
        {
            set
            {
                if (value < 0 || value > 120)
                {
                    Console.WriteLine("Ошибка");
                }
                else
                {
                    buffStat = value;
                }
            }
            get
            {
                return buffStat;
            }
        }
        string BuffDescription
        {
            set
            {
                buffDescription = value;
            }
            get
            {
                return buffDescription;
            }
        }
        public HG(int newLvl,string newName, int newWeight, string newGender, int newROF, string newSkill, int newRare, string newBuffDescription, int newBuffStat) : base(newLvl,newName, newWeight, newGender, newROF, newSkill, newRare)
        {
            BuffDescription = newBuffDescription;
            BuffStat = newBuffStat;
        }
        public HG() : base()
        {
            BuffDescription = "Во время боя единоразво увеличивает всему отряду Rof";
            BuffStat = 90;
        }
        public override int Feed(int CountOfSnaks)
        {
            return base.Feed(CountOfSnaks) * 2;
        }
        public void Buff()
        {
            Rof += BuffStat*2;
        }
        public override string ToString()
        {
            return base.ToString() + $"\nBuffStat: {BuffStat}\nBuffDescription: {BuffDescription}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace l11._2
{
    class MG:TDoll
    {
        public string typesWhichBuffed = "SG";
        string buffDescription;
        int buffStat;
        public int BuffStat
        {
            set
            {
                if(value<0 || value > 100)
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
        public MG(int newLwl,string newName, int newWeight, string newGender, int newROF, string newSkill, int newRare,string newBuffDescription,int newBuffStat) : base(newLwl,newName, newWeight, newGender, newROF,newSkill,newRare)
        {
            BuffDescription = newBuffDescription;
            BuffStat = newBuffStat;
        }
        public MG() : base()
        {
            BuffDescription = "Каждый третий выстрел единоразово повышает себе ROF";
            BuffStat = 50;
        }
        public override int Feed(int CountOfSnaks)
        {
            return base.Feed(CountOfSnaks)/2;
        }
        public void Buff()
        {
            Rof += BuffStat;
        }
        public override string ToString()
        {
            return base.ToString() + $"\nBuffStat: {BuffStat}\nBuffDescription: {BuffDescription}";
        }
    }
}

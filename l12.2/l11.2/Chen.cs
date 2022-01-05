using System;
using System.Collections.Generic;
using System.Text;

namespace l11._2
{
    class Caster:Operator
    {
        int attackStat;
        int attackCount;
        public int AttackStat
        {
            set
            {
                if(value<0)
                {
                    Console.WriteLine("Ошибка");
                }
                else
                {
                    attackStat = value;
                }
            }
            get
            {
                return attackStat;
            }
        }
        public int AttackCount
        {
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Ошибка");
                }
                else
                {
                    attackCount = value;
                }
            }
            get
            {
                return attackCount;
            }
        }
        public Caster(int newLvl,string newName, int newWeight, string newGender, string newSkill, string newType, int newRare,int newAttacks,int newAttackc) : base(newLvl,newName, newWeight, newGender, newSkill,newType,newRare)
        {
            AttackStat = newAttacks;
            AttackCount = newAttackc;
        }
        public Caster() : base()
        {
            AttackStat = 120;
            AttackCount = 3;
        }
        public override int Feed(int CountOfSnaks)
        {
            return base.Feed(CountOfSnaks);
        }
        public int DPM()
        {
            return AttackStat * AttackCount;
        }
        public override string ToString()
        {
            return base.ToString() + $"\nAttackStat: {AttackStat}\nAttackCount: {AttackCount}";
        }
    }
}

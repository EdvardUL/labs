using System;
using System.Collections.Generic;
using System.Text;

namespace l11._2
{
    class BattleCruiser:Kansen
    {
        int mainGunCaliber;
        int baseHp;
        public int MainGunCaliber
        {
            set
            {
                if(value<0||value>460||value%2==0)
                {
                    Console.WriteLine("Ошибка");
                }
                else
                {
                    mainGunCaliber = value;
                }
            }
            get
            {
                return mainGunCaliber;
            }
        }
        public int BaseHp
        {
            set
            {
                if(value <0)
                {
                    Console.WriteLine("Ошибка");
                }
                else
                {
                    baseHp = value;
                }
            }
            get
            {
                return baseHp;
            }
        }
        public BattleCruiser(int newLvl,string newName, int newWeight, string newGender, int newFuel, string newFraction, string newShipType, string newSkill, int newRare,int newCaliber,int newHp) : base(newLvl,newName, newWeight, newGender, newFuel,newSkill ,newFraction, newShipType, newRare)
        {
            BaseHp = newHp;
            MainGunCaliber = newCaliber;
        }
        public BattleCruiser() : base()
        {
            BaseHp = 4600;
            MainGunCaliber = 460;
        }
        public override int Feed(int CountOfSnaks)
        {
            return base.Feed(CountOfSnaks);
        }
        public int TakeDMG(int DMG)
        {
            baseHp -= DMG;
            return BaseHp;
        }
        public override string ToString()
        {
            return base.ToString() + $"\nMainGunCaliber: {MainGunCaliber}\nBaseHp: {BaseHp}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace l11._2
{
    class Kansen : Creature
    {
        string fraction;
        string shipType;
        int fuelPerMove;
        int rare;
        public int Rare
        {
            set
            {
                if (value < 0||value>6)
                {
                    Console.WriteLine("Ошибка");
                }
                else
                {
                    rare = value;
                }
            }
            get
            {
                return rare;
            }
        }
        public int FuelPerMove
        {
            set
            {
                if(value < 0)
                {
                    Console.WriteLine("Ошибка");
                }
                else
                {
                    fuelPerMove = value;
                }
            }
            get
            {
                return fuelPerMove;
            }
        }
        public string ShipType
        {
            set
            {
                shipType = value;
            }
            get
            {
                return shipType;
            }
        }
        public string Fraction
        {
            set
            {
                fraction = value;
            }
            get
            {
                return fraction;
            }
        }
        public Kansen():base()
        {
            fraction = "Sakura empire";
            shipType = "CV";
            fuelPerMove = 9;
        }
        public Kansen(int newLvl,string newName, int newWeight, string newGender , int newFuel,string newFraction,string newShipType,string newSkill,int newRare):base(newName,newWeight,newGender,newSkill, newLvl)
        {
            fuelPerMove = newFuel;
            ShipType = newShipType;
            Fraction = newFraction;
            Rare = newRare;
        }
        public override void Show()
        {
            Console.WriteLine("Name:" + Name);
            Console.WriteLine("Weight:" + Weight);
            Console.WriteLine("Gender:" + Gender);
            Console.WriteLine("skillName:" + SkillName);
            Console.WriteLine("FuelPerMove:" + FuelPerMove);
            Console.WriteLine("ShipType:" + ShipType);
            Console.WriteLine("Fraction:" + Fraction);
        }
        public override void Enhance()
        {
            Console.WriteLine("Введите колличество материалов для повышения уровня(1-10)");
            int mat = Convert.ToInt32(Console.ReadLine());
            if(mat>10)
            {
                Console.WriteLine("Ошибка");
            }
            else if(Lvl > 125)
            {
                Console.WriteLine("Данный метод нельзя применить к персонажу максимального уровня");
            }
            else
            {

                Lvl += mat * 2;
            }
        }
        public override void LimitBreak()
        {
            if(rare==6)
            {
                Console.WriteLine("Персонаж имеет максимальную редкоcть");
            }
            else
            {
                if (Lvl < 85)
                {
                    Console.WriteLine("Для повышения редкости кансен должна быть выше 85 уровня");
                }
                else
                {
                    Name = Name + "(retrofit)";
                    SkillName  += "(epochal)";
                    rare += 1;
                    FuelPerMove += 3;
                }
            }
        }
        public int SumOfFuel(int TilesOfMove)
        {
            return fuelPerMove * TilesOfMove;
        }
        public virtual int Feed(int CountOfSnaks)
        {
            affinity += CountOfSnaks * 3;
            return affinity;
        }
        public override string ToString()
        {
            return $"\nname: {Name}\ngender: {Gender}\nweight: {Weight}\nSkillName: {SkillName}\nRare: {Rare}\nLvl: {Lvl}\nFuelPerMove: {FuelPerMove}\nFuelPerMove: {FuelPerMove}\nShipType: {ShipType}\nFraction: {Fraction}"; 
        }
    }
}

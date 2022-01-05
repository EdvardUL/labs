using System;
using System.Collections.Generic;
using System.Text;

namespace l11._2
{
    class TDoll:Creature,ICloneable,IComparable
    {
        int rare;
        public int Rare
        {
            set
            {
                if (value < 0 || value > 5)
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
        int rof;
        public int Rof
        {
            set
            {
                if(value < 0 || value >300)
                {
                    Console.WriteLine("Ошибка");
                }
                else
                {
                    rof = value;
                }
            }
            get
            {
                return rof;
            }
        }
        public TDoll() : base()
        {
            Rare = 5;
            Rof = 120;
        }
        public TDoll(int newLvl,string newName, int newWeight, string newGender, int newROF, string newSkill, int newRare) : base(newName, newWeight, newGender, newSkill, newLvl)
        {
            Rof = newROF;
            Rare = newRare;
        }
        public override void Show()
        {
            Console.WriteLine("Name:" + Name);
            Console.WriteLine("Weight:" + Weight);
            Console.WriteLine("Gender:" + Gender);
            Console.WriteLine("skillName:" + SkillName);
            Console.WriteLine("ROF:" + Rof);
            Console.WriteLine("Rere:" + Rare);
        }
        public override void Enhance()
        {
            if (Lvl > 120)
            {
                Console.WriteLine("Данный метод нельзя применить к существу выше максимального уровня");
            }
            else
            {
                Console.WriteLine("Введите колличество уровней на которые вы хотите повысить свое существо(1-45)");
                int nlvl = Convert.ToInt32(Console.ReadLine());
                if (nlvl == 120 || nlvl > 45)
                {
                    Console.WriteLine("введите корректное значение");
                }
                while (nlvl != 0)
                {
                    nlvl -= 1;
                    Lvl += 1;
                    if (Lvl == 120)
                    {
                        Console.WriteLine("Ваша Tdoll достиглa максимального уровня(120)");
                        break;
                    }
                }
                Console.WriteLine("Уровень Tdoll повышен,теперь он составляет: " + Lvl);
            }
        }
        public override void LimitBreak()
        {
            if (Lvl < 120)
            {
                Console.WriteLine("Данный метод нельзя применить к существу ниже максимального уровня");
            }
            else if (rare == 7)
            {
                Console.WriteLine("Ваше существо имеет максимальную редкость");
            }
            else
            {
                if (Name.Contains("mod 1"))
                {
                    Name = Name.Replace(" mod 1", " mod 2");
                    rare += 1;
                    SkillName = SkillName.Replace("(upper intermidiate)", "(Final)");
                }
                else
                {
                    Name = Name + " mod 1";
                    rare += 1;
                    SkillName += " (upper intermidiate)";
                }
                Console.WriteLine("Повышение редкости произошло успешно");
            }
        }
        public virtual int Feed(int CountOfSnaks)
        {
            affinity += CountOfSnaks * 3;
            return affinity;
        }
        public override string ToString()
        {
            return $"\nname: {Name}\ngender: {Gender}\nweight: {Weight}\nSkillName: {SkillName}\nRare: {Rare}\nLvl: {Lvl}"; ;
        }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        public int CompareTo(object o)
        {
            TDoll p = o as TDoll;
            if (p != null)
                return this.Lvl.CompareTo(p.Lvl);
            else
                throw new Exception("Невозможно сравнить два объекта");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace l11._2
{
    class Operator : Creature
    {
        int rare;
        string type;
        public int Rare
        {
            set
            {
                if (value > 6 || value < 0)
                {
                    Console.WriteLine("Ошибка");
                }
                else
                {
                    value = rare;
                }
            }
            get
            {
                return rare;
            }
        }
        public string Type
        {
            set
            {
                type = value;
            }
            get
            {
                return type;
            }
        }
        public Operator(int newLvl,string newName, int newWeight, string newGender, string newSkill, string newType, int newRare) : base(newName, newWeight, newGender, newSkill, newLvl)
        {
            Rare = newRare;
            Type = newType;
        }
        public Operator() : base()
        {
            Rare = 7;
            Type = "Caster";
        }
        public override void Show()
        {
            Console.WriteLine("Name:" + Name);
            Console.WriteLine("Weight:" + Weight);
            Console.WriteLine("Gender:" + Gender);
            Console.WriteLine("skillName:" + SkillName);
            Console.WriteLine("Type:" + Type);
            Console.WriteLine("Rere:" + Rare);
        }
        public override void Enhance()
        {
            if (Lvl >= 100)
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
            if (rare == 7)
            {
                Console.WriteLine("Персонаж имеет максимальную редкоcть");
            }
            else
            {
                if (Lvl < 90)
                {
                    Console.WriteLine("Для повышения редкости оператор должен быть выше 90 уровня");
                }
                else
                {
                    rare += 1;
                }
            }
        }
        public virtual int Feed(int CountOfSnaks)
        {
            affinity += CountOfSnaks * 3;
            return affinity;
        }
        public override string ToString()
        {
            return $"\nname: {Name}\ngender: {Gender}\nweight: {Weight}\nSkillName: {SkillName}\nRare: {Rare}\nLvl: {Lvl}\nType: {Type}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace l11._2
{
    abstract class Creature
    {
        public int affinity = 50;
        string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        int weight;
        public int Weight
        {
            get
            {
                return weight;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Введите корректное значение");
                }
                else
                {
                    weight = value;
                }
            }
        }
        int lvl;
        public int Lvl
        {
            get
            {
                return lvl;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Введите корректное значение");
                }
                else
                {
                    lvl = value;
                }
            }
        }
        string gender;
        public string Gender
        {
            get
            {
                return gender;
            }
            set
            {
                gender = value;
            }
        }
        string skillName;
        public string SkillName
        {
            set
            {
                skillName = value;
            }
            get
            {
                return skillName;
            }
        }
        public Creature( string newName, int newWeight, string newGender,string newSkill ,int newLvl)
        {
            name = newName;
            weight = newWeight;
            gender = newGender;
            SkillName = newSkill;
            Lvl = newLvl;
        }
        public Creature()
        {
            name = "Skk";
            Weight = 85;
            gender = "Female";
            SkillName = "None";
        }
        public abstract void Show();
        public abstract void Enhance();
        public abstract void LimitBreak();
    }
}

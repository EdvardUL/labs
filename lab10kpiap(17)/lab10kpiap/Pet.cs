using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10kpiap
{
    [Serializable]
    public class Pet:Animal,InputInterface,IComparable,ICloneable
    {
        public string nickname;
        public Pet():base()
        {
            nickname = "Buddy";
        }
        public Pet(string newclass, int newlimbs, int newdescend,string newnick):base(newclass,newlimbs,newdescend)
        {
            nickname = newnick;
        }
        public string Nickname
        {
            get { return nickname; }
            set { nickname = value; }
        }
        public override string ToString()
        {
            return base.ToString() + $"\nnickname: {nickname}";
        }
        public string ChangeNick(string newname)
        {
            Console.WriteLine($"Change nickname from {Nickname} to {newname}...");
            Nickname = newname;
            return Nickname;
        }
        public int ChangeDescendants(int newdescendants)
        {
            Console.WriteLine($"Change Descendants from {Descendants} to {newdescendants}...");
            Descendants = newdescendants;
            return Descendants;
        }
        public string ShortestNickname(Pet[] arr)
        {
            string shortnick = arr[0].Nickname;
            for(int i = 0;i<arr.Length;i++)
            {
                if(shortnick.Length>arr[i].Nickname.Length)
                {
                    shortnick = arr[i].Nickname;
                }
            }
            Console.WriteLine($"shjortest nickname is {shortnick}!");
            return shortnick;
        }
        public string InputData()
        {
            Console.WriteLine("Enter data: class,limbs,descend,nick");
            Classify =  Console.ReadLine();
            Limbs = Convert.ToInt32(Console.ReadLine());
            Descendants = Convert.ToInt32(Console.ReadLine());
            Nickname = Console.ReadLine();
            return Classify + " " + Limbs + " " + Descendants + " " + Nickname;
        }
        public int CompareTo(object obj)
        {
            Pet C = (Pet)obj;
            return Math.Sign(this.Limbs - C.Limbs);
        }
        public object Clone()
        {
            return new Pet(this.Classify, this.Limbs,this.Descendants,this.Nickname);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10kpiap
{
    [Serializable]
        public class Animal
    {
        public string classify;
        public int limbs;
        public int descendants;
        public Animal()
        {
            classify = "doglike";
            limbs = 4;
            descendants = 6;
        }
        public Animal(string newclass,int newlimbs,int newdescend)
        {
            classify = newclass;
            limbs = newlimbs;
            descendants = newdescend;
        }
        public string Classify
        {
            get { return classify; }
            set { classify = value; }
        }
        public int Limbs
        {
            get { return limbs; }
            set { limbs = value; }
        }
        public int Descendants
        {
            get { return descendants; }
            set { descendants = value; }
        }
        public override string ToString()
        {
            return $"\nclassife: {classify}\nlimbs: {limbs}\ndescendants: {descendants}";
        }
    }
}

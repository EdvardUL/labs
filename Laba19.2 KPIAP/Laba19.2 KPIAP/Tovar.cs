using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba19._2_KPIAP
{
    class Tovar
    {
        public string Name;
        public int Weight;
        public string Category;
        public int Price;
        public Tovar(int weight, int price, string name, string cagory)
        {
            Weight = weight;
            Price = price;
            Name = name;
            Category = cagory;
        }
        public override string ToString()
        {
            return $"Weight:{Weight}\nPrice:{Price}\nName:{Name}\nCategory:{Category}";
        }
    }
}

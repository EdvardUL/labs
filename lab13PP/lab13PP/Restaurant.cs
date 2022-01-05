using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab13PP
{
    class Restaurant
    {
        string name, reasonDiscount;
        int chek, visits, dishes,amountDiscount;
        bool discount;
        public string Name
        {
            get { return name; }
            set
            {
                if (!Char.IsUpper(name[0])) throw new Exception("not in upper register");
                else { name = value; }
            }
        }
        public string ReasonDiscount
        {
            get { return reasonDiscount; }
            set
            {
                if (!Char.IsUpper(name[0])) throw new Exception("not in upper register");
                else if(discount == false) { reasonDiscount = ""; }
                else {reasonDiscount = value; }
            }
        }
        public int Chek
        {
            get { return chek; }
            set
            {
                if(value <2 || value>1000) throw new Exception("invalid value");
                else { chek = value; }
            }

        }
        public int Visits
        {
            get { return visits; }
            set
            {
                if (value < 1 || value > 20) throw new Exception("invalid value");
                else { visits = value; }
            }
        }
        public int Dishes
        {
            get { return dishes; }
            set
            {
                if (value < 1 || value > 20) throw new Exception("invalid value");
                else { dishes = value; }
            }
        }
        public bool Discount
        {
            get { return discount; }
            set
            {
                discount = value;
            }
        }
        public int AmountDiscount
        {
            get { return amountDiscount; }
        }
        public Restaurant(string _name,string _reasonDiscount,int _chek,int _visits,int _dishes,bool _discount)
        {
            name = _name;
            reasonDiscount = _reasonDiscount;
            chek = _chek;
            visits = _visits;
            dishes = _dishes;
            discount = _discount;
            if (reasonDiscount == "Bday") { amountDiscount = 10; }
            else if (visits > 7) { amountDiscount = 7; }
            else if (discount == false) { amountDiscount = 0; }
            else { amountDiscount = 0; }
        }
        public override string ToString()
        {
            return $"name {name},reason of discount {reasonDiscount}, chek {chek}, visits {visits},dishes {dishes},amount of discount {amountDiscount}, discount {discount}";
        }
        public double AveragePrice()
        {
            return (double)chek / (double)dishes;
        }
        public (double,double) DiscountOfOrder()
        {
            return (chek/100*amountDiscount,chek - chek / 100 * amountDiscount);
        }
    }
}

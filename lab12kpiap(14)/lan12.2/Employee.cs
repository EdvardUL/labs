using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lan12._2
{
    delegate void PromotionMaker(object obj, PromotionEvent m);

    class Employee

    {
        int hoursPerMonth, hourlyRate;
        public event PromotionMaker Hire;
        public string Fullname { get; set; }
        public int PersonalNumber { get; set; }
        public int HoursPerMonth {
            get { return hoursPerMonth; }
            set 
            {
                Hire = printf;
                Hire(this, new PromotionEvent("change hours per month"));
                if (value <= 0 || value >= 270) { throw new ZeroException("impossible value"); }
                else { hoursPerMonth = value; }

            }
        }
        public int HourlyRate
        {
            get { return hourlyRate; }
            set
            {
                Hire = printf;
                Hire(this, new PromotionEvent("change hourly rate"));
                if (value <= 0) throw new ZeroException("value cant be zero or less");
                else { hourlyRate = value; }

            }
        }
        public Employee(string _fullname,int _persinalNumber, int _hoursPerMonth,int _hourlyRate)
        {
            Hire = printf;
            if (Hire != null) Hire(this, new PromotionEvent("new employee was hired"));
            Fullname = _fullname;
            PersonalNumber = _persinalNumber;
            hoursPerMonth = _hoursPerMonth;
            hourlyRate = _hourlyRate;
        }
        public int MonthSalaryWithoutTax()
        {
            try
            {
                if (hoursPerMonth > 144)
                {
                    int overhours = hoursPerMonth - 144;
                    return 144 * hoursPerMonth + overhours * (hoursPerMonth * 2);
                }
            }
            catch(ZeroException ex)
            { 
                Console.WriteLine($"Exception: {ex.Message}");
            }
            return hoursPerMonth * hourlyRate;
        }
        public int MonthSalary()
        {
            try
            {
                if (hoursPerMonth > 144)
                {
                    int overhours = HoursPerMonth - 144;
                    int salary = 144 * HourlyRate + overhours * (HoursPerMonth * 2);
                    return salary - (salary / 100 * 13);
                }
            }
            catch(ZeroException ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
 
            return (HourlyRate * HoursPerMonth )-((HourlyRate * HoursPerMonth) / 100*13);
        }
        public void Promotion(int prom)
        {
            Hire = printf;
            if (Hire != null) Hire(this, new PromotionEvent("You`ve been promoted,your hourly rate increased on ", prom));
            hourlyRate += prom;
        }
        public void Demotion(int prom)
        {
            Hire = printf;
            if (hourlyRate > prom)
            {
                if (Hire != null) Hire(this, new PromotionEvent("You`ve been deomoted,your hourly rate decreased on ", prom));
                hourlyRate -= prom;
            }
            else if (Hire != null) Hire(this,new PromotionEvent("your hourly rate ",prom));
        }
        public void printf(object o, PromotionEvent m)
        {
            Console.WriteLine($"{m}");
        }
    }
}

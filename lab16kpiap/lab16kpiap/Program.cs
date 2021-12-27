using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace lab16kpiap
{
    class Program
    {

        static void Main(string[] args)
        {
            StreamReader f = new StreamReader("test.txt");
            string s = f.ReadToEnd(), temp;
            int i = 3, count = 0;
            while (i < s.Length)
            {
                temp = s.Substring(i - 3, 3);
                Regex regex = new Regex(@temp);
                MatchCollection matches = regex.Matches(s);
                if (matches.Count > 0)
                {
                    if (matches.Count > count)
                    { count = matches.Count; }
                }
                i++;
            }
            Console.WriteLine(count);
            f.Close();
        }
    }
}

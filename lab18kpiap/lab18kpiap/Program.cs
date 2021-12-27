using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace lab18kpiap
{
    class Program
    {
        static void Steck()
        {
            string s;
            StreamReader f = new StreamReader("test.txt");
            while ((s = f.ReadLine()) != null)
            {
                char[] rvrsstr = s.ToCharArray();
                Stack<char> letters = new Stack<char>();
                foreach (char i in rvrsstr)
                {
                    letters.Push(i);
                }
                foreach (char i in rvrsstr)
                {
                    char stackElement = letters.Pop();
                    Console.Write(stackElement);
                }
                Console.WriteLine("");
            }
            f.Close();
        }
        static void Que()
        {
            char[] separators = new char[] { ' ', ',', '.', '\'', '—', '-', '(', ')', '\n', ':' };
            string vowels = "ёуеыаоэяиюeyuioaЁУЕЫАОЭЯИЮEYUIOA";
            Queue<string> queueVowel = new Queue<string>();
            Queue<string> queueConsonant = new Queue<string>();
            string text = File.ReadAllText("test2.txt");
            string[] result = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            foreach (string i in result)
            {
                if (vowels.Contains(i[0]))
                {
                    queueVowel.Enqueue(i);
                }
                else
                {
                    queueConsonant.Enqueue(i);
                }
            }
            while (queueVowel.Count > 0)
            {
                Console.Write(queueVowel.Dequeue() + " ");
            }
            Console.WriteLine();
            while (queueConsonant.Count > 0)
            {
                Console.Write(queueConsonant.Dequeue() + " ");
            }
        }
        
        static void Main(string[] args)
        {
            //Steck();
            Que();
        }
    }
}

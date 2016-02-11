using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4_ProjectWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //Sum Method
            Console.WriteLine(Sum(5, 3));
            */
            /*
            //SobrietyTest Method
            string alpha = "abcdefghijklmnopqrstuvwxyz";
            string sober = SobrietyTest(alpha);
            Console.WriteLine(sober);
            */


            //NameAgeState Method
            Console.WriteLine("Enter name: ");
            string l = Console.ReadLine();
            Console.WriteLine("Enter age: ");
            string m = Console.ReadLine();
            Console.WriteLine("Enter what state you are from: ");
            string n = Console.ReadLine();
            string info = NameAgeState(l, m, n);
            Console.WriteLine(info);


        }

        static string NameAgeState(string l, string m, string n)
        {
            Console.WriteLine(string.Concat("Hello", " ", l, " ", "you are", m, " ", "from", " ", n));
            return l;
        }

        static string SobrietyTest(string alpha)
        {
            StringBuilder reverse = new StringBuilder();
            for (int g = alpha.Length - 1; g >= 0; g--)
            {
                reverse.Append(alpha[g]);
                 
            }
            return reverse.ToString();
        }

        static int Sum(int a, int b)
        {
            int c =  a +  b;
            return c;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _75
    {
        //Write a C# Sharp program to create a new string taking 3 characters from the middle of a given string at least 3.

        public static void Main(string[] args)
        {
            Console.WriteLine("Input your string: ");
            string s1 = Convert.ToString(Console.ReadLine());

            


            Console.WriteLine(Test(s1));
            Console.ReadKey();

        }
        public static string Test(string s)
        {
            return s.Length > 3 ? s.Substring(s.Length / 2 - 2, 3) : s;
            //return s1.Substring((s1.Length - 1) / 2 - 1, 3);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _81
    {
        //Write a C# Sharp program to check whether the first two characters and last two characters of a given string are same.

        public static void Main(string[] args)
        {
            Console.WriteLine("Input your string: ");
            string s1 = Convert.ToString(Console.ReadLine());

            Console.WriteLine(Test(s1));
            Console.ReadKey();

        }

        public static bool Test(string s)
        {
            return s.Substring(0, 2).Equals(s.Substring(s.Length - 2));

        }
    }
}

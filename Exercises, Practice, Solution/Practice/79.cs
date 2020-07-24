using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _79
    {
        //Write a C# Sharp program to create a new string from a given string after swapping last two characters.

        public static void Main(string[] args)
        {
            Console.WriteLine("Input your string: ");
            string s1 = Convert.ToString(Console.ReadLine());

            Console.WriteLine(Test(s1));
            Console.ReadKey();

        }

        public static string Test(string a)
        {
            return a.Length > 1 ? a.Substring(0, a.Length - 2) + a[a.Length - 1] + a[a.Length - 2] : a;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _76
    {
        //Write a C# Sharp program to create a new string of length 2, using first two characters of a given string.
        //If the given string length is less than 2 use '#' as missing characters.

        public static void Main(string[] args)
        {
            Console.WriteLine("Input your string: ");
            string s1 = Convert.ToString(Console.ReadLine());

       


            Console.WriteLine(Test(s1));
            Console.ReadKey();

        }

        public static string Test(string s)
        {
            return s.Length > 1 ? s.Substring(0, 2) : s + "#";
        }


    }
}

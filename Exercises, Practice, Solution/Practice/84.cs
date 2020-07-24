using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _84
    {
        //Write a C# Sharp program to create a new string from a given string.
        //If the two characters of the given string from its beginning and end are same return the given string without the first two characters otherwise return the original string.

        public static void Main(string[] args)
        {
            Console.WriteLine("Input your string: ");
            string s1 = Convert.ToString(Console.ReadLine());

            Console.WriteLine(Test(s1));
            Console.ReadKey();

        }

        public static string Test(string s)
        {
            return s.Substring(0, 2) == s.Substring(s.Length - 2) ? s.Substring(2) : s;
        }


    }
}

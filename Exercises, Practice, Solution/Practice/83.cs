using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _83
    {
        //Write a C# Sharp program to create a new string using 3 copies of the first 2 characters of a given string. 
        //If the length of the given string is less than 2 use the whole string.
        public static void Main(string[] args)
        {
            Console.WriteLine("Input your string: ");
            string s1 = Convert.ToString(Console.ReadLine());

            Console.WriteLine(Test(s1));
            Console.ReadKey();

        }
        public static string Test(string s)
        {
           
            return s.Length < 2 ? s + s + s : s.Substring(0, 2) + s.Substring(0, 2) + s.Substring(0, 2);
        }


    }
}

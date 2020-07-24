using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _66
    {
        //Write a C# Sharp program to create a new string from two given string one is shorter and another is longer. 
        //The format of the new string will be long string + short string + long string.

        public static void Main(string[] args)
        {
            Console.WriteLine("Input your string: ");
            string s = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Input second string: ");
            string d = Convert.ToString(Console.ReadLine());

            Console.WriteLine("New string: " + StringX(s,d));
            Console.ReadKey();


        }
        public static string StringX(string s1, string s2)
        {
            if (s1.Length >= s2.Length) return s1 + s2 + s1;
            return s2 + s1 + s2;

            //return s1.Length < s2.Length ? s2 + s1 + s2 : s1 + s2 + s1;
        }


    }
}

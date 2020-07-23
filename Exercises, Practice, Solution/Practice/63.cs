using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _63
    {
        //Write a C# Sharp program to create a new string using first two characters of a given string.
        //If the string length is less than 2 then return the original string.
        public static void Main(string[] args)
        {
            Console.WriteLine("Input your string: ");
            string s = Convert.ToString(Console.ReadLine());

            Console.WriteLine("New string: " + StringX(s));
            Console.ReadKey();


        }
        public static string StringX(string str)
        {
            if (str.Length >= 2)
            {
                string first = str.Substring(0, 2);
                return first + first + first;
            }
            return str;

        }
    }
}
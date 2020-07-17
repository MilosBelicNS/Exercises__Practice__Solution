using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _09
    {
        //Write a C# Sharp program to create  a new string with the last char added at the front and back of a given string of length 1 or more.

        public static void Main (string [] args)
        {
            Console.Write("Input your string: ");
            string a = Convert.ToString(Console.ReadLine());
            Console.WriteLine(Last(a));
            Console.ReadKey();

        }

        public static string Last(string str)
        {
            return str.Length > 1 ? str.Substring(str.Length - 1) + str : str;
        }
    }
}

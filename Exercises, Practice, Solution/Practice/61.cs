using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _61
    {
        //Write a C# Sharp program to insert a given string into middle of the another given string of length 4.
        public static void Main(string[] args)
        {
            Console.WriteLine("Input your string: ");
            string s = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Input your string: ");
            string d = Convert.ToString(Console.ReadLine());

            Console.WriteLine("New string: " + StringX(s,d));
            Console.ReadKey();


        }
        public static string StringX(string str, string word)
        {
            return str.Length == 4 ? str.Substring(0, 2) + word + str.Substring(2, 2) : word;
        }
    }
}

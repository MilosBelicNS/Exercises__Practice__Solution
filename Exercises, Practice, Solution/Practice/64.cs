using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _64
    {
        //Write a C# Sharp program to create a new string of the first half of a given string of even length.

        public static void Main(string[] args)
        {
            Console.WriteLine("Input your string: ");
            string s = Convert.ToString(Console.ReadLine());

            Console.WriteLine("New string: " + StringX(s));
            Console.ReadKey();


        }

        public static string StringX(string s1)
        {
            return s1.Substring(0, s1.Length / 2);
        }
    }
}

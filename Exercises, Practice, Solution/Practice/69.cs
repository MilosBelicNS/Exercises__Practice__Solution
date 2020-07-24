using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _69
    {
        //Write a C# Sharp program to move the last two characters to the start of a given string of length at least two.

        public static void Main(string[] args)
        {
            Console.WriteLine("Input your string: ");
            string s1 = Convert.ToString(Console.ReadLine());



            Console.WriteLine("New string: " + StringX(s1));
            Console.ReadKey();


        }
        public static string StringX(string s)
        {
            return s.Substring(s.Length - 3) + s.Substring(0, s.Length - 3);
            // return s1.Substring(s1.Length - 2) + s1.Remove(s1.Length - 2);
        }
    }
}

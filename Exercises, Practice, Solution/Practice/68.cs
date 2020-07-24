using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _68
    {
        //Write a C# Sharp program to move the first two characters to the end of a given string of length at least two.

        public static void Main(string[] args)
        {
            Console.WriteLine("Input your string: ");
            string s1 = Convert.ToString(Console.ReadLine());

           

            Console.WriteLine("New string: " + StringX(s1));
            Console.ReadKey();


        }
        public static string StringX(string s1)
        {
            return s1.Remove(0, 2) + s1.Substring(0, 2);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _74
    {
        //Write a C# Sharp program to create a new string of length 2 starting at the given index of a given string.

        public static void Main(string[] args)
        {
            Console.WriteLine("Input your string: ");
            string s1 = Convert.ToString(Console.ReadLine());

            Console.WriteLine("From which index: ");
            int n = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine(StringX(s1, n));
            Console.ReadKey();

        }

        public static string StringX(string s, int n)
        {
            return s.Substring(n, 2);
        }
    }
}

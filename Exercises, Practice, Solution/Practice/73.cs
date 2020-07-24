using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _73
    {
        //Write a C# Sharp program to create a new string using the first and last n characters from a given string of length at least n

        public static void Main(string[] args)
        {
            Console.WriteLine("Input your string: ");
            string s1 = Convert.ToString(Console.ReadLine());

            Console.WriteLine("How many elements: ");
            int n = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine(StringX(s1,n));
            Console.ReadKey();

        }
        public static string StringX(string s, int n)
        {
            return s.Substring(0, n) + s.Substring(s.Length - n);
        }
    }
}

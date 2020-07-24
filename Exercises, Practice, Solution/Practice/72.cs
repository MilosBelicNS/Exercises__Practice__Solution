using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _72
    {
        //Write a C# Sharp program to check if a given string ends with "on".

        public static void Main(string[] args)
        {
            Console.WriteLine("Input your string: ");
            string s1 = Convert.ToString(Console.ReadLine());


            Console.WriteLine(StringX(s1));
            Console.ReadKey();

        }

        public static bool StringX(string s)
        {
            return s.EndsWith("on");
            //return s.Substring(s.Length - 2) == "on";
        }

    }
}

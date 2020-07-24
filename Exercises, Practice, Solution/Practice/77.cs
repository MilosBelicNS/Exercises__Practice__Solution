using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _77
    {
        //Write a C# Sharp program to create a new string taking the first character from a given string and the last character from another given string. 
        //If the length of any given string is 0, use '#' as its  missing character.

        public static void Main(string[] args)
        {
            Console.WriteLine("Input your string: ");
            string s1 = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Input second string: ");
            string s2 = Convert.ToString(Console.ReadLine());




            Console.WriteLine(Test(s1,s2));
            Console.ReadKey();

        }

        public static string Test(string a,string b)
        {
            return (a.Length != 0 ? a.Substring(0, 1) : "#") + (b.Length != 0 ? b.Substring(b.Length - 1) : "#");

        }


    }
}

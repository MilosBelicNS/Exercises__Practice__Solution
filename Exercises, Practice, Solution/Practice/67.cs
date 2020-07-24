using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _67
    {
        //Write a C# Sharp program to concat two given string of length atleast 1, after removing their first character.

        public static void Main(string[] args)
        {
            Console.WriteLine("Input your string: ");
            string s1 = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Input second string: ");
            string s2 = Convert.ToString(Console.ReadLine());

            Console.WriteLine("New string: " + StringX(s1, s2));
            Console.ReadKey();


        }

        public static string StringX(string s1, string s2)
        {
           // return s1.Length >=2 && s2.Length>=2? s1.Substring(1) + s2.Substring(1): s1+s2;

            return s1.Substring(1) + s2.Substring(1);
        }
    }
}

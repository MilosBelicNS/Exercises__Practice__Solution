using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _87
    {
        //Write a C# Sharp program to create a new string from a given string. 
        //If the first or first two characters is 'a', return the string without those 'a' characters otherwise return the original given string.
        public static void Main(string[] args)
        {
            Console.WriteLine("Input your string: ");
            string s1 = Convert.ToString(Console.ReadLine());

            Console.WriteLine(Test(s1));
            Console.ReadKey();

        }
        public static string Test(string s)
        {
            return s.Substring(0, 2) == "aa" ? s.Substring(2) : s;
        }

    }
}

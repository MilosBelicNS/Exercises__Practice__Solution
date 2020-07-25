using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _86
    {
        //Write a C# Sharp program to create a new string from a given string without the first and last character.
        //if the first or last characters are 'a' otherwise return the original given string.


        public static void Main(string[] args)
        {
            Console.WriteLine("Input your string: ");
            string s1 = Convert.ToString(Console.ReadLine());

            Console.WriteLine(Test(s1));
            Console.ReadKey();

        }
        public static string Test(string s)
        {
            if (s.Substring(0, 1) == "a" && s.Substring(s.Length - 1) == "a")
            {
                return s.Substring(1, s.Length - 2);
            }
            else if (s.Substring(0, 1) == "a")
            {
                return s.Substring(1);
            }
            else if (s.Substring(s.Length - 1) == "a")
            {
                return s.Remove(s.Length - 1);
            }
            return s;

        }


    }
}

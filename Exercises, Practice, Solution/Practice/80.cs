using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _80
    {
        //Write a C# Sharp program to check if a given string begins with "abc" or "xyz". 
        //If the string begins with "abc" or "xyz" return "abc" or "xyz" otherwise return the empty string.

        public static void Main(string[] args)
        {
            Console.WriteLine("Input your string: ");
            string s1 = Convert.ToString(Console.ReadLine());

            Console.WriteLine(Test(s1));
            Console.ReadKey();

        }

        public static string Test(string s)
        {
            if (s.StartsWith("abc"))
            {
                return "abc";

            }else if(s.StartsWith("xyz"))
            {
                return "xyz";

            }
            return String.Empty;
        }


    }
}

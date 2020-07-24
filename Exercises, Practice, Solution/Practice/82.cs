using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _82
    {
        //Write a C# Sharp program to concat two given strings. 
        //If the given strings have different length remove the characters from the longer string.
        public static void Main(string[] args)
        {
            Console.WriteLine("Input your string: ");
            string s1 = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Input second string: ");
            string s2 = Convert.ToString(Console.ReadLine());

            Console.WriteLine(Test(s1,s2));
            Console.ReadKey();

        }
        public static string Test(string s1, string s2)
        {
            int n = Math.Abs(s1.Length - s2.Length);
           

            if(s1.Length == s2.Length) 
            {
                return s1 + s2;
            }
            return s1.Length > s2.Length ? s1.Substring(n) + s2 : s1 + s2.Substring(n);
        }


    }
}

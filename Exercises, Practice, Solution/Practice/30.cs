using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _30
    {
        //Write a C# Sharp program to create a string like "aababcabcd" from a given string "abcd"
        public static void Main (string [] args)
        {
            Console.Write("Input your string: ");
            string a = Convert.ToString(Console.ReadLine());
            Console.WriteLine(Test(a));


            Console.ReadKey();
        }
        public static string Test(string str)
        {
            var result = string.Empty;
            for (var i = 0; i < str.Length; i++)
            {
                result += str.Substring(0, i + 1); 
                //u svakoj iteraciji daj mi 0 element i element i+1
            }
            return result;
        }
    }
}

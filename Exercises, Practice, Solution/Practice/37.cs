using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _37
    {
        //Write a C# Sharp program to create a new string of the characters at indexes 0,1, 4,5, 8,9 ... from a given string.

        public static void Main(string[] args)
        {
            Console.WriteLine("Input your string: ");
            string s = Convert.ToString(Console.ReadLine());

            Console.WriteLine("New string: " + StringX(s));
            Console.ReadKey();
      
        
        }


        public static string StringX(string str1)
        {
            var result = string.Empty;
            for (var i = 0; i < str1.Length; i += 4)
            {
                var c = i + 2;
                var n = 0;
                n += c > str1.Length ? 1 : 2;
                result += str1.Substring(i, n);
            }
            return result;
        }
    }
}

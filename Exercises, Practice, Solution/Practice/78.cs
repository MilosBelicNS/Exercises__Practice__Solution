using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _78
    {
        //Write a C# Sharp program to concat two given strings (lowercase). 
        //If there are any double character in new string then omit one character.

        public static void Main(string[] args)
        {
            Console.WriteLine("Input your string: ");
            string s1 = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Input second string: ");
            string s2 = Convert.ToString(Console.ReadLine());




            Console.WriteLine(Test(s1, s2));
            Console.ReadKey();

        }
        public static string Test(string a, string b)
        {
            if (a.Substring(a.Length - 1) == b.Substring(0,1))
            {
                return a + b.Substring(1);
            }
            return a + b;
          //  return a.Substring(a.Length - 1) == b.Substring(0, 1) ? a + b.Substring(1) : a + b;
        }

    }
}

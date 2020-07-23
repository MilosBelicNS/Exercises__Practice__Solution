using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _60
    {
        //Write a C# Sharp program to create a new string using two given strings s1, s2, the format of the new string will be s1s2s2s1.

        public static void Main(string[] args)
        {
            Console.WriteLine("Input your string: ");
            string s = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Input your string: ");
            string d = Convert.ToString(Console.ReadLine());

            Console.WriteLine("New string: " + Test(s, d));
            Console.ReadKey();


        }
        public static string Test(string str, string st)
        {
            return (str + st + st + str);
        }
    }
}

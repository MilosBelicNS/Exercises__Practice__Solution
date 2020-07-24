using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _70
    {
        //Write a C# Sharp program to create a new string without the first and last character of a given string of any length

        public static void Main(string[] args)
        {
            Console.WriteLine("Input your string: ");
            string s1 = Convert.ToString(Console.ReadLine());



            Console.WriteLine("New string: " + StringX(s1));
            Console.ReadKey();


        }
        public static string StringX(string s)
        {
            return s.Substring(1, s.Length - 2);
            //return s1.Length < 2 ? String.Empty : s.Substring(1, s.Length - 2);
        }
    }
}

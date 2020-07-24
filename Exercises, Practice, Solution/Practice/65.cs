using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _65
    {
        //Write a C# Sharp program to create a new string without the first and last character of a given string of length atleast two.

        public static void Main(string[] args)
        {
            Console.WriteLine("Input your string: ");
            string s = Convert.ToString(Console.ReadLine());

            Console.WriteLine("New string: " + StringX(s));
            Console.ReadKey();


        }

        public static string StringX(string str)
        {
            //return str.Substring(1).Substring(0, str.Length - 2);
            return str.Substring(1, str.Length -2);
            
        }
    }
}

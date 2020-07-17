using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _12
    {
       // Write a C# Sharp program to check if a given string starts with 'C#' or not.

        public static void Main (string [] args)
        {
            Console.Write("Input your string: ");
            string a = Convert.ToString(Console.ReadLine());
            Console.WriteLine(Start(a));
            Console.ReadKey();

        }

        public static bool Start(string str)
        {

            return str.StartsWith("C#");

            //return (str.Length < 3 && str.Equals("C#")) || (str.StartsWith("C#") && str[2] == ' ');
        }


    }
}

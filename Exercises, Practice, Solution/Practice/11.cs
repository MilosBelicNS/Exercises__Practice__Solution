using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _11
    {
        //Write a C# Sharp program to create a new string taking the first 3 characters of a given string and return the string with the 3 characters added at both the front and back.
        //If the given string length is less than 3, use whatever characters are there.
        public static void Main (string [] args)
        {
            Console.Write("Input your string: ");
            string a = Convert.ToString(Console.ReadLine());
            Console.WriteLine(St(a));
            Console.ReadKey();

        }

        public static string St(string str)
        {
            return str.Length > 3 ? str.Substring(0, 2) + str + str.Substring(0, 2) : str+str+str;
        }
    }
}

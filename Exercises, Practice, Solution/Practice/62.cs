using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _62
    {
        //Write a C# Sharp program to create a new string using three copies of the last two character of a given string of length atleast two.

        public static void Main(string[] args)
        {
            Console.WriteLine("Input your string: ");
            string s = Convert.ToString(Console.ReadLine());

            Console.WriteLine("New string: " + StringX(s));
            Console.ReadKey();


        }

        public static string StringX(string str)
        {
            if (str.Length >= 2)
            {
                return str.Substring(str.Length - 2) + str.Substring(str.Length - 2) + str.Substring(str.Length - 2);
            }
            return str;
            //drugi nacin
        //    string last2 = s1.Substring(s1.Length - 2);
        //    return last2 + last2 + last2;
        }
    }
}

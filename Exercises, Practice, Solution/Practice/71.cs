using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _71
    {
        //Write a C# Sharp program to create a new string using the two middle characters of a given string of even length (at least 2).


        public static void Main(string[] args)
        {
            Console.WriteLine("Input your string: ");
            string s1 = Convert.ToString(Console.ReadLine());



            Console.WriteLine("New string: " + StringX(s1));
            Console.ReadKey();


        }
        public static string StringX(string s)
        {
            return s.Substring(s.Length / 2 - 1, 2);
            //podeli string na dva dela i izbaci od slova unazad dva sledeca slova
        }

    }
}

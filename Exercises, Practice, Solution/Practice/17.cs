using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _17
    {
        //Write a C# Sharp program to check if a string 'yt' appears at index 1 in a given string. 
       //If it appears return a string without 'yt' otherwise return the original string.

        public static void Main (string [] args)
        {
            Console.WriteLine("Write a C# Sharp program to check if a string 'yt' appears at index 1 in a given string. \n");


            Console.Write("Input your string: ");
            string a = Convert.ToString(Console.ReadLine());

         

            Console.WriteLine(Test(a));

            
            Console.ReadKey();
        }
        public static string Test(string str)
        {
            return str.Substring(1, 2).Equals("yt") ? str.Remove(1, 2) : str;
        }
    }
}

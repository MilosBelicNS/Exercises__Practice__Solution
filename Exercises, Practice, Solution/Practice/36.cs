using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _36
    {
        //Write a C# Sharp program to create a new string from a give string where a specified character have been removed except starting and ending position of the given string.

        public static void Main(string[] args)
        {
            Console.WriteLine("Input your string: ");
            string s = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Input char that you want to remove: ");
            char c = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("New string: " + StringX(s,c));
            Console.ReadKey();
        }
        public static string StringX(string s, char c)
        {
            for(int i = s.Length -2; i > 0; i--)
            {
                if(s[i] == c)
                {
                    s = s.Remove(i, 1);
                }
               

            }
            return s;
        }


    }
}

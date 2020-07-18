using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _26
    {
        //Write a C# Sharp program to create a new string which is n (non-negative integer ) copies of the the first 3 characters of a given string. 
        //If the length of the given string is less than 3 then return n copies of the string.

        public static void Main (string [] args)
        {
            Console.Write("Input your string: ");
            string a = Convert.ToString(Console.ReadLine());

            Console.Write("How many copies: ");
            int n = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine(Test(a, n));


            Console.ReadKey();
        }
        public static string Test(string s, int n)
        {
            //laksi nacin 
           // return (s.Length < 3) ? String.Concat(Enumerable.Repeat(s, n)) : String.Concat(Enumerable.Repeat(s.Substring(0, 3), n));

            if (s.Length > 3)
            {
                string result = String.Empty;
                for (int i = 0; i < n; i++)
                {
                    result += s.Substring(0, 3);
                }
                return result;
            }
            else
            {
                string result = String.Empty;
                for (int i = 0; i < n; i++)
                {
                    result += s;
                }
                return result;

            }
            //drugi nacin 
            //var result = string.Empty;
            //var frontOfString = 3;

            //if (frontOfString > s.Length)
            //    frontOfString = s.Length;

            //var front = s.Substring(0, frontOfString);

            //for (var i = 0; i < n; i++)
            //{
            //    result += front;
            //}
            //return result;
        }

    }
}

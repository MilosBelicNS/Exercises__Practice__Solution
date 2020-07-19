using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _35
    {
        //Write a C# Sharp program to compare two given strings and return the number of the positions where they contain the same length 2 substring.

        static void Main(string[] args)
        {
            Console.WriteLine(test("abcdefgh", "abijsklm"));
            Console.WriteLine(test("abcde", "osuefrcd"));
            Console.WriteLine(test("pqrstuvwx", "pqkdiewx"));
            Console.ReadLine();
        }

        public static int test(string str1, string str2)
        {
            var ctr = 0;//inicijalizujemo brojac sa 0
            for (var i = 0; i < str1.Length - 1; i++) //iteriramo kroz str 1
            {
                var firstString = str1.Substring(i, 2); //firstString je substring koji cemo porediti 
                for (var j = 0; j < str2.Length - 1; j++)//iteriramo kroz drugi string
                {
                    var secondString = str2.Substring(j, 2);//secondString je substring drugog stringa str2 
                    if (firstString.Equals(secondString))// poredimo dva stringa i ako su jednaki 
                        ctr++;//povecavamo brojac
                }
            }
            return ctr;//vracamo broj stringova koji poseduju iste elemente duzine 2
        }

    }
}

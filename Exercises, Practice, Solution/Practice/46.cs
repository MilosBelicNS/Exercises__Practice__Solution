using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _46
    {
        //Write a C# Sharp program to check whether a given string starts with "F" or ends with "B".

        //If the string starts with "F" return "Fizz" and return "Buzz" if it ends with "B" If the string starts with "F" and ends with "B" return "FizzBuzz".

        //In other cases return the original string.

        public static void Main(string[] args)
        {
            Console.WriteLine("Input your string: ");
            string s = Convert.ToString(Console.ReadLine());

            

            Console.WriteLine(Test(s));
            Console.ReadKey();
        }

        public static string Test(string str)
        {
            if(str.StartsWith("F") && str.EndsWith("B"))
            {
                return "FizzBuzz";
            }
            else if (str.StartsWith("F"))
            {
                return "Fizz";
            }
            else if(str.EndsWith("B"))
            {
                return "Buzz";

            }else
            return str;
        }


    }
}

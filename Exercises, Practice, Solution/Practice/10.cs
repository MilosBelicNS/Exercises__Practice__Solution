using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _10
    {
        //Write a C# Sharp program to check if a given positive number is a multiple of 3 or a multiple of 7.

        public static void Main ()
        {
            Console.Write("Input your int: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Is(a));
            Console.ReadKey();
        }

        public static bool Is(int a)
        {
            //if(a % 3 == 0 || a % 7 == 0)
            //{
            //    return true;
            //}
            //return false;

            // return (a % 3 == 0 || a % 7 == 0) ? true : false;
            return a % 3 == 0 || a % 7 == 0;
        }
    }
}

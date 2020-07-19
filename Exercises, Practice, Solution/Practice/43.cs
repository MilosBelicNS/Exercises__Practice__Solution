using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _43
    {
        //Write a C# Sharp program to check if a given non-negative given number is a multiple of 3 or 7, but not both.

        public static void Main()
        {
            Console.Write("Input your integer: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Test(a));
            Console.ReadKey();
        }

        public static bool Test(int a)
        {
            return a % 3 == 0 ^ a % 7 == 0;
            // ekskluzivno ili, sto znaci da je true samo ako je jedan od njih deljiv sa 3
        }
    }
}

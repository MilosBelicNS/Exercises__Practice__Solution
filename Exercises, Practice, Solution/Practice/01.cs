using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _01

    //Write a C# Sharp program to compute the sum of the two given integer values. If the two values are the same, then return triple their sum.
    {
        static void Main (string [] args)
        {
            Console.WriteLine(Test(1, 4));
            Console.WriteLine(Test(5, 2));
            Console.WriteLine(Test(3, 3));
            Console.WriteLine(Test(8, 5));
            Console.WriteLine(Test(7, 7));
            Console.ReadKey();
        }

        public static int Test(int x, int y)
        {
            return x == y ? (x + y) * 3 : x + y;
        }
    }
}

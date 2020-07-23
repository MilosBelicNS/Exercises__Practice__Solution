using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _50
    {
        //Write a C# Sharp program to check if two or more non-negative given integers have the same rightmost digit.

        public static void Main()
        {
            Console.Write("Input your integer: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input second integer: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input third integer: ");
            int c = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine(Test(a, b, c));
            Console.ReadKey();

        }
        public static bool Test(int x, int y, int z)
        {
            return x % 10 == y % 10 || x % 10 == z % 10 || y % 10 == z % 10;
        }
    }
}

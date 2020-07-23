using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _49
    {
        //Write a C# Sharp program to check if three given numbers are in strict increasing order, such as 4 7 15, or 45, 56, 67, but not 4 ,8, 8 or 6, 6, 8.
        //However,if a fourth parameter  is true, equality is allowed, such as 6, 6, 8 or 7, 7, 7.

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
            return  x <= y && y <= z;
        }
    }
}

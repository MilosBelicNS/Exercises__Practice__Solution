using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _55
    {
        //Write a C# Sharp program to compute the sum of three given integers. 
        //If the two values are same return the third value.

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
        public static int Test(int a, int b, int c)
        {
            int sum = a + b + c;

            return a == b || b == c || a == c ? c : sum;
        }

        //public static int test(int x, int y, int z)
        //{
        //    if (x == y && y == z) return 0;
        //    if (x == y) return z;
        //    if (x == z) return y;
        //    if (y == z) return x;
        //    return x + y + z;
        //}


    }
}

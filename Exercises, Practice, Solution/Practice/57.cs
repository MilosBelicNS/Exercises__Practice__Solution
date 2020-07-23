using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _57
    {
        //Write a C# Sharp program to compute the sum of the three given integers. 
        //However, if any of the values is in the range 10..20 inclusive then that value counts as 0, except 13 and 17.

        public static void Main()
        {
            Console.Write("Input your integer: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input second integer: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input third integer: ");
            int c = Convert.ToInt32(Console.ReadLine());


            Console.Write("Result: " + Test(a, b, c));
            Console.ReadKey();

        }
        public static int Test(int a, int b, int c)
        {
            return Range(a + b + c);
        }
        public static int Range(int n)
        {
            return (n > 9 && n < 13 ) ||  (n > 17 && n < 21) ? 0 : n;
        }
        //algoritam nije tacan u potpunosti jer sama postavka zadatka ne valja

    }
}

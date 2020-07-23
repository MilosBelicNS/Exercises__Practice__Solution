using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _56
    {
        //Write a C# Sharp program to compute the sum of the three integers. 
        //If one of the values is 13 then do not count it and its right towards the sum.

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
            if (a == 13) return 0;
            if (b == 13) return a;
            if (c == 13) return a + b;
            return a + b + c;

        }


    }
}

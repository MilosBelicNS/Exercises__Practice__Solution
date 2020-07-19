using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _45
    {
        //Write a C# Sharp program to compute the sum of the two given integers.
        //If one of the given integer value is in the range 10..20 inclusive return 18.

        public static void Main()
        {
            Console.Write("Input your integer: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input second integer: ");
            int b = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine(Test(a, b));
            Console.ReadKey();

        }
        public static int Test( int a, int b)
        {
            int sum = a + b;
            return a >= 10 && a <= 20 || b >= 10 && b <= 20 ? 18 : sum;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _40
    {
        //Write a C# Sharp program to compute the sum of the two given integers.
        //If the sum is in the range 10..20 inclusive return 30.
        public static void Main()
        { 
        Console.Write("Input your integer: ");
        int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input second integer: ");
            int b = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine(Test(a, b));
            Console.ReadKey();
        }

        public static int Test(int a, int b)
        {
            int sum = a + b;

            return sum >= 10 && sum <= 20 ? 30 : sum;
        }
    }
}

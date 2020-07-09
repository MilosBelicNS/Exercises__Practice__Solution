using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _03
    {
        //Write a C# Sharp program to check two given integers, and return true if one of them is 30 or if their sum is 30.

        public static bool Test(int a, int b)
        {
            return a == 30 || b == 30 ||( a + b == 30);
        }

        public static void Main (string [] args)
        {
            Console.WriteLine("\n Input integer a: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n Input integer b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Test(a, b));
            Console.ReadKey();

        }
    }
}

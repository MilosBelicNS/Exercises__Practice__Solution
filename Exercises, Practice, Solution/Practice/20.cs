using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _20
    {
        //Write a C# Sharp program to check whether two given integers are in the range 40..50 inclusive, or they are both in the range 50..60 inclusive.

        public static void Main()
        {
            Console.Write("Input your integer: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input your integer: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Test(a, b));

            Console.ReadLine();
            Console.ReadKey();
        }
        public static bool Test(int a, int b)
        {
            return (a >= 40 && b <= 50 && b >= 40 & a <= 50) || (a >= 50 && b <= 60 && b >= 50 & a <= 60);
        }
    }
}

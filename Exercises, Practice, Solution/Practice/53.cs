using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _53
    {
        //Write a C# Sharp program to check two given integers, each in the range 10..99.
        //Return true if a digit appears in both numbers, such as the 3 in 13 and 33

        public static void Main()
        {
            Console.Write("Input your integer: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input second integer: ");
            
            int b = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine(Test(a, b));
            Console.ReadKey();

        }
        public static bool Test(int x, int y)
        {
            return x / 10 == y / 10 || x / 10 == y % 10 || x % 10 == y / 10 || x % 10 == y % 10;
        }
    }
}

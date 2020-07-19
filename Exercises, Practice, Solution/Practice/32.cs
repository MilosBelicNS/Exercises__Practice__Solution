using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _32
    {
        //Write a C# Sharp program to check a specified number is present in a given array of integers.

        public static void Main()
        {
            Console.WriteLine(Test(new[] { 1, 2, 9, 3 }, 3));
            Console.WriteLine(Test(new[] { 1, 2, 2, 3 }, 2));
            Console.WriteLine(Test(new[] { 1, 2, 2, 3 }, 9));
            Console.ReadKey();
            Console.ReadLine();
        }
        public static bool Test(int[] numbers, int a)
        {
            if (numbers.Contains(a))
                return true;
            return false;
        }

    }
}

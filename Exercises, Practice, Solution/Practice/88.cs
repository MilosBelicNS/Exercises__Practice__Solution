using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _88
    {
        //Write a C# Sharp program to check a given array of integers of length 1 or more and return true if 10 appears as either first or last element in the given array.

        public static void Main(string[] args)
        {


            Console.WriteLine(Test(new[] { 10, 20, 40, 50 }));
            Console.WriteLine(Test(new[] {  5, 20, 40, 10 }));
            Console.WriteLine(Test(new[] { 10, 20, 40, 10 }));
            Console.WriteLine(Test(new[] { 12, 24, 35, 55 }));

            Console.ReadKey();

        }
        public static bool Test(int[] nums)
        {
            return nums[0] == 10 || nums[nums.Length - 1] == 10;
        }
    }
}

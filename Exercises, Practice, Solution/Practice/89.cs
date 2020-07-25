using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _89
    {
        //Write a C# Sharp program to check a given array of integers of length 1 or more and return true if the first element and the last element are equal in the given array.

        public static void Main(string[] args)
        {


            Console.WriteLine(Test(new[] { 10, 20, 40, 50 }));
            Console.WriteLine(Test(new[] { 5, 20, 40, 10 }));
            Console.WriteLine(Test(new[] { 10, 20, 40, 10 }));
            Console.WriteLine(Test(new[] { 12, 24, 35, 55 }));

            Console.ReadKey();

        }
        public static bool Test(int[] nums)
        {
            return nums.Length > 1 && nums[0].Equals(nums[nums.Length - 1]);
        }
    }
}

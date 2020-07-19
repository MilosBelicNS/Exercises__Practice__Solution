using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _34
    {
        //Write a C# Sharp program to check whether the sequence of numbers 1, 2, 3 appears in a given array of integers somewhere.
        public static void Main()
        {
            Console.WriteLine(Test(new[] { 1, 2, 9, 3, 1 }));
            Console.WriteLine(Test(new[] { 1, 2, 2, 3, 6 }));
            Console.WriteLine(Test(new[] { 1, 2, 3, 3, 8, 5, 7 }));
            Console.ReadKey();
            Console.ReadLine();
        }

        public static bool Test(int[] nums)
        {

            for (var i = 0; i < nums.Length - 2; i++)
            {
                if (nums[i] == 1 && nums[i + 1] == 2 && nums[i + 2] == 3) 
            //ako je neki element jednak 1 i ako je sledeci element jednak dva, i ako odma do njega sledeci jednak 3
                    return true;//vrati mi tacno
            }
            return false;
        }


    }
}

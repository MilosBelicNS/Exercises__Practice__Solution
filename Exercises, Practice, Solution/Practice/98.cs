using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _98
    {
        //Write a C# Sharp program to check if a given array of integers and length 2, does not contain 15 and 20.

        public static void Main(string[] args)
        {
            Console.WriteLine(Test(new[] { 12, 20 }));
            Console.WriteLine(Test(new[] { 14, 15 }));
            Console.WriteLine(Test(new[] { 11, 21 }));

            Console.ReadKey();

        }
        public static bool Test(int[] n)
        {
            return n[0] == 15 || n[1] == 15 || n[0] == 20 || n[1] == 20? false:true;
        }
    }
}

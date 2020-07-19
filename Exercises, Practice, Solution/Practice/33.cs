using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _33
    {
        //Write a C# Sharp program to check if one of the first 4 elements in an array of integers is equal to a given element.

        public static void Main()
        {
            Console.WriteLine(Test(new[] { 1, 2, 9, 3, 8 }, 3));
            Console.WriteLine(Test(new[] { 1, 2, 2, 3, 6}, 6));
            Console.WriteLine(Test(new[] { 1, 2, 2 }, 9));
            Console.ReadKey();
            Console.ReadLine();
        }
        public static bool Test(int[] numbers, int n)
        {
            return numbers.Length < 4 ? numbers.Contains(n) : numbers.Take(4).Contains(n);
            
        }
    }
    
}

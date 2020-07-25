using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _91
    {
        //Write a C# Sharp program to compute the sum of the elements of an given array of integers.

        public static void Main(string[] args)
        {


            Console.WriteLine(Test(new[] { 10, 20, 40, 50 }));
            Console.WriteLine(Test(new[] { 5, 20, 40, 10 }));
            Console.WriteLine(Test(new[] { 10, 20, 40, 10 }));
            Console.WriteLine(Test(new[] { 12, 24, 35, 55 }));

            Console.ReadKey();

        }
        public static int Test(int[] n)
        {
            int sum = 0;
            for (int i = 0; i < n.Length ; i++)
            {
                sum += n[i];
            }
            return sum;
            //  return n.Sum();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _102
    {
        //Write a C# Sharp program to compute the sum of the two given arrays of integers, length 3 and find the array which has the largest sum.

        public static void Main(string[] args)
        {

            int[] item = Test(new[] { 10, 20, -30 }, new[] { 10, 35, 45 });

            Console.Write("New array: ");

            foreach (var i in item)
            {
                Console.Write(i.ToString() + " ");
            }

            Console.ReadKey();

        }
        public static int[] Test(int[] n, int[] m)
        {
            int sum1 = n.Sum();
            int sum2 = m.Sum();

            return sum1 > sum2 ? n : m;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _95
    {
        //Write a C# Sharp program to create a new array containing the middle elements from the two given arrays of integers, each length 5.

        public static void Main(string[] args)
        {

            int[] item = Test(new[] { 10, 20, -30, -40, 70 }, new[] { 10, 35, 45, 50, 60 });

            Console.Write("New array: ");

            foreach (var i in item)
            {
                Console.Write(i.ToString() + " ");
            }

            Console.ReadKey();

        }
        public static int[] Test(int[] n, int[] m)
        {
            return new int[] { n[2], m[2] };
        }
    }
}

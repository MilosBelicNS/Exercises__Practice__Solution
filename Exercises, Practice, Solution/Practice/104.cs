using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _104
    {
        //Write a C# Sharp program to create a new array from two give array of integers, each length 3.

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
            return new int[] { n[0], n[1], n[2], m[0], m[1], m[2] };

        }
    }
}

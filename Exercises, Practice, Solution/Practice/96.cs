using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _96
    {
        //Write a C# Sharp program to create a new array taking the first and last elements of a given array of integers and length 1 or more.

        public static void Main(string[] args)
        {

            int[] item = Test(new[] { 10, 20, -30, -40, 70 });

            Console.Write("New array: ");

            foreach (var i in item)
            {
                Console.Write(i.ToString() + " ");
            }

            Console.ReadKey();

        }

        public static int[] Test(int[] n)
        {
            return new int[] { n[0], n[n.Length - 1] };
        }
    }
}

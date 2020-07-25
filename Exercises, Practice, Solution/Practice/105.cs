using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _105
    {
        //Write a C# Sharp program to create a new array swapping the first and last elements of a given array of integers and length will be least 1.

        public static void Main(string[] args)
        {

            int[] item = Test(new[] { 10, 20, -30, 10, 35, 45 });

            Console.Write("New array: ");

            foreach (var i in item)
            {
                Console.Write(i.ToString() + " ");
            }

            Console.ReadKey();

        }
        public static int[] Test(int[] n)
        {
            int first = n[0];
            n[0] =n[n.Length - 1];
            n[n.Length - 1] = first;
            return n;

        }
    }
}

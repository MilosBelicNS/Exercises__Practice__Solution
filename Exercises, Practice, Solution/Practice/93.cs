using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _93
    {
        //Write a C# Sharp program to reverse a given array of integers and length 5.

        public static void Main(string[] args)
        {

            int[] item = Test(new[] { 10, 20, -30, -40, 70 });

            Console.Write("Rotated array: ");

            foreach (var i in item)
            {
                Console.Write(i.ToString() + " ");
            }

            Console.ReadKey();

        }
        public static int[] Test(int[] n)
        {
            return new int[] { n[4], n[3], n[2], n[1], n[0] };

        }
    }
}

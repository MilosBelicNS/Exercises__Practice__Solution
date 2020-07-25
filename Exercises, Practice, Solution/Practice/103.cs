using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _103
    {
        //Write a C# Sharp program to create an array taking two middle elements from a given array of integers of length even.

        public static void Main(string[] args)
        {

            int[] item = Test(new[] { 10, 5, 7, 4, 52, 60 });

            Console.Write("New array: ");

            foreach (var i in item)
            {
                Console.Write(i.ToString() + " ");
            }

            Console.ReadKey();

        }
        public static int[] Test(int[] n)
        {
           // return new int[] { n[2], n[3] };
            return new int[] { n[n.Length / 2 - 1], n[n.Length / 2] };
        }
    }
}

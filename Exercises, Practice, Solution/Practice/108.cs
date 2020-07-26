using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _108
    {
        //Write a C# Sharp program to create a new array taking the first two elements from a given array. If the length of the given array is less than 2 then return the give array.


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
            return n.Length >= 2 ? new int[] { n[0], n[1] } : n;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _94
    {
        //Write a C# Sharp program to find out the maximum element between the first or last element in a given array of integers (length 4), replace all elements with maximum element.

        public static void Main(string[] args)
        {

            int[] item = Test(new[] { 10, 20, -30, -40, 70 });

            Console.Write("Max in array: ");

            foreach (var i in item)
            {
                Console.Write(i.ToString() + " ");
            }

            Console.ReadKey();

        }
        public static int[] Test(int[] n)
        {
            int max = n.Max();
            return new int[] { max, max, max, max, max };
        }
    }
}

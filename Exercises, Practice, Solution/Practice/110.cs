using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _110
    {
        //Write a C# Sharp program to compute the difference between the largest and smallest values in a gvien array of integers and length one or more.

        static void Main(string[] args)
        {
            Console.WriteLine(Test(new[] { 1, 5, 7, 9, 10, 12 }));
            Console.ReadKey();
        }

        public static int Test(int[] n)
        {
            int max = n.Max();
            int min = n.Min();
            int diff = Math.Abs(max - min);

            return n.Length > 1 ? diff : n[0];
            
        }
    }
}

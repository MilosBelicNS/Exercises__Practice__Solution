using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _109
    {
        //Write a C# Sharp program to count even number of elements in a given array of integers.

        static void Main(string[] args)
        {
            Console.WriteLine(Test(new[] { 1, 5, 7, 9, 10, 12 }));
            Console.ReadKey();
        }
        public static int Test(int[] n)
        {
            int even_nums  = 0;

            for(int i =0; i < n.Length; i++)
            {
                if (n[i] % 2 == 0) even_nums++;

            }
            return even_nums;
        }

    }
}

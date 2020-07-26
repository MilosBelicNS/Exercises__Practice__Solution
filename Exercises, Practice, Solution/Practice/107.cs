using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _107
    {
        //Write a C# Sharp program to find the largest value from first, last, and middle elements of a given array of integers of odd length (atleast 1).

        static void Main(string[] args)
        {
            Console.WriteLine(Test(new[] { 1 }));
            Console.WriteLine(Test(new[] { 1, 2, 9 }));
            Console.WriteLine(Test(new[] { 1, 2, 9, 3, 3 }));
            Console.WriteLine(Test(new[] { 1, 2, 3, 4, 5, 6, 7 }));
            Console.WriteLine(Test(new[] { 1, 2, 2, 3, 7, 8, 9, 10, 6, 5, 4 }));
            Console.ReadKey();

        }
        public static int Test(int[] n)
        {
            int first = n[0];
            int middle = n[n.Length / 2];
            int last = n[n.Length - 1];
            int max = first;
            
            if(middle > max)
            {
                max = middle;
            }
            if(last > max)
            {
                max = last;
            }
            return max;


        }
    }
}

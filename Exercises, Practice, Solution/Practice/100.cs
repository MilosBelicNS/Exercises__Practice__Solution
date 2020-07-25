using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _100
    {
        //Write a C# Sharp program to check a given array of integers and return true if the array contains 10 or 20 twice.
        //The length of the array will be 0, 1, or 2.

        static void Main(string[] args)
        {

            Console.WriteLine(Test(new[] { 12, 20 }));
            Console.WriteLine(Test(new[] { 20, 20 }));
            Console.WriteLine(Test(new[] { 10, 10 }));
            Console.WriteLine(Test(new[] { 10 }));
            Console.ReadKey();

        }
        public static bool Test(int[] n)
        {
            return n.Length == 2 && ((n[0] == 10 && n[1] == 10) || (n[0] == 20 && n[1] == 20));
          //return a.Length>1?a[0] == 10 && a[1] == 10|| a[0] == 20 && a[1] == 20:false;
        }

    }
}

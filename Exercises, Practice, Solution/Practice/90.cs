using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _90
    {
        //Write a C# Sharp program to check two given arrays of integers of length 1 or more and return true if they have the same first element or they have the same last element.

        public static void Main(string[] args)
        {


            Console.WriteLine(Test(new[] { 10, 20, 40, 50 }, new []{ 5, 20, 30, 10 }));
     
            Console.ReadKey();

        }

        public static bool Test(int[] n1, int[] n2)
        {
            return n1[0] == n2[0] || n1[n1.Length - 1] == n2[n2.Length - 1];
                  
        }

    }
}

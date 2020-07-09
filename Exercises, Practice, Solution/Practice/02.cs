using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _02
    {
        //Write a C# Sharp program to get the absolute difference between n and 51. If n is greater than 51 return triple the absolute difference.


        public static void Main(string[] args)
        {
            Console.WriteLine("\n Input your integer: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Test(n));
            Console.ReadKey();
        }

        public static int Test(int n)
            {
                int x = 51;

                if(n > x)
            {
               return (n - x) *3;
            }
            return x - n;
    }       }
}

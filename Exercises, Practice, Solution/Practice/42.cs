using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _42
    {
        //Write a C# Sharp program to test if a given non-negative number is a multiple of 13 or it is one more than a multiple of 13
        public static void Main()
        {
            Console.Write("Input your integer: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Test(a));
            Console.ReadKey();
        }

        public static bool Test(int a)
        {
            return (a % 13 == 0) || (a % 13 == 1);
        }
    }
}

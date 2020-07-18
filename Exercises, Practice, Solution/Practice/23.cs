using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _23
    {
        //Write a C# Sharp program to check if two given non-negative integers have the same last digit. 

        public static void Main()
        {
            Console.Write("Input your integer: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input second integer: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Test(a, b));

            Console.ReadLine();
            Console.ReadKey();

        }
        public static bool Test(int a, int b)
        {
            return Math.Abs(a % 10) == Math.Abs(b % 10); 
        }


    }
}

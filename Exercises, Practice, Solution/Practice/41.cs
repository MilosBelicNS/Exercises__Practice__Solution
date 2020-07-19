using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _41
    {
        //Write a C# Sharp program that accept two integers and return true if either one is 5 or their sum or difference is 5.

        public static void Main()
        {
            Console.Write("Input your integer: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input second integer: ");
            int b = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine(Test(a, b));
            Console.ReadKey();
        }
        public static bool Test(int a, int b)
        {
            int sum = a + b;
            int diff = a - b;

            return a == 5 || b == 5 || sum == 5 || diff == 5;
        }
    }
}

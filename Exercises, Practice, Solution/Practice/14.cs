using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _14
    {
        //Write a C# Sharp program to check two given integers whether either of them is in the range 100..200 inclusive.
        public static void Main()
        {
            Console.Write("Input your temperature: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input your temperature: ");
            int b = Convert.ToInt32(Console.ReadLine());




            Console.WriteLine(Test(a, b));

            Console.ReadLine();
            Console.ReadKey();
        }
        public static bool Test(int a, int b)
        {
            int max = 200;
            int min = 100;
             return a >= min && a <= max || b >= min && a <= max;
        }
    }
}

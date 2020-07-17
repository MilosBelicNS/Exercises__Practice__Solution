using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _18
    {
        //Write a C# Sharp program to check the largest number among three given integers.

        public static void Main()
        {
            Console.Write("Input your integer: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input second integer: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input third integer: ");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Max value is: " + Test(a, b, c));

            Console.ReadLine();
            Console.ReadKey();
        }
        public static int Test(int a, int b, int c)
        {
            var max = Math.Max(a, Math.Max(b, c));
            return max;
        }
    }
}

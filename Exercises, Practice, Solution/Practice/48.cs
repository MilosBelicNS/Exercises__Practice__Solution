using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _48
    {
        //Write a C# Sharp program to check if y is greater than x, and z is greater than y from three given integers x,y,z.

        public static void Main()
        {
            Console.Write("Input your integer: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input second integer: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input third integer: ");
            int c = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine(Test(a, b, c));
            Console.ReadKey();

        }
        public static bool Test(int x, int y, int z)
        {
            return y > x && z > y;
        }
    }
}

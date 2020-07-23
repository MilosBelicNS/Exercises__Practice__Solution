using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _59
    {
        //Write a C# Sharp program to check three given integers (small, medium and large) and return true if the difference between small and medium and the difference between medium and large is same.

        public static void Main()
        {
            Console.Write("Input your integer: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input second integer: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input third integer: ");
            int c = Convert.ToInt32(Console.ReadLine());


            Console.Write("Result: " + Test(a, b, c));
            Console.ReadKey();

        }
        public static bool Test(int x, int y, int z)
        {
            //if (x > y && x > z && y > z) return x - y == y - z;
            //if (x > y && x > z && z > y) return x - z == z - y;
            //if (y > x && y > z && x > z) return y - x == x - z;
            //if (y > x && y > z && z > x) return y - z == z - x;
            //if (z > x && z > y && x > y) return z - x == x - y;
            //return z - y == y - x;

            //drugi nacin
            var result1 = Math.Abs(x - y);
            var result2 = Math.Abs(y - z);

            return result1 == result2 ? true : false;

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _21
    {
        //Write a C# Sharp program to find the larger value from two positive integer values that is in the range 20..30 inclusive, or return 0 if neither is in that range.

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
        public static int Test(int x, int y)
        {
            if (x >= 20 && x <= 30 && y >= 20 && y <= 30)
            {
                if (x >= y)
                {
                    return x;
                }
                else
                {
                    return y;
                }
            }
            else if (x >= 20 && x <= 30)
            {
                return x;
            }
            else if (y >= 20 && y <= 30)
            {
                return y;
            }
            else
            {
                return 0;
            }

            ////drugi nacin, laksi ali nepotpun
            //public static int Test(int a, int b)
            //{
            //    return ((Enumerable.Range(20, 30).Contains(a) && Enumerable.Range(20, 30).Contains(b))) ? Math.Max(a, b) : 0;
            //}

        }
    }
}

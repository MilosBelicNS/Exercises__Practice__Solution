using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _52
    {
        //Write a C# Sharp program to find the larger from two given integers. 
        //However if the two integers have the same remainder when divided by 7, then return the smaller integer. 
        //If the two integers are the same, return 0.

        public static void Main()
        {
            Console.Write("Input your integer: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input second integer: ");
            int b = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine(Test(a, b));
            Console.ReadKey();

        }

        public static int Test(int x, int y)
        {
            //if( x == y)
            //{
            //    return 0;

            //}else if((x % 7 == y % 7 && x > y) || x < y )
            //{
            //    return x;
            //}
            //return y;
            int max = Math.Max(x, y);
            int min = Math.Min(x, y);

            if (x == y)
            {
                return 0;
            }
            else if (x % 7 == y % 7)
            {
                return min;
            }
            else return max;
        }


    }
}

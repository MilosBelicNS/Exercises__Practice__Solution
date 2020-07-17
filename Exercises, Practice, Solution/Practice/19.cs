using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _19
    {
        //Write a C# Sharp program to check which number nearest to the value 100 among two given integers. 
        //Return 0 if the two numbers are equal.

        public static void Main()
        {
            Console.Write("Input your integer: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input your integer: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Test(a, b));

            Console.ReadLine();
            Console.ReadKey();
        }

        public static int Test(int a, int b)
        {
            int n = 100;
            int val1 = Math.Abs(a - n);
            int val2 = Math.Abs(b - n);

            return val1 == val2 ? 0 : (val1 < val2 ? a : b);
        }
    }
}

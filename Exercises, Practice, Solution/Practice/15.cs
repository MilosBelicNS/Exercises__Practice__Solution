using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _15
    {
        //Write a C# Sharp program to check whether three given integer values are in the range 20..50 inclusive. 
        //Return true if 1 or more of them are in the said range otherwise false.

        public static void Main()
        {
            Console.Write("Input your temperature: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input your temperature: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input your temperature: ");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Test(a, b, c));

            Console.ReadLine();
            Console.ReadKey();
        }

        public static bool Test(int a, int b, int c)
        {

            return (a >= 20 && a <= 50) || (b >= 20 && b <= 50) || (c >= 20 && c <= 50);
        }
    }
}

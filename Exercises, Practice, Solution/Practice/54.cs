using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _54
    {
        //Write a C# Sharp program to compute the sum of two given non-negative integers x and y as long as the sum has the same number of digits as x.
        //If the sum has more digits than x then return x without y.


        public static void Main()
        {
            Console.Write("Input your integer: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input second integer: ");

            int y = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine(Test(x, y));
            Console.ReadKey();

        }
        public static int Test(int a, int b)
        {
            return (a + b).ToString().Length > a ? a : a + b; 

            //pretvaramo sumu u string i proveravamo da li je duzina cifara veca od a, i vracamo a ili sumu
        }
    }
}

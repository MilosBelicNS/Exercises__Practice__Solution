using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _47
    {
        //Write a C# Sharp program to check if it is possible to add two integers to get the third integer from three given integers.

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
        public static bool Test(int a, int b, int c)
        {

            //int sum = a + b;

            //if (sum ==  c)

            //    return true;
            //return false;
            return a == b + c || b == a + c || c == a + b; 
            
        }

    }
}

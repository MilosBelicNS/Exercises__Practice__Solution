using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _13
    {
        //Write a C# Sharp program to check if one given temperatures is less than 0 and the other is greater than 100.

        public static void Main()
        {
            Console.Write("Input your temperature: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input your temperature: ");
            int b = Convert.ToInt32(Console.ReadLine());




            Console.WriteLine(Temp(a, b));
            
            Console.ReadLine();
            Console.ReadKey();
        }
        public static bool Temp(int a, int b)
        {
            return a < 0 && b > 100 || b < 0 && a > 100 ;
           
        }
    }
}

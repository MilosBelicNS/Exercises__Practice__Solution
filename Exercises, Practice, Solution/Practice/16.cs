using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _16
    {    //Write a C# Sharp program to check whether two given integer values are in the range 20..50 inclusive. 
        //Return true if 1 or other is in the said range otherwise false. 

        public static void Main()
        {
            Console.WriteLine("Write a C# Sharp program to check whether two given integer values are in the range 20..50 inclusive. \n");


            Console.Write("Input your integer: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input your integer: ");
            int b = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine(Test(a, b));

            Console.ReadLine();
            Console.ReadKey();
        }
        public static bool Test(int a, int b)
        {
            return (a >= 20 || a <= 50) || (b >= 20 || b <= 50);
        }
            

    }
}

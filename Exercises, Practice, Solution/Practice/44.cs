using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _44
    {
        //Write a C# Sharp program to check if a given number is within 2 of a multiple of 10.

        public static void Main()
        {
            Console.Write("Input your integer: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Test(a));
            Console.ReadKey();
            
        }



        public static bool Test(int n)
        {
            return n % 10 <= 2 || n % 10 >= 8;
            //vidi jel 10% od n manji ili jednak sa 2, ili veci ili jednak sa 8
        }
    }
}

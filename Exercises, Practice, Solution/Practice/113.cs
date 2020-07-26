using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _113
    {
        //Write a C# Sharp program to check if a given array of integers contains 5 next to a 5 somewhere.


        static void Main(string[] args)
        {
            Console.WriteLine("Does a given array of integers contains 5 next to a 5 somewhere: ");
            Console.WriteLine(Test(new[] { 1, 5, 5, 9, 10, 17 }));
            Console.ReadKey();
        }
        public static bool Test(int[] n)
        {
            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] == 5 && n[i + 1] == 5) 
                return true;
            }
            return false;
        }

    }
}


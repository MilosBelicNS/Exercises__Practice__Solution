using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _111
    {
        //Write a C# Sharp program to compute the sum of values in a given array of integers except the number 17.
        //Return 0 if the given array has no integer.

        static void Main(string[] args)
        {
            Console.WriteLine("Sum of values in the array of integers except the number 17: ");
            Console.WriteLine(Test(new[] { 1, 5, 7, 9, 10, 17 }));
            Console.ReadKey();
        }

        public static int Test(int[] n)
        {
            int sum = 0;

            for(int i = 0; i < n.Length; i++)
            if(n[i] != 17)//ako element nije 17
            {
                    sum += n[i]; //dodaj u sumu element
                    
            }
            return sum;
        }
           


    }
}

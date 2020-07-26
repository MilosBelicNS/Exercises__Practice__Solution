using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _115
    {
        //Write a C# Sharp program to check if the sum of all 5' in the array exactly 15 in a given array of integers.

        static void Main(string[] args)
        {
            Console.WriteLine("If the sum of all 5' in the array exactly 15 in a given array of integers: ");
            Console.WriteLine(Test(new[] { 1, 5, 5, 8, 10, 17 }));
            Console.ReadKey();
        }
        public static bool Test(int[] n)
        {
            
            int sum = 0;
           
            for (int i=0; i<n.Length; i++)
            {
                if(n[i] == 5)
                {
                    sum += n[i];
                    
                }

                if (sum == 15) return true;


            }
            return false;
        }
    }
}

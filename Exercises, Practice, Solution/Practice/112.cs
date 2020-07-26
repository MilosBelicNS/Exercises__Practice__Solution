using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _112
    {
        //Write a C# Sharp program to compute the sum of the numbers in a given array except those numbers starting with 5 followed by atleast one 6.
        //Return 0 if the given array has no integer.

        static void Main(string[] args)
        {
            Console.WriteLine("Sum of values in the array of integers except the number 5 followed by atleast one 6: ");
            Console.WriteLine(Test(new[] { 1, 5, 6, 9, 10, 17 }));
            Console.ReadKey();
        }


        public static int Test(int[] n)
        {



            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] == 5 && n[i + 1] == 6) { n[i] = 0; n[i + 1] = 0; } //ako je uslov tacan pretvori te elemente u nule
            }
            return n.Sum();
        }

    }
}

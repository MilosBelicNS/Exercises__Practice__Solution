using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _106
    {
        //Write a C# Sharp program to create a new array of length 3 from a given array (length atleast 3) using the elements from the middle of the array.




        public static void Main(string[] args)
        {

            int[] item = Test(new[] { 10, 5, 7, 4, 52, 60 });

            Console.Write("New array: ");

            foreach (var i in item)
            {
                Console.Write(i.ToString() + " ");
            }

            Console.ReadKey();

        }
        public static int[] Test(int[] n)
        {
            // return new int[] { n[2], n[3] };
            return n.Length > 3 ? new int[] { n[n.Length / 2 - 1], n[n.Length / 2], n[n.Length / 2 +1] } : n;
        }
    }
}


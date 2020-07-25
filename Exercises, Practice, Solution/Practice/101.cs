using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _101
    {
        //Write a C# Sharp program to check a given array of integers, length 3 and create a new array.
        //If there is a 5 in the given array immediately followed by a 7 then set 7 to 1.

        public static void Main(string[] args)
        {

            int[] item = Test(new[] { 10, 5, 7 });

            Console.Write("New array: ");

            foreach (var i in item)
            {
                Console.Write(i.ToString() + " ");
            }

            Console.ReadKey();

        }
        public static int[] Test(int[] n)
        {
            
            for(int i= 0; i<n.Length-1;i++)
            {
                if (n[i] == 5 && n[i+1]==7)
                
                    n[i + 1] = 1;
                
              
            }
            return n;
        }


    }
}

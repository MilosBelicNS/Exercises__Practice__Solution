using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _99
    {
        //Write a C# Sharp program to create a new array of integers and length 1 or more. 
        //The length of the new array will be double length of an given array and all the elements are 0 except the first element which is equal to first elements of the given array.

        public static void Main(string[] args)
        {

            int[] item = Test(new[] { 125, 20, -30, -40, 70 });

            Console.Write("New array: ");

            foreach (var i in item)
            {
                Console.Write(i.ToString() + " ");
            }

            Console.ReadKey();

        }
        public static int[] Test(int[] n)
        {
            
                int elements = n.Length * 2;//int sa koji ima elemenata kolika je duzina duplog niza n
                int[] doubleNums = new int[elements];//novi niz "doubleNums" koji ima elemenata koliko ima int "elements"

                doubleNums[0] = n[0];//prvi element novog niza je element prvog niza
                return doubleNums;//vracamo novi niz
            
        }

    }
}

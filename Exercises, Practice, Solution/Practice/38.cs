using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _38
    {
        //Write a C# Sharp program to count the number of two 5's are next to each other in an array of integers. 
        //Also count the situation where the second 5 is actually a 6.


        static void Main(string[] args)
        {
            Console.WriteLine(test(new[] { 5, 5, 2 }));
            Console.WriteLine(test(new[] { 5, 5, 2, 5, 5 }));
            Console.WriteLine(test(new[] { 5, 6, 2, 9 }));
            Console.ReadLine();
        }
        public static int test(int[] numbers)
        {
            var ctr = 0;//brojac
            for (var i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i].Equals(5) && (numbers[i + 1].Equals(5) || (numbers[i].Equals(5) && numbers[i + 1].Equals(6)))) ctr++;
            }//ako je neki broj iz niza jednak 5 i ako je sledeci 5 povecaj brojac, ili eko je neki 5 a sledeci 6 povecaj brojac
            return ctr;//rezultat
        }
    }
}

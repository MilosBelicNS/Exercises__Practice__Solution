using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _39
    {
        //Write a C# Sharp program to check if a triple is presents in an array of integers or not. 
        //If a value appears three times in a row in an array it is called a triple.
        static void Main(string[] args)
        {
            Console.WriteLine(Test(new[] { 1, 1, 2, 2, 1 }));
            Console.WriteLine(Test(new[] { 1, 1, 2, 1, 2, 3 }));
            Console.WriteLine(Test(new[] { 1, 1, 1, 2, 2, 2, 1 }));
            Console.ReadLine();
        }
        public static bool Test(int[] nums)
        {
            int duzinaNiza= nums.Length - 1;//brojac elemenata u nizu
            int n = 0; //brojac
            for (int i = 0; i < duzinaNiza; i++) //iteriramo kroz duzinu niza
            {
                n = nums[i];//brojac neka bude element kroz koji iteriramo
                if (n == nums[i + 1] && n == nums[i + 2]) return true;//ako je sledeci element i onaj do njega isti kao n element daj mi true
            }
            return false;
        }
    }
}

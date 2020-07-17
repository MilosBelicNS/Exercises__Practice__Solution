using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _06
    {
        // Write a C# Sharp program to remove the character in a given position of a given string. 
        //The given position will be in the range 0.. string length -1 inclusive

        public static void Main (string [] args)
        {
            Console.WriteLine(Test("Python", 1));
            Console.WriteLine(Test("Python", 0));
            Console.WriteLine(Test("Python", 4));
            Console.ReadKey();
        }
        public static string Test(string str, int n)
        {
            return str.Remove(n, 1);
        }
    }
}

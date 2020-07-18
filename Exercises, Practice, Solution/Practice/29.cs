using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _29
    {
        //Od unetog stringa stampaj mi novi string koji se sastoji od svakog drugog elementa unetog stringa
        //Write a C# Sharp program to create a new string made of every other character starting with the first from a given string.

        public static void Main(string [] args)
        {
            Console.Write("Input your string: ");
            string a = Convert.ToString(Console.ReadLine());
            Console.WriteLine(Test(a));


            Console.ReadKey();
        }
        static string Test(string str)
        {
            var result = String.Empty;//napravi mi prazan string
            for (var i = 0; i < str.Length; i += 2)//iteriraj na svaki drugi
            {


                result += str[i];//u novi string "result" dodaj mi svaki drugi element
            }
            return result;//vrati mi novi string
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _25
    {
        //Write a C# Sharp program to create a new string which is n (non-negative integer) copies of a given string

        public static void Main(string[] args)
        {
            Console.Write("Input your string: ");
            string a = Convert.ToString(Console.ReadLine());

            Console.Write("How many copies: ");
            int n = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine(Test(a, n));


            Console.ReadKey();
        }
        public static string Test(string s, int n)
        {
            string result = String.Empty;//napravili smo prazan string result

            for(int i = 0; i < n; i++)//iteriraj dok je n vece od i(n je nas broj kopija)
            {
                result += s;// u svakoj iteraciji vrati mi uvecan string
            }
            return result;
            //drugi nacin
            //return string.Concat(Enumerable.Repeat(str, n));

        }
    }
}

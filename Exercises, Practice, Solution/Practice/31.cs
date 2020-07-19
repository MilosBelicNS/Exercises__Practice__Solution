using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _31
    {
        //Write a C# Sharp program to count a substring of length 2 appears in a given string and also as the last 2 characters of the string. 
        //Do not count the end substring.

        public static void Main (string [] args)
        {
            Console.Write("Input your string: ");
            string a = Convert.ToString(Console.ReadLine());
            Console.WriteLine(Test(a));


            Console.ReadKey();
        }

        public static int Test(string str)
        {
            var lastTwo = str.Substring(str.Length - 2);
            //string lastTwo koji je zapravo substring unesenog stringa, tj njegova zadnja dva elementa
            var brojac = 0;//brojac
            for(int i = 0; i< str.Length - 2; i++)//iteriraj do poslednja dva
            {
                if (str.Substring(i, 2).Equals(lastTwo)) brojac++;
                //ako je neki substring(dva elementa) isti kao poslednja dva, povecaj brojac
            }
            return brojac;//vrati koliko puta je pronadjen substring
        }
    }
}

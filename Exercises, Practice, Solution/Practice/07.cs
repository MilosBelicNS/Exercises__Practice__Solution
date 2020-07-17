using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _07
    {
        //Write a C# Sharp program to exchange the first and last characters in a given string and return the new string

            public static void Main(string [] args)
        {
            Console.WriteLine(Rep("milos"));
            Console.WriteLine(Rep("mikica"));
            Console.WriteLine(Rep("mile"));
            Console.Read();
        }


        public static string Rep(string str)
        {
            if(str.Length > 1)
            {
                //Console.WriteLine(str.Last() + str.Substring(1, str.Length - 2) + str.First());
                return str.Substring(str.Length - 1) + str.Substring(1, str.Length - 2) + str.Substring(0, 1);
                //poslednji karakter(element) + sve od prvog do predposlednjeg elementa + prvi karakter(od 0 do 1 elementa)
            }
            return str;
        }
    }
}

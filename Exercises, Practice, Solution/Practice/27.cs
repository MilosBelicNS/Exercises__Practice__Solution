using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _27
    {
        //Write a C# Sharp program to count the string "aa" in a given string and assume "aaa" contains two "aa".

        public static void Main(string [] args)
        {
            Console.Write("Input your string: ");
            string a = Convert.ToString(Console.ReadLine());
            Console.WriteLine(Test(a));


            Console.ReadKey();
        }
        public static int Test(string s)
        {
            int cr_oo = 0; //brojac
            for(int i=0; i < s.Length -1; i++) //iteriramo kroz string
            {
                if(s.Substring(i,2) == "oo")//ako su od nekog n clana stringa naredna dva sa oo 
                {
                    cr_oo++; //povecaj mi brojac
                }
               
            }
            return cr_oo;//vrati mi kolko je puta izbrojao "oo"
        }
    }

}

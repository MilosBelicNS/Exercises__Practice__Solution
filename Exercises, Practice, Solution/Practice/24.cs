using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _24
    {

        //Write a C# Sharp program to convert the last 3 characters of a given string in upper case. 
        //If the length of the string has less than 3 then uppercase all the characters.

        public static void Main (string [] args)
        {
            Console.Write("Input your string: ");
            string a = Convert.ToString(Console.ReadLine());



            Console.WriteLine(Test(a));


            Console.ReadKey();
        }

        public static string Test(string str)
        {
            return str.Length < 3 ? str.ToUpper() : str.Remove(str.Length - 3) + str.Substring(str.Length - 3).ToUpper();
            //ako je duzina stringa manja od 3 daj mi ceo string upper, ako je veci od 3 vrati string bez zadnja tri elementa i onda ta tri elementa dodaj  sa povecane
        //    string s1 = str.Substring(str.Length - 3);
        //    string s2 = str.Substring(str.Length - 3).ToUpper();

        //    return str.Length < 3 ? str.ToUpper() : str.Replace(s1, s2);
        }
    }
}

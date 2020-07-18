using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _28
    {
     //Write a C# Sharp program to check if the first appearance of "a" in a given string is immediately followed by another "a".

        public static void Main()
        {
            Console.Write("Input your string: ");
            string a = Convert.ToString(Console.ReadLine());
            Console.WriteLine(Test(a));


            Console.ReadKey();
        }
        public static bool Test(string s)
        {
           

            //drugi nacin daleko laksi
            // return (s.Substring(s.IndexOf('o'), 2).Equals("oo")) ? true:false;

            
            
            for (int i = 0; i < s.Length - 1; i++) //iteriramo kroz string
            {
                if (s.Substring(i, 2) == "oo")//ako su od nekog n clana stringa naredna dva sa oo 
                {
                    return true; 
                }
               

            }
            return false;


        }

    }
}

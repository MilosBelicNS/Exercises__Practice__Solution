using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _85
    {
        //Write a C# Sharp program to create a new string from a given string without the first two characters.
        //Keep the first character if it is "p" and keep the second character if it is "y".

        public static void Main(string[] args)
        {
            Console.WriteLine("Input your string: ");
            string s1 = Convert.ToString(Console.ReadLine());

            Console.WriteLine(Test(s1));
            Console.ReadKey();

        }
        public static string Test(string s)
        {
            if(s.Substring(0,1) == "p" && s.Substring(1,1) == "y")
            {
                return s;
            }else if(s.Substring(0,1) == "p")
            {
                return s.Substring(0, 1) + s.Substring(2);
            }else if(s.Substring(1, 1) == "y")
            {
                return s.Substring(1);
            }
            return s.Substring(2);

                
        }

        //private static string CreateNewAndCheckChars(string str)
        //{
        //    if (str.Length < 2) return "Invalid length!";
        //    return str.ToLower().StartsWith("py") ? str : str.ToLower().StartsWith("p") ? str.Remove(1, 1) : str.Substring(1, 1).Equals("y") ? str.Substring(1) : str.Substring(2);
        //}

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _22
    {

        //Write a C# Sharp program to check if a given string contains between 2 and 4 'z' character.
        public static void Main (string [] args)
        {
            Console.Write("Input your string: ");
            string a = Convert.ToString(Console.ReadLine());



            Console.WriteLine(Test(a));


            Console.ReadKey();
        }
        public static bool Test(string str)
        {
            int ctr = 0; //nas brojac
            for(int i = 0; i < str.Length; i++)// prolaz kroz string
            {
                if (str[i] == 'z')// ako neki element stringa sadrzi z vrednost
                {
                    ctr++; //povecaj mi brojac
                }
                
            }
            return ctr > 1 && ctr < 4; //ako vrednost brojaca bude izmedju 1-4 daj mi true, ili suprotno
        }
    }
}

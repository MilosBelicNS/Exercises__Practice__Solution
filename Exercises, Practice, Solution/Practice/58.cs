using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _58
    {
        //Write a C# Sharp program to check two given integers and return the value whichever value is nearest to 13 without going over.
        //Return 0 if both numbers go over.

        public static void Main()
        {
            Console.Write("Input your integer: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input second integer: ");

            int y = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine(Test(x, y));
            Console.ReadKey();

        }
        public static int Test(int x, int y)
        {
            
                //if (x > 13 && y > 13) return 0;//ako su obe vrednosti vece od 13 izbaci 0
                //if (x <= 13 && y > 13) return x;// ako je x manji ili jednak 13, a y veci od 13 daj mi x
                //if (y <= 13 && x > 13) return y;// ako je y manji ili jednak 13, a x veci od 13 daj mi y
                //return x > y ? x : y;// na kraju mi daj x ako je x veci od y i obrnuto
            //drugi laksi nacin
            
            
                const int n = 13;
                return x > n && y > n ? 0 : Math.Max(x, y);
            

        }
    }
}

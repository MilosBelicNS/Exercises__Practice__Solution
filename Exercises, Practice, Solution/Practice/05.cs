using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises__Practice__Solution.Practice
{
    class _05
    {

        public static void Main()
        {
                int i, n, 
                sum = 0;

            Console.Write("\n Input the 10 numbers: \n");
            for(i = 1; i<=10; i++)
            {
                Console.Write("Number {0} : ", i);
                n = Convert.ToInt32(Console.ReadLine());
                sum += n;
            }
           double avg = sum / 10.0;
            Console.WriteLine("The sum of 10 numbers is: {0} \nThe average of 10 numbers is: {1}", sum, avg);
            Console.ReadKey();
        }
    }
}

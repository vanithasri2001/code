using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_C_Sharp
{
    class Sum_Of_even_Odd_Numbers
    {
        public static void Main(string[] args)
        {
            int i, sum1 = 0, sum2 = 0;
            int[] j = new int[10];
            Console.WriteLine("enter numbers");
            for (i = 0; i < 10; i++)
            {
                j[i] = Convert.ToInt32(Console.ReadLine());
                if (j[i] % 2 == 0)
                {
                    sum1 += j[i];
                }
                else
                {
                    sum2 += j[i];
                }
            }
            Console.WriteLine($"sum of even numbers:{ sum1}");
            Console.WriteLine($"sum of odd numbers:{ sum2}");




        }
    }
}


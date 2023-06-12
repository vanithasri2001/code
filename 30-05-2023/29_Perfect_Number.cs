using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_C_Sharp
{
    class _29_Perfect_Number
    {
        public static void Main(string[] args)
        {
            //sum of proper factors is perfect number
            Console.WriteLine("enter the number:");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <n; i++)
            {
                if (n % i==0)
                {
                    sum += i;
                   // Console.WriteLine(i);
                   
                }
            }
            if(sum==n)
            {
                Console.WriteLine("Number is perfect");
            }
            else
            {
                Console.WriteLine("Number is not perfect");
            }
            Console.ReadLine();
        }
    }
}

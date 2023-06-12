using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_C_Sharp
{
    class _27_Prime_Nos_Within_Range
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter the range of numbers");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            Console.WriteLine("-------");
            for(int i=a;i<=b;i++)
            {
                count = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                    }
                }
                if (count == 2)
                    Console.WriteLine(i);
            }
        }

        }
    }


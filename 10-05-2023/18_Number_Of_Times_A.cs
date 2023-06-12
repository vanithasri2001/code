using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_C_Sharp
{
    class Number_Of_Times_A
    {
        public static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("enter the string");
            string string1 = Console.ReadLine();
            char[] c = string1.ToCharArray();
            for (int i = 0; i < string1.Length; i++)
            {
                if (c[i] == 'a')
                {
                    count++;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("No 'a' s are found");
            }
            else
            {
                Console.WriteLine($"Number of 'a's present was : {count}");
            }
        }
    }
}

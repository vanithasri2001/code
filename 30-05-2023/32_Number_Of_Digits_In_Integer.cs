using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_C_Sharp
{
    class Number_Of_Digits_In_Integer
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int count=0;
            while(n>0)
            {
                
                n = n / 10;
                count++;
            }
            Console.WriteLine("number of digits in an integer" +count);
        }
    }
}

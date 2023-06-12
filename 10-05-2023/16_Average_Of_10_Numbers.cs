using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    class Average_Of_10_Numbers
    {
        public static void Main(string[] args)
        {
            int[] i = new int[10];
            Console.WriteLine("enter ten numbers");
            for(int j=0;j<10;j++)
            {
                i[j] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine($"sum of nos : { i.Sum()}");
            Console.WriteLine($"Average  of nos : { i.Sum()/i.Length}");

        }
    }
}

         









        

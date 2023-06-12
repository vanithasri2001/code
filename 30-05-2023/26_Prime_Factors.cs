using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_C_Sharp
{
    class _26_Prime_Factors
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter the number:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Prime factors ");
            for(int i=2;i<=n;i++)
            {
                while(n%i==0)
                {
                    Console.WriteLine(i);
                    n /= i;
                }
            }
            Console.ReadLine();
            
                         
        }
    }
}
                                                                                                                                         
                                                                                                                                                                                                                                                                                                  
                                                                                                                                                                                                                                            
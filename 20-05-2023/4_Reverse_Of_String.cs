using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    class Reverse_Of_String
    {
        public static void Main(string[] args)
        {
            //string reverse without recursion
            Console.WriteLine("enter the string");
            string name = Console.ReadLine();
            char[] c = name.ToCharArray();
            Array.Reverse(c);
            string s = new string(c);
            Console.WriteLine("reverse of the string" + s);


            
            
            
        }
    }
}

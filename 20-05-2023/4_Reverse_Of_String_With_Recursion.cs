using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    class Reverse_Of_String_With_Recursion
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter the string :");
            string name = Console.ReadLine();
            Reverse_Of_String_With_Recursion str = new Reverse_Of_String_With_Recursion();
            string rev = str.Reverse(name);
            Console.WriteLine("reverse of a string : " + rev);

        }

        private string Reverse(string name)
        {
            if (name.Length > 0)
            {
                return name[name.Length - 1] + Reverse(name.Substring(0, name.Length - 1));
            }
            else
            {
                return name;
            }


        }
    }
}


























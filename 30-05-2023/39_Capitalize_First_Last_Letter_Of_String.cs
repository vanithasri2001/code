using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_C_Sharp
{
    class _39_Capitalize_First_Last_Letter_Of_String
    {
        public static void Main(string[] args)
        {


            Console.WriteLine("Enter a string");
            string str = Console.ReadLine();
            string str1 = str.Substring(0, 1).ToUpper() + str.Substring(1, str.Length - 2) + str.Substring(str.Length - 1).ToUpper();
            Console.WriteLine(str1);
        }

    }
}






//
//Console.WriteLine("Enter any string:");
//string str = Console.ReadLine();
//char[] c = str.ToCharArray();
//c[0] = char.ToUpper(c[0]);
//c[c.Length - 1] = char.ToUpper(c[c.Length - 1]);
//Console.WriteLine(c);



                                                                  
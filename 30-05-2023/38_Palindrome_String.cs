using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_C_Sharp
{
    class Palindrome_Number1
    {
        public static void Main(string[] args)
        {
            string temp;
            Console.WriteLine("enter a string");
            string name = Console.ReadLine();
            temp = name;
            char[] revstr = name.ToCharArray();
            Array.Reverse(revstr);
            string s = new string(revstr);
            if (temp == s)
            {
                Console.WriteLine("Palindrome string");

            }
            else
            {
                Console.WriteLine("Not a Palindrome");
            }



        }
    }
}



//in another way


//static void Main(string[] args)
//{
//    Console.Write("Enter a string : ");
//    string name = Console.ReadLine();
//    string reverse = string.Empty;



//    for (int i = name.Length - 1; i >= 0; i--)
//    {
//        reverse += name[i];
//    }



//    if (name == reverse)
//    {
//        Console.WriteLine($"{name} is Palindrome.");
//    }
//    else
//    {
//        Console.WriteLine($"{name} is not Palindrome");
//    }
//    Console.ReadKey();
//}

using System;
using System.Linq;

namespace BasicPrograms
{
    class TwoStrings
    {
        static void Main(string[] args)
        {
            //Two String which are reverse of each other or not


            string s3, s4;
            Console.WriteLine("enter the strings:");
            s3 = Console.ReadLine();
            s4 = Console.ReadLine();
            char[] name = s4.ToCharArray();

            Array.Reverse(name);
            string name1 = new string(name);
            Console.WriteLine("reverse string is:" + name1);
            if (s3.Equals(name1))
            {
                Console.WriteLine("equal");
            }
            else
            {
                Console.WriteLine("not equal");
            }


            //using equals method in another way
            string s1, s2;
            Console.WriteLine("enter the two strings:");
            s1 = Console.ReadLine();
            s2 = Console.ReadLine();
            string reverses1 = new string(s1.Reverse().ToArray());
            if(reverses1.Equals(s2))
            {
                Console.WriteLine("two strings are equal");
            }
            else
            {
                Console.WriteLine("not equal");
            }
        }
    }
}


















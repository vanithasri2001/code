using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    class Count_Of_Repeated_Characters
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("enter the string");
            string s = Console.ReadLine();
            Console.WriteLine("Repeated character in string");
            while(s.Length>0)
            {
                Console.Write(s[0] + "=");
                int count = 0;
                for(int j=0;j<s.Length;j++)
                {
                    if(s[0]==s[j])
                    {
                        count++;
                    }
                }
                Console.WriteLine(count);
                s = s.Replace(s[0].ToString(), string.Empty);
            }
            Console.ReadLine();
        }
    }
}

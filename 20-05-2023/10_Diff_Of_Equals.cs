using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    class Diff_Of_Equals
    {
        public static void Main(string[] args)
        {
            string s1, s2;
            s1 = Console.ReadLine();
            s2 = Console.ReadLine();

            Console.WriteLine(s1 == s2);
            Console.WriteLine(s1.Equals(s2));


        }
    }
}

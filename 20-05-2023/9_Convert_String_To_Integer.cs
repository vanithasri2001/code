using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    class Convert_String_To_Integer
    {
        public static void Main(string[] args)
        {
           string name = Console.ReadLine();
            int i;
            try
            {
                i = Convert.ToInt32(name);
                Console.WriteLine("string to int :" + i);

            }
            catch(Exception e)
            {
                Console.WriteLine(e);

            }
            //Parse is used to convert string to int 
            // int i =Int32.Parse(name);
            //int i = Convert.ToInt32(name);
           // Console.WriteLine("string to int :" + i);
        }
    }
}

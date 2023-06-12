using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    class Repeated_Character_String
    {
        public static void Main(string[] args)
        {
            string input;
            Console.WriteLine("Enter the string");
            input = Console.ReadLine();
            char repChar = '\0';
            for(int i = 0;i<input.Length;i++)
            {
                char crtchar = input[i];

                if (input.IndexOf(crtchar) != input.LastIndexOf(crtchar))
                {

                    repChar = crtchar;

                    break;
                }
            }
            if (repChar == '\0')
            {
                Console.WriteLine("No repeated character found");
            }
            else
            {
                Console.WriteLine("The repeated character is:" + repChar);
            }
        }
    }
}


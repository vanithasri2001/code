using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    class Vowels_Consonants
    {
        public static void Main(string[] args)
        {
            int vowel=0, consonant=0;
            Console.WriteLine("enter the string:");
            string name = Console.ReadLine();
            for(int i=0;i<name.Length;i++)
            {
                if(name[i]=='a'||name[i]== 'A' || name[i] == 'e' || name[i] == 'E' || name[i] == 'i' || name[i] == 'I' || name[i] == 'o' || name[i] == 'O' || name[i] == 'u' || name[i] == 'U' )
                {
                    vowel++;
                }
                else
                {
                    consonant++;
                }

            }
            Console.WriteLine("vowels count:" + vowel);
            Console.WriteLine("consonants  count:" + consonant);



        }
    }
}

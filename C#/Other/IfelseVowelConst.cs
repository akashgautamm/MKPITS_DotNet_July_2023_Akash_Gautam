using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfelseVowelConst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char vowel;
            Console.WriteLine("Enter vowel");
            vowel = Convert.ToChar(Console.ReadLine());

           

            if (vowel == 'a' || vowel == 'e' || vowel == 'i' || vowel == 'o' || vowel == 'u')
            {
                Console.WriteLine("It is a Vowel");
            }
            else 
            {
                Console.WriteLine("It is a Constant");
         
            }
            Console.ReadKey();


        }  
    }
}

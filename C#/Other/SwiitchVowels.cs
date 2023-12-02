using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Vowels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char op;
            Console.WriteLine("Enter Charaacter:");
            op=Convert.ToChar(Console.ReadLine());

            switch(op)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("It is a vowel");
                    break;
                default:
                    Console.WriteLine("It is a Constant");
                    break;


            }
            Console.ReadKey();

        }
    }
}

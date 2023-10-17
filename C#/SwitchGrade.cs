using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchGrade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char op;
            Console.WriteLine("Enter Grade:");
            op = Convert.ToChar(Console.ReadLine());

            switch(op)
            {
                case 'E':
                    Console.WriteLine("Excellent");
                    break;
                case 'V':
                    Console.WriteLine("Very Good");
                    break;
                case 'G':
                    Console.WriteLine("Good");
                    break;
                case 'A':
                    Console.WriteLine("Average");
                    break;
                case 'F':
                    Console.WriteLine("Fail");
                    break;
                default:
                    Console.WriteLine("Invalid Grade");
                    break;
            }
            Console.ReadKey();

        }
    }
}

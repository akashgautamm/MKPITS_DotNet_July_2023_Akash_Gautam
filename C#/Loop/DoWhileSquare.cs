using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileSquare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num,square;
            char choice= 'y';
            do
            {
                Console.WriteLine("Enter Num");
                num = Convert.ToInt32(Console.ReadLine());

                square = num * num;
                Console.WriteLine("Square is " + square);
                Console.WriteLine("Do you want exit press 'y' and 'n'");
                choice = Convert.ToChar(Console.ReadLine());

            }
            while (choice == 'y' || choice=='Y');
            Console.ReadKey();

        }
    }
}

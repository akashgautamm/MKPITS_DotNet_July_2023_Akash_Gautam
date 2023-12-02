using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ifelse3GreaterNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.WriteLine("Enter Num 1");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter num 2");
            num2 =Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter num 3");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 < num2 && num1 < num3)
            {
                Console.WriteLine("Num 1 is smaller");
            }
            else if (num2 < num3 && num2 < num1)
            {
                Console.WriteLine("Num 2 is smaller");
            }
            else
            {
                Console.WriteLine("Num 3 is smaller");
            }
            Console.ReadKey();
        }
    }
}

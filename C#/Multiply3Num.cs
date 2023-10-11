using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiply3Num
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, sum;
            Console.Write("Eenter Num1 :");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Num2 :");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Num3 :");
            num3 = Convert.ToInt32(Console.ReadLine());

            sum = num1 * num2 * num3;
            Console.Write("Total is " + sum);
            Console.ReadKey();
        }
    }
}

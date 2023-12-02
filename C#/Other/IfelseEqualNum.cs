using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1,num2;
            Console.WriteLine("Enter Num 1");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Num 2");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 == num2)
                Console.WriteLine("Both Num are equal");
            else
                Console.WriteLine("It is not are equal");

            Console.ReadKey();

        }
    }
}

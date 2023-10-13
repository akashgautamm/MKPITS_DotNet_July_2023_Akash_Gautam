using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greater2num
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Enter Num 1");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Num 1");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
                Console.WriteLine("Num1 is greater");
            else
                Console.WriteLine("Num 2 is greater");
            Console.ReadKey();



        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greater_3_num
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.WriteLine("Enter Num 1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Num 2");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Num 3");
            num3 = Convert.ToInt32(Console.ReadLine());

            if(num1>num2 && num1>num3)
            {
                Console.WriteLine("Num 1 is greater");
            }
            else if (num2 > num3 && num2 > num1)
            {
                Console.WriteLine("Num 2 is greater");
            }
            else
            {
                Console.WriteLine("Num 3 is greater");
            }
            Console.ReadKey();

        }
    }
}

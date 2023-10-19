using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileFebonn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int count = 3;
            int num1 = 0;
            int num2 = 1;
            int add = num1 + num2;
            Console.Write("Enter Num:");
            num = Convert.ToInt32(Console.ReadLine());
            Console.Write("{0},{1},", num1, num2);
            do
            {
                Console.Write("{0},",add);
                num1 = num2;
                num2 = add;
                add = num1 + num2;
                
                count++;

            }
            while (count <=num);
            Console.ReadKey();
        }
    }
}

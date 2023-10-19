using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoopFebonn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, num1 = 0,num2 = 1;
            int add = num1 + num2;
            int counter;

            Console.WriteLine("Enter Number");
            num = Convert.ToInt32(Console.ReadLine());

            Console.Write("{0},{1},", num1, num2);
            for(counter=3;counter<=num;counter++)
            {
                Console.Write("{0},", add);
                num1 = num2;
                num2 = add;
                add = num1 + num2;
            }
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodFactorialReturn
{
    internal class Program
    {
        static int factorial(int num)
        {
            int fact=1;
            while(num>0)
            {
                fact = fact * num;
                num--;

            }
            return fact;
        }
        static void Main(string[] args)
        {
            int number,result;
            Console.WriteLine("Enter Num:");
            number = Convert.ToInt32(Console.ReadLine());

            result=factorial(number);
            Console.WriteLine("Fact is " + result);
            Console.ReadKey();
        }
    }
}

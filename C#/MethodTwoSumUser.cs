using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodTwoSumUser
{
    internal class Program
    {
        static void add(int n1,int n2)
        {
            int result = n1 + n2;
            Console.WriteLine("Add is " + result);
        }
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Enter num 1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter num 2");
            num2 = Convert.ToInt32(Console.ReadLine());

            add(num1, num2);
            Console.ReadKey();
        }
    }
}

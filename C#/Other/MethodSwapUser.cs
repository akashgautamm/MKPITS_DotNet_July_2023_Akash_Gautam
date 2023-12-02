using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSwapUser
{
    internal class Program
    {
        static void swap(int a,int b)
        {
            a = a - b;
            b = a + b;
            a = b - a;
            Console.WriteLine("Now the 1st number is :{0} , and the 2nd number is : {1}", a, b);
        }
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Enter Num 1:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Num 1:");
            num2 = Convert.ToInt32(Console.ReadLine());
            swap(num1, num2);
            Console.ReadKey();
        }
    }
}

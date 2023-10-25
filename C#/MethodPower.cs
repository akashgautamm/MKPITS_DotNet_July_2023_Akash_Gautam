using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodPower
{
    internal class Program
    {
        static void power(int num,int power)
        {
            int counter;
            int result = 1;
            for(counter=1;counter<=power;counter++)
            {
                result = num * result;
                Console.WriteLine("Result is "+result);
            }
            
        }
        static void Main(string[] args)
        {
            int n, p;
            Console.WriteLine("Enter Num:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Power:");
            p = Convert.ToInt32(Console.ReadLine());
            power(n, p);
            Console.ReadKey();
        }
    }
}

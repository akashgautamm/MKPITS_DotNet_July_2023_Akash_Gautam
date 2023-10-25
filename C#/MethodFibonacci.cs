using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodFibonacci
{
    internal class Program
    {
        static void fibo(int n)
        {
            int n1 = 0;
            int counter = 3;
            int n2 = 1;
            int add = n1 + n2;
            Console.Write("{0},{1},", n1, n2);
            while(counter<=n)
            {
                Console.Write("{0},", add);
                n1 = n2;
                n2 = add;
                add = n1 + n2;
                counter++;
                
            }
            
        }

        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter Num:");
            num = Convert.ToInt32(Console.ReadLine());
            fibo(num);
            Console.ReadKey();

        }
    }
}

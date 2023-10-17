using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileNaturalNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 1,sum=0;
            while(num<=10)
            {
                Console.WriteLine(num);
                sum = num + sum;
                
                num++;
            }
            Console.WriteLine("Sum of all natural number="+sum);
            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodFactorialUser
{
    internal class Program
    {
        static void factorial(int num)
        {
            int fact = 1;
            
            while(num>0)
            {
                fact = num* fact;
                num--;
            }
            Console.WriteLine("Fact is {0}", fact);
            
        }
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter num:");
            number = Convert.ToInt32(Console.ReadLine());
            factorial(number);
            Console.ReadKey();

                
        }
    }
}

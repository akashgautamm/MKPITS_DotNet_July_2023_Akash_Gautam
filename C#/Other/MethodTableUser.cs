using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodTableUser
{
    internal class Program
    {
        static void table(int num)
        {
            int result, counter=1;
            while(counter<=10)
            {
                result = num * counter;

                Console.WriteLine("{0}x{1}={2}", num, counter, result);
                counter++;
            }
        }
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter num:");
            number = Convert.ToInt32(Console.ReadLine());
            table(number);
            Console.ReadKey();
        }
    }
}

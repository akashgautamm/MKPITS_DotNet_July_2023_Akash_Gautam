using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfelsePositiveEqualorNegative
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter num");
            num = Convert.ToInt32(Console.ReadLine());

            if (num>0)
            {
                Console.WriteLine("It is Positive num");
            }
            else if(num<0)
            {
                Console.WriteLine("It is a negative");
            }
            else if(num==0)
            {
                Console.WriteLine("It is a equal");
            }
            Console.ReadKey();
        }
    }
}

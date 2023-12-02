using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfEvenodd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter num");
            num = Convert.ToInt32(Console.ReadLine());

            if(num%2==0)
            {
                Console.WriteLine("It is Even Num");
            }
           
            {
                Console.WriteLine("It is Odd num");
            }
            Console.ReadKey();
        }  
    }
}

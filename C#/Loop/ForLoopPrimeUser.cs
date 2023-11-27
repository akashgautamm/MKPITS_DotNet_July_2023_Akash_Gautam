using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoopPrimeUser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int count;
            int flag = 0;
            Console.WriteLine("Enter Num:");
            num = Convert.ToInt32(Console.ReadLine());

            for(count=2; count<num; count++)
            {
                if(num%count==0)
                {
                    flag = 1;
                    break;
                    
                }
            }
            if(flag==0)
            {
                Console.WriteLine("It is a prime num");
            }
            else
            {
                Console.WriteLine("It is not prime");
            }
            Console.ReadKey();

        }
    }
}

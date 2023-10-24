using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoopPrimeCheck2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int counter;
            int flag = 0;
            Console.WriteLine("Enter Num :");
            num = Convert.ToInt32(Console.ReadLine());


            for(counter=1;counter<=num;counter++)
            {
                if(num%counter==0)
                {
                    flag++;
                    
                }

            }
            if(flag==2)
            {
                Console.WriteLine("It is a Prime Num");
            }
            else
            {
                Console.WriteLine("It is not prime num");
            }
            Console.ReadKey();
        }
    }
}

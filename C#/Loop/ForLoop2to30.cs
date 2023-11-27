using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoopPrime2to30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int num1;
            int count;
            int flag = 0;
            Console.WriteLine("Enter Num:");
            num1 = Convert.ToInt32(Console.ReadLine());
            for(num=1;num<=num1;num++)
            {
                flag = 0;   
                for(count=1;count<=num;count++)
                {
                    if(num%count==0)
                    {
                        flag++;
                    }

                }
                if(flag==2)
                {
                    Console.WriteLine(num);
                }
            }
            Console.ReadKey();
        }
    }
}

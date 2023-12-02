using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodPrimeUser
{
    internal class Program
    {
        static void prime(int num)
        {
            int counter,flag=0;
            for(counter=1;counter<=num;counter++)
            {
                if(num%counter==0)
                {
                    flag++;
                }

            }
            if(flag==2)
            {
                Console.WriteLine("It is a Prime Number");
            }
            else
            {
                Console.WriteLine("It is not Prime Number");
            }
        }
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter Num :");
            number = Convert.ToInt32(Console.ReadLine());
            prime(number);
            Console.ReadKey();
        }
    }
}

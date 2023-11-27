using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileCubenum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num,count=1,sum=0;
            Console.WriteLine("Enter Num:");
            num=Convert.ToInt32(Console.ReadLine());

            while(count<=num)
            {
                sum = count * count * count;
                Console.WriteLine("Number is : {0} and cube of the {1} is: {2}", count, count, sum);
                count++;
            }
            Console.ReadKey();
        }
    }
}
